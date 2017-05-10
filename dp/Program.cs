using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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
            //TEST DATA
            Database.Data.Add(new dp.Item("JUST", 100, 5, 0));
            Database.Data.Add(new dp.Item("FUCKING", 0, 7, 1));
            Database.Data.Add(new dp.Item("WORK", 5, 18, 2));

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //show me the magic
            Application.Run(new fm_Database());
            Application.Run(new fm_Database());
            //magic showed
        

        }
    }
}
