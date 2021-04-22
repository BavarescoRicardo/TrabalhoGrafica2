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
    public partial class CaixinhaDesenho : Form
    {
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
        // Coordenadas - Propriedades
        public int propX1 
        {
            get
            {
                if (txtX1.Text != "")
                    return Int32.Parse(txtX1.Text);
                else
                    return 0;
            }           
            
        }

        public int propX2
        {
            get
            {
                if (txtX2.Text != "")
                    return Int32.Parse(txtX2.Text);
                else
                    return 0;
            }

        }
        public int propY1
        {
            get
            {
                if (txtY1.Text != "")
                        return Int32.Parse(txtY1.Text);
                else
                    return 0;
            }

        }
        public int propY2
        {
            get
            {
                if (txtY2.Text != "")
                    return Int32.Parse(txtY2.Text);
                else
                    return 0;
            }

        }



        public CaixinhaDesenho()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
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
    }
}
