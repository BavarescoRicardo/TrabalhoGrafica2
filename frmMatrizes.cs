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
        private GameObject Jogobjeto;

        public frmMatrizes(int indice, GameObject Jogobjeto)
        {
            InitializeComponent();

            this.indice = indice;
            this.Jogobjeto = Jogobjeto;

            if (this.lblDesenho != null)
            {
                // Definir label com indice selecionado
                this.lblDesenho.Text += " " + indice.ToString();
            }
        }
    }
}
