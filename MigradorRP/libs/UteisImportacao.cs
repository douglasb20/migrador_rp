using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MigradorRP.libs
{
    public static class UteisImportacao
    {
        public static List<Dictionary<string, string>> PreparaProdutos(DataRowCollection produtos)
        {
            List<Dictionary<string, string>> produtosFormatado = new List<Dictionary<string, string>>();

            Dictionary<string, string> campos= new Dictionary<string, string>()
            {
                {"id_prod"  , "mat_001"},
                {"id_emp"   , "emp_001"},
                {"desc_pro" , "mat_003"},
                {"codbar"   , "mat_004"},
                {"refer"    , "cod_ref"},
                {"unidade"  , "uni_001"},
                {"mtp_001"  , "mtp_001"},
                {"mat_009"  , "mat_009"},
                {"status"   , "sit_001"},
                {"custo"    , "mat_012"},
                {"venda"    , "mat_008"},
                {"margem"   , "mat_018"},
                {"categ"    , "cat_001"},
                {"subcat"   , "sub_001"},
                {"setor"    , "id_setor"},
                {"origem"   , "orm_codigo"},
                {"csosn"    , "cso_codigo"},
                {"cfop"     , "cfop_consumidor"},
                {"icsm"     , "icms"},
                {"cst"      , "cst_consumidor"},
                {"pis"      , "pis_codigo_saida"},
                {"cofins"   , "cof_codigo_saida"},
                {"cest"     , "cest"},
                {"ncm"      , "ncm"}
            };

            MateriaisPGDAO materiais = new MateriaisPGDAO();


            int i = 1;
            foreach(DataRow row in produtos)
            {
                string subCat   = "";
                string codigo   = (i + 1).ToString();
                string desc     = Funcoes.TiraAcento(row["prodes"].ToString().Trim());

                string codean   =  ConfigReader.GetConfigValue("Produtos", "prod_remover_zeros_esquerda") == "true" 
                    ? row["codigo"].ToString().Trim().TrimStart('0') 
                    : row["codigo"].ToString().Trim();

                string refer    = ConfigReader.GetConfigValue("Produtos", "prod_remover_zeros_esquerda") == "true" 
                    ? row["referencia"].ToString().Trim().TrimStart('0') 
                    : row["referencia"].ToString().Trim();

                int unidade     = materiais.undRet(row["unidade"].ToString().Trim());
                string custo    = (row["compra"].ToString().Trim().Replace(",", "."));
                string venda    = (row["venda"].ToString().Trim().Replace(",", "."));

                string margem = ConfigReader.GetConfigValue("Produtos", "calcular_margem") == "true" ?
                    (((Convert.ToDouble(venda.Replace(".", ",")) / Convert.ToDouble(custo.Replace(".", ","))) - 1) * 100).ToString().Replace(",", ".")
                    : row["margem"].ToString().Replace(",", ".");

                double estProd = 0;
                int categ = row["categoria"].ToString().Trim() == "" ? materiais.catRet("Padrao") : materiais.catRet(row["categoria"].ToString().Trim());
                int csosn = row["csosn"].ToString().Trim() == "" ? 102 : Convert.ToInt32(row["csosn"].ToString());

                string cfop = ConfigReader.GetConfigValue("Produtos", "ajusta_cfop_csosn") == "true" ?
                    (csosn == 102 ? "5102" : "5405") :
                    row["cfop"].ToString();

                int cst     = Convert.ToInt32(row["cst"].ToString().Trim());
                int pis     = csosn == 102 ? 99 : 04;
                int cofins  = csosn == 102 ? 99 : 04;
                string cest = row["cest"].ToString().Trim();
                string ncm  = row["ncm"].ToString().Trim();


                produtosFormatado.Add(new Dictionary<string, string>()
                {
                    { campos["id_prod"].ToString(), codigo },
                    { campos["id_emp"].ToString(), "1" },
                    { campos["id_prod"].ToString(), row["codigo"].ToString() },
                    { campos["id_prod"].ToString(), row["codigo"].ToString() },
                });

                i++;
            }


            return produtosFormatado;
        }
    }
}
