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

namespace StorageAndTrade
{
    public partial class NumericControl : UserControl
    {
        public NumericControl()
        {
            InitializeComponent();
        }

        public event EventHandler OnChanged;

        public decimal Value
        {
            get
            {
                decimal result;
                return IsValidParse(out result) ? decimal.Parse(textBoxNumeric.Text) : 0;
            }
            set
            {
                textBoxNumeric.Text = value.ToString();
            }
        }

        public bool IsValid
        {
            get
            {
                decimal result;
                return IsValidParse(out result);
            }
        }

        private bool IsValidParse(out decimal result)
        {
            return decimal.TryParse(textBoxNumeric.Text, out result);
        }

        private void textBoxNumeric_TextChanged(object sender, EventArgs e)
        {
            if (textBoxNumeric.TextLength > 0)
            {
                string endChar = textBoxNumeric.Text.Substring(textBoxNumeric.TextLength - 1, 1);
                if (endChar == ".")
                {
                    textBoxNumeric.Text = textBoxNumeric.Text.Replace(".", ",");
                    textBoxNumeric.SelectionStart = textBoxNumeric.TextLength;
                }
            }

            decimal result;
            bool isValid = IsValidParse(out result);

            labelError.Visible = !isValid;

            OnChanged?.Invoke(this, null);
        }

        private void NumericControl_Load(object sender, EventArgs e)
        {
            Value = 0;
        }
    }
}
