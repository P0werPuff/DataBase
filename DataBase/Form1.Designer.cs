namespace DataBase
{
    partial class Form1
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
            this.Toodetxt = new System.Windows.Forms.TextBox();
            this.Kogustxt = new System.Windows.Forms.TextBox();
            this.Hindtxt = new System.Windows.Forms.TextBox();
            this.btn_insert = new System.Windows.Forms.Button();
            this.btn_Update = new System.Windows.Forms.Button();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.toodedDataSet = new DataBase.ToodedDataSet();
            this.toodetableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.toodetableTableAdapter = new DataBase.ToodedDataSetTableAdapters.ToodetableTableAdapter();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toodeNimetusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kogusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hindDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.toodedDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.toodetableBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // Toodetxt
            // 
            this.Toodetxt.Location = new System.Drawing.Point(31, 26);
            this.Toodetxt.Name = "Toodetxt";
            this.Toodetxt.Size = new System.Drawing.Size(144, 20);
            this.Toodetxt.TabIndex = 0;
            // 
            // Kogustxt
            // 
            this.Kogustxt.Location = new System.Drawing.Point(31, 61);
            this.Kogustxt.Name = "Kogustxt";
            this.Kogustxt.Size = new System.Drawing.Size(144, 20);
            this.Kogustxt.TabIndex = 1;
            // 
            // Hindtxt
            // 
            this.Hindtxt.Location = new System.Drawing.Point(31, 97);
            this.Hindtxt.Name = "Hindtxt";
            this.Hindtxt.Size = new System.Drawing.Size(144, 20);
            this.Hindtxt.TabIndex = 2;
            // 
            // btn_insert
            // 
            this.btn_insert.Location = new System.Drawing.Point(31, 123);
            this.btn_insert.Name = "btn_insert";
            this.btn_insert.Size = new System.Drawing.Size(144, 43);
            this.btn_insert.TabIndex = 3;
            this.btn_insert.Text = "Lisa uus";
            this.btn_insert.UseVisualStyleBackColor = true;
            this.btn_insert.Click += new System.EventHandler(this.btn_insert_Click);
            // 
            // btn_Update
            // 
            this.btn_Update.Location = new System.Drawing.Point(31, 172);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(144, 43);
            this.btn_Update.TabIndex = 4;
            this.btn_Update.Text = "Uuenda";
            this.btn_Update.UseVisualStyleBackColor = true;
            // 
            // btn_Delete
            // 
            this.btn_Delete.Location = new System.Drawing.Point(31, 221);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(144, 43);
            this.btn_Delete.TabIndex = 5;
            this.btn_Delete.Text = "Kustuda";
            this.btn_Delete.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.toodeNimetusDataGridViewTextBoxColumn,
            this.kogusDataGridViewTextBoxColumn,
            this.hindDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.toodetableBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(197, 26);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(444, 238);
            this.dataGridView1.TabIndex = 6;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // toodedDataSet
            // 
            this.toodedDataSet.DataSetName = "ToodedDataSet";
            this.toodedDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // toodetableBindingSource
            // 
            this.toodetableBindingSource.DataMember = "Toodetable";
            this.toodetableBindingSource.DataSource = this.toodedDataSet;
            // 
            // toodetableTableAdapter
            // 
            this.toodetableTableAdapter.ClearBeforeFill = true;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // toodeNimetusDataGridViewTextBoxColumn
            // 
            this.toodeNimetusDataGridViewTextBoxColumn.DataPropertyName = "ToodeNimetus";
            this.toodeNimetusDataGridViewTextBoxColumn.HeaderText = "ToodeNimetus";
            this.toodeNimetusDataGridViewTextBoxColumn.Name = "toodeNimetusDataGridViewTextBoxColumn";
            // 
            // kogusDataGridViewTextBoxColumn
            // 
            this.kogusDataGridViewTextBoxColumn.DataPropertyName = "Kogus";
            this.kogusDataGridViewTextBoxColumn.HeaderText = "Kogus";
            this.kogusDataGridViewTextBoxColumn.Name = "kogusDataGridViewTextBoxColumn";
            // 
            // hindDataGridViewTextBoxColumn
            // 
            this.hindDataGridViewTextBoxColumn.DataPropertyName = "Hind";
            this.hindDataGridViewTextBoxColumn.HeaderText = "Hind";
            this.hindDataGridViewTextBoxColumn.Name = "hindDataGridViewTextBoxColumn";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.btn_Update);
            this.Controls.Add(this.btn_insert);
            this.Controls.Add(this.Hindtxt);
            this.Controls.Add(this.Kogustxt);
            this.Controls.Add(this.Toodetxt);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.toodedDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.toodetableBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Toodetxt;
        private System.Windows.Forms.TextBox Kogustxt;
        private System.Windows.Forms.TextBox Hindtxt;
        private System.Windows.Forms.Button btn_insert;
        private System.Windows.Forms.Button btn_Update;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.DataGridView dataGridView1;
        private ToodedDataSet toodedDataSet;
        private System.Windows.Forms.BindingSource toodetableBindingSource;
        private ToodedDataSetTableAdapters.ToodetableTableAdapter toodetableTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn toodeNimetusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kogusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hindDataGridViewTextBoxColumn;
    }
}

