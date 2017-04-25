using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dp
{
    public partial class EditForm : Form
    {
		public EditForm()
		{
			InitializeComponent();
        }

        private void editRecordToolStripMenuItem_Click(object sender, EventArgs e)
        {
			for (int i = 0; i < Database.Data.Count; i++)
			{
				comboBox1.Items.Add(Database.Data[i].Name);
			}
        }

        private void lblBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void grpInputData_Enter(object sender, EventArgs e)
        {
			

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnUpload_Click(object sender, EventArgs e)
        {

        }
    }
}
