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
using System.Windows.Forms;

using AccountingSoftware;
using Конфа = StorageAndTrade_1_0;
using Константи = StorageAndTrade_1_0.Константи;
using Довідники = StorageAndTrade_1_0.Довідники;
using Перелічення = StorageAndTrade_1_0.Перелічення;
using System.IO;
using StorageAndTrade_1_0.Довідники;
using System.Threading;

namespace StorageAndTrade
{
	public partial class Form_ФайлиЕлемент : Form
	{
		public Form_ФайлиЕлемент()
		{
			InitializeComponent();
		}

		/// <summary>
		/// Форма списку
		/// </summary>
		public Form_Файли OwnerForm { get; set; }

		/// <summary>
		/// Чи це новий
		/// </summary>
		public Nullable<bool> IsNew { get; set; }

		/// <summary>
		/// Ід запису
		/// </summary>
		public string Uid { get; set; }

		/// <summary>
		/// Обєкт запису
		/// </summary>
		private Довідники.Файли_Objest файли_Objest { get; set; }

		private string PathToFileInput { get; set; }

		private void Form_ФайлиЕлемент_Load(object sender, EventArgs e)
		{
			labelFileInput.Text = "";

			if (IsNew.HasValue)
			{
				файли_Objest = new Довідники.Файли_Objest();

				if (IsNew.Value)
				{
					this.Text += " - Новий";
					textBox_Код.Text = файли_Objest.Код = (++Константи.НумераціяДовідників.Файли_Const).ToString("D6");
				}
				else
				{
					if (файли_Objest.Read(new UnigueID(Uid)))
					{
						this.Text += " - Редагування";

						textBoxName.Text = файли_Objest.Назва;
                        textBox_НазваФайлу.Text = файли_Objest.НазваФайлу;
                        textBox_Код.Text = файли_Objest.Код;
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
					файли_Objest.New();

				файли_Objest.Назва = textBoxName.Text;
                файли_Objest.НазваФайлу = textBox_НазваФайлу.Text;
                файли_Objest.Код = textBox_Код.Text;

				if (!String.IsNullOrEmpty(PathToFileInput))
				{
					if (File.Exists(PathToFileInput))
					{
						файли_Objest.БінарніДані = File.ReadAllBytes(PathToFileInput);
						файли_Objest.НазваФайлу = new FileInfo(PathToFileInput).Name;
                        файли_Objest.Розмір = Math.Round((decimal)(файли_Objest.БінарніДані.Length / 1024)).ToString() + " KB";
						файли_Objest.ДатаСтворення = DateTime.Now;
                    }
					else
					{
						MessageBox.Show("Не знайдений файл", "Повідомлення", MessageBoxButtons.OK, MessageBoxIcon.Error);
						return;
					}
				}

				try
				{
					файли_Objest.Save();
				}
				catch (Exception exp)
				{
					MessageBox.Show(exp.Message);
					return;
				}

				if (OwnerForm != null && !OwnerForm.IsDisposed)
				{
					OwnerForm.SelectPointerItem = файли_Objest.GetDirectoryPointer();
					OwnerForm.LoadRecords();
				}

				this.Close();
			}
		}

		private void buttonClose_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void toolStripButtonSaveFile_Click(object sender, EventArgs e)
		{
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.FileName = файли_Objest.НазваФайлу;
            saveFileDialog.Filter = "*.*|*.*";
            saveFileDialog.Title = "Збереження файлу";
            saveFileDialog.InitialDirectory = Environment.SpecialFolder.Desktop.ToString();

            if (!(saveFileDialog.ShowDialog() == DialogResult.OK))
                return;
            else
            {
                string fileExport = saveFileDialog.FileName;
                File.WriteAllBytes(fileExport, файли_Objest.БінарніДані);
            }
        }

		private void toolStripButtonFileInput_Click(object sender, EventArgs e)
		{
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "*.*|*.*";
            openFileDialog.Title = "Файл";
            openFileDialog.InitialDirectory = Environment.SpecialFolder.Desktop.ToString();

            PathToFileInput = "";

            if (!(openFileDialog.ShowDialog() == DialogResult.OK))
                return;
            else
            {
                PathToFileInput = openFileDialog.FileName;
                labelFileInput.Text = PathToFileInput;

                textBox_НазваФайлу.Text = Path.GetFileName(PathToFileInput);

                if (String.IsNullOrEmpty(textBoxName.Text))
                    textBoxName.Text = textBox_НазваФайлу.Text;
            }
        }
	}
}
