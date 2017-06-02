namespace IOOP_Assignment
{
    partial class EmployeeList
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
            this.DGV_EmployeeList = new System.Windows.Forms.DataGridView();
            this.employeeIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usernameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.realNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nRICDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.doBDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contactNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bankInfoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passwordDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jobTitleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.databaseDataSet = new IOOP_Assignment.DatabaseDataSet();
            this.employeeTableAdapter = new IOOP_Assignment.DatabaseDataSetTableAdapters.EmployeeTableAdapter();
            this.btn_back = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txt_ID = new System.Windows.Forms.TextBox();
            this.txt_username = new System.Windows.Forms.TextBox();
            this.txt_Realname = new System.Windows.Forms.TextBox();
            this.txt_NRIC = new System.Windows.Forms.TextBox();
            this.txt_DOB = new System.Windows.Forms.TextBox();
            this.txt_Contact = new System.Windows.Forms.TextBox();
            this.txt_Address = new System.Windows.Forms.TextBox();
            this.txt_Bank = new System.Windows.Forms.TextBox();
            this.txt_Password = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cb_Jobtitle = new System.Windows.Forms.ComboBox();
            this.cb_Gender = new System.Windows.Forms.ComboBox();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.btn_Insert = new System.Windows.Forms.Button();
            this.btn_Update = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_EmployeeList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // DGV_EmployeeList
            // 
            this.DGV_EmployeeList.AutoGenerateColumns = false;
            this.DGV_EmployeeList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_EmployeeList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.employeeIDDataGridViewTextBoxColumn,
            this.usernameDataGridViewTextBoxColumn,
            this.realNameDataGridViewTextBoxColumn,
            this.nRICDataGridViewTextBoxColumn,
            this.genderDataGridViewTextBoxColumn,
            this.doBDataGridViewTextBoxColumn,
            this.contactNumberDataGridViewTextBoxColumn,
            this.addressDataGridViewTextBoxColumn,
            this.bankInfoDataGridViewTextBoxColumn,
            this.passwordDataGridViewTextBoxColumn,
            this.jobTitleDataGridViewTextBoxColumn});
            this.DGV_EmployeeList.DataSource = this.employeeBindingSource;
            this.DGV_EmployeeList.Location = new System.Drawing.Point(12, 12);
            this.DGV_EmployeeList.Name = "DGV_EmployeeList";
            this.DGV_EmployeeList.Size = new System.Drawing.Size(1142, 191);
            this.DGV_EmployeeList.TabIndex = 0;
            this.DGV_EmployeeList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_EmployeeList_CellContentClick);
            // 
            // employeeIDDataGridViewTextBoxColumn
            // 
            this.employeeIDDataGridViewTextBoxColumn.DataPropertyName = "EmployeeID";
            this.employeeIDDataGridViewTextBoxColumn.HeaderText = "EmployeeID";
            this.employeeIDDataGridViewTextBoxColumn.Name = "employeeIDDataGridViewTextBoxColumn";
            // 
            // usernameDataGridViewTextBoxColumn
            // 
            this.usernameDataGridViewTextBoxColumn.DataPropertyName = "username";
            this.usernameDataGridViewTextBoxColumn.HeaderText = "username";
            this.usernameDataGridViewTextBoxColumn.Name = "usernameDataGridViewTextBoxColumn";
            // 
            // realNameDataGridViewTextBoxColumn
            // 
            this.realNameDataGridViewTextBoxColumn.DataPropertyName = "realName";
            this.realNameDataGridViewTextBoxColumn.HeaderText = "realName";
            this.realNameDataGridViewTextBoxColumn.Name = "realNameDataGridViewTextBoxColumn";
            // 
            // nRICDataGridViewTextBoxColumn
            // 
            this.nRICDataGridViewTextBoxColumn.DataPropertyName = "NRIC";
            this.nRICDataGridViewTextBoxColumn.HeaderText = "NRIC";
            this.nRICDataGridViewTextBoxColumn.Name = "nRICDataGridViewTextBoxColumn";
            // 
            // genderDataGridViewTextBoxColumn
            // 
            this.genderDataGridViewTextBoxColumn.DataPropertyName = "Gender";
            this.genderDataGridViewTextBoxColumn.HeaderText = "Gender";
            this.genderDataGridViewTextBoxColumn.Name = "genderDataGridViewTextBoxColumn";
            // 
            // doBDataGridViewTextBoxColumn
            // 
            this.doBDataGridViewTextBoxColumn.DataPropertyName = "DoB";
            this.doBDataGridViewTextBoxColumn.HeaderText = "DoB";
            this.doBDataGridViewTextBoxColumn.Name = "doBDataGridViewTextBoxColumn";
            // 
            // contactNumberDataGridViewTextBoxColumn
            // 
            this.contactNumberDataGridViewTextBoxColumn.DataPropertyName = "ContactNumber";
            this.contactNumberDataGridViewTextBoxColumn.HeaderText = "ContactNumber";
            this.contactNumberDataGridViewTextBoxColumn.Name = "contactNumberDataGridViewTextBoxColumn";
            // 
            // addressDataGridViewTextBoxColumn
            // 
            this.addressDataGridViewTextBoxColumn.DataPropertyName = "Address";
            this.addressDataGridViewTextBoxColumn.HeaderText = "Address";
            this.addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            // 
            // bankInfoDataGridViewTextBoxColumn
            // 
            this.bankInfoDataGridViewTextBoxColumn.DataPropertyName = "BankInfo";
            this.bankInfoDataGridViewTextBoxColumn.HeaderText = "BankInfo";
            this.bankInfoDataGridViewTextBoxColumn.Name = "bankInfoDataGridViewTextBoxColumn";
            // 
            // passwordDataGridViewTextBoxColumn
            // 
            this.passwordDataGridViewTextBoxColumn.DataPropertyName = "password";
            this.passwordDataGridViewTextBoxColumn.HeaderText = "password";
            this.passwordDataGridViewTextBoxColumn.Name = "passwordDataGridViewTextBoxColumn";
            // 
            // jobTitleDataGridViewTextBoxColumn
            // 
            this.jobTitleDataGridViewTextBoxColumn.DataPropertyName = "JobTitle";
            this.jobTitleDataGridViewTextBoxColumn.HeaderText = "JobTitle";
            this.jobTitleDataGridViewTextBoxColumn.Name = "jobTitleDataGridViewTextBoxColumn";
            // 
            // employeeBindingSource
            // 
            this.employeeBindingSource.DataMember = "Employee";
            this.employeeBindingSource.DataSource = this.databaseDataSet;
            // 
            // databaseDataSet
            // 
            this.databaseDataSet.DataSetName = "DatabaseDataSet";
            this.databaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // employeeTableAdapter
            // 
            this.employeeTableAdapter.ClearBeforeFill = true;
            // 
            // btn_back
            // 
            this.btn_back.Location = new System.Drawing.Point(511, 400);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(139, 36);
            this.btn_back.TabIndex = 27;
            this.btn_back.Text = "Back";
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "EmployeeID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Username";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Real Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "NRIC";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(355, 34);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Gender";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(349, 73);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Date of Birth";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(349, 112);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "Contact Number";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(355, 150);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 13);
            this.label8.TabIndex = 9;
            this.label8.Text = "Address";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(636, 31);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 13);
            this.label9.TabIndex = 10;
            this.label9.Text = "Bank Info";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(636, 73);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 13);
            this.label10.TabIndex = 11;
            this.label10.Text = "Password";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(636, 112);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(47, 13);
            this.label11.TabIndex = 12;
            this.label11.Text = "Job Title";
            // 
            // txt_ID
            // 
            this.txt_ID.Location = new System.Drawing.Point(101, 26);
            this.txt_ID.Name = "txt_ID";
            this.txt_ID.Size = new System.Drawing.Size(202, 20);
            this.txt_ID.TabIndex = 13;
            // 
            // txt_username
            // 
            this.txt_username.Location = new System.Drawing.Point(101, 63);
            this.txt_username.Name = "txt_username";
            this.txt_username.Size = new System.Drawing.Size(202, 20);
            this.txt_username.TabIndex = 14;
            // 
            // txt_Realname
            // 
            this.txt_Realname.Location = new System.Drawing.Point(101, 105);
            this.txt_Realname.Name = "txt_Realname";
            this.txt_Realname.Size = new System.Drawing.Size(202, 20);
            this.txt_Realname.TabIndex = 15;
            // 
            // txt_NRIC
            // 
            this.txt_NRIC.Location = new System.Drawing.Point(101, 147);
            this.txt_NRIC.Name = "txt_NRIC";
            this.txt_NRIC.Size = new System.Drawing.Size(202, 20);
            this.txt_NRIC.TabIndex = 16;
            // 
            // txt_DOB
            // 
            this.txt_DOB.Location = new System.Drawing.Point(444, 70);
            this.txt_DOB.Name = "txt_DOB";
            this.txt_DOB.Size = new System.Drawing.Size(169, 20);
            this.txt_DOB.TabIndex = 18;
            // 
            // txt_Contact
            // 
            this.txt_Contact.Location = new System.Drawing.Point(444, 104);
            this.txt_Contact.Name = "txt_Contact";
            this.txt_Contact.Size = new System.Drawing.Size(169, 20);
            this.txt_Contact.TabIndex = 19;
            // 
            // txt_Address
            // 
            this.txt_Address.Location = new System.Drawing.Point(444, 147);
            this.txt_Address.Name = "txt_Address";
            this.txt_Address.Size = new System.Drawing.Size(169, 20);
            this.txt_Address.TabIndex = 20;
            // 
            // txt_Bank
            // 
            this.txt_Bank.Location = new System.Drawing.Point(719, 24);
            this.txt_Bank.Name = "txt_Bank";
            this.txt_Bank.Size = new System.Drawing.Size(176, 20);
            this.txt_Bank.TabIndex = 21;
            // 
            // txt_Password
            // 
            this.txt_Password.Location = new System.Drawing.Point(719, 66);
            this.txt_Password.Name = "txt_Password";
            this.txt_Password.Size = new System.Drawing.Size(176, 20);
            this.txt_Password.TabIndex = 22;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cb_Jobtitle);
            this.groupBox1.Controls.Add(this.cb_Gender);
            this.groupBox1.Controls.Add(this.btn_Delete);
            this.groupBox1.Controls.Add(this.btn_Insert);
            this.groupBox1.Controls.Add(this.txt_Bank);
            this.groupBox1.Controls.Add(this.txt_Password);
            this.groupBox1.Controls.Add(this.btn_Update);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.txt_DOB);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.txt_Contact);
            this.groupBox1.Controls.Add(this.txt_Address);
            this.groupBox1.Controls.Add(this.txt_ID);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txt_username);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txt_NRIC);
            this.groupBox1.Controls.Add(this.txt_Realname);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(13, 210);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1141, 184);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Manage Employee";
            // 
            // cb_Jobtitle
            // 
            this.cb_Jobtitle.FormattingEnabled = true;
            this.cb_Jobtitle.Items.AddRange(new object[] {
            "Employee",
            "Supervisor"});
            this.cb_Jobtitle.Location = new System.Drawing.Point(719, 112);
            this.cb_Jobtitle.Name = "cb_Jobtitle";
            this.cb_Jobtitle.Size = new System.Drawing.Size(176, 21);
            this.cb_Jobtitle.TabIndex = 28;
            // 
            // cb_Gender
            // 
            this.cb_Gender.FormattingEnabled = true;
            this.cb_Gender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.cb_Gender.Location = new System.Drawing.Point(444, 26);
            this.cb_Gender.Name = "cb_Gender";
            this.cb_Gender.Size = new System.Drawing.Size(169, 21);
            this.cb_Gender.TabIndex = 27;
            // 
            // btn_Delete
            // 
            this.btn_Delete.Location = new System.Drawing.Point(958, 137);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(156, 38);
            this.btn_Delete.TabIndex = 26;
            this.btn_Delete.Text = "Delete";
            this.btn_Delete.UseVisualStyleBackColor = true;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // btn_Insert
            // 
            this.btn_Insert.Location = new System.Drawing.Point(958, 83);
            this.btn_Insert.Name = "btn_Insert";
            this.btn_Insert.Size = new System.Drawing.Size(156, 34);
            this.btn_Insert.TabIndex = 25;
            this.btn_Insert.Text = "Insert";
            this.btn_Insert.UseVisualStyleBackColor = true;
            this.btn_Insert.Click += new System.EventHandler(this.btn_Insert_Click);
            // 
            // btn_Update
            // 
            this.btn_Update.Location = new System.Drawing.Point(958, 21);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(156, 39);
            this.btn_Update.TabIndex = 24;
            this.btn_Update.Text = "Update";
            this.btn_Update.UseVisualStyleBackColor = true;
            this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click);
            // 
            // EmployeeList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1166, 448);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.DGV_EmployeeList);
            this.Controls.Add(this.groupBox1);
            this.Name = "EmployeeList";
            this.Text = "EmployeeList";
            ((System.ComponentModel.ISupportInitialize)(this.DGV_EmployeeList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DGV_EmployeeList;
        private DatabaseDataSet databaseDataSet;
        private System.Windows.Forms.BindingSource employeeBindingSource;
        private DatabaseDataSetTableAdapters.EmployeeTableAdapter employeeTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeeIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn usernameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn realNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nRICDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn genderDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn doBDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn contactNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bankInfoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passwordDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn jobTitleDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txt_ID;
        private System.Windows.Forms.TextBox txt_username;
        private System.Windows.Forms.TextBox txt_Realname;
        private System.Windows.Forms.TextBox txt_NRIC;
        private System.Windows.Forms.TextBox txt_DOB;
        private System.Windows.Forms.TextBox txt_Contact;
        private System.Windows.Forms.TextBox txt_Address;
        private System.Windows.Forms.TextBox txt_Bank;
        private System.Windows.Forms.TextBox txt_Password;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_Update;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.Button btn_Insert;
        private System.Windows.Forms.ComboBox cb_Gender;
        private System.Windows.Forms.ComboBox cb_Jobtitle;
    }
}