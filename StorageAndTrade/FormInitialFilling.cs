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
using System.Threading;
using System.Windows.Forms;
using System.IO;
using System.Xml.XPath;

using AccountingSoftware;
using Константи = StorageAndTrade_1_0.Константи;
using Journal = StorageAndTrade_1_0.Журнали;
using System.Reflection;
using StorageAndTrade.Service;
using System.Xml;
using StorageAndTrade_1_0.Довідники;

namespace StorageAndTrade
{
	public partial class FormInitialFilling : Form
	{
		public FormInitialFilling()
		{
			InitializeComponent();
		}

        CancellationTokenSource CancellationTokenThread { get; set; }
        private Thread thread;

		private void FormInitialFilling_FormClosing(object sender, FormClosingEventArgs e)
		{
			if (CancellationTokenThread != null)
				CancellationTokenThread.Cancel();
		}

        private void buttonCancel_Click(object sender, EventArgs e)
        {
			buttonSpendAll.Enabled = true;
			buttonCancel.Enabled = false;

			CancellationTokenThread.Cancel();
        }

        private void buttonSpendAll_Click(object sender, EventArgs e)
        {
			buttonSpendAll.Enabled = false;
			buttonCancel.Enabled = true;

			

			CancellationTokenThread = new CancellationTokenSource();
            thread = new Thread(new ThreadStart(InitialFilling));
			thread.Start();
		}

		void InitialFilling()
		{
			bool isOK = true;
			string InitialFillingXmlFile = Path.Combine(Path.GetDirectoryName(Application.ExecutablePath), "InitialFilling.xml");

            if(!File.Exists(InitialFillingXmlFile))
			{
				ApendLine("Не знайдений файл InitialFilling.xml в каталозі програми");
                isOK = false;
            }

			if (isOK)
			{
                XPathDocument xPathDoc = new XPathDocument(InitialFillingXmlFile);
                XPathNavigator xPathDocNavigator = xPathDoc.CreateNavigator();

                Валюти_Select валюти_Select = new Валюти_Select();

                XPathNodeIterator ДовідникВалютиЗаписи = xPathDocNavigator.Select("/root/Довідники/Валюти/Запис");
                while (ДовідникВалютиЗаписи.MoveNext())
				{
                    XPathNavigator currentNode = ДовідникВалютиЗаписи.Current;

                    string Код_R030 = currentNode.SelectSingleNode("Код").Value;
                    string Назва = currentNode.SelectSingleNode("Назва").Value;
                    string Коротко = currentNode.SelectSingleNode("Коротко")?.Value ?? "";

                    Валюти_Pointer валюти_Pointer = валюти_Select.FindByField(Валюти_Const.Код_R030, Код_R030);
                    if (валюти_Pointer.IsEmpty())
                    {
                        Валюти_Objest валюти_Objest = new Валюти_Objest();
                        валюти_Objest.New();
                        валюти_Objest.Код = (++Константи.НумераціяДовідників.Валюти_Const).ToString("D6");
                        валюти_Objest.Назва = Назва;
                        валюти_Objest.Код_R030 = Код_R030;
                        валюти_Objest.КороткаНазва = Коротко;
                        валюти_Objest.Save();

                        ApendLine($"Додано новий елемент довідника Валюти: {Назва}, код {Код_R030}");
                    }
                    else
                        ApendLine($"Знайдно елемент довідника Валюти: {Назва} з кодом {Код_R030}");
                }
            }

            if (!this.Disposing)
			{
				buttonSpendAll.Invoke(new Action(() => buttonSpendAll.Enabled = true));
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
    }
}
