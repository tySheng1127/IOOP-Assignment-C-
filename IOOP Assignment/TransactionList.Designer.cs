﻿namespace IOOP_Assignment
{
    partial class TransactionList
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
            this.DGV_TransactionList = new System.Windows.Forms.DataGridView();
            this.btn_back = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_TransactionList)).BeginInit();
            this.SuspendLayout();
            // 
            // DGV_TransactionList
            // 
            this.DGV_TransactionList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_TransactionList.Location = new System.Drawing.Point(12, 12);
            this.DGV_TransactionList.Name = "DGV_TransactionList";
            this.DGV_TransactionList.Size = new System.Drawing.Size(502, 327);
            this.DGV_TransactionList.TabIndex = 0;
            // 
            // btn_back
            // 
            this.btn_back.Location = new System.Drawing.Point(193, 356);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(128, 40);
            this.btn_back.TabIndex = 1;
            this.btn_back.Text = "Back";
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // TransactionList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 408);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.DGV_TransactionList);
            this.Name = "TransactionList";
            this.Text = "TransactionList";
            ((System.ComponentModel.ISupportInitialize)(this.DGV_TransactionList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DGV_TransactionList;
        private System.Windows.Forms.Button btn_back;
    }
}