using ArenaDeBatalha.GUI;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace TrabalhoGrafica2
{
    public partial class frnPrincipal : Form
    {
        // Classe do jogo que uso no painel para exibir os desenhos
        FormPrincipal frmJogo;

        // Objetos de desenho
        Panel pain = new Panel();        
        List<Graphics> listaG = new List<Graphics>();
        List<Point> listaPontos = new List<Point>();
        public FormulariaCoordenadas cxDesenho = new FormulariaCoordenadas();
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
            frmJogo = new FormPrincipal();
            frmJogo.Visible = true;
            frmJogo.TopLevel = false;
            this.paineldesenho.Controls.Add(frmJogo);
            frmJogo.Dock = DockStyle.Fill;

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmJogo.Desenhar();
            this.listaDesenhos.Items.Add("Desenho " + (listaDesenhos.Items.Count + 1).ToString());
            return;
            // Decidir qual função de Desenho deve ser executada
            switch (cxDesenho.propTipoDesenho)
            {
                case 0:
                    listaTipos.Add(TipoDesenhoIndiceLista.Ponto);
                    desenharPonto();
                    break;

                case 1:
                    listaTipos.Add(TipoDesenhoIndiceLista.Linha);
                    desenharPainelTeste();
                    break;

                case 2:
                    listaTipos.Add(TipoDesenhoIndiceLista.Polilinha);
                    desenharPolilinha();
                    limparListaPolis();
                    break;

                case 3:
                    listaTipos.Add(TipoDesenhoIndiceLista.Poligono);
                    desenharPoligono();
                    limparListaPolis();
                    break;
                default:
                    break;
            }            
        }
        public void desenharPainelTeste()
        {
            if (!cxDesenho.propPintar)
            {
                return;
            }
            this.Refresh();
            // Desenho sera feito no metodo paint 

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
//            listaG.Add(pain.CreateGraphics());
            listaG[listaG.Count-1].DrawLine(blackPen, x1, y1, x2, y2);

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
            Pen blackPen = new Pen(Color.Black, 3);

            // Desenhar no painel principal
            int x1 = cxDesenho.propX1;
            int y1 = cxDesenho.propY1;

            // Draw line to screen.
            listaG.Add(pain.CreateGraphics());
            listaTipos.Add(TipoDesenhoIndiceLista.Ponto);


            DesenhoTransparente dest = new DesenhoTransparente(cxDesenho.propX1, cxDesenho.propX1+5, cxDesenho.propY1, cxDesenho.propY1+5);
            dest.dsnho();
//            dest.Show();
            listaDesenhos.Items.Add(dest.ToString());

/*            listaBitmapes.Add(dest.propAreaDesenho);
            pain.DrawToBitmap(listaBitmapes[listaBitmapes.Count-1], pain.Bounds);
            listaG[listaG.Count - 1].DrawImage(listaBitmapes[listaBitmapes.Count - 1], 0, 0, 500, 500);
*/

            Bitmap bitmap;
//            bitmap.InitializeLifetimeService();
            bitmap = dest.propAreaDesenho;

            listaG.Add(pain.CreateGraphics());
            listaG[listaG.Count-1].DrawImage(bitmap, 0, 0);
            
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
                listaG.Add(pain.CreateGraphics());
                if (pontoAtual == 0)
                {
                    listaG[listaG.Count-1].DrawLine(blackPen, cxDesenho.listaPoliLinha[pontoAtual], cxDesenho.listaPoliLinha[pontoAtual + 1]);
                    pontoAtual += 2;
                }
                else
                {
                    listaG[listaG.Count - 1].DrawLine(blackPen, cxDesenho.listaPoliLinha[pontoAtual-1], cxDesenho.listaPoliLinha[pontoAtual]);
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
                listaG.Add(pain.CreateGraphics());
                if (pontoAtual == 0)
                {
                    listaG[listaG.Count - 1].DrawLine(blackPen, cxDesenho.listaPoligono[pontoAtual], cxDesenho.listaPoligono[pontoAtual + 1]);
                    pontoAtual += 2;
                }
                else
                {
                    listaG[listaG.Count-1].DrawLine(blackPen, cxDesenho.listaPoligono[pontoAtual - 1], cxDesenho.listaPoligono[pontoAtual]);
                    pontoAtual += 1;
                }
                
                contLinha++;
                contagemLinhasExibir++;
            }
            // Linha que deve fechar o poligono
            listaG.Add(pain.CreateGraphics());
            listaG[listaG.Count - 1].DrawLine(blackPen, cxDesenho.listaPoligono[cxDesenho.listaPoligono.Count- 1], cxDesenho.listaPoligono[0]);

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
//                    apagarPolicoisa();
                    pain.Refresh();
                    break;

                case TipoDesenhoIndiceLista.Poligono:
                    pain.Refresh();
                    break;
                case TipoDesenhoIndiceLista.Ponto:
                case TipoDesenhoIndiceLista.Linha:

                    break;

                default:
                    break;
            }
            listaDesenhos.Items.RemoveAt(listaDesenhos.SelectedIndex);
        }

        private void apagarPolicoisa()
        {
            // laço para contar quantos pontos existem na polilnha
            // while alguma coisa
            // Apagar pintando o mesmo desenho de branco            
            listaG[listaG.Count - 1].DrawLine(new Pen(Color.White, 3), listaPontos[listaDesenhos.SelectedIndex == 0 ? 0 : (listaDesenhos.SelectedIndex * 2)],
                listaPontos[listaDesenhos.SelectedIndex == 0 ? 1 : ((listaDesenhos.SelectedIndex * 2) + 1)]);
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
        private void pain_Paint(object sender, PaintEventArgs e)
        {
            //Create empty bitmap image of original size
            if (cxDesenho.propPintar != false)
            {
                listaG.Add(pain.CreateGraphics());
                listaG[listaG.Count - 1].DrawLine(new Pen(Color.DarkRed, 4), cxDesenho.propX1, cxDesenho.propX2, cxDesenho.propY1, cxDesenho.propY2);

                MessageBox.Show("Trocar ordem do senh");
                for (int cc = 1; cc < pain.Controls.Count-cc; cc++) {
                    pain.Controls.SetChildIndex(pain.Controls[pain.Controls.Count-cc], 0);
                }

                MessageBox.Show("Apagar o ultimo desenho");
                GraphicsPath caminho = new GraphicsPath();
                caminho.AddLine(cxDesenho.propX1, cxDesenho.propX2, cxDesenho.propY1, cxDesenho.propY2);
                listaG[listaG.Count - 1].SetClip(caminho);                
                listaG[listaG.Count - 1].Clear(Color.Transparent);
                listaG[listaG.Count - 1].ResetClip();
            }
            
        }

        private void limparListaPolis()
        {
            cxDesenho.listaPoligono.Clear();
            cxDesenho.listaPoliLinha.Clear();
            cxDesenho.listPoligono.Items.Clear();
            cxDesenho.listPolilinha.Items.Clear();
        }
    }   

}
