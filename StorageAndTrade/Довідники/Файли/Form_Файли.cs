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
using Конфа = StorageAndTrade_1_0;
using Константи = StorageAndTrade_1_0.Константи;
using Довідники = StorageAndTrade_1_0.Довідники;
using Перелічення = StorageAndTrade_1_0.Перелічення;
using System.IO;

namespace StorageAndTrade
{
    public partial class Form_Файли : Form
    {
        public Form_Файли()
        {
            InitializeComponent();

			RecordsBindingList = new BindingList<Записи>();
			dataGridViewRecords.DataSource = RecordsBindingList;
			
			dataGridViewRecords.Columns["Image"].Width = 30;
			dataGridViewRecords.Columns["Image"].HeaderText = "";

			dataGridViewRecords.Columns["ID"].Visible = false;
			dataGridViewRecords.Columns["Назва"].Width = 300;
			dataGridViewRecords.Columns["НазваФайлу"].Width = 300;
            dataGridViewRecords.Columns["НазваФайлу"].HeaderText = "Назва файлу";
            dataGridViewRecords.Columns["Розмір"].Width = 100;
            dataGridViewRecords.Columns["Створений"].Width = 150;
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

		private void Form_Файли_Load(object sender, EventArgs e)
        {
			LoadRecords();
		}

		private BindingList<Записи> RecordsBindingList { get; set; }

		public void LoadRecords()
		{
			RecordsBindingList.Clear();

			Довідники.Файли_Select файли_Select = new Довідники.Файли_Select();
            файли_Select.QuerySelect.Field.Add(Довідники.Файли_Const.Назва);
            файли_Select.QuerySelect.Field.Add(Довідники.Файли_Const.НазваФайлу);
            файли_Select.QuerySelect.Field.Add(Довідники.Файли_Const.Розмір);
            файли_Select.QuerySelect.Field.Add(Довідники.Файли_Const.ДатаСтворення);
            файли_Select.QuerySelect.Field.Add(Довідники.Файли_Const.Код);

            //ORDER
            файли_Select.QuerySelect.Order.Add(Довідники.Файли_Const.Назва, SelectOrder.ASC);

            файли_Select.Select();
			while (файли_Select.MoveNext())
			{
				Довідники.Файли_Pointer cur = файли_Select.Current;

				RecordsBindingList.Add(new Записи
				{
					ID = cur.UnigueID.ToString(),
					Назва = cur.Fields[Довідники.Файли_Const.Назва].ToString(),
                    НазваФайлу = cur.Fields[Довідники.Файли_Const.НазваФайлу].ToString(),
                    Розмір = cur.Fields[Довідники.Файли_Const.Розмір].ToString(),
                    Створений = cur.Fields[Довідники.Файли_Const.ДатаСтворення].ToString(),
                    Код = cur.Fields[Довідники.Файли_Const.Код].ToString()
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
            public string НазваФайлу { get; set; }
            public string Розмір { get; set; }
            public string Створений { get; set; }
            public string Код { get; set; }
		}

        private void dataGridViewRecords_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
			if (e.RowIndex >= 0 && e.RowIndex < dataGridViewRecords.RowCount)
			{
				string Uid = dataGridViewRecords.Rows[e.RowIndex].Cells["ID"].Value.ToString();

				if (DirectoryPointerItem != null)
				{
					DirectoryPointerItem = new Довідники.Файли_Pointer(new UnigueID(Uid));
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
            Form_ФайлиЕлемент form_ФайлиЕлемент = new Form_ФайлиЕлемент();
            form_ФайлиЕлемент.MdiParent = this.MdiParent;
            form_ФайлиЕлемент.IsNew = true;
            form_ФайлиЕлемент.OwnerForm = this;
			if (DirectoryPointerItem != null && this.MdiParent == null)
                form_ФайлиЕлемент.ShowDialog();
			else
                form_ФайлиЕлемент.Show();
		}

        private void toolStripButtonEdit_Click(object sender, EventArgs e)
        {
			if (dataGridViewRecords.SelectedRows.Count > 0)
			{
				int RowIndex = dataGridViewRecords.SelectedRows[0].Index;

                Form_ФайлиЕлемент form_ФайлиЕлемент = new Form_ФайлиЕлемент();
                form_ФайлиЕлемент.MdiParent = this.MdiParent;
                form_ФайлиЕлемент.IsNew = false;
                form_ФайлиЕлемент.OwnerForm = this;
                form_ФайлиЕлемент.Uid = dataGridViewRecords.Rows[RowIndex].Cells["ID"].Value.ToString();
				if (DirectoryPointerItem != null && this.MdiParent == null)
                    form_ФайлиЕлемент.ShowDialog();
				else
                    form_ФайлиЕлемент.Show();
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

                    Довідники.Файли_Objest файли_Objest = new Довідники.Файли_Objest();
                    if (файли_Objest.Read(new UnigueID(uid)))
                    {
						Довідники.Файли_Objest файли_Objest_Новий = файли_Objest.Copy();
                        файли_Objest_Новий.Назва = "Копія - " + файли_Objest_Новий.Назва;
                        файли_Objest_Новий.Код = (++Константи.НумераціяДовідників.Файли_Const).ToString("D6");
                        файли_Objest_Новий.Save();

						SelectPointerItem = файли_Objest_Новий.GetDirectoryPointer();
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

                    Довідники.Файли_Objest файли_Objest = new Довідники.Файли_Objest();
                    if (файли_Objest.Read(new UnigueID(uid)))
                    {
                        файли_Objest.Delete();
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

		private void toolStripButtonAddMultiple_Click(object sender, EventArgs e)
		{
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "*.*|*.*";
            openFileDialog.Title = "Файл";
			openFileDialog.Multiselect = true;
            openFileDialog.InitialDirectory = Environment.SpecialFolder.Desktop.ToString();

			if (!(openFileDialog.ShowDialog() == DialogResult.OK))
				return;
			else
			{
				string[] PathToFileInput = openFileDialog.FileNames;

				foreach (string FileInput in PathToFileInput)
				{
					FileInfo fileInfo = new FileInfo(FileInput);

					Довідники.Файли_Objest файли_Objest = new Довідники.Файли_Objest();
					файли_Objest.New();
                    файли_Objest.Код = (++Константи.НумераціяДовідників.Файли_Const).ToString("D6");
					файли_Objest.НазваФайлу = fileInfo.Name;
					файли_Objest.Назва = файли_Objest.НазваФайлу;
                    файли_Objest.Розмір = Math.Round((decimal)(fileInfo.Length / 1024)).ToString() + " KB";
					файли_Objest.ДатаСтворення = DateTime.Now;
                    файли_Objest.БінарніДані = File.ReadAllBytes(FileInput);
					файли_Objest.Save();
                }

				LoadRecords();
			}
        }
	}
}
