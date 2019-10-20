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
            this.textServidor = new System.Windows.Forms.TextBox();
            this.textBanco = new System.Windows.Forms.TextBox();
            this.textUsuario = new System.Windows.Forms.TextBox();
            this.textSenha = new System.Windows.Forms.TextBox();
            this.btClonar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listViewTable
            // 
            this.listViewTable.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.listViewTable.FullRowSelect = true;
            this.listViewTable.GridLines = true;
            this.listViewTable.HideSelection = false;
            this.listViewTable.Location = new System.Drawing.Point(12, 211);
            this.listViewTable.Name = "listViewTable";
            this.listViewTable.Size = new System.Drawing.Size(323, 309);
            this.listViewTable.TabIndex = 1;
            this.listViewTable.UseCompatibleStateImageBehavior = false;
            this.listViewTable.View = System.Windows.Forms.View.Details;
            this.listViewTable.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listViewTable_MouseClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Nome";
            this.columnHeader1.Width = 318;
            // 
            // listViewColuns
            // 
            this.listViewColuns.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader2,
            this.columnHeader3});
            this.listViewColuns.FullRowSelect = true;
            this.listViewColuns.GridLines = true;
            this.listViewColuns.HideSelection = false;
            this.listViewColuns.Location = new System.Drawing.Point(341, 211);
            this.listViewColuns.Name = "listViewColuns";
            this.listViewColuns.Size = new System.Drawing.Size(431, 309);
            this.listViewColuns.TabIndex = 2;
            this.listViewColuns.UseCompatibleStateImageBehavior = false;
            this.listViewColuns.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Nome";
            this.columnHeader2.Width = 231;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Tipo";
            this.columnHeader3.Width = 194;
            // 
            // textBoxTableName
            // 
            this.textBoxTableName.Location = new System.Drawing.Point(15, 185);
            this.textBoxTableName.Name = "textBoxTableName";
            this.textBoxTableName.Size = new System.Drawing.Size(103, 20);
            this.textBoxTableName.TabIndex = 3;
            // 
            // textBoxCollunName
            // 
            this.textBoxCollunName.Location = new System.Drawing.Point(341, 185);
            this.textBoxCollunName.Name = "textBoxCollunName";
            this.textBoxCollunName.Size = new System.Drawing.Size(159, 20);
            this.textBoxCollunName.TabIndex = 4;
            // 
            // comboBoxTipo
            // 
            this.comboBoxTipo.FormattingEnabled = true;
            this.comboBoxTipo.Location = new System.Drawing.Point(577, 184);
            this.comboBoxTipo.Name = "comboBoxTipo";
            this.comboBoxTipo.Size = new System.Drawing.Size(86, 21);
            this.comboBoxTipo.TabIndex = 5;
            // 
            // btAddTable
            // 
            this.btAddTable.Location = new System.Drawing.Point(232, 182);
            this.btAddTable.Name = "btAddTable";
            this.btAddTable.Size = new System.Drawing.Size(103, 23);
            this.btAddTable.TabIndex = 6;
            this.btAddTable.Text = "Adicionar Tabela";
            this.btAddTable.UseVisualStyleBackColor = true;
            this.btAddTable.Click += new System.EventHandler(this.btAddTable_Click);
            // 
            // btAddCollunn
            // 
            this.btAddCollunn.Location = new System.Drawing.Point(669, 182);
            this.btAddCollunn.Name = "btAddCollunn";
            this.btAddCollunn.Size = new System.Drawing.Size(103, 23);
            this.btAddCollunn.TabIndex = 7;
            this.btAddCollunn.Text = "Adicionar Coluna";
            this.btAddCollunn.UseVisualStyleBackColor = true;
            this.btAddCollunn.Click += new System.EventHandler(this.btAddCollunn_Click);
            // 
            // btFinish
            // 
            this.btFinish.Location = new System.Drawing.Point(669, 526);
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
            this.labelTable.Location = new System.Drawing.Point(338, 157);
            this.labelTable.Name = "labelTable";
            this.labelTable.Size = new System.Drawing.Size(40, 13);
            this.labelTable.TabIndex = 9;
            this.labelTable.Text = "Tabela";
            // 
            // textServidor
            // 
            this.textServidor.Location = new System.Drawing.Point(58, 13);
            this.textServidor.Name = "textServidor";
            this.textServidor.Size = new System.Drawing.Size(83, 20);
            this.textServidor.TabIndex = 10;
            // 
            // textBanco
            // 
            this.textBanco.Location = new System.Drawing.Point(58, 39);
            this.textBanco.Name = "textBanco";
            this.textBanco.Size = new System.Drawing.Size(83, 20);
            this.textBanco.TabIndex = 11;
            // 
            // textUsuario
            // 
            this.textUsuario.Location = new System.Drawing.Point(58, 65);
            this.textUsuario.Name = "textUsuario";
            this.textUsuario.Size = new System.Drawing.Size(83, 20);
            this.textUsuario.TabIndex = 12;
            // 
            // textSenha
            // 
            this.textSenha.Location = new System.Drawing.Point(58, 91);
            this.textSenha.Name = "textSenha";
            this.textSenha.Size = new System.Drawing.Size(83, 20);
            this.textSenha.TabIndex = 13;
            // 
            // btClonar
            // 
            this.btClonar.Location = new System.Drawing.Point(6, 114);
            this.btClonar.Name = "btClonar";
            this.btClonar.Size = new System.Drawing.Size(135, 23);
            this.btClonar.TabIndex = 15;
            this.btClonar.Text = "Clonar";
            this.btClonar.UseVisualStyleBackColor = true;
            this.btClonar.Click += new System.EventHandler(this.BtClonar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Servidor";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Banco";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "Usuario";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 94);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "Senha";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.textServidor);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.textBanco);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textUsuario);
            this.groupBox1.Controls.Add(this.textSenha);
            this.groupBox1.Controls.Add(this.btClonar);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(161, 142);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Clonar do Servidor";
            // 
            // SelectLanguage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.labelTable);
            this.Controls.Add(this.btFinish);
            this.Controls.Add(this.btAddCollunn);
            this.Controls.Add(this.btAddTable);
            this.Controls.Add(this.comboBoxTipo);
            this.Controls.Add(this.textBoxCollunName);
            this.Controls.Add(this.textBoxTableName);
            this.Controls.Add(this.listViewColuns);
            this.Controls.Add(this.listViewTable);
            this.Name = "SelectLanguage";
            this.Text = "SelectLanguage";
            this.Activated += new System.EventHandler(this.SelectLanguage_Activated);
            this.Load += new System.EventHandler(this.SelectLanguage_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
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
        private System.Windows.Forms.TextBox textServidor;
        private System.Windows.Forms.TextBox textBanco;
        private System.Windows.Forms.TextBox textUsuario;
        private System.Windows.Forms.TextBox textSenha;
        private System.Windows.Forms.Button btClonar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}