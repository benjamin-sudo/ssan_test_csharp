﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoDP4501
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void btnRegistrar_Click(object sender, EventArgs e){
            frmRegistrar registrar = new frmRegistrar();
            registrar.ShowDialog();
        }

        private void btnVerificar_Click(object sender, EventArgs e){
            fmrVerificar verificar = new fmrVerificar();
            verificar.ShowDialog();
        }
    }
}
