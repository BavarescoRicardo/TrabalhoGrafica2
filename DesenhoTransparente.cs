using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace TrabalhoGrafica2
{
    public partial class DesenhoTransparente : Form
    {
        int x1;
        int x2;
        int y1;
        int y2;
        // O C# me obriga desenhar num bitmap antes de adicionar ao painel
        private Bitmap areaDesenho;
        // Então fiz objeto privado e propriedade que retorna o valor sem risco de alterar enquanto esta sendo desenhado
        public Bitmap propAreaDesenho 
        { 
            get
            {
                return this.areaDesenho;
            } 
        }

        public DesenhoTransparente(int x1, int x2, int y1, int y2)
        {
            InitializeComponent();
            this.x1 = x1;
            this.x2 = x2;
            this.y1 = y1;
            this.y2 = y2;
        }

        public void dsnho()
        {
            Graphics gPn1;
            gPn1 = painel.CreateGraphics();
            gPn1.DrawLine(new Pen(Color.Green, 4), 10, 10, 150, 200);
            this.SetDesktopLocation(this.Location.X + 86, this.Location.Y - 3);
            this.areaDesenho = new Bitmap(500, 500, gPn1);
            this.areaDesenho = new Bitmap(450, 450);
            this.areaDesenho.MakeTransparent();
        }

        private void DesenhoTransparente_Load(object sender, EventArgs e)
        {
        }

        private void DesenhoTransparente_Paint(object sender, PaintEventArgs e)
        {        }

        private void painel_Paint(object sender, PaintEventArgs e)
        {
            Graphics gPn1;
            gPn1 = painel.CreateGraphics();
            gPn1.DrawLine(new Pen(Color.Green, 4), this.x1, this.y1, this.x2, this.y2);
        }
    }

}
