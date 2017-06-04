namespace IOOP_Assignment
{
    partial class TransactionRecord
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
            this.DGV_TransactionRecord = new System.Windows.Forms.DataGridView();
            this.btn_Back = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_TransactionRecord)).BeginInit();
            this.SuspendLayout();
            // 
            // DGV_TransactionRecord
            // 
            this.DGV_TransactionRecord.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_TransactionRecord.Location = new System.Drawing.Point(13, 13);
            this.DGV_TransactionRecord.Name = "DGV_TransactionRecord";
            this.DGV_TransactionRecord.Size = new System.Drawing.Size(506, 322);
            this.DGV_TransactionRecord.TabIndex = 0;
            // 
            // btn_Back
            // 
            this.btn_Back.Location = new System.Drawing.Point(232, 353);
            this.btn_Back.Name = "btn_Back";
            this.btn_Back.Size = new System.Drawing.Size(100, 32);
            this.btn_Back.TabIndex = 1;
            this.btn_Back.Text = "Back";
            this.btn_Back.UseVisualStyleBackColor = true;
            this.btn_Back.Click += new System.EventHandler(this.btn_Back_Click);
            // 
            // TransactionRecord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(531, 397);
            this.Controls.Add(this.btn_Back);
            this.Controls.Add(this.DGV_TransactionRecord);
            this.Name = "TransactionRecord";
            this.Text = "TransactionRecord";
            ((System.ComponentModel.ISupportInitialize)(this.DGV_TransactionRecord)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DGV_TransactionRecord;
        private System.Windows.Forms.Button btn_Back;
    }
}