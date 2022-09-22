using System;
using System.Windows.Forms;

namespace StorageAndTrade
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new ConfigurationSelectionForm());
        }
    }
}