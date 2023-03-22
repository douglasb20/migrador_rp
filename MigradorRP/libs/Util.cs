using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace MigradorRP
{
    static class Util
    {
        private static string titulo = ConfigurationManager.AppSettings["appTitle"];
        public static void ErrorMessage(string text)
        {
            MessageBox.Show(text, titulo, MessageBoxButton.OK, MessageBoxImage.Error);
        }
    }
}
