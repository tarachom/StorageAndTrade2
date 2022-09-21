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
using Довідники = StorageAndTrade_1_0.Довідники;
using Перелічення = StorageAndTrade_1_0.Перелічення;

namespace StorageAndTrade
{
    public partial class Form_ПартіяТоварівКомпозит : Form
    {
        public Form_ПартіяТоварівКомпозит()
        {
            InitializeComponent();

			RecordsBindingList = new BindingList<Записи>();
			dataGridViewRecords.DataSource = RecordsBindingList;
			
			dataGridViewRecords.Columns["Image"].Width = 30;
			dataGridViewRecords.Columns["Image"].HeaderText = "";

			dataGridViewRecords.Columns["ID"].Visible = false;
			dataGridViewRecords.Columns["Назва"].Width = 400;
			dataGridViewRecords.Columns["Дата"].Width = 100;
			dataGridViewRecords.Columns["Тип"].Width = 200;
		}

        #region Поля

        /// <summary>
        /// Чи вже завантажений список
        /// </summary>
        private bool IsLoadRecords { get; set; } = false;

        /// <summary>
        /// Вказівник для вибору
        /// </summary>
        public DirectoryPointer DirectoryPointerItem { get; set; }

        /// <summary>
        /// Вказівник для виділення в списку
        /// </summary>
        public DirectoryPointer SelectPointerItem { get; set; }

        /// <summary>
        /// Колекція записів
        /// </summary>
        private BindingList<Записи> RecordsBindingList { get; set; }

        #endregion

        private void Form_ПартіяТоварівКомпозит_Load(object sender, EventArgs e)
        {
            if (!IsLoadRecords)
                LoadRecords(false);
        }

        private void Form_ПартіяТоварівКомпозит_Shown(object sender, EventArgs e)
        {
            ФункціїДляІнтерфейсу.ВиділитиЕлементСпискуПоІД(dataGridViewRecords, DirectoryPointerItem, SelectPointerItem);
        }

        public void LoadRecords(bool isSelectRecord)
		{
			RecordsBindingList.Clear();
			dataGridViewRecords.Rows.Clear();

			Довідники.ПартіяТоварівКомпозит_Select ПартіяТоварівКомпозит_Select = new Довідники.ПартіяТоварівКомпозит_Select();
			ПартіяТоварівКомпозит_Select.QuerySelect.Field.Add(Довідники.ПартіяТоварівКомпозит_Const.Назва);
			ПартіяТоварівКомпозит_Select.QuerySelect.Field.Add(Довідники.ПартіяТоварівКомпозит_Const.Дата);
			ПартіяТоварівКомпозит_Select.QuerySelect.Field.Add(Довідники.ПартіяТоварівКомпозит_Const.ТипДокументу);

			//ORDER
			ПартіяТоварівКомпозит_Select.QuerySelect.Order.Add(Довідники.ПартіяТоварівКомпозит_Const.Дата, SelectOrder.ASC);

			ПартіяТоварівКомпозит_Select.Select();
			while (ПартіяТоварівКомпозит_Select.MoveNext())
			{
				Довідники.ПартіяТоварівКомпозит_Pointer cur = ПартіяТоварівКомпозит_Select.Current;

				RecordsBindingList.Add(new Записи
				{
					ID = cur.UnigueID.ToString(),
					Назва = cur.Fields[Довідники.ПартіяТоварівКомпозит_Const.Назва].ToString(),
					Дата = (DateTime)cur.Fields[Довідники.ПартіяТоварівКомпозит_Const.Дата],
					Тип = ((Перелічення.ТипДокументуПартіяТоварівКомпозит)cur.Fields[Довідники.ПартіяТоварівКомпозит_Const.ТипДокументу]).ToString()
				});
			}

            if (isSelectRecord)
                ФункціїДляІнтерфейсу.ВиділитиЕлементСпискуПоІД(dataGridViewRecords, DirectoryPointerItem, SelectPointerItem);

            IsLoadRecords = true;
        }

		private class Записи
		{
			public Записи() { Image = Properties.Resources.doc_text_image; }
			public Bitmap Image { get; set; }
			public string ID { get; set; }
			public string Назва { get; set; }
			public DateTime Дата { get; set; }
			public string Тип { get; set; }
		}

        private void dataGridViewRecords_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
			if (e.RowIndex >= 0 && e.RowIndex < dataGridViewRecords.RowCount)
			{
				string Uid = dataGridViewRecords.Rows[e.RowIndex].Cells["ID"].Value.ToString();

				if (DirectoryPointerItem != null)
				{
					DirectoryPointerItem = new Довідники.ПартіяТоварівКомпозит_Pointer(new UnigueID(Uid));
					this.DialogResult = DialogResult.OK;
					this.Close();
				}
				else
				{
					toolStripButtonEdit_Click(this, null);
				}
			}
		}

        private void toolStripButtonEdit_Click(object sender, EventArgs e)
        {
			if (dataGridViewRecords.SelectedRows.Count > 0)
			{
				int RowIndex = dataGridViewRecords.SelectedRows[0].Index;

				Form_ПартіяТоварівКомпозитЕлемент form_ПартіяТоварівКомпозитЕлемент = new Form_ПартіяТоварівКомпозитЕлемент();
				form_ПартіяТоварівКомпозитЕлемент.MdiParent = this.MdiParent;
				form_ПартіяТоварівКомпозитЕлемент.IsNew = false;
				form_ПартіяТоварівКомпозитЕлемент.OwnerForm = this;
				form_ПартіяТоварівКомпозитЕлемент.Uid = dataGridViewRecords.Rows[RowIndex].Cells["ID"].Value.ToString();
				if (DirectoryPointerItem != null && this.MdiParent == null)
					form_ПартіяТоварівКомпозитЕлемент.ShowDialog();
				else
					form_ПартіяТоварівКомпозитЕлемент.Show();
			}			
		}

        private void toolStripButtonRefresh_Click(object sender, EventArgs e)
        {
			LoadRecords(true);
		}

        private void toolStripButtonDelete_Click(object sender, EventArgs e)
        {
			
		}
	}
}
