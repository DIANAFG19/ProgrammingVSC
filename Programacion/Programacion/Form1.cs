﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Programacion
{
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
        }

        private void btnSesion1_Click(object sender, EventArgs e)
        {
            Sesion1 sesion = new Sesion1();
            sesion.Show();
            this.Hide();
        }
    }
}