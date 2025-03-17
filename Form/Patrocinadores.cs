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
    public partial class Patrocinadores: Form
    {
        csConexion conexion;
        public Patrocinadores(string u, string c)
        {
            conexion = new csConexion(u,c);
            InitializeComponent();
        }

        private void Patrocinadores_Load(object sender, EventArgs e)
        {
            Modo_oscuro.AplicarModoOscuro(this, GlobalSettings.ModoOscuro);
        }
    }
}
