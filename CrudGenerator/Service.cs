using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrudGenerator
{
    class Service
    {
        List<Meta> arrayMetaGlobal = new List<Meta>();

        string aux = "";

        public string gerarOb(List<Meta> arraym, string tabelaNome)
        {

            string obj = "";
            obj = "<?php \nclass " + nomeProprio(tabelaNome) + "{\n";
            for (int i = 0; i < arraym.Count(); i++)
            {
                obj = obj + "\tprivate $" + arraym.ElementAt(i).Nome + ";\n";
                aux = nomeProprio(arraym.ElementAt(i).Nome);
                obj = obj + "\tpublic function set" + aux + "($new" + aux + "){\n"
                        + "\t\t$this->" + arraym.ElementAt(i).Nome + " = $new" + aux + ";\n\t}\n"
                        + "\tpublic function get" + aux + "(){\n"
                        + "\t\treturn $this->" + arraym.ElementAt(i).Nome + ";\n\t}\n\n";
                aux = "";
            }
            obj = obj + "\n}\n?>";
            return obj;
        }

        public string nomeProprio(string str)
        {

            str = str.Substring(0, 1).ToUpper() + str.Substring(1, str.Length-1);

            return str;
        }

        public string gerarDao(List<Meta> arrayMeta, string tabelaNome)
        {

            string sql = "";

            sql = "<?php\n"
                    + "require_once(\"Banco.php\");\n"
                    + "require_once(\"" + nomeProprio(tabelaNome) + ".php\");\n\n"
                    + "class BD" + nomeProprio(tabelaNome) + "{\n"
                    //
                    //
                    //Adicionar
                    //
                    //
                    + "\tpublic function insert($" + nomeProprio(tabelaNome) + "){\n "
                    + "\t\t$banco = new BDConexao();\n"
                    + "\t\t$conn = $banco->getConexao();\n";
            for (int i = 0; i < arrayMeta.Count(); i++)
            {
                aux = nomeProprio(arrayMeta.ElementAt(i).Nome);
                sql = sql + "\t\t$" + arrayMeta.ElementAt(i).Nome + " = ($" + nomeProprio(tabelaNome) + "->get" + aux + "());\n";
            }
            sql = sql + "\t\t$sql = \"INSERT INTO " + tabelaNome + " (";
            for (int i = 0; i < arrayMeta.Count(); i++)
            {
                if (i != arrayMeta.Count() - 1)
                {
                    sql = sql + arrayMeta.ElementAt(i).Nome + ", ";
                }
                else
                {
                    sql = sql + arrayMeta.ElementAt(i).Nome + ") VALUES ("; //Quando for o ultimo
                }
            }
            for (int i = 0; i < arrayMeta.Count(); i++)
            {
                if (i != arrayMeta.Count() - 1)
                {
                    sql = sql + "'$" + arrayMeta.ElementAt(i).Nome + "', ";
                }
                else
                {
                    sql = sql + "'$" + arrayMeta.ElementAt(i).Nome + "')\";"
                            + "\n\t\t$conn->query($sql);\n\t}"; //Quando for o ultimo
                }
            }
            //
            //
            //Deletar
            //
            //
            sql = sql + "\n\n\t"
                    + "public function delete($" + nomeProprio(tabelaNome) + "){\n "
                    + "\t\t$banco = new BDConexao();\n"
                    + "\t\t$conn = $banco->getConexao();\n";
            sql = sql + "\t\t$" + arrayMeta.ElementAt(0).Nome + " = $" + nomeProprio(tabelaNome) + "->get" + nomeProprio(arrayMeta.ElementAt(0).Nome) + "();\n";

            sql = sql + "\t\t$sql = \"DELETE FROM  " + tabelaNome + " WHERE " + arrayMeta.ElementAt(0).Nome + " = $" + arrayMeta.ElementAt(0).Nome + "\";"
                    + "\n\t\t$conn->query($sql);\n\t}";
            //
            //
            //Alterar
            //
            //
            sql = sql + "\n\n\t"
                    + "public function update($" + nomeProprio(tabelaNome) + "){\n "
                    + "\t\t$banco = new BDConexao();\n"
                    + "\t\t$conn = $banco->getConexao();\n";
            for (int i = 0; i < arrayMeta.Count(); i++)
            {
                aux = nomeProprio(arrayMeta.ElementAt(i).Nome);
                sql = sql + "\t\t$" + arrayMeta.ElementAt(i).Nome + " = $" + nomeProprio(tabelaNome) + "->get" + aux + "();\n";
            }
            sql = sql + "\t\t$sql = \"UPDATE " + tabelaNome + " SET ";
            for (int i = 1; i < arrayMeta.Count(); i++)
            {
                if (i != arrayMeta.Count() - 1)
                {
                    sql = sql + arrayMeta.ElementAt(i).Nome + " = '$" + arrayMeta.ElementAt(i).Nome + "', ";
                }
                else
                {
                    sql = sql + arrayMeta.ElementAt(i).Nome + " = '$" + arrayMeta.ElementAt(i).Nome + "' WHERE " + arrayMeta.ElementAt(0).Nome + " = '$" + arrayMeta.ElementAt(0).Nome + "'\";"
                            + "\n\t\t$conn->query($sql);\n\t}";
                }

            }
            //
            //
            //Lista
            //
            //
            sql = sql + "\n\n\t" + "public function select() {\n"
                    + "\t\t$banco = new BDConexao();\n"
                    + "\t\t$conn = $banco->getConexao();\n"
                    + "\t\t$sql = \"SELECT * FROM " + tabelaNome + "\";\n"
                    + "\t\t$result = $conn->query($sql);\n"
                    + "\t\t$resposta = array();\n"
                    + "\t\twhile ($linha = mysqli_fetch_array($result)) {"
                    + "\n\t\t\t$" + tabelaNome + " = new " + nomeProprio(tabelaNome) + "();";
            for (int i = 0; i < arrayMeta.Count(); i++)
            {
                sql = sql + "\n\t\t\t$" + tabelaNome + "->set" + nomeProprio(arrayMeta.ElementAt(i).Nome) + "($linha[\"" + arrayMeta.ElementAt(i).Nome + "\"]);";
            }
            sql = sql + "\n\t\t\t$resposta[] = $" + tabelaNome + ";\n"
                    + "\t\t}\n";
            sql = sql + "\t" + "return $resposta;\n";
            sql = sql + "\t}\n}";
            return sql;
        }

        public string gerarController(List<Meta> arrayMeta, string tabelaNome)
        {

            string controller = "";

            controller = "<?php\n"
                    + "require_once(\"BD_" + tabelaNome + ".php\");\n"
                    + "require_once(\"" + tabelaNome + ".php\");\n\n"
                    + "class Controller_" + nomeProprio(tabelaNome) + "{\n";
            //
            //
            //Adicionar
            //
            //
            controller = controller + "\n\tpublic function insert($dados){\n "
                    + "\n\t\t$" + tabelaNome + " = new " + nomeProprio(tabelaNome) + "();\n";
            for (int i = 0; i < arrayMeta.Count(); i++)
            {
                aux = nomeProprio(arrayMeta.ElementAt(i).Nome);
                controller = controller + "\t\t$" + tabelaNome + "->Set" + aux + "($_POST[\'" + arrayMeta.ElementAt(i).Nome + "\']);\n";
            }
            controller = controller + "\t\t$bd = new BD" + nomeProprio(tabelaNome) + "();\n"
                    + "\t\t$bd->insert($" + tabelaNome + ");\n"
                    + "\t\tprint (\"" + nomeProprio(tabelaNome) + " Adicionado\");\n"
                    + "\t}";
            //
            //
            //Deletar
            //
            //
            controller = controller + "\n\n\tpublic function delete($dados){\n "
                    + "\n\t\t$" + tabelaNome + " = new " + nomeProprio(tabelaNome) + "();\n";
            aux = nomeProprio(arrayMeta.ElementAt(0).Nome);
            controller = controller + "\t\t$" + tabelaNome + "->Set" + aux + "($_POST[\'" + arrayMeta.ElementAt(0).Nome + "\']);\n";

            controller = controller + "\t\t$bd = new BD" + nomeProprio(tabelaNome) + "();\n"
                    + "\t\t$bd->delete($" + tabelaNome + ");\n"
                    + "\t\tprint (\"" + nomeProprio(tabelaNome) + " Deletado\");\n"
                    + "\t}";
            //
            //
            //Alterar
            //
            //
            controller = controller + "\n\n\tpublic function update($dados){\n "
                    + "\n\t\t$" + tabelaNome + " = new " + nomeProprio(tabelaNome) + "();\n";
            for (int i = 0; i < arrayMeta.Count(); i++)
            {
                aux = nomeProprio(arrayMeta.ElementAt(i).Nome);
                controller = controller + "\t\t$" + tabelaNome + "->Set" + aux + "($_POST[\'" + arrayMeta.ElementAt(i).Nome + "\']);\n";
            }
            controller = controller + "\t\t$bd = new BD" + nomeProprio(tabelaNome) + "();\n"
                    + "\t\t$bd->update($" + tabelaNome + ");\n"
                    + "\t\tprint (\"" + nomeProprio(tabelaNome) + " Alterado\");\n"
                    + "\t}\n}\n";
            //
            //
            //Method
            //
            //
            controller = controller + "\nif($_SERVER['REQUEST_METHOD'] == 'POST' && isset($_POST['method'])) {\n"
                    + "\t$method = $_POST['method'];\n"
                    + "\tif(method_exists('Controller_" + nomeProprio(tabelaNome) + "', $method)) {\n"
                    + "\t\t$controller = new Controller_" + nomeProprio(tabelaNome) + ";\n"
                    + "\t\t$controller->$method($_POST);\n"
                    + "\t}\n"
                    + "\telse {\n"
                    + "\t\techo 'Metodo incorreto';\n"
                    + "\t}\n"
                    + "}";
            return controller;
        }

        public string gerarcrud(List<Meta> arrayMeta, string tabelaNome)
        {
            string crud = "";
            crud = crud + "<h1>Lista de " + nomeProprio(tabelaNome) + "s</h1>\n"
                    + "<table border=\"1\" align=\"center\">\n"
                    + "\t<tr>\n\t\t";
            for (int i = 0; i < arrayMeta.Count(); i++)
            {
                crud = crud + "<td><strong>" + arrayMeta.ElementAt(i).Nome.ToUpper() + "</strong></td>";
            }
            crud = crud + "\n\t</tr>\n"
                    + "<?php\n"
                    + "require_once (\"BD_" + nomeProprio(tabelaNome) + ".php\");\n"
                    + "require_once (\"" + nomeProprio(tabelaNome) + ".php\");\n"
                    + "$bd = new BD" + nomeProprio(tabelaNome) + "();\n"
                    + "$array" + nomeProprio(tabelaNome) + " = $bd->select();\n"
                    + "foreach ($array" + nomeProprio(tabelaNome) + " as $key => $value) {\n"
                    + "\ttry {\n";

            for (int i = 0; i < arrayMeta.Count(); i++)
            {
                crud = crud + "\t\t$" + arrayMeta.ElementAt(i).Nome + " = $array" + nomeProprio(tabelaNome) + "[$key]->get" + nomeProprio(arrayMeta.ElementAt(i).Nome) + "();\n";
            }

            crud = crud + "\t\techo \"<tr>";
            for (int i = 0; i < arrayMeta.Count(); i++)
            {
                crud = crud + "<td><i>$" + arrayMeta.ElementAt(i).Nome + "</i></td>";
            }
            crud = crud + "\";\n\t}\n"
                    + "\tcatch (Exception $e) {\n"
                    + "\t\techo \"ERRO!!\";\n"
                    + "\t\tbreak;\n"
                    + "\t}\n"
                    + "}\n"
                    + "?>\n"
                    + "</table>\n";
            //Agora Form
            crud = crud + "<h2>Formulário de cadastro de Afiliado</h2>\n"
                    + "<form method=\"post\" action=\"Controller_" + nomeProprio(tabelaNome) + ".php\" class=\"form\">\n";

            for (int i = 0; i < arrayMeta.Count(); i++)
            {
                crud = crud + "\t<p class=\"\">\n"
                        + "\t\t<label for=\"" + arrayMeta.ElementAt(i).Nome + "\">" + nomeProprio(arrayMeta.ElementAt(i).Nome) + ": </label>\n"
                        + "\t\t<input type=\"text\" name=\"" + arrayMeta.ElementAt(i).Nome + "\"/>\n"
                        + "\t</p>\n";
            }

            crud = crud + "\n\t<p class=\"submit\">\n"
                    + "\t\t<input type=\"submit\" name=\"method\" value=\"insert\" />\n"
                    + "\t</p>\n"
                    + "\n"
                    + "\t<p class=\"submit\">\n"
                    + "\t\t<input type=\"submit\" name=\"method\" value=\"delete\" />\n"
                    + "\t</p>\n"
                    + "\n"
                    + "\t<p class=\"submit\">\n"
                    + "\t\t<input type=\"submit\" name=\"method\" value=\"update\" />\n"
                    + "\t</p>\n"
                    + "</form>";
            return crud;
        }
    }
}
