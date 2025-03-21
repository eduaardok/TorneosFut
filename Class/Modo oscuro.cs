using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TorneosFut
{
    public static class Modo_oscuro
    {
        public static void AplicarModoOscuro(Control formulario, bool activarModoOscuro)
        {
            if (activarModoOscuro)
            {
                AplicarTemaOscuro(formulario);
            }
            else
            {
                AplicarTemaClaro(formulario);
            }
        }

        private static void AplicarTemaOscuro(Control formulario)
        {
            // Aplicar el fondo del formulario y paneles solo si no son botones específicos
            if (formulario is Form)
            {
                if (formulario.Tag != "NoCambiar")
                {

                    formulario.BackColor = Color.FromArgb(18, 18, 18);  // Fondo del formulario en modo oscuro
                }
            }
            foreach (Control control in formulario.Controls)
            {
                // Excluir los botones específicos que no deben cambiar
                if (control is Button && control.Name != "btnModoOscuro")  // No cambia el botón "ModoOscuro"
                {
                    continue; // No cambiar este botón
                }

                // Cambiar el color de los labels
                if (control is Label)
                {
                    control.ForeColor = Color.White;  // Texto blanco
                }

                // Cambiar el estilo de los DataGridViews
                if (control is DataGridView )
                {
                    DataGridView dgv = (DataGridView)control;
                    dgv.BackgroundColor = Color.FromArgb(18, 18, 18);  // Fondo oscuro
                    dgv.ForeColor = Color.White;  // Texto blanco
                    dgv.DefaultCellStyle.BackColor = Color.FromArgb(30, 35, 40);
                    dgv.DefaultCellStyle.ForeColor = Color.White;
                    dgv.DefaultCellStyle.SelectionBackColor = Color.FromArgb(50, 55, 60);
                    dgv.DefaultCellStyle.SelectionForeColor = Color.White;

                }
                if(control is Panel)
                {
                    Panel panel = (Panel)control;
                    if (panel.Tag!= "NoCambiar")
                    {
                        panel.BackColor = Color.FromArgb(40, 45, 50);
                    }
                }
                // Llamamos recursivamente a los controles hijos
                AplicarTemaOscuro(control);
            }
        }

        private static void AplicarTemaClaro(Control formulario)
        {
            // Aplicar el fondo del formulario y paneles en modo claro
            if (formulario is Form)
            {
                if (formulario.Tag != "NoCambiar")
                {


                    formulario.BackColor = Color.White;  // Fondo del formulario en modo claro
                }
            }

            // Recorrer los controles del formulario
            foreach (Control control in formulario.Controls)
            {
                // Excluir los botones específicos que no deben cambiar
                if (control is Button && control.Name != "btnModoOscuro")  // No cambia el botón "ModoOscuro"
                {
                    continue; // No cambiar este botón
                }

                // Cambiar el color de los labels
                if (control is Label)
                {
                    control.ForeColor = Color.Black;  // Texto negro
                }

                // Cambiar el estilo de los DataGridViews
                if (control is DataGridView)
                {
                    DataGridView dgv = (DataGridView)control;

                    dgv.BackgroundColor = Color.White; 
                    dgv.ForeColor = Color.Black; 
                    dgv.DefaultCellStyle.BackColor = Color.White;
                    dgv.DefaultCellStyle.ForeColor = Color.Black;
                    dgv.DefaultCellStyle.SelectionBackColor = Color.LightGray;
                    dgv.DefaultCellStyle.SelectionForeColor = Color.Black;
                }
                if(control is Panel)
                {
                    Panel panel = (Panel)control;
                    if (panel.Tag != "NoCambiar")
                    {
                        panel.BackColor = Color.FromArgb(217, 200, 209);
                    }
                }
                // Llamamos recursivamente a los controles hijos
                AplicarTemaClaro(control);
            }
        }
    }
    }
