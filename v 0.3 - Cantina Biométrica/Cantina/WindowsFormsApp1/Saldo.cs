﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Saldo : Form
    {
        public Saldo()
        {
            InitializeComponent();
        }

 

        private void btnVolta_Click(object sender, EventArgs e)
        {
            Menu m = new Menu();
            m.Show();

            this.Close();
        }

    }
}
