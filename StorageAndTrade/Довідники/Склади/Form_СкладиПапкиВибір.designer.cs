﻿
namespace StorageAndTrade
{
    partial class Form_СкладиПапкиВибір
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_СкладиПапкиВибір));
            this.panel2 = new System.Windows.Forms.Panel();
            this.Склади_Папки_Дерево = new StorageAndTrade.Form_Склади_Папки_Дерево();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.Склади_Папки_Дерево);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(446, 621);
            this.panel2.TabIndex = 2;
            // 
            // Склади_Папки_Дерево
            // 
            this.Склади_Папки_Дерево.CallBack_AfterSelect = null;
            this.Склади_Папки_Дерево.CallBack_DoubleClick = null;
            this.Склади_Папки_Дерево.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Склади_Папки_Дерево.Location = new System.Drawing.Point(0, 0);
            this.Склади_Папки_Дерево.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.Склади_Папки_Дерево.Name = "Склади_Папки_Дерево";
            this.Склади_Папки_Дерево.Size = new System.Drawing.Size(446, 621);
            this.Склади_Папки_Дерево.TabIndex = 3;
            this.Склади_Папки_Дерево.UidOpenFolder = null;
            // 
            // Form_СкладиПапкиВибір
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(446, 621);
            this.Controls.Add(this.panel2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Form_СкладиПапкиВибір";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Склади Папки";
            this.Load += new System.EventHandler(this.Form_СкладиПапкиВибір_Load);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private Form_Склади_Папки_Дерево Склади_Папки_Дерево;
    }
}