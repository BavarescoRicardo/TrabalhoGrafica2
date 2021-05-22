using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrabalhoGrafica2.Paineis_para_componentes_de_desenho
{
    class PainelDesenho : Panel
    {
        // Todo tipo de desenho deve ser criado um painel
        Panel painel = new Panel();

        Panel panel1 = new Panel();
        TextBox textBox1 = new TextBox();
        Label label1 = new Label();

        // Initialize the Panel control.
        panel1.Location = new Point(56,72);
        panel1.Size = new Size(264, 152);

    }
}
