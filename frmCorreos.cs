using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;
using System.IO;


namespace TorneosFut
{
    public partial class frmCorreos : Form
    {
        private List<string> archivosAdjuntos = new List<string>();

        private string emailRemitente = $@"fuxpertcompany@gmail.com";
        private string passwordRemitente = "vgqg dftj ixki cfzy";
        private string servidorSmtp = "smtp.gmail.com";
        private int puertoSmtp = 587;
        private bool usarSSL = true;
        public frmCorreos()
        {
            InitializeComponent();
        }

        private void frmCorreos_Load(object sender, EventArgs e)
        {
            Modo_oscuro.AplicarModoOscuro(this, GlobalSettings.ModoOscuro);
            if (!GlobalSettings.ModoOscuro)
            {
                panel1.BackColor = Color.FromArgb(251, 3, 140);
                panel2.BackColor = Color.FromArgb(251, 3, 140);
                panel3.BackColor = Color.FromArgb(251, 3, 140);
                panel4.BackColor = Color.FromArgb(251, 3, 140);
            }
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtPara.Text))
                {
                    MessageBox.Show("Por favor, ingrese una dirección de correo destinatario.",
                                    "Campo requerido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                Cursor.Current = Cursors.WaitCursor;

                using (MailMessage mensaje = new MailMessage())
                {
                    mensaje.From = new MailAddress(emailRemitente);

                    string[] destinatarios = txtPara.Text.Split(new char[] { ',', ';' },
                                            StringSplitOptions.RemoveEmptyEntries);

                    foreach (string destinatario in destinatarios)
                    {
                        mensaje.To.Add(destinatario.Trim());
                    }

                    mensaje.Subject = txtAsunto.Text;
                    mensaje.Body = rtbCuerpo.Text;
                    mensaje.IsBodyHtml = false;

                    foreach (string rutaArchivo in archivosAdjuntos)
                    {
                        if (File.Exists(rutaArchivo))
                        {
                            mensaje.Attachments.Add(new Attachment(rutaArchivo));
                        }
                    }

                    using (SmtpClient cliente = new SmtpClient(servidorSmtp, puertoSmtp))
                    {
                        cliente.EnableSsl = usarSSL;
                        cliente.Credentials = new NetworkCredential(emailRemitente, passwordRemitente);
                        cliente.DeliveryMethod = SmtpDeliveryMethod.Network;

                        cliente.Send(mensaje);
                    }
                }

                Cursor.Current = Cursors.Default;

                MessageBox.Show("Correo enviado correctamente.", "Éxito",
                               MessageBoxButtons.OK, MessageBoxIcon.Information);

                LimpiarFormulario();
            }
            catch (Exception ex)
            {
                Cursor.Current = Cursors.Default;

                MessageBox.Show($"Error al enviar el correo: {ex.Message}",
                               "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ActualizarContadorArchivos()
        {
            lblArchi.Text = $"Se adjuntaron ({archivosAdjuntos.Count}) archivos";
        }

        private void btnArchivo_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "Archivos PDF (*.pdf)|*.pdf",
                Multiselect = true,
                Title = "Seleccionar archivos PDF para adjuntar"
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                foreach (string rutaArchivo in openFileDialog.FileNames)
                {
                    if (!archivosAdjuntos.Contains(rutaArchivo))
                    {
                        archivosAdjuntos.Add(rutaArchivo);
                    }
                }

                ActualizarContadorArchivos();
            }
        }

        private void LimpiarFormulario()
        {
            txtPara.Clear();
            txtAsunto.Clear();
            rtbCuerpo.Clear();
            archivosAdjuntos.Clear();
            ActualizarContadorArchivos();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
