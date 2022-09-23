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
using System.IO;
using System.Windows.Forms;

using AccountingSoftware;
using Константи = StorageAndTrade_1_0.Константи;
using Довідники = StorageAndTrade_1_0.Довідники;
using РегістриВідомостей = StorageAndTrade_1_0.РегістриВідомостей;

namespace StorageAndTrade
{
    public partial class Form_ФайлиДокументів : Form
    {
        public Form_ФайлиДокументів()
        {
            InitializeComponent();

			dataGridViewRecords.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

			RecordsBindingList = new BindingList<Записи>();
			dataGridViewRecords.DataSource = RecordsBindingList;

			dataGridViewRecords.Columns["Image"].Width = 30;
			dataGridViewRecords.Columns["Image"].HeaderText = "";

			dataGridViewRecords.Columns["ID"].Visible = false;
            dataGridViewRecords.Columns["Файл"].Visible = false;

			dataGridViewRecords.Columns["ФайлНазва"].HeaderText = "Назва";
            dataGridViewRecords.Columns["ФайлНазва"].Width = 500;

            dataGridViewRecords.Columns["НазваФайлу"].HeaderText = "Файл";
            dataGridViewRecords.Columns["НазваФайлу"].Width = 400;

            dataGridViewRecords.Columns["Створений"].Width = 150;
        }

		/// <summary>
		/// Документ власник
		/// </summary>
		public DocumentPointer ДокументВласник { get; set; }

		/// <summary>
		/// UID для виділення в списку
		/// </summary>
		public string SelectPointerItem { get; set; }

		private void Form_ФайлиДокументів_Load(object sender, EventArgs e)
        {
			LoadRecords();
		}

		private BindingList<Записи> RecordsBindingList { get; set; }

		public void LoadRecords()
		{
			RecordsBindingList.Clear();

			РегістриВідомостей.ФайлиДокументів_RecordsSet ФайлиДокументів = new РегістриВідомостей.ФайлиДокументів_RecordsSet();

            //JOIN 1
            ФайлиДокументів.QuerySelect.FieldAndAlias.Add(
                new NameValue<string>(Довідники.Файли_Const.TABLE + "." + Довідники.Файли_Const.Назва, "file_name"));

            ФайлиДокументів.QuerySelect.FieldAndAlias.Add(
                new NameValue<string>(Довідники.Файли_Const.TABLE + "." + Довідники.Файли_Const.Розмір, "file_size"));

            ФайлиДокументів.QuerySelect.FieldAndAlias.Add(
                new NameValue<string>(Довідники.Файли_Const.TABLE + "." + Довідники.Файли_Const.ДатаСтворення, "file_datecreate"));

            ФайлиДокументів.QuerySelect.FieldAndAlias.Add(
                new NameValue<string>(Довідники.Файли_Const.TABLE + "." + Довідники.Файли_Const.НазваФайлу, "file_filename"));

            ФайлиДокументів.QuerySelect.Joins.Add(
                new Join(Довідники.Файли_Const.TABLE, РегістриВідомостей.ФайлиДокументів_Const.Файл, РегістриВідомостей.ФайлиДокументів_Const.TABLE));

            //Відбір
            if (ДокументВласник != null && !ДокументВласник.IsEmpty())
				ФайлиДокументів.QuerySelect.Where.Add(
					new Where("owner", Comparison.EQ, ДокументВласник.UnigueID.UGuid));
			
			//ORDER
			ФайлиДокументів.QuerySelect.Order.Add(Довідники.Файли_Const.TABLE + "." + Довідники.Файли_Const.Назва, SelectOrder.ASC);

            ФайлиДокументів.Read();

			foreach (РегістриВідомостей.ФайлиДокументів_RecordsSet.Record запис in ФайлиДокументів.Records)
			{
				RecordsBindingList.Add(new Записи
				{
					ID = запис.UID.ToString(),
					Файл = запис.Файл,
					ФайлНазва = ФайлиДокументів.JoinValue[запис.UID.ToString()]["file_name"].ToString(),
                    Розмір = ФайлиДокументів.JoinValue[запис.UID.ToString()]["file_size"].ToString(),
                    Створений = ФайлиДокументів.JoinValue[запис.UID.ToString()]["file_datecreate"].ToString(),
                    НазваФайлу = ФайлиДокументів.JoinValue[запис.UID.ToString()]["file_filename"].ToString()
                });
			}

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
            public Довідники.Файли_Pointer Файл { get; set; }
            public string ФайлНазва { get; set; }
            public string НазваФайлу { get; set; }
            public string Розмір { get; set; }
            public string Створений { get; set; }
        }

		private void dataGridViewRecords_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
			if (e.RowIndex >= 0 && e.RowIndex < dataGridViewRecords.RowCount)
			{
				toolStripButtonEdit_Click(this, null);
			}
		}

		private void toolStripButtonAdd_Click(object sender, EventArgs e)
		{
			Form_ФайлиДокументівЕлемент form_ФайлиДокументівЕлемент = new Form_ФайлиДокументівЕлемент();
            form_ФайлиДокументівЕлемент.MdiParent = this.MdiParent;
            form_ФайлиДокументівЕлемент.IsNew = true;
            form_ФайлиДокументівЕлемент.OwnerForm = this;
			form_ФайлиДокументівЕлемент.ДокументВласник = ДокументВласник;
            form_ФайлиДокументівЕлемент.Show();
		}

        private void toolStripButtonEdit_Click(object sender, EventArgs e)
        {
			if (dataGridViewRecords.SelectedRows.Count > 0)
			{
				DataGridViewRow row = dataGridViewRecords.SelectedRows[0];
				string uid = row.Cells["ID"].Value.ToString();

                Form_ФайлиДокументівЕлемент form_ФайлиДокументівЕлемент = new Form_ФайлиДокументівЕлемент();
                form_ФайлиДокументівЕлемент.MdiParent = this.MdiParent;
                form_ФайлиДокументівЕлемент.IsNew = false;
                form_ФайлиДокументівЕлемент.OwnerForm = this;
                form_ФайлиДокументівЕлемент.ДокументВласник = ДокументВласник;
                form_ФайлиДокументівЕлемент.Uid = uid;
                form_ФайлиДокументівЕлемент.Show();
			}
		}

        private void toolStripButtonRefresh_Click(object sender, EventArgs e)
        {
            LoadRecords();
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

					РегістриВідомостей.ФайлиДокументів_Objest файлиДокументів_Objest = new РегістриВідомостей.ФайлиДокументів_Objest();
					if (файлиДокументів_Objest.Read(new UnigueID(uid)))
                    {
                        файлиДокументів_Objest.Delete();
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

		private void toolStripButtonAddImage_Click(object sender, EventArgs e)
		{
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "*.*|*.*";
            openFileDialog.Title = "Файл";
            openFileDialog.InitialDirectory = Environment.SpecialFolder.Desktop.ToString();

            if (!(openFileDialog.ShowDialog() == DialogResult.OK))
                return;
            else
            {
                string FileInput = openFileDialog.FileName;

                Довідники.Файли_Pointer файл = ФункціїДляДовідників.ЗавантажитиФайл(FileInput);

                РегістриВідомостей.ФайлиДокументів_Objest файлиДокументів_Objest = new РегістриВідомостей.ФайлиДокументів_Objest();
                файлиДокументів_Objest.New();
                файлиДокументів_Objest.Period = DateTime.Now;
                файлиДокументів_Objest.Owner = ДокументВласник.UnigueID.UGuid;
                файлиДокументів_Objest.Файл = файл;
                файлиДокументів_Objest.Save();

                LoadRecords();
            }
        }
	}
}
