﻿namespace WinDapper
{
    partial class Insert
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
            this.txtBxName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbBxSup = new System.Windows.Forms.ComboBox();
            this.CmbBxCateg = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBxPrice = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtBxName
            // 
            this.txtBxName.Location = new System.Drawing.Point(348, 65);
            this.txtBxName.Name = "txtBxName";
            this.txtBxName.Size = new System.Drawing.Size(121, 20);
            this.txtBxName.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(260, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Product Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(260, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Suppiler";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(260, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Category";
            // 
            // cmbBxSup
            // 
            this.cmbBxSup.FormattingEnabled = true;
            this.cmbBxSup.Location = new System.Drawing.Point(348, 108);
            this.cmbBxSup.Name = "cmbBxSup";
            this.cmbBxSup.Size = new System.Drawing.Size(121, 21);
            this.cmbBxSup.TabIndex = 6;
            // 
            // CmbBxCateg
            // 
            this.CmbBxCateg.FormattingEnabled = true;
            this.CmbBxCateg.Location = new System.Drawing.Point(348, 159);
            this.CmbBxCateg.Name = "CmbBxCateg";
            this.CmbBxCateg.Size = new System.Drawing.Size(121, 21);
            this.CmbBxCateg.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(260, 216);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Unit Price";
            // 
            // txtBxPrice
            // 
            this.txtBxPrice.Location = new System.Drawing.Point(348, 209);
            this.txtBxPrice.Name = "txtBxPrice";
            this.txtBxPrice.Size = new System.Drawing.Size(121, 20);
            this.txtBxPrice.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(368, 267);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "Ekle";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Insert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtBxPrice);
            this.Controls.Add(this.CmbBxCateg);
            this.Controls.Add(this.cmbBxSup);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBxName);
            this.Name = "Insert";
            this.Text = "Insert";
            this.Load += new System.EventHandler(this.Insert_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBxName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbBxSup;
        private System.Windows.Forms.ComboBox CmbBxCateg;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBxPrice;
        private System.Windows.Forms.Button button1;
    }
}