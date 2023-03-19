using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MigradorRP
{
    public static class ConfigReader
    {
        public static string filePath = "";

        public static void SetFilePath(string fileName)
        {
            try
            {
                if (!File.Exists(fileName))
                {
                    throw new Exception("Arquivo de config.conf não localizado");
                }

                filePath = fileName;

            }catch(Exception error)
            {
                throw error;
            }
        }
        public static Dictionary<string, string> config() { 
            try{

                Dictionary<string, string> fileConfig = new Dictionary<string, string>();

                using (StreamReader reader = new StreamReader(filePath))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        try
                        {
                            if (line.StartsWith("#") || line.Trim().Length == 0)
                            {
                                // Ignora comentários e linhas vazias
                                continue;
                            }

                            // Divide a linha em nome e valor usando o caractere '=' como separador
                            string[] parts = line.Split(new char[] { '=' }, 2);
                            if (parts.Length == 2)
                            {
                                // Adiciona a configuração ao dicionário
                                fileConfig[parts[0].Trim()] = parts[1].Trim();
                            }
                        }
                        catch (Exception error)
                        {
                            throw error;
                        }
                    }
                }

                return fileConfig;

            }
            catch(Exception error){
                throw error;
            }
        }
    }
}
