using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace TrabalhoGrafica2
{
    public partial class DesenhoTransparente : Form
    {
        public DesenhoTransparente()
        {
            InitializeComponent();
        }

        // Objetos de desenho
        Graphics gr;
        Pen canetaAzul = new Pen(Color.Red, 4);
        List<Point> listaPontos = new List<Point>();
        List<int> vetorPontos = new List<int>();
        FormulariaCoordenadas cxDesenho = new FormulariaCoordenadas();

        private enum TipoDesenhoIndiceLista
        {
            Ponto = 0,
            Linha = 1,
            Polilinha = 2,
            Poligono = 3
        }

        private List<TipoDesenhoIndiceLista> listaTipos = new List<TipoDesenhoIndiceLista>();


        //             * Talvez seja mais inteligente usar uma lista de paineis para cada desenho com o fundo transparente 
        public void testespaineu(int x1, int y1, int x2, int y2)
        {
            //                        p1.Width = 400;
            //                        p1.Height = 400;

//            painel.BringToFront();
            Graphics gPn1;
            gPn1 = painel.CreateGraphics();

            gPn1.DrawLine(new Pen(Color.Green, 4), x1, y1, x2, y2);
            /*            gPn1.DrawLine(new Pen(Color.Red, 3), 10, 10, 200, 200);
                        gPn1.DrawLine(new Pen(Color.Green, 4), 200, 300, 200, 400);
                        gPn1.DrawLine(new Pen(Color.Green, 4), 200, 300, 200, 400);
                        gPn1.DrawLine(new Pen(Color.White, 4), 200, 300, 200, 400);*/


            //p1.Parent = pnlDesenho;
            //pnlDesenho.Controls[0].Location = new Point(0, 0);
            //            pnlDesenho.Controls[0].Visible = true;
            //            pnlDesenho.Controls[0].BringToFront();
            //  pnlDesenho.Controls[0]
        }

        private void DesenhoTransparente_Load(object sender, EventArgs e)
        {
            Graphics gPn1;
            gPn1 = painel.CreateGraphics();
            gPn1.DrawLine(new Pen(Color.Green, 4), 10, 10, 150, 200);


            this.painel.BackColor = Color.Wheat;
            this.TransparencyKey = Color.Wheat;

/*            int initialStyle = GetWindowLong(this.Handle, -20);
            SetWindowLong(this.Handle, -20, initialStyle | 0x80000 | 0x20);*/
        }

        private void DesenhoTransparente_Paint(object sender, PaintEventArgs e)
        {        }

        private void painel_Paint(object sender, PaintEventArgs e)
        {
            Graphics gPn1;
            gPn1 = painel.CreateGraphics();
            gPn1.DrawLine(new Pen(Color.Green, 4), 100, 10, 220, 200);
        }
    }

}
