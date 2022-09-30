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
using System.Windows.Forms;

using AccountingSoftware;
using Довідники = StorageAndTrade_1_0.Довідники;
using РегістриВідомостей = StorageAndTrade_1_0.РегістриВідомостей;

namespace StorageAndTrade
{
    public partial class Form_КурсиВалютЕлемент : Form
    {
        public Form_КурсиВалютЕлемент()
        {
            InitializeComponent();
        }

		/// <summary>
		/// Форма списку
		/// </summary>
        public Form_КурсиВалют OwnerForm { get; set; }
        
		/// <summary>
		/// Чи це новий
		/// </summary>
        public Nullable<bool> IsNew { get; set; }

		/// <summary>
		/// Ід запису
		/// </summary>
        public string Uid { get; set; }

		/// <summary>
		/// Власник
		/// </summary>
		public Довідники.Валюти_Pointer ВалютаВласник { get; set; }

		/// <summary>
		/// Обєкт запису
		/// </summary>
		private РегістриВідомостей.КурсиВалют_Objest курсиВалют_Objest { get; set; }

		private void Form_КурсиВалютЕлемент_Load(object sender, EventArgs e)
        {
            курсиВалют_Objest = new РегістриВідомостей.КурсиВалют_Objest();

			directoryControl_Валюта.Init(new Form_Валюти(), new Довідники.Валюти_Pointer(), ПошуковіЗапити.Валюти);

			if (IsNew.HasValue)
			{
				if (IsNew.Value)
				{
					this.Text += " - Новий";
					directoryControl_Валюта.DirectoryPointerItem = ВалютаВласник;
                    dateTimePicker_Дата.Value = DateTime.Now;

                }
				else
				{
					if (курсиВалют_Objest.Read(new UnigueID(Uid)))
                    {
						this.Text += " - Редагування";

						numericControlКурс.Value = курсиВалют_Objest.Курс;
						directoryControl_Валюта.DirectoryPointerItem = курсиВалют_Objest.Валюта;
                        dateTimePicker_Дата.Value = курсиВалют_Objest.Period;
                    }
					else
						MessageBox.Show("Error read");
				}
			}
		}

        private void buttonSave_Click(object sender, EventArgs e)
        {
			if (!numericControlКурс.IsValid)
			{
                MessageBox.Show("Перевірте правельність формату курсу", "Повідомлення", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
			
			if (IsNew.HasValue)
			{
				if (IsNew.Value)
                    курсиВалют_Objest.New();

				курсиВалют_Objest.Period = dateTimePicker_Дата.Value;
                курсиВалют_Objest.Курс = numericControlКурс.Value;
                курсиВалют_Objest.Валюта = (Довідники.Валюти_Pointer)directoryControl_Валюта.DirectoryPointerItem;

				try
				{
                    курсиВалют_Objest.Save();
				}
				catch (Exception exp)
				{
					MessageBox.Show(exp.Message);
					return;
				}

				if (OwnerForm != null && !OwnerForm.IsDisposed)
				{
					OwnerForm.SelectPointerItem = курсиВалют_Objest.UnigueID.ToString();
					OwnerForm.LoadRecords(true);
				}

				this.Close();
			}
		}

		private void buttonClose_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
