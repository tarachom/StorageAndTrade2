﻿/*
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
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using AccountingSoftware;
using Конфа = StorageAndTrade_1_0;
using Константи = StorageAndTrade_1_0.Константи;
using Довідники = StorageAndTrade_1_0.Довідники;
using Перелічення = StorageAndTrade_1_0.Перелічення;

namespace StorageAndTrade
{
    public partial class Form_ПакуванняОдиниціВиміру : Form
    {
        public Form_ПакуванняОдиниціВиміру()
        {
            InitializeComponent();

			dataGridViewRecords.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

			RecordsBindingList = new BindingList<Записи>();
			dataGridViewRecords.DataSource = RecordsBindingList;

			dataGridViewRecords.Columns["Image"].Width = 30;
			dataGridViewRecords.Columns["Image"].HeaderText = "";

			dataGridViewRecords.Columns["ID"].Visible = false;
			dataGridViewRecords.Columns["Назва"].Width = 300;
			dataGridViewRecords.Columns["Код"].Width = 50;
		}


		/// <summary>
		/// Вказівник для вибору
		/// </summary>
		public DirectoryPointer DirectoryPointerItem { get; set; }

		/// <summary>
		/// Вказівник для виділення в списку
		/// </summary>
		public DirectoryPointer SelectPointerItem { get; set; }

		private void Form_ПакуванняОдиниціВиміру_Load(object sender, EventArgs e)
        {
			LoadRecords();
		}

		private BindingList<Записи> RecordsBindingList { get; set; }

		public void LoadRecords()
		{
			RecordsBindingList.Clear();

			Довідники.ПакуванняОдиниціВиміру_Select пакуванняОдиниціВиміру_Select = new Довідники.ПакуванняОдиниціВиміру_Select();
			пакуванняОдиниціВиміру_Select.QuerySelect.Field.Add(Довідники.ПакуванняОдиниціВиміру_Const.Назва);
			пакуванняОдиниціВиміру_Select.QuerySelect.Field.Add(Довідники.ПакуванняОдиниціВиміру_Const.Код);
			пакуванняОдиниціВиміру_Select.QuerySelect.Field.Add(Довідники.ПакуванняОдиниціВиміру_Const.НазваПовна);
			пакуванняОдиниціВиміру_Select.QuerySelect.Field.Add(Довідники.ПакуванняОдиниціВиміру_Const.КількістьУпаковок);

			//ORDER
			пакуванняОдиниціВиміру_Select.QuerySelect.Order.Add(Довідники.ПакуванняОдиниціВиміру_Const.Назва, SelectOrder.ASC);

			пакуванняОдиниціВиміру_Select.Select();
			while (пакуванняОдиниціВиміру_Select.MoveNext())
			{
				Довідники.ПакуванняОдиниціВиміру_Pointer cur = пакуванняОдиниціВиміру_Select.Current;

				RecordsBindingList.Add(new Записи
				{
					ID = cur.UnigueID.ToString(),
					Назва = cur.Fields[Довідники.ПакуванняОдиниціВиміру_Const.Назва].ToString(),
					Код = cur.Fields[Довідники.ПакуванняОдиниціВиміру_Const.Код].ToString(),
					НазваПовна = cur.Fields[Довідники.ПакуванняОдиниціВиміру_Const.НазваПовна].ToString(),
					КількістьУпаковок = cur.Fields[Довідники.ПакуванняОдиниціВиміру_Const.КількістьУпаковок].ToString()
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
			public string Код { get; set; }
			public string НазваПовна { get; set; }
			public string КількістьУпаковок { get; set; }

		}

        private void dataGridViewRecords_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
			if (e.RowIndex >= 0 && e.RowIndex < dataGridViewRecords.RowCount)
			{
				string Uid = dataGridViewRecords.Rows[e.RowIndex].Cells["ID"].Value.ToString();

				if (DirectoryPointerItem != null)
				{
					DirectoryPointerItem = new Довідники.ПакуванняОдиниціВиміру_Pointer(new UnigueID(Uid));
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
			Form_ПакуванняОдиниціВиміруЕлемент form_ПакуванняОдиниціВиміруЕлемент = new Form_ПакуванняОдиниціВиміруЕлемент();
			form_ПакуванняОдиниціВиміруЕлемент.MdiParent = this.MdiParent;
			form_ПакуванняОдиниціВиміруЕлемент.IsNew = true;
			form_ПакуванняОдиниціВиміруЕлемент.OwnerForm = this;
			if (DirectoryPointerItem != null && this.MdiParent == null)
				form_ПакуванняОдиниціВиміруЕлемент.ShowDialog();
			else
				form_ПакуванняОдиниціВиміруЕлемент.Show();
		}

        private void toolStripButtonEdit_Click(object sender, EventArgs e)
        {
			if (dataGridViewRecords.SelectedRows.Count > 0)
			{
				int RowIndex = dataGridViewRecords.SelectedRows[0].Index;

				Form_ПакуванняОдиниціВиміруЕлемент form_ПакуванняОдиниціВиміруЕлемент = new Form_ПакуванняОдиниціВиміруЕлемент();
				form_ПакуванняОдиниціВиміруЕлемент.MdiParent = this.MdiParent;
				form_ПакуванняОдиниціВиміруЕлемент.IsNew = false;
				form_ПакуванняОдиниціВиміруЕлемент.OwnerForm = this;
				form_ПакуванняОдиниціВиміруЕлемент.Uid = dataGridViewRecords.Rows[RowIndex].Cells["ID"].Value.ToString();
				if (DirectoryPointerItem != null && this.MdiParent == null)
					form_ПакуванняОдиниціВиміруЕлемент.ShowDialog();
				else
					form_ПакуванняОдиниціВиміруЕлемент.Show();
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

                    Довідники.ПакуванняОдиниціВиміру_Objest пакуванняОдиниціВиміру_Objest = new Довідники.ПакуванняОдиниціВиміру_Objest();
                    if (пакуванняОдиниціВиміру_Objest.Read(new UnigueID(uid)))
                    {
						Довідники.ПакуванняОдиниціВиміру_Objest пакуванняОдиниціВиміру_Objest_Новий = пакуванняОдиниціВиміру_Objest.Copy();
						пакуванняОдиниціВиміру_Objest_Новий.Назва = "Копія - " + пакуванняОдиниціВиміру_Objest_Новий.Назва;
						пакуванняОдиниціВиміру_Objest_Новий.Код = (++Константи.НумераціяДовідників.ПакуванняОдиниціВиміру_Const).ToString("D6");
						пакуванняОдиниціВиміру_Objest_Новий.Save();

						SelectPointerItem = пакуванняОдиниціВиміру_Objest_Новий.GetDirectoryPointer();
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

                    Довідники.ПакуванняОдиниціВиміру_Objest пакуванняОдиниціВиміру_Objest = new Довідники.ПакуванняОдиниціВиміру_Objest();
                    if (пакуванняОдиниціВиміру_Objest.Read(new UnigueID(uid)))
                    {
						пакуванняОдиниціВиміру_Objest.Delete();
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

				SelectPointerItem = new Довідники.ПакуванняОдиниціВиміру_Pointer(new UnigueID(dataGridViewRecords.Rows[RowIndex].Cells["ID"].Value.ToString()));
			}
		}
    }
}
