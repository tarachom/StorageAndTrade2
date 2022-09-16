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

using AccountingSoftware;
using Константи = StorageAndTrade_1_0.Константи;
using Journal = StorageAndTrade_1_0.Журнали;
using System.Reflection;
using StorageAndTrade.Service;

namespace StorageAndTrade
{
	public partial class FormService : Form
	{
		public FormService()
		{
			InitializeComponent();
		}

        CancellationTokenSource CancellationTokenThread { get; set; }
        private Thread thread;

		private void FormService_FormClosing(object sender, FormClosingEventArgs e)
		{
			if (CancellationTokenThread != null)
				CancellationTokenThread.Cancel();
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
			button_CalculationBalancesAll.Enabled = false;

			CancellationTokenThread = new CancellationTokenSource();
            thread = new Thread(new ThreadStart(SpendAllDocument));
			thread.Start();
		}

		private void button_CalculationBalancesAll_Click(object sender, EventArgs e)
		{
			buttonSpendAll.Enabled = false;
			buttonCancel.Enabled = true;
			button_CalculationBalancesAll.Enabled = false;

            CancellationTokenThread = new CancellationTokenSource();
            thread = new Thread(new ThreadStart(CalculationBalancesAll));
			thread.Start();
		}

		void CalculationBalancesAll()
		{
			Константи.Системні.ВвімкнутиФоновіЗадачі_Const = false;

			CalculationBalancesAll_Func();

			Константи.Системні.ВвімкнутиФоновіЗадачі_Const = true;

			if (!this.Disposing && this.IsHandleCreated)
			{
				buttonSpendAll.Invoke(new Action(() => buttonSpendAll.Enabled = true));
				buttonCancel.Invoke(new Action(() => buttonCancel.Enabled = false));
				button_CalculationBalancesAll.Invoke(new Action(() => button_CalculationBalancesAll.Enabled = true));
			}
		}

		void CalculationBalancesAll_Func()
		{
			//Видалити всі задачі
            CalculationBalances.ClearAllTask();

            if (!CancellationTokenThread.IsCancellationRequested)
			{
				ApendLine("\nПерерахунок залишків");

				ApendLine("\nОбчислення залишків з групуванням по днях");
				foreach (string registerAccumulation in CalculationBalances.СписокДоступнихВіртуальнихРегістрів)
				{
					if (CancellationTokenThread.IsCancellationRequested)
						break;

					ApendLine(" --> регістер: " + registerAccumulation);
					CalculationBalances.ОбчисленняВіртуальнихЗалишківПоВсіхДнях(registerAccumulation);
				}
			}

			if (!CancellationTokenThread.IsCancellationRequested)
			{
				ApendLine("\nОбновлення актуальності:");
				foreach (string registerAccumulation in CalculationBalances.СписокДоступнихВіртуальнихРегістрів)
				{
					if (CancellationTokenThread.IsCancellationRequested)
						break;

					ApendLine(" --> регістер: " + registerAccumulation);
					CalculationBalances.СкинутиЗначенняАктуальностіВіртуальнихЗалишківПоВсіхМісяцях(registerAccumulation);
				}
			}

			if (!CancellationTokenThread.IsCancellationRequested)
			{
				ApendLine("\nОбчислення залишків з групуванням по місяцях");
				CalculationBalances.ОбчисленняВіртуальнихЗалишківПоМісяцях();
			}

			if (!CancellationTokenThread.IsCancellationRequested)
				ApendLine("\nГотово!");
		}

		void SpendAllDocument()
		{
			Константи.Системні.ВвімкнутиФоновіЗадачі_Const = false;

			Journal.Journal_Select journalSelect = new Journal.Journal_Select();
			journalSelect.Select(DateTime.Parse("01.01.2000 00:00:00"), DateTime.Now);

			while (journalSelect.MoveNext())
            {
				if (CancellationTokenThread.IsCancellationRequested)
					break;

				if (journalSelect.Current.Spend)
				{
					ApendLine(journalSelect.Current.TypeDocument + " " + journalSelect.Current.SpendDate);

					DocumentObject doc = journalSelect.GetDocumentObject(true);

                    // !!!
                    // треба додати перехват помилки
                    //

                    if (doc.GetType().GetMember("SpendTheDocument").Length == 1)
					{
						try
						{
							doc.GetType().InvokeMember("SpendTheDocument", BindingFlags.InvokeMethod, null , doc,
								new object[] { journalSelect.Current.SpendDate });
						}
                        catch 
                        {
                            ApendLine("Помилка: ");
                        }
                    }
				}
			}

			ApendLine("Готово!");

			CalculationBalancesAll_Func();

			Константи.Системні.ВвімкнутиФоновіЗадачі_Const = true;

			if (!this.Disposing)
			{
				buttonSpendAll.Invoke(new Action(() => buttonSpendAll.Enabled = true));
				buttonCancel.Invoke(new Action(() => buttonCancel.Enabled = false));
				button_CalculationBalancesAll.Invoke(new Action(() => button_CalculationBalancesAll.Enabled = true));
			}
		}
	}
}
