﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TorneosFut
{
    public partial class IngresarCorreoRecuperacion: Form
    {
        csDatos csDatos;
        public IngresarCorreoRecuperacion()
        {
            csDatos = new csDatos("u", "c");
            InitializeComponent();
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            if (csDatos.EnviarCorreoRecuperacion("Su contraseña es", txtCorreo.Text))
                this.Close();
        }
    }
}
