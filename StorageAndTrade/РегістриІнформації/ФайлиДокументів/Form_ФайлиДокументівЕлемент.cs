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
using System.IO;
using System.Windows.Forms;

using AccountingSoftware;
using Константи = StorageAndTrade_1_0.Константи;
using Довідники = StorageAndTrade_1_0.Довідники;
using РегістриВідомостей = StorageAndTrade_1_0.РегістриВідомостей;

namespace StorageAndTrade
{
    public partial class Form_ФайлиДокументівЕлемент : Form
    {
        public Form_ФайлиДокументівЕлемент()
        {
            InitializeComponent();
        }

		/// <summary>
		/// Форма списку
		/// </summary>
        public Form_ФайлиДокументів OwnerForm { get; set; }
        
		/// <summary>
		/// Чи це новий
		/// </summary>
        public Nullable<bool> IsNew { get; set; }

		/// <summary>
		/// Ід запису
		/// </summary>
        public string Uid { get; set; }

        /// <summary>
        /// Документ власник
        /// </summary>
        public DocumentPointer ДокументВласник { get; set; }

        /// <summary>
        /// Обєкт запису
        /// </summary>
        private РегістриВідомостей.ФайлиДокументів_Objest файлиДокументів_Objest { get; set; }

		private void Form_ФайлиДокументівЕлемент_Load(object sender, EventArgs e)
        {
            файлиДокументів_Objest = new РегістриВідомостей.ФайлиДокументів_Objest();

			directoryControl_Файл.Init(new Form_Файли(), new Довідники.Файли_Pointer(), ПошуковіЗапити.Файли);

			if (IsNew.HasValue)
			{
				if (IsNew.Value)
				{
					this.Text += " - Новий";
                }
				else
				{
					if (файлиДокументів_Objest.Read(new UnigueID(Uid)))
                    {
						this.Text += " - Редагування";
						directoryControl_Файл.DirectoryPointerItem = файлиДокументів_Objest.Файл;
                    }
					else
						MessageBox.Show("Error read");
				}
			}
		}

        private void buttonSave_Click(object sender, EventArgs e)
        {
			if (IsNew.HasValue)
			{
				if (IsNew.Value)
                    файлиДокументів_Objest.New();

                файлиДокументів_Objest.Period = dateTimePicker_Дата.Value;
                файлиДокументів_Objest.Owner = ДокументВласник.UnigueID.UGuid;
                файлиДокументів_Objest.Файл = (Довідники.Файли_Pointer)directoryControl_Файл.DirectoryPointerItem;

				try
				{
                    файлиДокументів_Objest.Save();
				}
				catch (Exception exp)
				{
					MessageBox.Show(exp.Message);
					return;
				}

				if (OwnerForm != null && !OwnerForm.IsDisposed)
				{
					OwnerForm.SelectPointerItem = файлиДокументів_Objest.UnigueID.ToString();
					OwnerForm.LoadRecords();
				}

				this.Close();
			}
		}

		private void buttonClose_Click(object sender, EventArgs e)
		{
			this.Close();
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

                dateTimePicker_Дата.Value = DateTime.Now;
                directoryControl_Файл.DirectoryPointerItem = файл;
            }
        }
	}
}
