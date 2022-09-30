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
using System.Threading;
using System.Windows.Forms;
using System.Xml.XPath;

using AccountingSoftware;
using Конфа = StorageAndTrade_1_0;
using Константи = StorageAndTrade_1_0.Константи;
using Довідники = StorageAndTrade_1_0.Довідники;
using РегістриВідомостей = StorageAndTrade_1_0.РегістриВідомостей;

namespace StorageAndTrade
{
	public partial class Form_ЗавантаженняКурсівВалют : Form
	{
		public Form_ЗавантаженняКурсівВалют()
		{
			InitializeComponent();
		}

        CancellationTokenSource CancellationTokenThread { get; set; }
        private Thread thread;

		private void Form_ЗавантаженняКурсівВалют_FormClosing(object sender, FormClosingEventArgs e)
		{
			if (CancellationTokenThread != null)
				CancellationTokenThread.Cancel();
		}

        private void buttonCancel_Click(object sender, EventArgs e)
        {
			buttonDownloadExCurr.Enabled = true;
			buttonCancel.Enabled = false;

			CancellationTokenThread.Cancel();
        }

        private void buttonDownloadExCurr_Click(object sender, EventArgs e)
        {
            buttonDownloadExCurr.Enabled = false;
            buttonCancel.Enabled = true;

            richTextBoxInfo.Clear();

            CancellationTokenThread = new CancellationTokenSource();
            thread = new Thread(new ThreadStart(DownloadExCurr));
            thread.Start();
        }

