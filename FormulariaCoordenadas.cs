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
    public partial class FormulariaCoordenadas : Form
    {
        public FormulariaCoordenadas()
        {
            InitializeComponent();        
            
        }

        private enum TipoDesenho
        {
            Ponto = 0,
            Linha = 1,
            Polilinha = 2,
            Poligono = 3
        }
        public int propTipoDesenho
        {
            get
            {                
                return (int)(TipoDesenho)abaDesenho.SelectedIndex;
            }
        }

        private bool pintar = false;
        public bool propPintar
        {
            get
            {
                return pintar;
            }
            set
            {
                pintar = value;
            }
        }



        // Coordenadas Linha - Propriedades
        public string propNomeLinha
        {
            get
            {
                return txtNomeLinha.Text;
            }
        }

        public int propX1
        {
            get
            {
                if (txtX1Linha.Text != "")
                    return Int32.Parse(txtX1Linha.Text);
                else
                    return 0;
            }

        }

        public int propY1
        {
            get
            {
                if (txtY1Linha.Text != "")
                    return Int32.Parse(txtY1Linha.Text);
                else
                    return 400;
            }

        }

        public int propX2
        {
            get
            {
                if (txtX1Linha.Text != "")
                    return Int32.Parse(txtX2Linha.Text);
                else
                    return 0;
            }

        }

        public int propY2
        {
            get
            {
                if (txtY1Linha.Text != "")
                    return Int32.Parse(txtY2Linha.Text);
                else
                    return 400;
            }

        }



        // Fim coordenadas da linha
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnConfirma_Click(object sender, EventArgs e)
        {
            pintar = true;
            this.Close();
        }

        private void txtX1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void txtY1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void txtX2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void txtY2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            pintar = true;
            this.Close();
        }
    }    
}
