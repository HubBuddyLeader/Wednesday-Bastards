using System;
using System.Windows.Forms;

namespace dp
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        //program redon
        [STAThread]
        static void Main()
        {
            // TEST DATA
            Database.Data.Add(new dp.Item("Panadol", 100, 5, 0));
            Database.Data.Add(new dp.Item("Moda", 0, 7, 1));
            Database.Data.Add(new dp.Item("Pain Killers", 5, 18, 2));

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //show me the magic
            Application.Run(new fm_Database());
            //magic showed
        }
    }
}
