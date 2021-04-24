using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrabalhoGrafica2
{
    public partial class frnPrincipal : Form
    {
        // Objetos de desenho
       Graphics gr;
       List<Point> listaPontos = new List<Point>();        
        CaixinhaDesenho cxDesenho = new CaixinhaDesenho();
        int contLinha,contagemLinhasExibir = 0;
        public frnPrincipal()
        {
            InitializeComponent();            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cxDesenho.propPintar = false;            
            cxDesenho.ShowDialog(this);
            desenharLinha();
        }

        public void desenharLinha()
        {
            if (!cxDesenho.propPintar)
            {
                return;
            }
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

            listaPontos.Add(new Point(x1, y1));
            listaPontos.Add(new Point(x2, y2));

            listaDesenhos.Items.Add("Deseninho "+ contagemLinhasExibir);
            contLinha++;
            contagemLinhasExibir++;
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            // Validações
            if (!(listaDesenhos.SelectedIndex >= 0))
                return;
            // Apagar pintando o mesmo desenho de branco
            // Magia não mexa
            gr.DrawLine(new Pen(Color.White, 3), listaPontos[listaDesenhos.SelectedIndex == 0 ? 0 : (listaDesenhos.SelectedIndex*2)],
                listaPontos[listaDesenhos.SelectedIndex == 0 ? 1 : ((listaDesenhos.SelectedIndex*2)+1)]);
            recalcularIndices(listaDesenhos.SelectedIndex);
            listaDesenhos.Items.RemoveAt(listaDesenhos.SelectedIndex);
        }
/*
 * Talvez seja mais inteligente usar uma lista de paineis para cada desenho com o fundo transparente 
        void testespaineu()
        {
            Panel p1 = new Panel();
//                        p1.Width = 400;
//                        p1.Height = 400;
            p1.Dock = DockStyle.Fill;
            p1.BackColor = Color.GreenYellow;
            
            p1.Visible = true;            
            p1.BringToFront();
            Graphics gPn1;
            gPn1 = p1.CreateGraphics();
            gPn1.DrawLine(new Pen(Color.Green, 4), 200, 300, 200, 400);
            gPn1.DrawLine(new Pen(Color.Red, 3), 10, 10, 200, 200);
            gPn1.DrawLine(new Pen(Color.Green, 4), 200, 300, 200, 400);
            gPn1.DrawLine(new Pen(Color.Green, 4), 200, 300, 200, 400);
            gPn1.DrawLine(new Pen(Color.White, 4), 200, 300, 200, 400);



            //p1.Parent = pnlDesenho;
            pnlDesenho.Controls.Add(p1);
            //pnlDesenho.Controls[0].Location = new Point(0, 0);
            //            pnlDesenho.Controls[0].Visible = true;
            //            pnlDesenho.Controls[0].BringToFront();
            //  pnlDesenho.Controls[0]
        }
*/

        private void recalcularIndices(int posicaoReduzida)
        {
            int indiceAtual = 0;
            posicaoReduzida++;
            if (contLinha == 0)
                return;

            // Se o só existia 1 desenho na lista e este foi removido é só remover direto 2 indices
            if ((listaPontos.Count) == 2)
            {                
                contLinha--;
                listaPontos.RemoveAt(1);
                listaPontos.RemoveAt(0);
                return;
            }

            // Caso o indice removido seja o ultimo da lista
            if ((listaPontos.Count) == (posicaoReduzida*2))
            {
                contLinha--;
                listaPontos.RemoveAt(listaPontos.Count-1);
                listaPontos.RemoveAt(listaPontos.Count-1);
                return;
            }

            // Caso exista mais de 1 item na lista
            indiceAtual = posicaoReduzida*2;
            while (indiceAtual <= listaPontos.Count)
            {
                listaPontos[indiceAtual-2] = listaPontos[indiceAtual - 1];
                indiceAtual++;
            }
            listaPontos.RemoveAt(listaPontos.Count-1);
            listaPontos.RemoveAt(listaPontos.Count-1);
        }
        private void pnlDesenho_Paint(object sender, PaintEventArgs e)
        {
        }
    }   

}
