/*
Copyright (C) 2019-2020 TARAKHOMYN YURIY IVANOVYCH
All rights reserved.
Licensed under the Apache License, Version 2.0 (the "License");
you may not use this file except in compliance with the License.
You may obtain a copy of the License at
    http://www.apache.org/licenses/LICENSE-2.0
Unless required by applicable law or agreed to in writing, software
distributed under the License is distributed on an "AS IS" BASIS,
WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
See the License for the specific language governing permissions and
limitations under the License.
*/

/*
Автор:    Тарахомин Юрій Іванович
Адреса:   Україна, м. Львів
Сайт:     accounting.org.ua
*/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

using AccountingSoftware;
using Довідники = StorageAndTrade_1_0.Довідники;
using РегістриВідомостей = StorageAndTrade_1_0.РегістриВідомостей;

namespace StorageAndTrade
{
    public partial class Form_КурсиВалют : Form
    {
        public Form_КурсиВалют()
        {
            InitializeComponent();

			dataGridViewRecords.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

			RecordsBindingList = new BindingList<Записи>();
			dataGridViewRecords.DataSource = RecordsBindingList;

			dataGridViewRecords.Columns["Image"].Width = 30;
			dataGridViewRecords.Columns["Image"].HeaderText = "";

			dataGridViewRecords.Columns["ID"].Visible = false;
            dataGridViewRecords.Columns["Валюта"].Visible = false;

			dataGridViewRecords.Columns["ВалютаНазва"].HeaderText = "Валюта";
            dataGridViewRecords.Columns["ВалютаНазва"].Width = 150;

            dataGridViewRecords.Columns["Дата"].Width = 150;

            dataGridViewRecords.Columns["Курс"].CellTemplate.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewRecords.Columns["Курс"].Width = 150;
        }

		/// <summary>
		/// Номенклатура власник
		/// </summary>
		public Довідники.Валюти_Pointer ВалютаВласник { get; set; }

		/// <summary>
		/// UID для виділення в списку
		/// </summary>
		public string SelectPointerItem { get; set; }

		private void Form_КурсиВалют_Load(object sender, EventArgs e)
        {
			directoryControl_Валюта.Init(new Form_Валюти(), new Довідники.Валюти_Pointer(), ПошуковіЗапити.Валюти);

			if (ВалютаВласник != null)
				directoryControl_Валюта.DirectoryPointerItem = ВалютаВласник;

			directoryControl_Валюта.AfterSelectFunc = () =>
			{
                ВалютаВласник = (Довідники.Валюти_Pointer)directoryControl_Валюта.DirectoryPointerItem;

                RecordsBindingList.Clear();
                loadRecordsLimit.PageIndex = 0;

                LoadRecords();

				return true;
			};

			LoadRecords();
		}

		private BindingList<Записи> RecordsBindingList { get; set; }
        private LoadRecordsLimit loadRecordsLimit = new LoadRecordsLimit() { Limit = 50 };

        public void LoadRecords(bool isClear = false)
		{
			if (isClear)
			{
                RecordsBindingList.Clear();
                loadRecordsLimit.PageIndex = 0;
            }

            РегістриВідомостей.КурсиВалют_RecordsSet КурсиВалют = new РегістриВідомостей.КурсиВалют_RecordsSet();

            //JOIN 1
            КурсиВалют.QuerySelect.FieldAndAlias.Add(
				new NameValue<string>(Довідники.Валюти_Const.TABLE + "." + Довідники.Валюти_Const.Назва, "val_name"));
            КурсиВалют.QuerySelect.Joins.Add(
				new Join(Довідники.Валюти_Const.TABLE, РегістриВідомостей.КурсиВалют_Const.Валюта, РегістриВідомостей.КурсиВалют_Const.TABLE));

			//Відбір
			if (ВалютаВласник != null && !ВалютаВласник.IsEmpty())
                КурсиВалют.QuerySelect.Where.Add(
					new Where(РегістриВідомостей.КурсиВалют_Const.Валюта, Comparison.EQ, ВалютаВласник.UnigueID.UGuid));

            //ORDER
            КурсиВалют.QuerySelect.Order.Add("period", SelectOrder.DESC);
            КурсиВалют.QuerySelect.Order.Add(РегістриВідомостей.КурсиВалют_Const.TABLE + "." + РегістриВідомостей.КурсиВалют_Const.Валюта, SelectOrder.ASC);

            //Обмеження завантаження
            КурсиВалют.QuerySelect.Limit = loadRecordsLimit.Limit;
			КурсиВалют.QuerySelect.Offset = loadRecordsLimit.Limit * loadRecordsLimit.PageIndex;

            КурсиВалют.Read();

            loadRecordsLimit.LastCountRow = КурсиВалют.Records.Count;

            foreach (РегістриВідомостей.КурсиВалют_RecordsSet.Record запис in КурсиВалют.Records)
			{
				RecordsBindingList.Add(new Записи
				{
					ID = запис.UID.ToString(),
					Валюта = запис.Валюта,
                    ВалютаНазва = КурсиВалют.JoinValue[запис.UID.ToString()]["val_name"].ToString(),
                    Дата = запис.Period,
					Курс = запис.Курс
                });
			}

            loadRecordsLimit.PageIndex++;

            if (!String.IsNullOrEmpty(SelectPointerItem) && dataGridViewRecords.Rows.Count > 0)
			{
				string UidSelect = SelectPointerItem;

				if (UidSelect != Guid.Empty.ToString())
					ФункціїДляІнтерфейсу.ВиділитиЕлементСписку(dataGridViewRecords, "ID", UidSelect);
			}
		}

