﻿using ArenaDeBatalha.GUI;
using ArenaDeBatalha.ObjetosDoJogo;
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
    public partial class frmMatrizes : Form
    {
        private int indice;
        List<GameObject> listaJogobjeto;
        frnGrafica graficaPrincipal;
        private GameObject Jogobjeto;

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
            
            this.lblBaixo.Text = (Jogobjeto.Top - Jogobjeto.desenhado.Height).ToString();
            this.lblCima.Text = (Jogobjeto.Top + Jogobjeto.desenhado.Height).ToString();
            this.lblDir.Text = (Jogobjeto.Left - Jogobjeto.desenhado.Width).ToString();
            this.lblEsq.Text = (Jogobjeto.Left + Jogobjeto.desenhado.Width).ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Jogobjeto.Top -= 10;
            exibirCoord();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Jogobjeto.Top += 10;
            exibirCoord();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Jogobjeto.Left -= 10;
            exibirCoord();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Jogobjeto.Left += 10;
            exibirCoord();
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            int giraGraus = Int32.Parse(this.txtAngulo.Text);
            this.Jogobjeto.Screen.RotateTransform((float)giraGraus);

            // Atualizar desenho no painel
            this.Jogobjeto.UpdateObject();
            exibirCoord();
        }

        private void frmMatrizes_FormClosed(object sender, FormClosedEventArgs e)
        {
            graficaPrincipal.desenharEixos();
        }
    }
}