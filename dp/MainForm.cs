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

        AddForm addForm = new AddForm();
        EditForm editForm = new EditForm();

        public fm_Database()
        {
            InitializeComponent();
        }

        private void pbShitImage_Click(object sender, EventArgs e)
        {

        }

        private void lblTitle_Click(object sender, EventArgs e)
        {

        }

        private void lbProduct_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void addRecordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            addForm.Show();
        }

        private void lblExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void editRecordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            editForm.Show();
        }

        private void fm_Database_Load(object sender, EventArgs e)
        {

        }

        private void lblProducts_Click(object sender, EventArgs e)
        {

        }


    }
}
