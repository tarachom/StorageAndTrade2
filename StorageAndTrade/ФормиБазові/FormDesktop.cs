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

using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

using AccountingSoftware;
using Константи = StorageAndTrade_1_0.Константи;
using Довідники = StorageAndTrade_1_0.Довідники;
using System;

namespace StorageAndTrade
{
    public partial class FormDesktop : Form
    {
        public FormDesktop()
        {
            InitializeComponent();

            RecordsBindingList = new BindingList<Записи>();
            dataGridViewRecords.DataSource = RecordsBindingList;

            dataGridViewRecords.Columns["Image"].Width = 30;
            dataGridViewRecords.Columns["Image"].HeaderText = "";

            dataGridViewRecords.Columns["Дата"].Width = 120;
            dataGridViewRecords.Columns["Стан"].Width = 100;
        }

        private BindingList<Записи> RecordsBindingList { get; set; }

        private void FormDesktop_Load(object sender, System.EventArgs e)
        {
            LoadRecords();
            LoadEndDownload();
        }

        public void LoadRecords()
        {
            RecordsBindingList.Clear();

            List<Dictionary<string, object>> ListRow = ФункціїДляФоновихЗавдань.ОтриматиЗаписиЗІсторіїЗавантаженняКурсуВалют();

            foreach (Dictionary<string, object> Row in ListRow)
            {
                RecordsBindingList.Add(new Записи
                {
                    Дата = Row["Дата"].ToString(),
                    Стан = Row["Стан"].ToString()
                });
            }
        }

        public void LoadEndDownload()
        {
            DateTime? ДатуОстанньогоЗавантаження = ФункціїДляФоновихЗавдань.ОтриматиДатуОстанньогоЗавантаженняКурсуВалют();

            if (ДатуОстанньогоЗавантаження != null)
                labelEndDownload.Text = ДатуОстанньогоЗавантаження.ToString();
        }

        private class Записи
        {
            public Записи() { Image = Properties.Resources.doc_text_image; }
            public Bitmap Image { get; set; }
            public string Дата { get; set; }
            public string Стан { get; set; }
        }

        private void DownLoadXml_Click(object sender, EventArgs e)
        {
            Form_ЗавантаженняКурсівВалют form_ЗавантаженняКурсівВалют = new Form_ЗавантаженняКурсівВалют();
            //form_ЗавантаженняКурсівВалют.MdiParent = this.MdiParent;
            form_ЗавантаженняКурсівВалют.ShowDialog();

            LoadRecords();
            LoadEndDownload();
        }
    }
}
