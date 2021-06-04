using ArenaDeBatalha.GUI;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace TrabalhoGrafica2
{
    public partial class frnGrafica : Form
    {
        // Classe do jogo que uso no painel para exibir os desenhos
        FormJogoPrincipal frmJogo;
        frmMatrizes telaMatrizes;

        private enum TipoDesenhoIndiceLista
        {
            Ponto = 0,
            Linha = 1,
            Polilinha = 2,
            Poligono = 3
        }

        public frnGrafica()
        {
            InitializeComponent();
            frmJogo = new FormJogoPrincipal();
            frmJogo.Visible = true;
            frmJogo.TopLevel = false;
            this.paineldesenho.Controls.Add(frmJogo);
            frmJogo.Dock = DockStyle.Fill;

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmJogo.Desenhar();
            this.listaDesenhos.Items.Add("Desenho " + (listaDesenhos.Items.Count + 1).ToString());            
        }


        private void btnSair_Click(object sender, EventArgs e)
        {
            // Valida se existe desenho selecionado
            if (!(this.listaDesenhos.SelectedIndex >= 0))
            {
                MessageBox.Show("Nenhum item marcado!");
                return;
            }
            int indiceSel = this.listaDesenhos.SelectedIndex + 2;
            int indiceSelExbe = this.listaDesenhos.SelectedIndex + 1;
            MessageBox.Show("foi selecionado o desenho:  " + indiceSelExbe.ToString() + ",  para ser rotacionado!");
            frmJogo.propListaObjetosDesenho[indiceSel].Active = false;
            this.listaDesenhos.Items.RemoveAt(indiceSel - 2);

        }

        private void btnEsq_Click(object sender, EventArgs e)
        {
            if (!(frmJogo.propListaObjetosDesenho.Count >= 0))
                return;
            // Movimenta view porta para a esquerda e desenhos para a direita
            for (int cont = 0; cont < frmJogo.propListaObjetosDesenho.Count; cont++)
            {
                frmJogo.propListaObjetosDesenho[cont].Left = frmJogo.propListaObjetosDesenho[cont].Left + 20;
            }
        }

        private void btnDir_Click(object sender, EventArgs e)
        {
            if (!(frmJogo.propListaObjetosDesenho.Count >= 0))
                return;
            // Movimenta view porta para a esquerda e desenhos para a direita
            for (int cont = 0; cont < frmJogo.propListaObjetosDesenho.Count; cont++)
            {
                frmJogo.propListaObjetosDesenho[cont].Left = frmJogo.propListaObjetosDesenho[cont].Left - 20;
            }
        }

        private void btnCima_Click(object sender, EventArgs e)
        {
            if (!(frmJogo.propListaObjetosDesenho.Count >= 0))
                return;
            // Movimenta view porta para a esquerda e desenhos para a direita
            for (int cont = 0; cont < frmJogo.propListaObjetosDesenho.Count; cont++)
            {
                frmJogo.propListaObjetosDesenho[cont].Top = frmJogo.propListaObjetosDesenho[cont].Top + 20;
            }
        }

        private void btnBaixo_Click(object sender, EventArgs e)
        {
            if (!(frmJogo.propListaObjetosDesenho.Count >= 0))
                return;
            // Movimenta view porta para a esquerda e desenhos para a direita
            for (int cont = 0; cont < frmJogo.propListaObjetosDesenho.Count; cont++)
            {
                frmJogo.propListaObjetosDesenho[cont].Top = frmJogo.propListaObjetosDesenho[cont].Top - 20;
            }
        }

        private void btnMatrizes_Click(object sender, EventArgs e)
        {
            // Valida se existe desenho selecionado
            if (!(this.listaDesenhos.SelectedIndex >= 0))
            {
                MessageBox.Show("Nenhum item marcado!");
                return;
            }
            int indiceSel = this.listaDesenhos.SelectedIndex + 2;
            int indiceSelExibe = this.listaDesenhos.SelectedIndex + 1;
            MessageBox.Show("foi selecionado o desenho:  " + indiceSelExibe.ToString() + ",  para as operações com matrizes!");

            telaMatrizes = new frmMatrizes(indiceSel, frmJogo.propListaObjetosDesenho);
            telaMatrizes.Visible = true;
        }
    }   

}
