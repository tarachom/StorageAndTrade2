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
using System.Drawing;
using System.Windows.Forms;
using System.IO;

using AccountingSoftware;
using Конфа = StorageAndTrade_1_0;
using Константи = StorageAndTrade_1_0.Константи;
using Довідники = StorageAndTrade_1_0.Довідники;
using Перелічення = StorageAndTrade_1_0.Перелічення;

namespace StorageAndTrade
{
    public partial class Form_НоменклатураЕлемент : Form
    {
        public Form_НоменклатураЕлемент()
        {
            InitializeComponent();
        }

		/// <summary>
		/// Форма списку
		/// </summary>
        public Form_Номенклатура OwnerForm { get; set; }
        
		/// <summary>
		/// Чи це новий
		/// </summary>
        public Nullable<bool> IsNew { get; set; }

		/// <summary>
		/// Ід запису
		/// </summary>
        public string Uid { get; set; }

		/// <summary>
		/// Ід родителя для нової папки
		/// </summary>
		public string ParentUid { get; set; }

		/// <summary>
		/// Обєкт запису
		/// </summary>
		private Довідники.Номенклатура_Objest номенклатура_Objest { get; set; }

		private void Form_НоменклатураЕлемент_Load(object sender, EventArgs e)
        {	
			//Заповнення елементів перелічення - ТипНоменклатури
			foreach (ConfigurationEnumField field in Конфа.Config.Kernel.Conf.Enums["ТипиНоменклатури"].Fields.Values)
				comboBox_ТипНоменклатури.Items.Add((Перелічення.ТипиНоменклатури)field.Value);

			directoryControl_НоменклатураПапка.Init(new Form_НоменклатураПапкиВибір(), new Довідники.Номенклатура_Папки_Pointer(new UnigueID(ParentUid)), ПошуковіЗапити.Номенклатура_Папки);
			directoryControl_Виробник.Init(new Form_Виробники(), new Довідники.Виробники_Pointer(), ПошуковіЗапити.Виробники);
			directoryControl_ВидНоменклатури.Init(new Form_ВидиНоменклатури(), new Довідники.ВидиНоменклатури_Pointer(), ПошуковіЗапити.ВидиНоменклатури);
			directoryControl_ОдиницяВиміру.Init(new Form_ПакуванняОдиниціВиміру(), new Довідники.ПакуванняОдиниціВиміру_Pointer(), ПошуковіЗапити.ПакуванняОдиниціВиміру);
            directoryControl_Картинка.Init(new Form_Файли(), new Довідники.Файли_Pointer(), ПошуковіЗапити.Файли);
			directoryControl_Картинка.AfterSelectFunc = () => 
			{
                номенклатура_Objest.ОсновнаКартинкаФайл = (Довідники.Файли_Pointer)directoryControl_Картинка.DirectoryPointerItem;
                ВідобразитиОсновнуКартинку();

                return true;
            };

            if (IsNew.HasValue)
			{
				номенклатура_Objest = new Довідники.Номенклатура_Objest();

				if (IsNew.Value)
				{
					this.Text += " - Новий";
					textBox_Код.Text = номенклатура_Objest.Код = (++Константи.НумераціяДовідників.Номенклатура_Const).ToString("D6");
					comboBox_ТипНоменклатури.SelectedItem = Перелічення.ТипиНоменклатури.Товар;
				}
				else
				{
					if (номенклатура_Objest.Read(new UnigueID(Uid)))
					{
						this.Text += " - Редагування";

						textBox_Назва.Text = номенклатура_Objest.Назва;
						textBox_НазваПовна.Text = номенклатура_Objest.НазваПовна;
						textBox_Артикул.Text = номенклатура_Objest.Артикул;
						textBox_Код.Text = номенклатура_Objest.Код;
						directoryControl_НоменклатураПапка.DirectoryPointerItem = new Довідники.Номенклатура_Папки_Pointer(номенклатура_Objest.Папка.UnigueID);
						directoryControl_Виробник.DirectoryPointerItem = new Довідники.Виробники_Pointer(номенклатура_Objest.Виробник.UnigueID);
						directoryControl_ВидНоменклатури.DirectoryPointerItem = new Довідники.ВидиНоменклатури_Pointer(номенклатура_Objest.ВидНоменклатури.UnigueID);
						directoryControl_ОдиницяВиміру.DirectoryPointerItem = new Довідники.ПакуванняОдиниціВиміру_Pointer(номенклатура_Objest.ОдиницяВиміру.UnigueID);
						comboBox_ТипНоменклатури.SelectedItem = номенклатура_Objest.ТипНоменклатури;
						textBox_Опис.Text = номенклатура_Objest.Опис;
                        directoryControl_Картинка.DirectoryPointerItem = new Довідники.Файли_Pointer(номенклатура_Objest.ОсновнаКартинкаФайл.UnigueID);

                        ВідобразитиОсновнуКартинку();
                    }
					else
						MessageBox.Show("Error read");
				}
			}
		}

