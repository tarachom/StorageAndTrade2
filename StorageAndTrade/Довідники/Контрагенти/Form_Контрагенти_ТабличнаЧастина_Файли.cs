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
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

using AccountingSoftware;
using Довідники = StorageAndTrade_1_0.Довідники;

namespace StorageAndTrade
{
    public partial class Form_Контрагенти_ТабличнаЧастина_Файли : UserControl
    {
        public Form_Контрагенти_ТабличнаЧастина_Файли()
        {
            InitializeComponent();

			RecordsBindingList = new BindingList<Записи>();
			dataGridViewRecords.DataSource = RecordsBindingList;

            dataGridViewRecords.Columns["Image"].Width = 30;
            dataGridViewRecords.Columns["Image"].HeaderText = "";

            dataGridViewRecords.Columns["ID"].Visible = false;
            dataGridViewRecords.Columns["Файл"].Visible = false;

            dataGridViewRecords.Columns["ФайлНазва"].Width = 500;
            dataGridViewRecords.Columns["ФайлНазва"].HeaderText = "Назва файлу";
            dataGridViewRecords.Columns["ФайлНазва"].ReadOnly = true;

            dataGridViewRecords.Columns["ДатаСтворенняФайлу"].Width = 150;
            dataGridViewRecords.Columns["ДатаСтворенняФайлу"].HeaderText = "Створений";
            dataGridViewRecords.Columns["ДатаСтворенняФайлу"].ReadOnly = true;
        }

		/// <summary>
		/// Власне довідник якому належить таблична частина
		/// </summary>
		public Довідники.Контрагенти_Objest ДовідникОбєкт { get; set; }

		private BindingList<Записи> RecordsBindingList { get; set; }

		private void Form_Контрагенти_ТабличнаЧастина_Файли_Load(object sender, EventArgs e) { }

		public void LoadRecords()
		{
			RecordsBindingList.Clear();

			Довідники.Контрагенти_Файли_TablePart контрагенти_Файли_TablePart =
				new Довідники.Контрагенти_Файли_TablePart(ДовідникОбєкт);

            Query querySelect = контрагенти_Файли_TablePart.QuerySelect;
            querySelect.Clear();

            //JOIN 1
            querySelect.FieldAndAlias.Add(
                new NameValue<string>(Довідники.Файли_Const.TABLE + "." + Довідники.Файли_Const.ДатаСтворення, "date_create"));
            querySelect.Joins.Add(
                new Join(Довідники.Файли_Const.TABLE, Довідники.Контрагенти_Файли_TablePart.Файл, querySelect.Table));

            контрагенти_Файли_TablePart.Read();

            Dictionary<string, Dictionary<string, string>> JoinValue = контрагенти_Файли_TablePart.JoinValue;

            foreach (Довідники.Контрагенти_Файли_TablePart.Record record in контрагенти_Файли_TablePart.Records)
            {
                Записи запис = new Записи
                {
                    ID = record.UID.ToString(),
                    Файл = record.Файл,
                    ДатаСтворенняФайлу = JoinValue[record.UID.ToString()]["date_create"]
                };

                RecordsBindingList.Add(запис);

                Записи.ПісляЗміни_Файл(запис);
            }
		}

		public void SaveRecords()
        {
            Довідники.Контрагенти_Файли_TablePart контрагенти_Файли_TablePart =
                new Довідники.Контрагенти_Файли_TablePart(ДовідникОбєкт);

            контрагенти_Файли_TablePart.Records.Clear();

			int counter = 0;

			foreach (Записи запис in RecordsBindingList)
            {
                контрагенти_Файли_TablePart.Records.Add(
					new Довідники.Контрагенти_Файли_TablePart.Record()
					{
                        Файл = запис.Файл
                    }
			    );

				counter++;
			}

            контрагенти_Файли_TablePart.Save(true);
		}

		private class Записи
		{
            public Записи() { Image = Properties.Resources.doc_text_image; }
            public Bitmap Image { get; set; }
            public string ID { get; set; }
			public Довідники.Файли_Pointer Файл { get; set; }
            public string ФайлНазва { get; set; }
            public string ДатаСтворенняФайлу { get; set; }
            public static Записи New()
			{
				return new Записи
				{
					ID = Guid.Empty.ToString(),
                    Файл = new Довідники.Файли_Pointer()
                };
			}

			public static Записи Clone(Записи запис)
			{
				return new Записи
				{
					ID = Guid.Empty.ToString(),
                    Файл = запис.Файл
                };
			}

            public static void ПісляЗміни_Файл(Записи запис)
            {
                запис.ФайлНазва = запис.Файл.GetPresentation();

                if (!запис.Файл.IsEmpty())
                {
                    Довідники.Файли_Objest файли_Objest = запис.Файл.GetDirectoryObject();
                    if (файли_Objest != null)
                        запис.ДатаСтворенняФайлу = файли_Objest.ДатаСтворення.ToString();
                }
            }
        }

        private void toolStripButtonAdd_Click(object sender, EventArgs e)
        {
			Записи НовийЗапис = Записи.New();
			RecordsBindingList.Add(НовийЗапис);
		}

        #region Вибір, Пошук, Зміна

