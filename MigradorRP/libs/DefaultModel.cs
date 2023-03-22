using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MigradorRP.libs
{
    internal class DefaultModel
    {
        private NpgsqlConnection con;

        public DefaultModel() { 
            Connect();
        }

        private void Connect()
        {
            try
            {
                string dbBase = ConfigReader.sistema == "LeCheff" ? "RP" : "SOFTMOBILE";
                string host = ConfigReader.GetConfigValue("host");
                string dbuser = ConfigReader.GetConfigValue("dbuser");
                string porta = ConfigReader.GetConfigValue("port");
                string password = ConfigReader.GetConfigValue("password");

                con = new NpgsqlConnection("Server=" + host + ";Port=" + porta + ";User Id=" + dbuser + ";Password=" + password + ";Database=" + dbBase + ";");
                con.Open();

            }catch(NpgsqlException e)
            {
                throw e;
            }catch(Exception e)
            {
                throw e;
            }
        }

        private void executeNonQuery(string query)
        {
            try
            {
                NpgsqlCommand cmd = new NpgsqlCommand(query, con);

                cmd.ExecuteNonQuery();

            }
            catch (NpgsqlException e)
            {
                throw e;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public DataRowCollection getAll(string tabela, string where = "") {
            try
            {
                string query = string.Format("SELECT * FROM {0} ", tabela);
                if (!string.IsNullOrEmpty(where))
                {
                    
                    query = string.Concat(query, string.Format(" WHERE {0}", where));
                }
                DataTable result = executeQuery(query);
                DataRowCollection dados = result.Rows;
                return dados;
            }
            catch (NpgsqlException e)
            {
                throw e;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public Dictionary<string, string> prepareParams(Dictionary<string, dynamic> parametros)
        {
            Dictionary<string, string> newParams = new Dictionary<string, string>();

            foreach(KeyValuePair<string, dynamic> el in parametros){
                if(el.Value == null)
                {
                    newParams.Add(el.Key, "null");
                    continue;
                }
                newParams.Add(el.Key, "'" + el.Value.ToString(CultureInfo.InvariantCulture) + "'");
            }

            return newParams;
        }

        public string prepareInsertMultiplo(List<Dictionary<string, dynamic>> parametros, string tabela)
        {
            try
            {
                List<Dictionary<string, string>> dados = new List<Dictionary<string, string>>();
                foreach(Dictionary<string, dynamic> el in parametros)
                {
                    dados.Add(prepareParams(el)); 
                }
                string[] campos = dados[0].Keys.ToArray();
                string[] valores = { };

                foreach (Dictionary<string, string> item_insert in dados)
                {
                    
                        Array.Resize(ref valores, valores.Length + 1);
                        valores[valores.Length - 1] = "(" + string.Join(",", item_insert.Values) + ")";
                    
                }

                string query = "INSERT INTO " + tabela;
                query += " (" + string.Join(",", campos) + ")" + " VALUES " + string.Join(",", valores);

                return query;

            }catch(Exception e)
            {
                throw e;
            }
        }


        private DataTable executeQuery(string query)
        {
            try
            {
                NpgsqlCommand cmd = new NpgsqlCommand(query, con);

                NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                return dt;

            }
            catch (NpgsqlException e)
            {
                throw e;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public void closeConnection()
        {
            con.Close();
        }

    }
}
