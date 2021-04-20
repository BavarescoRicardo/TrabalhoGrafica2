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
        // Coordenadas - Propriedades
        public int propX1 
        {
            get
            {
                return Int32.Parse(txtX1.Text);
            }           
            
        }

        public int propX2
        {
            get
            {
                return Int32.Parse(txtX2.Text);
            }

        }
        public int propY1
        {
            get
            {
                return Int32.Parse(txtY1.Text);
            }

        }
        public int propY2
        {
            get
            {
                return Int32.Parse(txtY2.Text);
            }

        }



        public CaixinhaDesenho()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