		private void Save(bool close)
		{
			if (IsNew.HasValue)
			{
				if (IsNew.Value)
					номенклатура_Objest.New();

				номенклатура_Objest.Назва = textBox_Назва.Text;
				номенклатура_Objest.НазваПовна = textBox_НазваПовна.Text;
				номенклатура_Objest.Артикул = textBox_Артикул.Text;
				номенклатура_Objest.Код = textBox_Код.Text;
				номенклатура_Objest.Папка = (Довідники.Номенклатура_Папки_Pointer)directoryControl_НоменклатураПапка.DirectoryPointerItem;
				номенклатура_Objest.Виробник = (Довідники.Виробники_Pointer)directoryControl_Виробник.DirectoryPointerItem;
				номенклатура_Objest.ВидНоменклатури = (Довідники.ВидиНоменклатури_Pointer)directoryControl_ВидНоменклатури.DirectoryPointerItem;
				номенклатура_Objest.ОдиницяВиміру = (Довідники.ПакуванняОдиниціВиміру_Pointer)directoryControl_ОдиницяВиміру.DirectoryPointerItem;
				номенклатура_Objest.ТипНоменклатури = comboBox_ТипНоменклатури.SelectedItem != null ? (Перелічення.ТипиНоменклатури)comboBox_ТипНоменклатури.SelectedItem : 0;
				номенклатура_Objest.Опис = textBox_Опис.Text;
                номенклатура_Objest.ОсновнаКартинкаФайл = (Довідники.Файли_Pointer)directoryControl_Картинка.DirectoryPointerItem;

                try
				{
					номенклатура_Objest.Save();
				}
				catch (Exception exp)
				{
					MessageBox.Show(exp.Message);
					return;
				}

				if (OwnerForm != null && !OwnerForm.IsDisposed)
				{
					OwnerForm.SelectPointerItem = номенклатура_Objest.GetDirectoryPointer();
					OwnerForm.LoadRecords(true);
				}

				if (close)
					this.Close();
			}
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
			Save(true);
        }

        private void buttonOnlySave_Click(object sender, EventArgs e)
        {
            Save(false);
        }

        private void buttonClose_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void toolStripButtonFileInput_Click(object sender, EventArgs e)
		{
			if (IsNew.Value)
			{
				if (MessageBox.Show("Не записаний елемент довідника. Записати?", "Повідомлення", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
					Save(false);
				else
					return;
			}

			Form_Номенклатура_Файли form_Номенклатура_Файли = new Form_Номенклатура_Файли();
			form_Номенклатура_Файли.MdiParent = this.MdiParent;
			form_Номенклатура_Файли.ДовідникОбєкт = номенклатура_Objest;
			form_Номенклатура_Файли.ОбновитиЗначенняРеквізитівНаФорміНоменклатури = ОбновитиЗначенняРеквізитів;
            form_Номенклатура_Файли.ВідобразитиКартинкуНаФорміНоменклатури = ВідобразитиОсновнуКартинку;
            form_Номенклатура_Файли.Show();
		}

		public void ОбновитиЗначенняРеквізитів()
		{
            directoryControl_Картинка.DirectoryPointerItem = new Довідники.Файли_Pointer(номенклатура_Objest.ОсновнаКартинкаФайл.UnigueID);
        }

		public void ВідобразитиОсновнуКартинку()
		{
			if (!номенклатура_Objest.ОсновнаКартинкаФайл.IsEmpty())
			{
				Довідники.Файли_Objest файлКартинки = номенклатура_Objest.ОсновнаКартинкаФайл.GetDirectoryObject();
				if (файлКартинки != null)
				{
					MemoryStream memoryStream = new MemoryStream(файлКартинки.БінарніДані);

					try
					{
						pictureBox_ОсновнаКартинка.Image = Image.FromStream(memoryStream);
						pictureBox_ОсновнаКартинка.SizeMode = PictureBoxSizeMode.Zoom;
					}
					catch
					{
						pictureBox_ОсновнаКартинка.Image = null;
					}

					memoryStream.Close();
				}
            }
			else
                pictureBox_ОсновнаКартинка.Image = null;
        }
	}
}