        void DownloadExCurr()
        {
            bool isOK = false;

            string link = Константи.ЗавантаженняДанихІзСайтів.ЗавантаженняКурсівВалют_Const;

            if (String.IsNullOrEmpty(link))
            {
                //За замовчуванням
                link = "https://bank.gov.ua/NBUStatService/v1/statdirectory/exchange";
            }

            if (checkBox_НаВказануДату.Checked)
            {
                DateTime ДатаКурсу = dateTimePicker1_ДатаКурсу.Value;
                link += "?date=" + ДатаКурсу.Year.ToString() + ДатаКурсу.Month.ToString("D2") + ДатаКурсу.Day.ToString("D2"); 
            }

            ApendLine("Завантаження ХМЛ файлу з курсами валют з офційного сайту: bank.gov.ua");
            ApendLine(" --> " + link);

            XPathDocument xPathDoc;
            XPathNavigator xPathDocNavigator = null;

            try
            {
                xPathDoc = new XPathDocument(link);
                xPathDocNavigator = xPathDoc.CreateNavigator();

                isOK = true;
                ApendLine("OK\n");
                ФункціїДляФоновихЗавдань.ДодатиЗаписВІсторіюЗавантаженняКурсуВалют("OK", link);
            }
            catch (Exception ex)
            {
                ApendLine("Помилка завантаження або аналізу ХМЛ файлу: " + ex.Message);
                ФункціїДляФоновихЗавдань.ДодатиЗаписВІсторіюЗавантаженняКурсуВалют("Помилка", link, ex.Message);
                Thread.Sleep(5000);
            }

            if (isOK)
            {
                Довідники.Валюти_Select валюти_Select = new Довідники.Валюти_Select();

                DateTime ПоточнаДатаКурсу = DateTime.MinValue;

                XPathNodeIterator КурсВалюти = xPathDocNavigator.Select("/exchange/currency");
                while (КурсВалюти.MoveNext())
                {
                    if (CancellationTokenThread.IsCancellationRequested)
                        break;

                    string Код_R030 = int.Parse(КурсВалюти.Current.SelectSingleNode("r030").Value).ToString("D3");
                    string НазваВалюти = КурсВалюти.Current.SelectSingleNode("txt").Value;
                    string Коротко = КурсВалюти.Current.SelectSingleNode("cc").Value;
                    decimal Курс = decimal.Parse(КурсВалюти.Current.SelectSingleNode("rate").Value.Replace(".", ","));
                    DateTime ДатаКурсу = DateTime.Parse(КурсВалюти.Current.SelectSingleNode("exchangedate").Value);

                    if (ДатаКурсу != ПоточнаДатаКурсу)
                    {
                        ApendLine($"Курс на дату: {ДатаКурсу}");
                        ПоточнаДатаКурсу = ДатаКурсу;
                    }

                    Довідники.Валюти_Pointer валюти_Pointer = валюти_Select.FindByField(Довідники.Валюти_Const.Код_R030, Код_R030);
                    if (валюти_Pointer.IsEmpty())
                    {
                        Довідники.Валюти_Objest валюти_Objest = new Довідники.Валюти_Objest();
                        валюти_Objest.New();
                        валюти_Objest.Код = (++Константи.НумераціяДовідників.Валюти_Const).ToString("D6");
                        валюти_Objest.Назва = НазваВалюти;
                        валюти_Objest.Код_R030 = Код_R030;
                        валюти_Objest.КороткаНазва = Коротко;
                        валюти_Objest.Save();

                        валюти_Pointer = валюти_Objest.GetDirectoryPointer();

                        ApendLine($"Додано новий елемент довідника Валюти: {НазваВалюти}, код {Код_R030}");
                    }

                    string query = $@"
SELECT
    КурсиВалют.uid
FROM
    {РегістриВідомостей.КурсиВалют_Const.TABLE} AS КурсиВалют
WHERE
    КурсиВалют.{РегістриВідомостей.КурсиВалют_Const.Валюта} = @Валюта AND
    date_trunc('day', КурсиВалют.period::timestamp) = date_trunc('day', @ДатаКурсу::timestamp)
LIMIT 1
";
                    Dictionary<string, object> paramQuery = new Dictionary<string, object>();
                    paramQuery.Add("Валюта", валюти_Pointer.UnigueID.UGuid);
                    paramQuery.Add("ДатаКурсу", ДатаКурсу);

                    string[] columnsName;
                    List<Dictionary<string, object>> listRow;

                    Конфа.Config.Kernel.DataBase.SelectRequest(query, paramQuery, out columnsName, out listRow);

                    if (listRow.Count == 0)
                    {
                        РегістриВідомостей.КурсиВалют_Objest курсиВалют_Objest = new РегістриВідомостей.КурсиВалют_Objest();
                        курсиВалют_Objest.New();
                        курсиВалют_Objest.Period = ДатаКурсу;
                        курсиВалют_Objest.Валюта = валюти_Pointer;
                        курсиВалют_Objest.Кратність = 1;
                        курсиВалют_Objest.Курс = Курс;
                        курсиВалют_Objest.Save();

                        ApendLine($"Додано новий курс валюти: {НазваВалюти} - курс {Курс}");
                    }
                    else
                    {
                        Dictionary<string, object> Рядок = listRow[0];

                        РегістриВідомостей.КурсиВалют_Objest курсиВалют_Objest = new РегістриВідомостей.КурсиВалют_Objest();
                        if (курсиВалют_Objest.Read(new UnigueID(Рядок["uid"])))
                        {
                            курсиВалют_Objest.Курс = Курс;
                            курсиВалют_Objest.Save();

                            ApendLine($"Перезаписано курс валюти: {НазваВалюти} - курс {Курс}");
                        }
                    }
                }
            }

            if (!this.Disposing)
            {
                buttonDownloadExCurr.Invoke(new Action(() => buttonDownloadExCurr.Enabled = true));
                buttonCancel.Invoke(new Action(() => buttonCancel.Enabled = false));
            }
        }

        private void ApendLine(string head)
        {
            if (richTextBoxInfo.InvokeRequired)
            {
                if (!this.Disposing && this.IsHandleCreated)
                    richTextBoxInfo.Invoke(new Action<string>(ApendLine), head);
            }
            else
            {
                if (!this.Disposing && this.IsHandleCreated)
                    richTextBoxInfo.AppendText("\n" + head);
            }
        }

        private void checkBox_НаВказануДату_CheckedChanged(object sender, EventArgs e)
        {
            label1.Enabled = dateTimePicker1_ДатаКурсу.Enabled = checkBox_НаВказануДату.Checked;
        }
    }
}
