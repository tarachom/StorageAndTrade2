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
            form_ЗавантаженняКурсівВалют.ShowDialog();

            LoadRecords();
            LoadEndDownload();
        }

        private void linkLabel_Валюти_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form_Валюти form_Валюти = new Form_Валюти();
            form_Валюти.MdiParent = this.MdiParent;
            form_Валюти.Show();
        }

        #region Продажі

        private void linkLabel_ЗамовленняКлієнта_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form_ЗамовленняКлієнтаЖурнал form_ЗамовленняКлієнтаЖурнал = new Form_ЗамовленняКлієнтаЖурнал();
            form_ЗамовленняКлієнтаЖурнал.MdiParent = this.MdiParent;
            form_ЗамовленняКлієнтаЖурнал.Show();
        }

        private void linkLabel_РахунокФактура_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form_РахунокФактураЖурнал form_РахунокФактураЖурнал = new Form_РахунокФактураЖурнал();
            form_РахунокФактураЖурнал.MdiParent = this.MdiParent;
            form_РахунокФактураЖурнал.Show();
        }

        private void linkLabel_АктВиконанихРобіт_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form_АктВиконанихРобітЖурнал form_АктВиконанихРобітЖурнал = new Form_АктВиконанихРобітЖурнал();
            form_АктВиконанихРобітЖурнал.MdiParent = this.MdiParent;
            form_АктВиконанихРобітЖурнал.Show();
        }

        private void linkLabel_РеалізаціяТоварівТаПослуг_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form_РеалізаціяТоварівТаПослугЖурнал form_РеалізаціяТоварівТаПослугЖурнал = new Form_РеалізаціяТоварівТаПослугЖурнал();
            form_РеалізаціяТоварівТаПослугЖурнал.MdiParent = this.MdiParent;
            form_РеалізаціяТоварівТаПослугЖурнал.Show();
        }

        private void linkLabel_ВстановленняЦінНоменклатури_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form_ВстановленняЦінНоменклатуриЖурнал form_ВстановленняЦінНоменклатуриЖурнал = new Form_ВстановленняЦінНоменклатуриЖурнал();
            form_ВстановленняЦінНоменклатуриЖурнал.MdiParent = this.MdiParent;
            form_ВстановленняЦінНоменклатуриЖурнал.Show();
        }

        #endregion

        #region Закупки

        private void linkLabel_ЗамовленняПостачальнику_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form_ЗамовленняПостачальникуЖурнал form_ЗамовленняПостачальникуЖурнал = new Form_ЗамовленняПостачальникуЖурнал();
            form_ЗамовленняПостачальникуЖурнал.MdiParent = this.MdiParent;
            form_ЗамовленняПостачальникуЖурнал.Show();
        }

        private void linkLabel_ПоступленняТоварівТаПослуг_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form_ПоступленняТоварівТаПослугЖурнал form_ПоступленняТоварівТаПослугЖурнал = new Form_ПоступленняТоварівТаПослугЖурнал();
            form_ПоступленняТоварівТаПослугЖурнал.MdiParent = this.MdiParent;
            form_ПоступленняТоварівТаПослугЖурнал.Show();
        }

        #endregion

        #region Каса

        private void linkLabel_ПрихіднийКасовийОрдер_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form_ПрихіднийКасовийОрдерЖурнал form_ПрихіднийКасовийОрдерЖурнал = new Form_ПрихіднийКасовийОрдерЖурнал();
            form_ПрихіднийКасовийОрдерЖурнал.MdiParent = this.MdiParent;
            form_ПрихіднийКасовийОрдерЖурнал.Show();
        }

        private void linkLabel_РозхіднийКасовийОрдер_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form_РозхіднийКасовийОрдерЖурнал form_РозхіднийКасовийОрдерЖурнал = new Form_РозхіднийКасовийОрдерЖурнал();
            form_РозхіднийКасовийОрдерЖурнал.MdiParent = this.MdiParent;
            form_РозхіднийКасовийОрдерЖурнал.Show();
        }

        #endregion

        #region Склад

        private void linkLabel_ПереміщенняТоварів_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form_ПереміщенняТоварівЖурнал form_ПереміщенняТоварівЖурнал = new Form_ПереміщенняТоварівЖурнал();
            form_ПереміщенняТоварівЖурнал.MdiParent = this.MdiParent;
            form_ПереміщенняТоварівЖурнал.Show();
        }

        private void linkLabel_ВведенняЗалишків_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form_ВведенняЗалишківЖурнал form_ВведенняЗалишківЖурнал = new Form_ВведенняЗалишківЖурнал();
            form_ВведенняЗалишківЖурнал.MdiParent = this.MdiParent;
            form_ВведенняЗалишківЖурнал.Show();
        }

        private void linkLabel_ВнутрішнєСпоживанняТоварів_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form_ВнутрішнєСпоживанняТоварівЖурнал form_ВнутрішнєСпоживанняТоварівЖурнал = new Form_ВнутрішнєСпоживанняТоварівЖурнал();
            form_ВнутрішнєСпоживанняТоварівЖурнал.MdiParent = this.MdiParent;
            form_ВнутрішнєСпоживанняТоварівЖурнал.Show();
        }

        private void linkLabel_ПсуванняТоварів_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form_ПсуванняТоварівЖурнал form_ПсуванняТоварівЖурнал = new Form_ПсуванняТоварівЖурнал();
            form_ПсуванняТоварівЖурнал.MdiParent = this.MdiParent;
            form_ПсуванняТоварівЖурнал.Show();
        }

        #endregion

        #region Звіти

        private void linkLabel_ЗамовленняКлієнтів_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form_ЗамовленняКлієнтів_Звіт form_ЗамовленняКлієнтів_Звіт = new Form_ЗамовленняКлієнтів_Звіт();
            form_ЗамовленняКлієнтів_Звіт.MdiParent = this.MdiParent;
            form_ЗамовленняКлієнтів_Звіт.Show();
        }

        private void linkLabel_ЗамовленняПостачальникам_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form_ЗамовленняПостачальникам_Звіт form_ЗамовленняПостачальникам_Звіт = new Form_ЗамовленняПостачальникам_Звіт();
            form_ЗамовленняПостачальникам_Звіт.MdiParent = this.MdiParent;
            form_ЗамовленняПостачальникам_Звіт.Show();
        }

        private void linkLabel_ТовариНаСкладах_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form_ТовариНаСкладах_Звіт form_ТовариНаСкладах_Звіт = new Form_ТовариНаСкладах_Звіт();
            form_ТовариНаСкладах_Звіт.MdiParent = this.MdiParent;
            form_ТовариНаСкладах_Звіт.Show();
        }

        private void linkLabel_ПартіїТоварів_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form_ПартіїТоварів_Звіт form_ПартіїТоварів_Звіт = new Form_ПартіїТоварів_Звіт();
            form_ПартіїТоварів_Звіт.MdiParent = this.MdiParent;
            form_ПартіїТоварів_Звіт.Show();
        }

        private void linkLabel_ВільніЗалишки_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form_ВільніЗалишки_Звіт form_ВільніЗалишки_Звіт = new Form_ВільніЗалишки_Звіт();
            form_ВільніЗалишки_Звіт.MdiParent = this.MdiParent;
            form_ВільніЗалишки_Звіт.Show();
        }

        private void linkLabel_РозрахункиЗКонтрагентами_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form_РозрахункиЗКонтрагентами_Звіт form_РозрахункиЗКонтрагентами_Звіт = new Form_РозрахункиЗКонтрагентами_Звіт();
            form_РозрахункиЗКонтрагентами_Звіт.MdiParent = this.MdiParent;
            form_РозрахункиЗКонтрагентами_Звіт.Show();
        }

        private void linkLabel_РухКоштів_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form_РухКоштів_Звіт form_РухКоштів_Звіт = new Form_РухКоштів_Звіт();
            form_РухКоштів_Звіт.MdiParent = this.MdiParent;
            form_РухКоштів_Звіт.Show();
        }

        #endregion
    }
}
