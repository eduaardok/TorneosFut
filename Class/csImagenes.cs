using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TorneosFut.Class
{
    class csImagenes
    {
        string NombreNuevo;
        string extension;
        string rutaDes;
        string destino;
        string rutIMG;

        public string guardarIMG(string rutaOriginal, string nombre)
        {
            try
            {
                destino = Path.Combine(Application.StartupPath, "Imagenes");
                if (!Directory.Exists(destino))
                {
                    Directory.CreateDirectory(destino);
                }

                extension = Path.GetExtension(rutaOriginal);
                NombreNuevo = nombre + extension;
                rutaDes = Path.Combine(destino, NombreNuevo);

                File.Copy(rutaOriginal, rutaDes, true);
                return NombreNuevo;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return "";
            }
        }

        public void CargarImagen(string nomIMG, PictureBox imgBox)
        {
            try
            {
                rutIMG = Path.Combine(Application.StartupPath, "Imagenes",

                if (File.Exists(rutIMG) && !string.IsNullOrEmpty(nomIMG))
                {
                    imgBox.Image = Image.FromFile(rutIMG);
                    imgBox.SizeMode = PictureBoxSizeMode.StretchImage;
                }
                else
                {
                    imgBox.Image = Properties.Resources.ImagenPorDefecto;
                    imgBox.SizeMode = PictureBoxSizeMode.StretchImage;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar la imagen: {ex.Message}");
            }
        }
    }
}