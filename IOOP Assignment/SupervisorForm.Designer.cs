namespace IOOP_Assignment
{
    partial class SupervisorForm
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
            this.components = new System.ComponentModel.Container();
            this.lb_time = new System.Windows.Forms.Label();
            this.btn_Logout = new System.Windows.Forms.Button();
            this.btm_switchCashier = new System.Windows.Forms.Button();
            this.btn_EmployeeList = new System.Windows.Forms.Button();
            this.rtb_detail = new System.Windows.Forms.RichTextBox();
            this.btn_store = new System.Windows.Forms.Button();
            this.btn_Logged = new System.Windows.Forms.Button();
            this.btn_Transacition = new System.Windows.Forms.Button();
            this.btn_Report = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // lb_time
            // 
            this.lb_time.AutoSize = true;
            this.lb_time.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_time.Location = new System.Drawing.Point(14, 25);
            this.lb_time.Name = "lb_time";
            this.lb_time.Size = new System.Drawing.Size(233, 25);
            this.lb_time.TabIndex = 28;
            this.lb_time.Text = "11/11/2017. 4:20:20pm";
            // 
            // btn_Logout
            // 
            this.btn_Logout.BackColor = System.Drawing.Color.Red;
            this.btn_Logout.Location = new System.Drawing.Point(17, 142);
            this.btn_Logout.Name = "btn_Logout";
            this.btn_Logout.Size = new System.Drawing.Size(230, 37);
            this.btn_Logout.TabIndex = 1;
            this.btn_Logout.Text = "Log Out";
            this.btn_Logout.UseVisualStyleBackColor = false;
            this.btn_Logout.Click += new System.EventHandler(this.btn_Logout_Click);
            // 
            // btm_switchCashier
            // 
            this.btm_switchCashier.Location = new System.Drawing.Point(17, 400);
            this.btm_switchCashier.Name = "btm_switchCashier";
            this.btm_switchCashier.Size = new System.Drawing.Size(230, 35);
            this.btm_switchCashier.TabIndex = 7;
            this.btm_switchCashier.Text = "Cashier Form";
            this.btm_switchCashier.UseVisualStyleBackColor = true;
            this.btm_switchCashier.Click += new System.EventHandler(this.btm_switchCashier_Click);
            // 
            // btn_EmployeeList
            // 
            this.btn_EmployeeList.Location = new System.Drawing.Point(17, 230);
            this.btn_EmployeeList.Name = "btn_EmployeeList";
            this.btn_EmployeeList.Size = new System.Drawing.Size(230, 40);
            this.btn_EmployeeList.TabIndex = 3;
            this.btn_EmployeeList.Text = "Employee List";
            this.btn_EmployeeList.UseVisualStyleBackColor = true;
            this.btn_EmployeeList.Click += new System.EventHandler(this.btn_EmployeeList_Click);
            // 
            // rtb_detail
            // 
            this.rtb_detail.Location = new System.Drawing.Point(17, 53);
            this.rtb_detail.Name = "rtb_detail";
            this.rtb_detail.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.rtb_detail.Size = new System.Drawing.Size(230, 54);
            this.rtb_detail.TabIndex = 32;
            this.rtb_detail.Text = "Logged in as: Koksin\nLogged in since: 420\nEmployee ID: 420blazeit\n";
            // 
            // btn_store
            // 
            this.btn_store.Location = new System.Drawing.Point(17, 360);
            this.btn_store.Name = "btn_store";
            this.btn_store.Size = new System.Drawing.Size(230, 34);
            this.btn_store.TabIndex = 6;
            this.btn_store.Text = "Current Stock";
            this.btn_store.UseVisualStyleBackColor = true;
            this.btn_store.Click += new System.EventHandler(this.btn_store_Click);
            // 
            // btn_Logged
            // 
            this.btn_Logged.Location = new System.Drawing.Point(17, 276);
            this.btn_Logged.Name = "btn_Logged";
            this.btn_Logged.Size = new System.Drawing.Size(230, 38);
            this.btn_Logged.TabIndex = 4;
            this.btn_Logged.Text = "Logged Sessions";
            this.btn_Logged.UseVisualStyleBackColor = true;
            this.btn_Logged.Click += new System.EventHandler(this.btn_Logged_Click);
            // 
            // btn_Transacition
            // 
            this.btn_Transacition.Location = new System.Drawing.Point(17, 185);
            this.btn_Transacition.Name = "btn_Transacition";
            this.btn_Transacition.Size = new System.Drawing.Size(230, 39);
            this.btn_Transacition.TabIndex = 2;
            this.btn_Transacition.Text = "Transaction Record";
            this.btn_Transacition.UseVisualStyleBackColor = true;
            // 
            // btn_Report
            // 
            this.btn_Report.Location = new System.Drawing.Point(17, 320);
            this.btn_Report.Name = "btn_Report";
            this.btn_Report.Size = new System.Drawing.Size(230, 34);
            this.btn_Report.TabIndex = 5;
            this.btn_Report.Text = "Generate Report";
            this.btn_Report.UseVisualStyleBackColor = true;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // SupervisorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(270, 453);
            this.Controls.Add(this.btn_Report);
            this.Controls.Add(this.btn_Logged);
            this.Controls.Add(this.btn_store);
            this.Controls.Add(this.btn_Transacition);
            this.Controls.Add(this.rtb_detail);
            this.Controls.Add(this.btn_EmployeeList);
            this.Controls.Add(this.btm_switchCashier);
            this.Controls.Add(this.btn_Logout);
            this.Controls.Add(this.lb_time);
            this.Name = "SupervisorForm";
            this.Text = "SupervisorForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_time;
        private System.Windows.Forms.Button btn_Logout;
        private System.Windows.Forms.Button btm_switchCashier;
        private System.Windows.Forms.Button btn_EmployeeList;
        private System.Windows.Forms.RichTextBox rtb_detail;
        private System.Windows.Forms.Button btn_store;
        private System.Windows.Forms.Button btn_Logged;
        private System.Windows.Forms.Button btn_Transacition;
        private System.Windows.Forms.Button btn_Report;
        private System.Windows.Forms.Timer timer1;

    }
}