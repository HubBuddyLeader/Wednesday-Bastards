using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dp
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            List<Item> items = new List<Item>();
            addForm addItem = new addForm();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //show me the magic
            Application.Run(new fm_Database());
            Application.Run(new fm_Database());
            //magic showed


        }
    }
}
