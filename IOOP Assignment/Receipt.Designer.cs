namespace IOOP_Assignment
{
    partial class Receipt
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
            this.rtb_receipt = new System.Windows.Forms.RichTextBox();
            this.lb_Receipt = new System.Windows.Forms.Label();
            this.btn_ok = new System.Windows.Forms.Button();
            this.lb_currentdt = new System.Windows.Forms.Label();
            this.rtb_Change = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // rtb_receipt
            // 
            this.rtb_receipt.Location = new System.Drawing.Point(12, 78);
            this.rtb_receipt.Name = "rtb_receipt";
            this.rtb_receipt.Size = new System.Drawing.Size(230, 239);
            this.rtb_receipt.TabIndex = 0;
            this.rtb_receipt.Text = "";
            // 
            // lb_Receipt
            // 
            this.lb_Receipt.AutoSize = true;
            this.lb_Receipt.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_Receipt.Location = new System.Drawing.Point(72, 9);
            this.lb_Receipt.Name = "lb_Receipt";
            this.lb_Receipt.Size = new System.Drawing.Size(103, 29);
            this.lb_Receipt.TabIndex = 1;
            this.lb_Receipt.Text = "Receipt";
            // 
            // btn_ok
            // 
            this.btn_ok.Location = new System.Drawing.Point(90, 384);
            this.btn_ok.Name = "btn_ok";
            this.btn_ok.Size = new System.Drawing.Size(75, 23);
            this.btn_ok.TabIndex = 2;
            this.btn_ok.Text = "Ok";
            this.btn_ok.UseVisualStyleBackColor = true;
            this.btn_ok.Click += new System.EventHandler(this.btn_ok_Click);
            // 
            // lb_currentdt
            // 
            this.lb_currentdt.AutoSize = true;
            this.lb_currentdt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_currentdt.Location = new System.Drawing.Point(12, 55);
            this.lb_currentdt.Name = "lb_currentdt";
            this.lb_currentdt.Size = new System.Drawing.Size(75, 20);
            this.lb_currentdt.TabIndex = 3;
            this.lb_currentdt.Text = "date time";
            // 
            // rtb_Change
            // 
            this.rtb_Change.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.rtb_Change.Location = new System.Drawing.Point(13, 316);
            this.rtb_Change.Name = "rtb_Change";
            this.rtb_Change.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.rtb_Change.Size = new System.Drawing.Size(229, 53);
            this.rtb_Change.TabIndex = 4;
            this.rtb_Change.Text = "";
            // 
            // Receipt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(254, 410);
            this.Controls.Add(this.rtb_Change);
            this.Controls.Add(this.lb_currentdt);
            this.Controls.Add(this.btn_ok);
            this.Controls.Add(this.lb_Receipt);
            this.Controls.Add(this.rtb_receipt);
            this.Name = "Receipt";
            this.Text = "Receipt";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtb_receipt;
        private System.Windows.Forms.Label lb_Receipt;
        private System.Windows.Forms.Button btn_ok;
        private System.Windows.Forms.Label lb_currentdt;
        private System.Windows.Forms.RichTextBox rtb_Change;
    }
}