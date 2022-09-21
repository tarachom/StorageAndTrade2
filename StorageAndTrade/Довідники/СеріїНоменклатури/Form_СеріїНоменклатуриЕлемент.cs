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
using Довідники = StorageAndTrade_1_0.Довідники;

namespace StorageAndTrade
{
    public partial class Form_СеріїНоменклатуриЕлемент : Form
    {
        public Form_СеріїНоменклатуриЕлемент()
        {
            InitializeComponent();
        }

		/// <summary>
		/// Форма списку
		/// </summary>
        public Form_СеріїНоменклатури OwnerForm { get; set; }
        
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
        private Довідники.СеріїНоменклатури_Objest серіїНоменклатури_Objest { get; set; }

		private void Form_СеріїНоменклатуриЕлемент_Load(object sender, EventArgs e)
        {
			if (IsNew.HasValue)
			{
				серіїНоменклатури_Objest = new Довідники.СеріїНоменклатури_Objest();

				if (IsNew.Value)
				{
					this.Text += " - Новий";
				}
				else
				{
					if (серіїНоменклатури_Objest.Read(new UnigueID(Uid)))
					{
						this.Text += " - Редагування";

						textBox_Номер.Text = серіїНоменклатури_Objest.Номер;
						textBox_Коментар.Text = серіїНоменклатури_Objest.Коментар;
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
					серіїНоменклатури_Objest.New();

				try
				{
					серіїНоменклатури_Objest.Номер = textBox_Номер.Text;
					серіїНоменклатури_Objest.Коментар = textBox_Коментар.Text;
					серіїНоменклатури_Objest.Save();
				}
				catch (Exception exp)
				{
					MessageBox.Show(exp.Message);
					return;
				}

				if (OwnerForm != null && !OwnerForm.IsDisposed)
				{
					OwnerForm.SelectPointerItem = серіїНоменклатури_Objest.GetDirectoryPointer();
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
