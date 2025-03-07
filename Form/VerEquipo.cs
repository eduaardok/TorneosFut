using System;
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
    public partial class VerEquipo: Form
    {
        int x;
        public VerEquipo(int equipo)
        {
            x = equipo;
            InitializeComponent();
        }
        private void lblBorde1_Paint(object sender, PaintEventArgs e)
        {
            lblBorde1.BackColor = Color.Transparent;
            using (Pen pen = new Pen(ColorTranslator.FromHtml("#FB038C"), 3))
            {
                e.Graphics.DrawRectangle(pen, 0, 0, lblBorde1.Width - 1, lblBorde1.Height - 1);
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            lblBorde1.Paint += lblBorde1_Paint;
        }
        private void lblBorde2_Paint(object sender, PaintEventArgs e)
        {
            lblBorde2.BackColor = Color.Transparent;
            using (Pen pen = new Pen(ColorTranslator.FromHtml("20; 25; 29"), 1))
            {
                e.Graphics.DrawRectangle(pen, 0, 0, lblBorde2.Width - 1, lblBorde2.Height - 1);
            }
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            lblBorde2.Paint += lblBorde1_Paint;
        }
        private void lblBorde3_Paint(object sender, PaintEventArgs e)
        {
            lblBorde3.BackColor = Color.Transparent;
            using (Pen pen = new Pen(ColorTranslator.FromHtml("20; 25; 29"), 1))
            {
                e.Graphics.DrawRectangle(pen, 0, 0, lblBorde3.Width - 1, lblBorde3.Height - 1);
            }
        }
        private void Form3_Load(object sender, EventArgs e)
        {
            lblBorde3.Paint += lblBorde1_Paint;
        }
        private void lblBorde4_Paint(object sender, PaintEventArgs e)
        {
            lblBorde4.BackColor = Color.Transparent;
            using (Pen pen = new Pen(ColorTranslator.FromHtml("20; 25; 29"), 1))
            {
                e.Graphics.DrawRectangle(pen, 0, 0, lblBorde4.Width - 1, lblBorde4.Height - 1);
            }
        }
        private void Form4_Load(object sender, EventArgs e)
        {
            lblBorde4.Paint += lblBorde1_Paint;
        }
        private void lblBorde5_Paint(object sender, PaintEventArgs e)
        {
            lblBorde5.BackColor = Color.Transparent;
            using (Pen pen = new Pen(ColorTranslator.FromHtml("20; 25; 29"), 1))
            {
                e.Graphics.DrawRectangle(pen, 0, 0, lblBorde5.Width - 1, lblBorde5.Height - 1);
            }
        }
        private void Form5_Load(object sender, EventArgs e)
        {
            lblBorde5.Paint += lblBorde1_Paint;
        }
        private void lblBorde6_Paint(object sender, PaintEventArgs e)
        {
            lblBorde6.BackColor = Color.Transparent;
            using (Pen pen = new Pen(ColorTranslator.FromHtml("#FB038C"), 3))
            {
                e.Graphics.DrawRectangle(pen, 0, 0, lblBorde6.Width - 1, lblBorde6.Height - 1);
            }
        }
        private void Form6_Load(object sender, EventArgs e)
        {
            lblBorde6.Paint += lblBorde1_Paint;
        }
        private void lblBorde7_Paint(object sender, PaintEventArgs e)
        {
            lblBorde7.BackColor = Color.Transparent;
            using (Pen pen = new Pen(ColorTranslator.FromHtml("#FB038C"), 3))
            {
                e.Graphics.DrawRectangle(pen, 0, 0, lblBorde7.Width - 1, lblBorde7.Height - 1);
            }
        }
        private void Form7_Load(object sender, EventArgs e)
        {
            lblBorde7.Paint += lblBorde1_Paint;
        }
        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
