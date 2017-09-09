﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI.Desktop
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void btnMaterias_Click(object sender, EventArgs e)
        {
            ABMmaterias abmMat = new ABMmaterias();
            abmMat.Show();
        }

        private void btnPersonas_Click(object sender, EventArgs e)
        {
            ABMPersonas abmPer = new ABMPersonas();
            abmPer.Show();
        }
    }
}
