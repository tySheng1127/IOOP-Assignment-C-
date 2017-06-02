namespace IOOP_Assignment
{
    partial class CurrentStock
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
            this.DGV_Stock = new System.Windows.Forms.DataGridView();
            this.productIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stockAmountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reorderThresholdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.databaseDataSet1 = new IOOP_Assignment.DatabaseDataSet1();
            this.productTableAdapter = new IOOP_Assignment.DatabaseDataSet1TableAdapters.ProductTableAdapter();
            this.btn_back = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cb_category = new System.Windows.Forms.ComboBox();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.btn_Insert = new System.Windows.Forms.Button();
            this.btn_Update = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_Reorder = new System.Windows.Forms.TextBox();
            this.txt_Amount = new System.Windows.Forms.TextBox();
            this.txt_Price = new System.Windows.Forms.TextBox();
            this.txt_Name = new System.Windows.Forms.TextBox();
            this.txt_ID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Stock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // DGV_Stock
            // 
            this.DGV_Stock.AutoGenerateColumns = false;
            this.DGV_Stock.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.productIDDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.categoryDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn,
            this.stockAmountDataGridViewTextBoxColumn,
            this.reorderThresholdDataGridViewTextBoxColumn});
            this.DGV_Stock.DataSource = this.productBindingSource;
            this.DGV_Stock.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.DGV_Stock.Location = new System.Drawing.Point(12, 12);
            this.DGV_Stock.Name = "DGV_Stock";
            this.DGV_Stock.Size = new System.Drawing.Size(644, 393);
            this.DGV_Stock.TabIndex = 0;
            this.DGV_Stock.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_Stock_CellContentClick);
            // 
            // productIDDataGridViewTextBoxColumn
            // 
            this.productIDDataGridViewTextBoxColumn.DataPropertyName = "ProductID";
            this.productIDDataGridViewTextBoxColumn.HeaderText = "ProductID";
            this.productIDDataGridViewTextBoxColumn.Name = "productIDDataGridViewTextBoxColumn";
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // categoryDataGridViewTextBoxColumn
            // 
            this.categoryDataGridViewTextBoxColumn.DataPropertyName = "Category";
            this.categoryDataGridViewTextBoxColumn.HeaderText = "Category";
            this.categoryDataGridViewTextBoxColumn.Name = "categoryDataGridViewTextBoxColumn";
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "Price";
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            // 
            // stockAmountDataGridViewTextBoxColumn
            // 
            this.stockAmountDataGridViewTextBoxColumn.DataPropertyName = "StockAmount";
            this.stockAmountDataGridViewTextBoxColumn.HeaderText = "StockAmount";
            this.stockAmountDataGridViewTextBoxColumn.Name = "stockAmountDataGridViewTextBoxColumn";
            // 
            // reorderThresholdDataGridViewTextBoxColumn
            // 
            this.reorderThresholdDataGridViewTextBoxColumn.DataPropertyName = "ReorderThreshold";
            this.reorderThresholdDataGridViewTextBoxColumn.HeaderText = "ReorderThreshold";
            this.reorderThresholdDataGridViewTextBoxColumn.Name = "reorderThresholdDataGridViewTextBoxColumn";
            // 
            // productBindingSource
            // 
            this.productBindingSource.DataMember = "Product";
            this.productBindingSource.DataSource = this.databaseDataSet1;
            // 
            // databaseDataSet1
            // 
            this.databaseDataSet1.DataSetName = "DatabaseDataSet1";
            this.databaseDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // productTableAdapter
            // 
            this.productTableAdapter.ClearBeforeFill = true;
            // 
            // btn_back
            // 
            this.btn_back.Location = new System.Drawing.Point(400, 425);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(129, 33);
            this.btn_back.TabIndex = 1;
            this.btn_back.Text = "Back";
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cb_category);
            this.groupBox1.Controls.Add(this.btn_Delete);
            this.groupBox1.Controls.Add(this.btn_Insert);
            this.groupBox1.Controls.Add(this.btn_Update);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txt_Reorder);
            this.groupBox1.Controls.Add(this.txt_Amount);
            this.groupBox1.Controls.Add(this.txt_Price);
            this.groupBox1.Controls.Add(this.txt_Name);
            this.groupBox1.Controls.Add(this.txt_ID);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(672, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(314, 392);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Product Manage";
            // 
            // cb_category
            // 
            this.cb_category.FormattingEnabled = true;
            this.cb_category.Items.AddRange(new object[] {
            "GST",
            "NON GST"});
            this.cb_category.Location = new System.Drawing.Point(141, 123);
            this.cb_category.Name = "cb_category";
            this.cb_category.Size = new System.Drawing.Size(145, 21);
            this.cb_category.TabIndex = 15;
            // 
            // btn_Delete
            // 
            this.btn_Delete.Location = new System.Drawing.Point(211, 321);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(75, 23);
            this.btn_Delete.TabIndex = 14;
            this.btn_Delete.Text = "Delete";
            this.btn_Delete.UseVisualStyleBackColor = true;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // btn_Insert
            // 
            this.btn_Insert.Location = new System.Drawing.Point(117, 321);
            this.btn_Insert.Name = "btn_Insert";
            this.btn_Insert.Size = new System.Drawing.Size(75, 23);
            this.btn_Insert.TabIndex = 13;
            this.btn_Insert.Text = "Insert";
            this.btn_Insert.UseVisualStyleBackColor = true;
            this.btn_Insert.Click += new System.EventHandler(this.btn_Insert_Click);
            // 
            // btn_Update
            // 
            this.btn_Update.Location = new System.Drawing.Point(23, 321);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(75, 23);
            this.btn_Update.TabIndex = 12;
            this.btn_Update.Text = "Update";
            this.btn_Update.UseVisualStyleBackColor = true;
            this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 267);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Reorder Threshold";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 221);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Stock Amount";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 169);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Price";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Category";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Name";
            // 
            // txt_Reorder
            // 
            this.txt_Reorder.Location = new System.Drawing.Point(141, 267);
            this.txt_Reorder.Name = "txt_Reorder";
            this.txt_Reorder.Size = new System.Drawing.Size(145, 20);
            this.txt_Reorder.TabIndex = 6;
            // 
            // txt_Amount
            // 
            this.txt_Amount.Location = new System.Drawing.Point(141, 214);
            this.txt_Amount.Name = "txt_Amount";
            this.txt_Amount.Size = new System.Drawing.Size(145, 20);
            this.txt_Amount.TabIndex = 5;
            // 
            // txt_Price
            // 
            this.txt_Price.Location = new System.Drawing.Point(141, 166);
            this.txt_Price.Name = "txt_Price";
            this.txt_Price.Size = new System.Drawing.Size(145, 20);
            this.txt_Price.TabIndex = 4;
            // 
            // txt_Name
            // 
            this.txt_Name.Location = new System.Drawing.Point(141, 68);
            this.txt_Name.Name = "txt_Name";
            this.txt_Name.Size = new System.Drawing.Size(145, 20);
            this.txt_Name.TabIndex = 2;
            // 
            // txt_ID
            // 
            this.txt_ID.Location = new System.Drawing.Point(141, 20);
            this.txt_ID.Name = "txt_ID";
            this.txt_ID.Size = new System.Drawing.Size(145, 20);
            this.txt_ID.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ProductID";
            // 
            // CurrentStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1007, 470);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.DGV_Stock);
            this.Controls.Add(this.groupBox1);
            this.Name = "CurrentStock";
            this.Text = "CurrentStock";
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Stock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DGV_Stock;
        private DatabaseDataSet1 databaseDataSet1;
        private System.Windows.Forms.BindingSource productBindingSource;
        private DatabaseDataSet1TableAdapters.ProductTableAdapter productTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn productIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stockAmountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn reorderThresholdDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.Button btn_Insert;
        private System.Windows.Forms.Button btn_Update;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_Reorder;
        private System.Windows.Forms.TextBox txt_Amount;
        private System.Windows.Forms.TextBox txt_Price;
        private System.Windows.Forms.TextBox txt_Name;
        private System.Windows.Forms.TextBox txt_ID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cb_category;

    }
}