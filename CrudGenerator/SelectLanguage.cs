﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CrudGenerator
{
    public partial class SelectLanguage : Form
    {
        public SelectLanguage()
        {
            InitializeComponent();
        }

        private List<Table> tables = new List<Table>();
        internal List<Table> Tables { get => tables; set => tables = value; }
        internal int SelectedTableId = -1;
        public void carregarListViewTabela()
        {
            if (Tables != null)
            {
                listViewTable.Items.Clear();
                for (int i = 0; i < Tables.Count; i++)
                {
                    ListViewItem item = listViewTable.Items.Add(Convert.ToString(Tables.ElementAt(i).Nome));
                }
            }
        }

        public void carregarListViewColunas()
        {
            listViewColuns.Items.Clear();
            if (SelectedTableId != -1)
            {
                for (int i = 0; i < Tables.ElementAt(SelectedTableId).metaDados.Count; i++)
                {
                    ListViewItem item = listViewColuns.Items.Add(Tables.ElementAt(SelectedTableId).metaDados.ElementAt(i).Nome);
                    item.SubItems.Add(Tables.ElementAt(SelectedTableId).metaDados.ElementAt(i).Tipo);

                }
            }
        }

        private void btAddTable_Click(object sender, EventArgs e)
        {
            if ("" == textBoxTableName.Text)
            {
                MessageBox.Show("Valor invalido!");
                return;
            }
            if (Tables.Where(x => x.Nome == textBoxTableName.Text).Any())
            {
                MessageBox.Show("Tabela ja existente!");
                return;
            }
            Table table = new Table();
            table.Nome = textBoxTableName.Text;
            Tables.Add(table);
            carregarListViewTabela();
            carregarListViewColunas();
        }

        private void btAddCollunn_Click(object sender, EventArgs e)
        {
            if ("" == labelTable.Text)
            {
                MessageBox.Show("Tabela não selecioada!");
                return;
            }
            if ("" == textBoxCollunName.Text)
            {
                MessageBox.Show("Valor invalido!");
                return;
            }
            if (Tables.ElementAt(SelectedTableId).metaDados != null && Tables.ElementAt(SelectedTableId).metaDados.Where(x => x.Nome == textBoxCollunName.Text).Any())
            {
                MessageBox.Show("Coluna ja existente!");
                return;
            }
            Meta meta = new Meta();
            meta.Nome = textBoxCollunName.Text;
            meta.Tipo = comboBoxTipo.Text;
            List<Meta> metas = Tables.ElementAt(SelectedTableId).metaDados;
            if (metas == null)
            {
                metas = new List<Meta>();
            }
            metas.Add(meta);
            tables.ElementAt(SelectedTableId).metaDados = metas;
        }

        private void SelectLanguage_Activated(object sender, EventArgs e)
        {
            carregarListViewTabela();
            carregarListViewColunas();
        }

        private void listViewTable_MouseClick(object sender, MouseEventArgs e)
        {
            SelectedTableId = listViewTable.FocusedItem.Index;
            labelTable.Text = "Tabela: " + listViewTable.FocusedItem.Text;
        }
        public string ChooseFolder()
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                return folderBrowserDialog1.SelectedPath;
            }
            else
            {
                return null;
            }
        }

        private void btFinish_Click(object sender, EventArgs e)
        {
            Service service = new Service();
            string folder = ChooseFolder() + "\\";
            
            DirectoryInfo raiz = new DirectoryInfo(folder);
            raiz.CreateSubdirectory("Model");
            raiz.CreateSubdirectory("Crud");
            raiz.CreateSubdirectory("Controller");
            raiz.CreateSubdirectory("Repository");
            StreamWriter RepositoryConnFile;
            RepositoryConnFile = File.CreateText(folder + "Repository\\Banco.php");
            ConnUser bd = new ConnUser { Database = "u376420042_oficina", Uid = "u376420042_oficina", Server = "sql50.main-hosting.eu", Pwd = "!Q@W3e4r" };
            RepositoryConnFile.WriteLine(service.gerarBanco(bd));
            RepositoryConnFile.Close();
            foreach (var tabela in Tables)
            {
                StreamWriter ModelFile;
                ModelFile = File.CreateText(folder + "Model\\" + service.nomeProprio(tabela.Nome) + ".php");
                ModelFile.WriteLine(service.gerarOb(tabela.metaDados, tabela.Nome));
                ModelFile.Close();
                StreamWriter CrudFile;
                CrudFile = File.CreateText(folder + "Crud\\Crud_" + service.nomeProprio(tabela.Nome) + ".php");
                CrudFile.WriteLine(service.gerarcrud(tabela.metaDados, tabela.Nome));
                CrudFile.Close();
                StreamWriter ControllerFile;
                ControllerFile = File.CreateText(folder + "Controller\\Controller_" + service.nomeProprio(tabela.Nome) + ".php");
                ControllerFile.WriteLine(service.gerarController(tabela.metaDados, tabela.Nome));
                ControllerFile.Close();
                StreamWriter RepositoryFile;
                RepositoryFile = File.CreateText(folder + "Repository\\BD_"+ service.nomeProprio(tabela.Nome) + ".php");
                RepositoryFile.WriteLine(service.gerarRepository(tabela.metaDados, tabela.Nome));
                RepositoryFile.Close();
            }
        }

        private void SelectLanguage_Load(object sender, EventArgs e)
        {

        }

        private void BtClonar_Click(object sender, EventArgs e)
        {
            //Conn bd = new Conn(new ConnUser { Database = "u376420042_lybe", Uid = "u376420042_user", Server = "sql50.main-hosting.eu", Pwd = "8o|pD#g8" });
            Conn bd = new Conn(new ConnUser { Database = "u376420042_oficina", Uid = "u376420042_oficina", Server = "srv794.hstgr.io", Pwd = "Qq!11234" });
            Tables = bd.selectTable(bd);
        }
    }
}
