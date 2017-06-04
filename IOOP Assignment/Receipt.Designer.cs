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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.rtb_GST = new System.Windows.Forms.RichTextBox();
            this.lb_Cashier = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.SuspendLayout();
            // 
            // rtb_receipt
            // 
            this.rtb_receipt.Location = new System.Drawing.Point(12, 165);
            this.rtb_receipt.Name = "rtb_receipt";
            this.rtb_receipt.ReadOnly = true;
            this.rtb_receipt.Size = new System.Drawing.Size(308, 206);
            this.rtb_receipt.TabIndex = 0;
            this.rtb_receipt.Text = "";
            // 
            // lb_Receipt
            // 
            this.lb_Receipt.AutoSize = true;
            this.lb_Receipt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_Receipt.Location = new System.Drawing.Point(65, 9);
            this.lb_Receipt.Name = "lb_Receipt";
            this.lb_Receipt.Size = new System.Drawing.Size(202, 20);
            this.lb_Receipt.TabIndex = 1;
            this.lb_Receipt.Text = "ABC Convenience Store";
            // 
            // btn_ok
            // 
            this.btn_ok.Location = new System.Drawing.Point(125, 536);
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
            this.lb_currentdt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_currentdt.Location = new System.Drawing.Point(107, 127);
            this.lb_currentdt.Name = "lb_currentdt";
            this.lb_currentdt.Size = new System.Drawing.Size(50, 13);
            this.lb_currentdt.TabIndex = 3;
            this.lb_currentdt.Text = "date time";
            // 
            // rtb_Change
            // 
            this.rtb_Change.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.rtb_Change.Location = new System.Drawing.Point(12, 369);
            this.rtb_Change.Name = "rtb_Change";
            this.rtb_Change.ReadOnly = true;
            this.rtb_Change.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.rtb_Change.Size = new System.Drawing.Size(308, 73);
            this.rtb_Change.TabIndex = 4;
            this.rtb_Change.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(210, 78);
            this.label1.TabIndex = 5;
            this.label1.Text = "Jalan Teknologi 5,\r\nTechnology Park Malaysia,\r\nBukit Jalil, Kuala Lumpur 57000,\r\n" +
    "Malaysia.\r\nTel: 03-4233200    Fax:03-4233300\r\nGST identification number:  000217" +
    "687380";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(79, 147);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Invoice No :";
            // 
            // rtb_GST
            // 
            this.rtb_GST.Location = new System.Drawing.Point(13, 448);
            this.rtb_GST.Name = "rtb_GST";
            this.rtb_GST.ReadOnly = true;
            this.rtb_GST.Size = new System.Drawing.Size(307, 54);
            this.rtb_GST.TabIndex = 7;
            this.rtb_GST.Text = "";
            // 
            // lb_Cashier
            // 
            this.lb_Cashier.AutoSize = true;
            this.lb_Cashier.Location = new System.Drawing.Point(12, 505);
            this.lb_Cashier.Name = "lb_Cashier";
            this.lb_Cashier.Size = new System.Drawing.Size(42, 13);
            this.lb_Cashier.TabIndex = 8;
            this.lb_Cashier.Text = "Cashier";
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(5, 9);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(324, 521);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            // 
            // Receipt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(332, 571);
            this.Controls.Add(this.lb_Cashier);
            this.Controls.Add(this.rtb_GST);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rtb_Change);
            this.Controls.Add(this.lb_currentdt);
            this.Controls.Add(this.btn_ok);
            this.Controls.Add(this.lb_Receipt);
            this.Controls.Add(this.rtb_receipt);
            this.Controls.Add(this.groupBox1);
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox rtb_GST;
        private System.Windows.Forms.Label lb_Cashier;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}