        private void dataGridViewRecords_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                dataGridViewRecords_CellDoubleClick(sender,
                    new DataGridViewCellEventArgs(dataGridViewRecords.CurrentCell.ColumnIndex, dataGridViewRecords.CurrentCell.RowIndex));
            else if (e.KeyCode == Keys.Delete)
            {
                if (dataGridViewRecords.CurrentCell == null)
                    return;

                string columnName = dataGridViewRecords.Columns[dataGridViewRecords.CurrentCell.ColumnIndex].Name;
                Записи запис = RecordsBindingList[dataGridViewRecords.CurrentCell.RowIndex];

                switch (columnName)
                {
                    case "ФайлНазва":
                        {
                            запис.Файл = new Довідники.Файли_Pointer();
                            Записи.ПісляЗміни_Файл(запис);
                            break;
                        }
                    default:
                        break;
                }

                dataGridViewRecords.Refresh();
            }
            else if (e.KeyCode == Keys.Insert)
                toolStripButtonAdd_Click(sender, new EventArgs());
        }

        private void dataGridViewRecords_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex >= 0 && e.RowIndex >= 0)
                ФункціїДляДокументів.ВідкритиМенюВибору(dataGridViewRecords, e.ColumnIndex, e.RowIndex, RecordsBindingList[e.RowIndex],
                    new string[] { "ФайлНазва" }, SelectClick, FindTextChanged);
        }

        private void SelectClick(object sender, EventArgs e)
        {
            ToolStripMenuItem selectMenu = (ToolStripMenuItem)sender;
            Записи запис = (Записи)selectMenu.Tag;

            switch (selectMenu.Name)
            {
                case "ФайлНазва":
                    {
                        Form_Файли form_Файли = new Form_Файли();
                        form_Файли.DirectoryPointerItem = запис.Файл;
                        form_Файли.ShowDialog();

                        запис.Файл = (Довідники.Файли_Pointer)form_Файли.DirectoryPointerItem;
                        Записи.ПісляЗміни_Файл(запис);

                        break;
                    }
                default:
                    break;
            }

            dataGridViewRecords.Refresh();
        }

        private void FindTextChanged(object sender, EventArgs e)
        {
            ToolStripTextBox findMenu = (ToolStripTextBox)sender;
            Записи запис = (Записи)findMenu.Tag;

            ToolStrip parent = findMenu.GetCurrentParent();

            ФункціїДляДокументів.ОчиститиМенюПошуку(parent);

            string findText = findMenu.Text.TrimStart();

            if (String.IsNullOrWhiteSpace(findMenu.Text))
                findText = "%";

            string query = "";

            switch (findMenu.Name)
            {
                case "ФайлНазва":
                    {
                        query = ПошуковіЗапити.Файли;
                        break;
                    }
                default:
                    return;
            }

            ФункціїДляДокументів.ЗаповнитиМенюПошуку(parent, query, findText, findMenu.Name, запис, FindClick);
        }

        private void FindClick(object sender, EventArgs e)
        {
            ToolStripMenuItem selectMenu = (ToolStripMenuItem)sender;
            NameValue<object> nameValue = (NameValue<object>)selectMenu.Tag;

            string uid = nameValue.Name;
            Записи запис = (Записи)nameValue.Value;

            switch (selectMenu.Name)
            {
                case "ФайлНазва":
                    {
                        запис.Файл = new Довідники.Файли_Pointer(new UnigueID(uid));
                        Записи.ПісляЗміни_Файл(запис);
                        break;
                    }
                default:
                    break;
            }

            dataGridViewRecords.Refresh();
        }

        #endregion

        private void toolStripButtonCopy_Click(object sender, EventArgs e)
        {
			if (dataGridViewRecords.SelectedCells.Count > 0)
			{
				List<int> rowIndexList = new List<int>();

				for (int i = 0; i < dataGridViewRecords.SelectedCells.Count; i++)
					if (!rowIndexList.Contains(dataGridViewRecords.SelectedCells[i].RowIndex) &&
						!dataGridViewRecords.Rows[dataGridViewRecords.SelectedCells[i].RowIndex].IsNewRow)
						rowIndexList.Add(dataGridViewRecords.SelectedCells[i].RowIndex);

				foreach (int rowIndex in rowIndexList)
				{
					Записи запис = Записи.Clone(RecordsBindingList[rowIndex]);
					RecordsBindingList.Add(запис);

                    Записи.ПісляЗміни_Файл(запис);
                }
			}
		}

        private void toolStripButtonDelete_Click(object sender, EventArgs e)
        {
			if (dataGridViewRecords.SelectedCells.Count > 0)
			{
				List<int> deleteRowIndex = new List<int>();

				for (int i = 0; i < dataGridViewRecords.SelectedCells.Count; i++)
					if (!deleteRowIndex.Contains(dataGridViewRecords.SelectedCells[i].RowIndex) &&
						!dataGridViewRecords.Rows[dataGridViewRecords.SelectedCells[i].RowIndex].IsNewRow)
						deleteRowIndex.Add(dataGridViewRecords.SelectedCells[i].RowIndex);

				deleteRowIndex.Sort();

				foreach (int rowIndex in deleteRowIndex.Reverse<int>())
					RecordsBindingList.RemoveAt(rowIndex);
			}
		}
    }
}
