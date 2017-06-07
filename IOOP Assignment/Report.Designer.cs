namespace IOOP_Assignment
{
    partial class Report
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
            this.DGV_report = new System.Windows.Forms.DataGridView();
            this.btn_back = new System.Windows.Forms.Button();
            this.lb_TotalSales = new System.Windows.Forms.Label();
            this.lb_TotalPayable = new System.Windows.Forms.Label();
            this.txt_TotalSales = new System.Windows.Forms.TextBox();
            this.txt_TotalPayable = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_report)).BeginInit();
            this.SuspendLayout();
            // 
            // DGV_report
            // 
            this.DGV_report.AllowUserToAddRows = false;
            this.DGV_report.AllowUserToDeleteRows = false;
            this.DGV_report.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_report.Location = new System.Drawing.Point(12, 13);
            this.DGV_report.Name = "DGV_report";
            this.DGV_report.ReadOnly = true;
            this.DGV_report.Size = new System.Drawing.Size(460, 326);
            this.DGV_report.TabIndex = 0;
            // 
            // btn_back
            // 
            this.btn_back.Location = new System.Drawing.Point(217, 395);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(102, 27);
            this.btn_back.TabIndex = 1;
            this.btn_back.Text = "Back";
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // lb_TotalSales
            // 
            this.lb_TotalSales.AutoSize = true;
            this.lb_TotalSales.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_TotalSales.Location = new System.Drawing.Point(12, 354);
            this.lb_TotalSales.Name = "lb_TotalSales";
            this.lb_TotalSales.Size = new System.Drawing.Size(87, 17);
            this.lb_TotalSales.TabIndex = 2;
            this.lb_TotalSales.Text = "Total Sales :";
            // 
            // lb_TotalPayable
            // 
            this.lb_TotalPayable.AutoSize = true;
            this.lb_TotalPayable.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_TotalPayable.Location = new System.Drawing.Point(227, 357);
            this.lb_TotalPayable.Name = "lb_TotalPayable";
            this.lb_TotalPayable.Size = new System.Drawing.Size(103, 17);
            this.lb_TotalPayable.TabIndex = 3;
            this.lb_TotalPayable.Text = "Total Payable :";
            // 
            // txt_TotalSales
            // 
            this.txt_TotalSales.Location = new System.Drawing.Point(105, 354);
            this.txt_TotalSales.Name = "txt_TotalSales";
            this.txt_TotalSales.ReadOnly = true;
            this.txt_TotalSales.Size = new System.Drawing.Size(102, 20);
            this.txt_TotalSales.TabIndex = 4;
            // 
            // txt_TotalPayable
            // 
            this.txt_TotalPayable.Location = new System.Drawing.Point(372, 357);
            this.txt_TotalPayable.Name = "txt_TotalPayable";
            this.txt_TotalPayable.ReadOnly = true;
            this.txt_TotalPayable.Size = new System.Drawing.Size(100, 20);
            this.txt_TotalPayable.TabIndex = 5;
            // 
            // Report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(481, 434);
            this.Controls.Add(this.txt_TotalPayable);
            this.Controls.Add(this.txt_TotalSales);
            this.Controls.Add(this.lb_TotalPayable);
            this.Controls.Add(this.lb_TotalSales);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.DGV_report);
            this.Name = "Report";
            this.Text = "Report";
            this.Load += new System.EventHandler(this.Report_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_report)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DGV_report;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.Label lb_TotalSales;
        private System.Windows.Forms.Label lb_TotalPayable;
        private System.Windows.Forms.TextBox txt_TotalSales;
        private System.Windows.Forms.TextBox txt_TotalPayable;
    }
}