﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cotizaciones
{
    public partial class frmPantallaPrincipal : Form
    {
        public frmPantallaPrincipal()
        {
            InitializeComponent();
        }

        private void chaGrafica_Click(object sender, EventArgs e)
        {

        }

        private void crearSoicitudToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSolicitudes solicitud = new frmSolicitudes();
            solicitud.Visible = true;
            this.Close();
        }
    }
}
