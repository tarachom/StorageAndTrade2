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

        public void LoadRecords()
        {
            richTextBoxInfo.Clear();

            string query = $@"
SELECT
    Помилки.{Константи.Системні.ПовідомленняТаПомилки_Помилки_TablePart.Дата} AS Дата,
    Помилки.{Константи.Системні.ПовідомленняТаПомилки_Помилки_TablePart.Обєкт} AS Обєкт,
    Помилки.{Константи.Системні.ПовідомленняТаПомилки_Помилки_TablePart.Повідомлення} AS Повідомлення
FROM
    {Константи.Системні.ПовідомленняТаПомилки_Помилки_TablePart.TABLE} AS Помилки

ORDER BY Дата DESC
";

            Dictionary<string, object> paramQuery = new Dictionary<string, object>();

            string[] columnsName;
            List<Dictionary<string, object>> listRow;

            Конфа.Config.Kernel.DataBase.SelectRequest(query, paramQuery, out columnsName, out listRow);

            foreach (Dictionary<string, object> row in listRow)
            {
                ApendLine(row["Дата"] + " - " + row["Повідомлення"]);
            }
        }

        private void ApendLine(string text)
        {
            richTextBoxInfo.AppendText("\n" + text);
        }

        private void toolStripButtonRefresh_Click(object sender, EventArgs e)
        {
            LoadRecords();
        }
    }
}
