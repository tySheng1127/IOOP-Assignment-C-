namespace IOOP_Assignment
{
    partial class LoggedSession
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
            this.DGV_logged = new System.Windows.Forms.DataGridView();
            this.payRollBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.databaseDataSetLoginScreen = new IOOP_Assignment.DatabaseDataSetLoginScreen();
            this.btn_Back = new System.Windows.Forms.Button();
            this.payRollTableAdapter = new IOOP_Assignment.DatabaseDataSetLoginScreenTableAdapters.PayRollTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_logged)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.payRollBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSetLoginScreen)).BeginInit();
            this.SuspendLayout();
            // 
            // DGV_logged
            // 
            this.DGV_logged.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_logged.Location = new System.Drawing.Point(6, 12);
            this.DGV_logged.Name = "DGV_logged";
            this.DGV_logged.Size = new System.Drawing.Size(341, 324);
            this.DGV_logged.TabIndex = 0;
            // 
            // payRollBindingSource
            // 
            this.payRollBindingSource.DataMember = "PayRoll";
            this.payRollBindingSource.DataSource = this.databaseDataSetLoginScreen;
            // 
            // databaseDataSetLoginScreen
            // 
            this.databaseDataSetLoginScreen.DataSetName = "DatabaseDataSetLoginScreen";
            this.databaseDataSetLoginScreen.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btn_Back
            // 
            this.btn_Back.Location = new System.Drawing.Point(132, 356);
            this.btn_Back.Name = "btn_Back";
            this.btn_Back.Size = new System.Drawing.Size(89, 27);
            this.btn_Back.TabIndex = 1;
            this.btn_Back.Text = "Back";
            this.btn_Back.UseVisualStyleBackColor = true;
            this.btn_Back.Click += new System.EventHandler(this.btn_Back_Click);
            // 
            // payRollTableAdapter
            // 
            this.payRollTableAdapter.ClearBeforeFill = true;
            // 
            // LoggedSession
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(352, 395);
            this.Controls.Add(this.btn_Back);
            this.Controls.Add(this.DGV_logged);
            this.Name = "LoggedSession";
            this.Text = "LoggedSession";
            ((System.ComponentModel.ISupportInitialize)(this.DGV_logged)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.payRollBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSetLoginScreen)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DGV_logged;
        private System.Windows.Forms.Button btn_Back;
        private DatabaseDataSetLoginScreen databaseDataSetLoginScreen;
        private System.Windows.Forms.BindingSource payRollBindingSource;
        private DatabaseDataSetLoginScreenTableAdapters.PayRollTableAdapter payRollTableAdapter;
    }
}