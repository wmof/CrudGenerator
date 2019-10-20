namespace CrudGenerator
{
    partial class SelectLanguage
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.listViewTable = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listViewColuns = new System.Windows.Forms.ListView();
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.textBoxTableName = new System.Windows.Forms.TextBox();
            this.textBoxCollunName = new System.Windows.Forms.TextBox();
            this.comboBoxTipo = new System.Windows.Forms.ComboBox();
            this.btAddTable = new System.Windows.Forms.Button();
            this.btAddCollunn = new System.Windows.Forms.Button();
            this.btFinish = new System.Windows.Forms.Button();
            this.labelTable = new System.Windows.Forms.Label();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(12, 332);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(121, 97);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // listViewTable
            // 
            this.listViewTable.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.listViewTable.FullRowSelect = true;
            this.listViewTable.GridLines = true;
            this.listViewTable.HideSelection = false;
            this.listViewTable.Location = new System.Drawing.Point(12, 67);
            this.listViewTable.Name = "listViewTable";
            this.listViewTable.Size = new System.Drawing.Size(103, 182);
            this.listViewTable.TabIndex = 1;
            this.listViewTable.UseCompatibleStateImageBehavior = false;
            this.listViewTable.View = System.Windows.Forms.View.Details;
            this.listViewTable.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listViewTable_MouseClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Nome";
            this.columnHeader1.Width = 95;
            // 
            // listViewColuns
            // 
            this.listViewColuns.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader2,
            this.columnHeader3});
            this.listViewColuns.FullRowSelect = true;
            this.listViewColuns.GridLines = true;
            this.listViewColuns.HideSelection = false;
            this.listViewColuns.Location = new System.Drawing.Point(121, 67);
            this.listViewColuns.Name = "listViewColuns";
            this.listViewColuns.Size = new System.Drawing.Size(251, 182);
            this.listViewColuns.TabIndex = 2;
            this.listViewColuns.UseCompatibleStateImageBehavior = false;
            this.listViewColuns.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Nome";
            this.columnHeader2.Width = 147;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Tipo";
            this.columnHeader3.Width = 97;
            // 
            // textBoxTableName
            // 
            this.textBoxTableName.Location = new System.Drawing.Point(12, 41);
            this.textBoxTableName.Name = "textBoxTableName";
            this.textBoxTableName.Size = new System.Drawing.Size(103, 20);
            this.textBoxTableName.TabIndex = 3;
            // 
            // textBoxCollunName
            // 
            this.textBoxCollunName.Location = new System.Drawing.Point(121, 41);
            this.textBoxCollunName.Name = "textBoxCollunName";
            this.textBoxCollunName.Size = new System.Drawing.Size(159, 20);
            this.textBoxCollunName.TabIndex = 4;
            // 
            // comboBoxTipo
            // 
            this.comboBoxTipo.FormattingEnabled = true;
            this.comboBoxTipo.Location = new System.Drawing.Point(286, 40);
            this.comboBoxTipo.Name = "comboBoxTipo";
            this.comboBoxTipo.Size = new System.Drawing.Size(86, 21);
            this.comboBoxTipo.TabIndex = 5;
            // 
            // btAddTable
            // 
            this.btAddTable.Location = new System.Drawing.Point(12, 12);
            this.btAddTable.Name = "btAddTable";
            this.btAddTable.Size = new System.Drawing.Size(103, 23);
            this.btAddTable.TabIndex = 6;
            this.btAddTable.Text = "Adicionar Tabela";
            this.btAddTable.UseVisualStyleBackColor = true;
            this.btAddTable.Click += new System.EventHandler(this.btAddTable_Click);
            // 
            // btAddCollunn
            // 
            this.btAddCollunn.Location = new System.Drawing.Point(121, 12);
            this.btAddCollunn.Name = "btAddCollunn";
            this.btAddCollunn.Size = new System.Drawing.Size(103, 23);
            this.btAddCollunn.TabIndex = 7;
            this.btAddCollunn.Text = "Adicionar Coluna";
            this.btAddCollunn.UseVisualStyleBackColor = true;
            this.btAddCollunn.Click += new System.EventHandler(this.btAddCollunn_Click);
            // 
            // btFinish
            // 
            this.btFinish.Location = new System.Drawing.Point(269, 11);
            this.btFinish.Name = "btFinish";
            this.btFinish.Size = new System.Drawing.Size(103, 23);
            this.btFinish.TabIndex = 8;
            this.btFinish.Text = "Finalizar";
            this.btFinish.UseVisualStyleBackColor = true;
            this.btFinish.Click += new System.EventHandler(this.btFinish_Click);
            // 
            // labelTable
            // 
            this.labelTable.AutoSize = true;
            this.labelTable.Location = new System.Drawing.Point(118, -4);
            this.labelTable.Name = "labelTable";
            this.labelTable.Size = new System.Drawing.Size(0, 13);
            this.labelTable.TabIndex = 9;
            // 
            // SelectLanguage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 261);
            this.Controls.Add(this.labelTable);
            this.Controls.Add(this.btFinish);
            this.Controls.Add(this.btAddCollunn);
            this.Controls.Add(this.btAddTable);
            this.Controls.Add(this.comboBoxTipo);
            this.Controls.Add(this.textBoxCollunName);
            this.Controls.Add(this.textBoxTableName);
            this.Controls.Add(this.listViewColuns);
            this.Controls.Add(this.listViewTable);
            this.Controls.Add(this.listView1);
            this.Name = "SelectLanguage";
            this.Text = "SelectLanguage";
            this.Activated += new System.EventHandler(this.SelectLanguage_Activated);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ListView listViewTable;
        private System.Windows.Forms.ListView listViewColuns;
        private System.Windows.Forms.TextBox textBoxTableName;
        private System.Windows.Forms.TextBox textBoxCollunName;
        private System.Windows.Forms.ComboBox comboBoxTipo;
        private System.Windows.Forms.Button btAddTable;
        private System.Windows.Forms.Button btAddCollunn;
        private System.Windows.Forms.Button btFinish;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Label labelTable;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
    }
}