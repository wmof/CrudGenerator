using System;
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
            if (Tables.Where(x=>x.Nome == textBoxTableName.Text).Any())
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
            if (""== labelTable.Text)
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
            Conn bd = new Conn(new ConnUser { Database = "u376420042_lybe", Uid = "u376420042_user", Server = "sql50.main-hosting.eu", Pwd = "8o|pD#g8" });
            Tables = bd.selectTable();
            string folder = ChooseFolder() + "\\";
            foreach (var tabela in Tables)
            {
                StreamWriter ObFile;
                ObFile = File.CreateText(folder + tabela.Nome + ".php");
                ObFile.WriteLine(service.gerarOb(tabela.metaDados, tabela.Nome));
                ObFile.Close();
                StreamWriter CrudFile;
                CrudFile = File.CreateText(folder +"Crud_" + tabela.Nome + ".php");
                CrudFile.WriteLine(service.gerarcrud(tabela.metaDados, tabela.Nome));
                CrudFile.Close();
                StreamWriter ControllerFile;
                ControllerFile = File.CreateText(folder + "Controller_" + tabela.Nome + ".php");
                ControllerFile.WriteLine(service.gerarController(tabela.metaDados, tabela.Nome));
                ControllerFile.Close();
                StreamWriter DaoFile;
                DaoFile = File.CreateText(folder + "BD"+ tabela.Nome + ".php");
                DaoFile.WriteLine(service.gerarDao(tabela.metaDados, tabela.Nome));
                DaoFile.Close();
            }            
        }
    }
}
