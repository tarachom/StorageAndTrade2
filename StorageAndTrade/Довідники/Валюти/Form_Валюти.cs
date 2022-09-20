/*
Copyright (C) 2019-2022 TARAKHOMYN YURIY IVANOVYCH
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
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

using AccountingSoftware;
using Константи = StorageAndTrade_1_0.Константи;
using Довідники = StorageAndTrade_1_0.Довідники;

namespace StorageAndTrade
{
    public partial class Form_Валюти : Form
    {
        public Form_Валюти()
        {
            InitializeComponent();

			RecordsBindingList = new BindingList<Записи>();
			dataGridViewRecords.DataSource = RecordsBindingList;
			
			dataGridViewRecords.Columns["Image"].Width = 30;
			dataGridViewRecords.Columns["Image"].HeaderText = "";

			dataGridViewRecords.Columns["ID"].Visible = false;
			dataGridViewRecords.Columns["Назва"].Width = 300;
            dataGridViewRecords.Columns["КороткаНазва"].Width = 80;
            dataGridViewRecords.Columns["КороткаНазва"].HeaderText = "Коротко";
            dataGridViewRecords.Columns["Код_R030"].Width = 80;
            dataGridViewRecords.Columns["Код_R030"].HeaderText = "R030";
            dataGridViewRecords.Columns["Код"].Width = 80;
        }

		/// <summary>
		/// Вказівник для вибору
		/// </summary>
		public DirectoryPointer DirectoryPointerItem { get; set; }

		/// <summary>
		/// Вказівник для виділення в списку
		/// </summary>
		public DirectoryPointer SelectPointerItem { get; set; }

		private void Form_Валюти_Load(object sender, EventArgs e)
        {
			LoadRecords();
		}

		private BindingList<Записи> RecordsBindingList { get; set; }

		public void LoadRecords()
		{
			RecordsBindingList.Clear();

			Довідники.Валюти_Select валюти_Select = new Довідники.Валюти_Select();
			валюти_Select.QuerySelect.Field.Add(Довідники.Валюти_Const.Назва);
            валюти_Select.QuerySelect.Field.Add(Довідники.Валюти_Const.Код_R030);
            валюти_Select.QuerySelect.Field.Add(Довідники.Валюти_Const.Код);
            валюти_Select.QuerySelect.Field.Add(Довідники.Валюти_Const.КороткаНазва);

            //ORDER
            валюти_Select.QuerySelect.Order.Add(Довідники.Валюти_Const.Код, SelectOrder.ASC);

			валюти_Select.Select();
			while (валюти_Select.MoveNext())
			{
				Довідники.Валюти_Pointer cur = валюти_Select.Current;

				RecordsBindingList.Add(new Записи
				{
					ID = cur.UnigueID.ToString(),
					Назва = cur.Fields[Довідники.Валюти_Const.Назва].ToString(),
                    КороткаНазва = cur.Fields[Довідники.Валюти_Const.КороткаНазва].ToString(),
                    Код = cur.Fields[Довідники.Валюти_Const.Код].ToString(),
                    Код_R030 = cur.Fields[Довідники.Валюти_Const.Код_R030].ToString()
                });
			}

			if ((DirectoryPointerItem != null || SelectPointerItem != null) && dataGridViewRecords.Rows.Count > 0)
			{
				string UidSelect = SelectPointerItem != null ? SelectPointerItem.UnigueID.ToString() : DirectoryPointerItem.UnigueID.ToString();

				if (UidSelect != Guid.Empty.ToString())
					ФункціїДляІнтерфейсу.ВиділитиЕлементСписку(dataGridViewRecords, "ID", UidSelect);
			}
		}

		private class Записи
		{
			public Записи() { Image = Properties.Resources.doc_text_image; }
			public Bitmap Image { get; set; }
			public string ID { get; set; }
			public string Назва { get; set; }
            public string КороткаНазва { get; set; }
            public string Код_R030 { get; set; }
            public string Код { get; set; }
        }

        private void dataGridViewRecords_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
			if (e.RowIndex >= 0 && e.RowIndex < dataGridViewRecords.RowCount)
			{
				string Uid = dataGridViewRecords.Rows[e.RowIndex].Cells["ID"].Value.ToString();

				if (DirectoryPointerItem != null)
				{
					DirectoryPointerItem = new Довідники.Валюти_Pointer(new UnigueID(Uid));
					this.DialogResult = DialogResult.OK;
					this.Close();
				}
				else
				{
					toolStripButtonEdit_Click(this, null);
				}
			}
		}

        private void toolStripButtonAdd_Click(object sender, EventArgs e)
        {
			Form_ВалютиЕлемент form_ВалютиЕлемент = new Form_ВалютиЕлемент();
			form_ВалютиЕлемент.MdiParent = this.MdiParent;
			form_ВалютиЕлемент.IsNew = true;
			form_ВалютиЕлемент.OwnerForm = this;
			if (DirectoryPointerItem != null && this.MdiParent == null)
				form_ВалютиЕлемент.ShowDialog();
			else
				form_ВалютиЕлемент.Show();
		}

        private void toolStripButtonEdit_Click(object sender, EventArgs e)
        {
			if (dataGridViewRecords.SelectedRows.Count > 0)
			{
				int RowIndex = dataGridViewRecords.SelectedRows[0].Index;

				Form_ВалютиЕлемент form_ВалютиЕлемент = new Form_ВалютиЕлемент();
				form_ВалютиЕлемент.MdiParent = this.MdiParent;
				form_ВалютиЕлемент.IsNew = false;
				form_ВалютиЕлемент.OwnerForm = this;
				form_ВалютиЕлемент.Uid = dataGridViewRecords.Rows[RowIndex].Cells["ID"].Value.ToString();
				if (DirectoryPointerItem != null && this.MdiParent == null)
					form_ВалютиЕлемент.ShowDialog();
				else
					form_ВалютиЕлемент.Show();
			}			
		}

        private void toolStripButtonRefresh_Click(object sender, EventArgs e)
        {
			LoadRecords();
		}

        private void toolStripButtonCopy_Click(object sender, EventArgs e)
        {
			if (dataGridViewRecords.SelectedRows.Count != 0 &&
				MessageBox.Show("Копіювати записи?", "Повідомлення", MessageBoxButtons.YesNo) == DialogResult.Yes)
			{
				for (int i = 0; i < dataGridViewRecords.SelectedRows.Count; i++)
				{
					DataGridViewRow row = dataGridViewRecords.SelectedRows[i];
					string uid = row.Cells["ID"].Value.ToString();

                    Довідники.Валюти_Objest валюти_Objest = new Довідники.Валюти_Objest();
                    if (валюти_Objest.Read(new UnigueID(uid)))
                    {
						Довідники.Валюти_Objest валюти_Objest_Новий = валюти_Objest.Copy();
						валюти_Objest_Новий.Назва = "Копія - " + валюти_Objest_Новий.Назва;
						валюти_Objest_Новий.Код = (++Константи.НумераціяДовідників.Валюти_Const).ToString("D6");
						валюти_Objest_Новий.Save();

						SelectPointerItem = валюти_Objest_Новий.GetDirectoryPointer();
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

        private void toolStripButtonDelete_Click(object sender, EventArgs e)
        {
			if (dataGridViewRecords.SelectedRows.Count != 0 &&
				MessageBox.Show("Видалити записи?", "Повідомлення", MessageBoxButtons.YesNo) == DialogResult.Yes)
			{
				for (int i = 0; i < dataGridViewRecords.SelectedRows.Count; i++)
				{
					DataGridViewRow row = dataGridViewRecords.SelectedRows[i];
					string uid = row.Cells["ID"].Value.ToString();

                    Довідники.Валюти_Objest валюти_Objest = new Довідники.Валюти_Objest();
                    if (валюти_Objest.Read(new UnigueID(uid)))
                    {
						валюти_Objest.Delete();
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

				SelectPointerItem = new Довідники.Валюти_Pointer(new UnigueID(dataGridViewRecords.Rows[RowIndex].Cells["ID"].Value.ToString()));
			}
		}

		private void toolStripButtonDownloadExchangeCurrency_Click(object sender, EventArgs e)
		{
			Form_ЗавантаженняКурсівВалют form_ЗавантаженняКурсівВалют = new Form_ЗавантаженняКурсівВалют();
			form_ЗавантаженняКурсівВалют.MdiParent = this.MdiParent;
			form_ЗавантаженняКурсівВалют.Show();
        }

		private void toolStripButtonКурсиВалюти_Click(object sender, EventArgs e)
		{
            if (dataGridViewRecords.SelectedRows.Count > 0)
            {
                int RowIndex = dataGridViewRecords.SelectedRows[0].Index;

                Form_КурсиВалют Form_КурсиВалют = new Form_КурсиВалют();
                Form_КурсиВалют.MdiParent = this.MdiParent;
                Form_КурсиВалют.ВалютаВласник = new Довідники.Валюти_Pointer(new UnigueID(dataGridViewRecords.Rows[RowIndex].Cells["ID"].Value.ToString()));
                Form_КурсиВалют.Show();
            }
        }
	}
}
