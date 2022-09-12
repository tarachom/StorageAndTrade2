using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StorageAndTrade.СпільніФорми
{
    public partial class Form_InputTextBox : Form
    {
        public Form_InputTextBox()
        {
            InitializeComponent();
        }

        public string InputText { get; set; }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            InputText = textBoxInputText.Text;
            this.DialogResult = DialogResult.OK;
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBoxInputText_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                if (!String.IsNullOrEmpty(textBoxInputText.Text))
                {
                    if (MessageBox.Show("Закрити форму?", "Повідомлення", MessageBoxButtons.YesNo) == DialogResult.Yes)
                        this.Close();
                }
                else
                    this.Close();
            }
        }
    }
}
