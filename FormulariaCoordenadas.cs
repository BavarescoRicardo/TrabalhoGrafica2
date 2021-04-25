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

        public enum TipoDesenho
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

        // Propriedade - nome é global para todas as abas
        public string propNome
        {
            get
            {
                return txtNome.Text;
            }
        }


        // Coordenadas Linha - Propriedades
        public int propX1
        {
            get
            {                
                switch ((int)(TipoDesenho)abaDesenho.SelectedIndex)
                {
                    case 0:
                        return Int32.Parse(txtX1Ponto.Text);

                    case 1:
                        return Int32.Parse(txtX1Linha.Text);

                    case 2:
                        return Int32.Parse(txtX1Ponto.Text);

                    case 3:
                        return Int32.Parse(txtX1Ponto.Text);

                    default:
                        break;
                }
                return 0;
                
            }

        }

        public int propY1
        {
            get
            {
                switch ((int)(TipoDesenho)abaDesenho.SelectedIndex)
                {
                    case 0:
                        return Int32.Parse(txtY1Ponto.Text);

                    case 1:
                        return Int32.Parse(txtY1Linha.Text);

                    case 2:
                        return Int32.Parse(txtY1Ponto.Text);

                    case 3:
                        return Int32.Parse(txtY1Ponto.Text);

                    default:
                        break;
                }
                return 0;
            }

        }

        public int propX2
        {
            get
            {
                switch ((int)(TipoDesenho)abaDesenho.SelectedIndex)
                {
                    case 0:                        
                        break;

                    case 1:
                        return Int32.Parse(txtX2Linha.Text);

                    case 2:
                        return Int32.Parse(txtX2Linha.Text);

                    case 3:
                        return Int32.Parse(txtX2Linha.Text);

                    default:
                        break;
                }
                return 0;
            }

        }

        public int propY2
        {
            get
            {
                switch ((int)(TipoDesenho)abaDesenho.SelectedIndex)
                {
                    case 0:
                        break;

                    case 1:
                        return Int32.Parse(txtY2Linha.Text);

                    case 2:
                        return Int32.Parse(txtY2Linha.Text);

                    case 3:
                        return Int32.Parse(txtY2Linha.Text);

                    default:
                        break;
                }
                return 0;
            }

        }



        // Fim coordenadas da linha
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnConfirma_Click(object sender, EventArgs e)
        {
            // Validações antes de desenhar
                // aba 1 esta preenchida
                // aba 2 esta preenchida
                // aba 3 esta preenchida
                // aba 4 esta preenchida

            if (txtNome.Text == "")
                return;

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