		private class Записи
		{
			public Записи() { Image = Properties.Resources.doc_text_image; }
			public Bitmap Image { get; set; }
			public string ID { get; set; }
            public DateTime Дата { get; set; }
            public Довідники.Валюти_Pointer Валюта { get; set; }
			public string ВалютаНазва { get; set; }
            public decimal Курс { get; set; }
        }

		private void dataGridViewRecords_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
			if (e.RowIndex >= 0 && e.RowIndex < dataGridViewRecords.RowCount)
			{
				//string Uid = dataGridViewRecords.Rows[e.RowIndex].Cells["ID"].Value.ToString();

				toolStripButtonEdit_Click(this, null);
			}
		}

		private void toolStripButtonAdd_Click(object sender, EventArgs e)
		{
			Довідники.Валюти_Pointer валюти_Pointer;			

			if (dataGridViewRecords.SelectedRows.Count > 0)
			{
				DataGridViewRow row = dataGridViewRecords.SelectedRows[0];
				string uid = row.Cells["Валюта"].Value.ToString();

                валюти_Pointer = new Довідники.Валюти_Pointer(new UnigueID(uid));
			}
			else
                валюти_Pointer = ВалютаВласник;

			Form_КурсиВалютЕлемент form_КурсиВалютЕлемент = new Form_КурсиВалютЕлемент();
            form_КурсиВалютЕлемент.MdiParent = this.MdiParent;
            form_КурсиВалютЕлемент.IsNew = true;
            form_КурсиВалютЕлемент.OwnerForm = this;
            form_КурсиВалютЕлемент.ВалютаВласник = ВалютаВласник;
            form_КурсиВалютЕлемент.Show();
		}

        private void toolStripButtonEdit_Click(object sender, EventArgs e)
        {
			if (dataGridViewRecords.SelectedRows.Count > 0)
			{
				DataGridViewRow row = dataGridViewRecords.SelectedRows[0];
				string uid = row.Cells["ID"].Value.ToString();

                Form_КурсиВалютЕлемент form_КурсиВалютЕлемент = new Form_КурсиВалютЕлемент();
                form_КурсиВалютЕлемент.MdiParent = this.MdiParent;
                form_КурсиВалютЕлемент.IsNew = false;
                form_КурсиВалютЕлемент.OwnerForm = this;
                form_КурсиВалютЕлемент.Uid = uid;
                form_КурсиВалютЕлемент.Show();
			}
		}

        private void toolStripButtonRefresh_Click(object sender, EventArgs e)
        {
            LoadRecords(true);
		}

        private void toolStripButtonDelete_Click(object sender, EventArgs e)
        {
            if (dataGridViewRecords.SelectedRows.Count != 0 &&
                MessageBox.Show("Видалити записи?", "Повідомлення", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                for (int i = 0; i < dataGridViewRecords.SelectedRows.Count; i++)
                {
                    DataGridViewRow row = dataGridViewRecords.SelectedRows[i];
                    string uid = row.Cells["ID"].Value.ToString();

					РегістриВідомостей.КурсиВалют_Objest курсиВалют_Objest = new РегістриВідомостей.КурсиВалют_Objest();
					if (курсиВалют_Objest.Read(new UnigueID(uid)))
                    {
                        курсиВалют_Objest.Delete();
                    }
                    else
                    {
                        MessageBox.Show("Error read");
                        break;
                    }
                }

                LoadRecords();
            }
        }

        private void dataGridViewRecords_CellClick(object sender, DataGridViewCellEventArgs e)
        {
			if (dataGridViewRecords.SelectedRows.Count > 0)
			{
				int RowIndex = dataGridViewRecords.SelectedRows[0].Index;

				SelectPointerItem = dataGridViewRecords.Rows[RowIndex].Cells["ID"].Value.ToString();
			}
		}

		private void dataGridViewRecords_Scroll(object sender, ScrollEventArgs e)
		{
			if (e.ScrollOrientation == ScrollOrientation.VerticalScroll)
			{
				int rowHeight = dataGridViewRecords.Rows[dataGridViewRecords.FirstDisplayedScrollingRowIndex].Height;
				int countVisibleRows = dataGridViewRecords.Height / rowHeight;

				if (e.NewValue >= dataGridViewRecords.Rows.Count - countVisibleRows && loadRecordsLimit.LastCountRow == loadRecordsLimit.Limit)
				{
					LoadRecords();
				}
			}
        }
	}
}
