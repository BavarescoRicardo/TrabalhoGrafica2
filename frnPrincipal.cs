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
       FormulariaCoordenadas cxDesenho = new FormulariaCoordenadas();
       int contLinha,contagemLinhasExibir = 0;

        private enum TipoDesenhoIndiceLista
        {
            Ponto = 0,
            Linha = 1,
            Polilinha = 2,
            Poligono = 3
        }

        private List<TipoDesenhoIndiceLista> listaTipos = new List<TipoDesenhoIndiceLista>();
        public frnPrincipal()
        {
            InitializeComponent();            
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            cxDesenho.propPintar = false;            
            cxDesenho.ShowDialog(this);

            // Decidir qual função de Desenho deve ser executada
            switch (cxDesenho.propTipoDesenho)
            {
                case 0:
                    listaTipos.Add(TipoDesenhoIndiceLista.Ponto);
                    desenharPonto();
                    break;

                case 1:
                    listaTipos.Add(TipoDesenhoIndiceLista.Linha);
                    desenharLinha();
                    break;

                case 2:
                    listaTipos.Add(TipoDesenhoIndiceLista.Polilinha);
                    desenharPolilinha();
                    break;

                case 3:
                    listaTipos.Add(TipoDesenhoIndiceLista.Poligono);
                    desenharPoligono();
                    break;
                default:
                    break;
            }            
        }

        public void desenharLinha()
        {
            if (!cxDesenho.propPintar)
            {
                return;
            }
            // Create pincel
            Pen blackPen = new Pen(Color.Black, 3);

            // Desenhar no painel principal
            int x1 = cxDesenho.propX1;
            int y1 = cxDesenho.propY1;
            int x2 = cxDesenho.propX2;
            int y2 = cxDesenho.propY2;

            // Draw line to screen.
            gr = pnlDesenho.CreateGraphics();
            gr.DrawLine(blackPen, x1, y1, x2, y2);

            listaPontos.Add(new Point(x1, y1));
            listaPontos.Add(new Point(x2, y2));

            listaDesenhos.Items.Add(cxDesenho.propNome + " "+ contagemLinhasExibir);
            contLinha++;
            contagemLinhasExibir++;
        }


        public void desenharPonto()
        {
            if (!cxDesenho.propPintar)
            {
                return;
            }
            // Create pincel
            Pen blackPen = new Pen(Color.Red, 3);

            // Create coordinates of points that define line.
            int x1 = cxDesenho.propX1;
            int y1 = cxDesenho.propY1;

            // Desenhar no painel principal
            gr = pnlDesenho.CreateGraphics();
            gr.DrawLine(blackPen, x1, y1, x1+5, y1+5);

            listaPontos.Add(new Point(x1, y1));
            listaPontos.Add(new Point(x1+5, y1+5));

            listaDesenhos.Items.Add(cxDesenho.propNome + " " + contagemLinhasExibir);
            contLinha++;
            contagemLinhasExibir++;
        }


        public void desenharPolilinha()
        {
            if (!cxDesenho.propPintar)
            {
                return;
            }
            // Create pincel
            Pen blackPen = new Pen(Color.Red, 3);

            // Laço de numero de pontos na lista
            int pontoAtual = 0;
            while (pontoAtual < cxDesenho.listaPoliLinha.Count)
            {
                // Desenhar no painel principal
                gr = pnlDesenho.CreateGraphics();
                if (pontoAtual == 0)
                {
                    gr.DrawLine(blackPen, cxDesenho.listaPoliLinha[pontoAtual], cxDesenho.listaPoliLinha[pontoAtual + 1]);
                    pontoAtual += 2;
                }
                else
                {
                    gr.DrawLine(blackPen, cxDesenho.listaPoliLinha[pontoAtual-1], cxDesenho.listaPoliLinha[pontoAtual]);
                    pontoAtual += 1;
                }               
                
                contLinha++;
                contagemLinhasExibir++;
            }
            listaDesenhos.Items.Add(cxDesenho.propNome + " " + contagemLinhasExibir);
        }

        public void desenharPoligono()
        {
            if (!cxDesenho.propPintar)
            {
                return;
            }
            // Create pincel
            Pen blackPen = new Pen(Color.Red, 3);

            // Laço de numero de pontos na lista
            int pontoAtual = 0;
            while (pontoAtual < cxDesenho.listaPoligono.Count)
            {
                // Desenhar no painel principal
                gr = pnlDesenho.CreateGraphics();
                if (pontoAtual == 0)
                {
                    gr.DrawLine(blackPen, cxDesenho.listaPoligono[pontoAtual], cxDesenho.listaPoligono[pontoAtual + 1]);
                    pontoAtual += 2;
                }
                else
                {
                    gr.DrawLine(blackPen, cxDesenho.listaPoligono[pontoAtual - 1], cxDesenho.listaPoligono[pontoAtual]);
                    pontoAtual += 1;
                }
                
                contLinha++;
                contagemLinhasExibir++;
            }
            // Linha que deve fechar o poligono
            gr = pnlDesenho.CreateGraphics();
            gr.DrawLine(blackPen, cxDesenho.listaPoligono[cxDesenho.listaPoligono.Count- 1], cxDesenho.listaPoligono[0]);

            listaDesenhos.Items.Add(cxDesenho.propNome + " " + contagemLinhasExibir);
            contLinha++;
            contagemLinhasExibir++;
        }


        private void btnSair_Click(object sender, EventArgs e)
        {
            // Validações
            if (!(listaDesenhos.SelectedIndex >= 0))
                return;

            // Verifica o tipo do objeto pelo seu indice na lisa
            switch (listaTipos[listaDesenhos.SelectedIndex])
            {
                case TipoDesenhoIndiceLista.Polilinha:
                    pnlDesenho.Refresh();
                    break;

                case TipoDesenhoIndiceLista.Poligono:
                    pnlDesenho.Refresh();
                    break;

                default:
                    // Apagar pintando o mesmo desenho de branco            
                    gr.DrawLine(new Pen(Color.White, 3), listaPontos[listaDesenhos.SelectedIndex == 0 ? 0 : (listaDesenhos.SelectedIndex * 2)],
                        listaPontos[listaDesenhos.SelectedIndex == 0 ? 1 : ((listaDesenhos.SelectedIndex * 2) + 1)]);
                    break;
            }

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

        private void apagarPoli()
        {

        }

        private void recalcularIndices(int posicaoReduzida)
        {
            int indiceAtual = 0;            
            if (contLinha == 0)
                return;

            // Caso o indice removido seja o primeiro da lista
            if (posicaoReduzida == 0)
            {
                if (listaTipos[listaDesenhos.SelectedIndex] == TipoDesenhoIndiceLista.Polilinha)
                    return;

                contLinha--;
                listaPontos.RemoveAt(0);
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
            // Aumenta 1 item da lista de desenhos e depois multiplica por 2 pq cada desenho tem 2 pontos 
            indiceAtual = (posicaoReduzida+1)*2;
            while (indiceAtual < listaPontos.Count)
            {
                // 2 pois cada linha/reta posssui 2 pontos 
                listaPontos[indiceAtual-2] = listaPontos[indiceAtual];
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
