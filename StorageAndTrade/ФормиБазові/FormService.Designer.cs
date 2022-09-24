﻿
namespace StorageAndTrade
{
    partial class FormService
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormService));
            this.buttonSpendAll = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button_CalculationBalancesAll = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.richTextBoxInfo = new System.Windows.Forms.RichTextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonSpendAll
            // 
            this.buttonSpendAll.Location = new System.Drawing.Point(4, 3);
            this.buttonSpendAll.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonSpendAll.Name = "buttonSpendAll";
            this.buttonSpendAll.Size = new System.Drawing.Size(217, 31);
            this.buttonSpendAll.TabIndex = 0;
            this.buttonSpendAll.Text = "Перепровести всі документи";
            this.buttonSpendAll.UseVisualStyleBackColor = true;
            this.buttonSpendAll.Click += new System.EventHandler(this.buttonSpendAll_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.button_CalculationBalancesAll);
            this.panel1.Controls.Add(this.buttonCancel);
            this.panel1.Controls.Add(this.buttonSpendAll);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(867, 38);
            this.panel1.TabIndex = 1;
            // 
            // button_CalculationBalancesAll
            // 
            this.button_CalculationBalancesAll.Location = new System.Drawing.Point(227, 3);
            this.button_CalculationBalancesAll.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button_CalculationBalancesAll.Name = "button_CalculationBalancesAll";
            this.button_CalculationBalancesAll.Size = new System.Drawing.Size(217, 31);
            this.button_CalculationBalancesAll.TabIndex = 2;
            this.button_CalculationBalancesAll.Text = "Перерахувати залишки";
            this.button_CalculationBalancesAll.UseVisualStyleBackColor = true;
            this.button_CalculationBalancesAll.Click += new System.EventHandler(this.button_CalculationBalancesAll_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Enabled = false;
            this.buttonCancel.Location = new System.Drawing.Point(472, 3);
            this.buttonCancel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(113, 31);
            this.buttonCancel.TabIndex = 1;
            this.buttonCancel.Text = "Зупинити";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.richTextBoxInfo);
            this.panel2.Location = new System.Drawing.Point(4, 42);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(864, 492);
            this.panel2.TabIndex = 1;
            // 
            // richTextBoxInfo
            // 
            this.richTextBoxInfo.BackColor = System.Drawing.SystemColors.Info;
            this.richTextBoxInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBoxInfo.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.richTextBoxInfo.Location = new System.Drawing.Point(0, 0);
            this.richTextBoxInfo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.richTextBoxInfo.Name = "richTextBoxInfo";
            this.richTextBoxInfo.ReadOnly = true;
            this.richTextBoxInfo.Size = new System.Drawing.Size(864, 492);
            this.richTextBoxInfo.TabIndex = 1;
            this.richTextBoxInfo.Text = "";
            // 
            // FormService
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(871, 539);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "FormService";
            this.Text = "Сервіс";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormService_FormClosing);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonSpendAll;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RichTextBox richTextBoxInfo;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button button_CalculationBalancesAll;
    }
}