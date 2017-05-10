﻿using System;
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
    public partial class fm_Database : Form
    {
        public fm_Database()
        {
            InitializeComponent();
        }

        private void pbShitImage_Click(object sender, EventArgs e)
        {
            // do nothing...
        }

        private void lblTitle_Click(object sender, EventArgs e)
        {
            // do nothing...
        }

        private void lbProduct_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (Item product in Database.Data)
            {
                lblProduct.Text = product.Name;
            }
        }

        private void addRecordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddForm addForm = new AddForm();
            addForm.Show();
        }

        private void lblExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void editRecordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditForm editForm = new EditForm();
            editForm.Show();
        }

        private void fm_Database_Load(object sender, EventArgs e)
        {
            // do nothing...
        }

        private void lblProducts_Click(object sender, EventArgs e)
        {
            // do nothing...
        }
    }
}
