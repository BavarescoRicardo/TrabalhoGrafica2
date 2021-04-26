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
        public List<Point> listaPoliLinha = new List<Point>();
        public List<Point> listaPoligono = new List<Point>();
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
        // seleção de desenhos com condições nas propriedades pela aba selecionada
        public int propX1
        {
            get
            {                
                switch ((int)(TipoDesenho)abaDesenho.SelectedIndex)
                {
                    case 0:
                        return Int32.Parse(txtX1Ponto.Text)+250;

                    case 1:
                        return Int32.Parse(txtX1Linha.Text) + 250;

                    case 2:
                        break;

                    case 3:
                        break;

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
                        return (-1 * Int32.Parse(txtY1Ponto.Text)) + 250;

                    case 1:
                        return (-1 * Int32.Parse(txtY1Linha.Text)) + 250;

                    case 2:
                        break;

                    case 3:
                        break;

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
                        return Int32.Parse(txtX2Linha.Text) + 250;

                    case 2:
                        break;

                    case 3:
                        break;

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
                        return (-1 * Int32.Parse(txtY2Linha.Text)) + 250;

                    case 2:
                        break;

                    case 3:
                        break;

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
            // Validações antes de desenhar fazer para proxima etapa
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

        private void btnAddPonto_Click(object sender, EventArgs e)
        {
            // Adiciona os pontos digitados em um array de pontos
            listaPoliLinha.Add(new Point(Int32.Parse(txtX1PoliLinha.Text) + 250, (-1 * Int32.Parse(txtY1PoliLinha.Text)) + 250));

            // Adiciona visualmente o novo ponto inserido no componente da tela
            listPolilinha.Items.Add("X: " + txtX1PoliLinha.Text + "    Y: " + txtY1PoliLinha.Text);

            // Limpar as caixas de texto
            txtX1PoliLinha.Text = "";
            txtY1PoliLinha.Text = "";
        }

        private void btnAddPontoPoligono_Click(object sender, EventArgs e)
        {
            // Adiciona os pontos digitados em um array de pontos
            listaPoligono.Add(new Point(Int32.Parse(txtX1Poligono.Text) + 250, (-1*Int32.Parse(txtY1Poligono.Text)) + 250));

            // Adiciona visualmente o novo ponto inserido no componente da tela
            listPoligono.Items.Add("X: " + txtX1Poligono.Text + "    Y: " + txtY1Poligono.Text);

            // Limpar as caixas de texto
            txtX1Poligono.Text = "";
            txtY1Poligono.Text = "";
        }

        private void abaDesenho_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Limpar arrays e listas visuais ao mudar aba da tela
            listaPoligono.Clear();
            listaPoliLinha.Clear();
            listPoligono.Items.Clear();
            listPolilinha.Items.Clear();

            txtNome.Text = "";            
        }
    }    
}
