using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrabalhoGrafica2
{
    public partial class frnPrincipal : Form
    {
        // Objetos de senho
        Graphics gr;
        CaixinhaDesenho cxDesenho = new CaixinhaDesenho();
        public frnPrincipal()
        {
            InitializeComponent();            
        }

        private void button1_Click(object sender, EventArgs e)
        {            
            cxDesenho.ShowDialog(this);
            desenharLinha();
        }

        public void desenharLinha()
        {
            // Create pen.
            Pen blackPen = new Pen(Color.Black, 3);

            // Create coordinates of points that define line.
            int x1 = cxDesenho.propX1;
            int y1 = cxDesenho.propY1;
            int x2 = cxDesenho.propX2;
            int y2 = cxDesenho.propY2;

            // Draw line to screen.
            gr = pnlDesenho.CreateGraphics();
            gr.DrawLine(blackPen, x1, y1, x2, y2);
            listaDesenhos.Items.Add("Deseninho");
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            listaDesenhos.Items.RemoveAt(0);
        }
    }
}
