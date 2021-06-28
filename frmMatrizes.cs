using ArenaDeBatalha.GUI;
using ArenaDeBatalha.ObjetosDoJogo;
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
    public partial class frmMatrizes : Form
    {
        private int indice;
        List<GameObject> listaJogobjeto;
        frnGrafica graficaPrincipal;
        private GameObject Jogobjeto;
        double[,] matriz,matrizTransf;
        int pontoAtual = 0;

        public frmMatrizes(int indice, List<GameObject> listaJogobjeto, frnGrafica graficaPrincipal)
        {
            InitializeComponent();

            this.listaJogobjeto = listaJogobjeto;
            this.indice = indice;
            this.Jogobjeto = listaJogobjeto[indice];
            this.graficaPrincipal = graficaPrincipal;

            if (this.lblDesenho != null)
            {
                // Definir label com indice selecionado
                indice--;
                this.lblDesenho.Text += " " + indice.ToString();
                //
                exibirCoord();
            }
        }

        private void exibirCoord()
        {
            // Decidir qual função de Desenho deve ser executada
            switch (Jogobjeto.tipo)
            {
                case 0:
                    this.lblBaixo.Text = (Jogobjeto.Y1 - 50).ToString();
                    this.lblCima.Text = (Jogobjeto.Y2 - 50).ToString();
                    this.lblDir.Text = (Jogobjeto.X2-250).ToString();
                    this.lblEsq.Text = Jogobjeto.X1.ToString();
                    break;

                case 1:
                    this.lblBaixo.Text = (Jogobjeto.Y1 - 50).ToString();
                    this.lblCima.Text = (Jogobjeto.Y2 - 50).ToString();
                    this.lblDir.Text = (Jogobjeto.X2 - 250).ToString();
                    this.lblEsq.Text = Jogobjeto.X1.ToString();
                    break;

                case 2:
                    // Desenhar polilinha
                    pontoAtual = 0;
                    while (pontoAtual < Jogobjeto.PontoDesenhos.Count - 1)
                    {
                        listaDesenhos.Items.Add(Jogobjeto.PontoDesenhos[pontoAtual]);
                        pontoAtual++;
                    }
                    listaDesenhos.Items.Add(Jogobjeto.PontoDesenhos[pontoAtual]);
                    break;

                /*                case 3:
                                    // Desenhar poligono
                                    pontoAtual = 0;
                                    while (pontoAtual < cxDesenho.listaPoligono.Count - 1)
                                    {
                                        // Salvar coordenadas no objeto
                                        PontoDesenhos.Add(cxDesenho.listaPoliLinha[pontoAtual]);

                                        // Deslocar x para centro do painel
                                        PontoDesenho = cxDesenho.listaPoligono[pontoAtual];
                                        ProxPontoDesenho = cxDesenho.listaPoligono[pontoAtual + 1];

                                        // Desenhar no painel principal
                                        gr.DrawLine(new Pen(Color.DarkCyan, 3), PontoDesenho, ProxPontoDesenho);
                                        pontoAtual++;
                                    }
                                    // Fechar poligono
                                    PontoDesenho = cxDesenho.listaPoligono[pontoAtual];
                                    ProxPontoDesenho = cxDesenho.listaPoligono[0];

                                    // Salvar coordenadas no objeto
                                    PontoDesenhos.Add(cxDesenho.listaPoliLinha[pontoAtual]);*/

                // Linha que deve fechar o poligono                    
                // gr.DrawLine(new Pen(Color.DarkCyan, 3), PontoDesenho, ProxPontoDesenho);
                // break;
                default:
                    break;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Jogobjeto.Y2 -= 10;
            exibirCoord();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Jogobjeto.Y1 += 10;
            exibirCoord();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Jogobjeto.X1 -= 10;
            exibirCoord();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Jogobjeto.X2 += 10;
            exibirCoord();
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            // rotacionar matriz depedend do n de pontos
            /*Just multiply the vector by a rotation matrix:

            | fx |     | cos a - sin a | | sx |
            | fy |  =  | sin a cos a | | sy |*/
            // Decidir qual função de Desenho deve ser executada
            switch (Jogobjeto.tipo)
            {
                case 0:
                case 1:
                    // Montar matriz
                    matriz = new double[2, 2];
                    matrizTransf = new double[2, 2];
                    matriz[0, 0] = Jogobjeto.X1;         matriz[1, 0] = Jogobjeto.X2;
                    matriz[0, 1] = Jogobjeto.X1;         matriz[1, 1] = Jogobjeto.X2;
                    
                    int giraGraus = Int32.Parse(this.txtAngulo.Text);
                    Double angulo = Math.Sin((Double)giraGraus);

                    matrizTransf[0, 0] = Jogobjeto.X1+ angulo; matrizTransf[1, 0] = Jogobjeto.X2 + angulo;
                    matrizTransf[0, 1] = Jogobjeto.Y1+ angulo; matrizTransf[1, 1] = Jogobjeto.Y2 + angulo;

                    for (int m = 0; m < 2; m++)
                    {
                        for (int n = 0; n < 2; n++)
                        {
                            matriz[m, n] = matriz[m, n] * matrizTransf[m, n];
                        }
                    }

                    Jogobjeto.X1 = (int)matriz[0, 0]; Jogobjeto.X2 = (int)matriz[1, 0];
                    Jogobjeto.X1 = (int)matriz[0, 1]; Jogobjeto.X2 = (int)matriz[1, 1];

                    // Atualizar desenho no painel
                    this.Jogobjeto.UpdateObject();
                    exibirCoord();
                    break;

                case 2:
                    // Desenhar polilinha
                    pontoAtual = 0;
                    while (pontoAtual < Jogobjeto.PontoDesenhos.Count - 1)
                    {
                        listaDesenhos.Items.Add(Jogobjeto.PontoDesenhos[pontoAtual]);
                        pontoAtual++;
                    }
                    listaDesenhos.Items.Add(Jogobjeto.PontoDesenhos[pontoAtual]);
                    break;

                /*                case 3:
                                    // Desenhar poligono
                                    pontoAtual = 0;
                                    while (pontoAtual < cxDesenho.listaPoligono.Count - 1)
                                    {
                                        // Salvar coordenadas no objeto
                                        PontoDesenhos.Add(cxDesenho.listaPoliLinha[pontoAtual]);

                                        // Deslocar x para centro do painel
                                        PontoDesenho = cxDesenho.listaPoligono[pontoAtual];
                                        ProxPontoDesenho = cxDesenho.listaPoligono[pontoAtual + 1];

                                        // Desenhar no painel principal
                                        gr.DrawLine(new Pen(Color.DarkCyan, 3), PontoDesenho, ProxPontoDesenho);
                                        pontoAtual++;
                                    }
                                    // Fechar poligono
                                    PontoDesenho = cxDesenho.listaPoligono[pontoAtual];
                                    ProxPontoDesenho = cxDesenho.listaPoligono[0];

                                    // Salvar coordenadas no objeto
                                    PontoDesenhos.Add(cxDesenho.listaPoliLinha[pontoAtual]);*/

                // Linha que deve fechar o poligono                    
                // gr.DrawLine(new Pen(Color.DarkCyan, 3), PontoDesenho, ProxPontoDesenho);
                // break;
                default:
                    break;
            }
        }

        private void frmMatrizes_FormClosed(object sender, FormClosedEventArgs e)
        {
            graficaPrincipal.desenharEixos();
        }
    }
}
