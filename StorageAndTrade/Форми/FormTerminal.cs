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
using System.Windows.Forms;

using AccountingSoftware;
using Конфа = StorageAndTrade_1_0;
using Константи = StorageAndTrade_1_0.Константи;

namespace StorageAndTrade
{
	public partial class FormTerminal : Form
	{
		public FormTerminal()
		{
			InitializeComponent();
		}

        private void FormTerminal_Load(object sender, EventArgs e)
        {
            LoadRecords();
        }

        private void FormTerminal_FormClosing(object sender, FormClosingEventArgs e)
        {
            ФункціїДляПовідомлень.ОчиститиПовідомлення();
        }

        public void LoadRecords()
        {
            richTextBoxInfo.Clear();

            ApendLine(ФункціїДляПовідомлень.ПрочитатиПовідомленняПроПомилку());
        }

        private void ApendLine(string text)
        {
            richTextBoxInfo.AppendText(text);
        }

        private void toolStripButtonRefresh_Click(object sender, EventArgs e)
        {
            LoadRecords();
        }

        private void toolStripButtonClear_Click(object sender, EventArgs e)
        {
            ФункціїДляПовідомлень.ОчиститиПовідомлення();
            richTextBoxInfo.Clear();
        }
    }
}
