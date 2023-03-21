using Salaros.Configuration;
using System;
using System.IO;

namespace MigradorRP
{
    public static class ConfigReader
    {
        private static ConfigParser config;

        public static void LoadConfig(string fileName)
        {

            try
            {
                if (!File.Exists(fileName))
                {
                    throw new Exception("Arquivo de config.conf não localizado");
                }

                config = new ConfigParser(fileName);

            }
            catch (Exception error)
            {
                throw error;
            }
        }

        public static void SaveConfig()
        {
            config.Save();
        }

        public static void SetConfigValue(string key, string value)
        {
            config.SetValue("Config", key, value);
        }

        public static string GetConfigValue(string key)
        {
            String value = config.GetValue("Config", key);
            return value;
        }

    }
}
