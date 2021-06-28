
namespace TrabalhoGrafica2
{
    partial class frmMatrizes
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.controleAba = new System.Windows.Forms.TabControl();
            this.abaRotaciona = new System.Windows.Forms.TabPage();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.txtAngulo = new System.Windows.Forms.TextBox();
            this.lblAngulo = new System.Windows.Forms.Label();
            this.abaTransl = new System.Windows.Forms.TabPage();
            this.abaMovMatriz = new System.Windows.Forms.TabPage();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.lblBaixo = new System.Windows.Forms.Label();
            this.lblEsq = new System.Windows.Forms.Label();
            this.lblDir = new System.Windows.Forms.Label();
            this.lblCima = new System.Windows.Forms.Label();
            this.lblDesenho = new System.Windows.Forms.Label();
            this.abaMovePoliMatriz = new System.Windows.Forms.TabPage();
            this.listaDesenhos = new System.Windows.Forms.ListBox();
            this.panel1.SuspendLayout();
            this.controleAba.SuspendLayout();
            this.abaRotaciona.SuspendLayout();
            this.abaMovMatriz.SuspendLayout();
            this.abaMovePoliMatriz.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Controls.Add(this.controleAba);
            this.panel1.Controls.Add(this.lblDesenho);
            this.panel1.Location = new System.Drawing.Point(2, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(540, 247);
            this.panel1.TabIndex = 0;
            // 
            // controleAba
            // 
            this.controleAba.Controls.Add(this.abaRotaciona);
            this.controleAba.Controls.Add(this.abaTransl);
            this.controleAba.Controls.Add(this.abaMovMatriz);
            this.controleAba.Controls.Add(this.abaMovePoliMatriz);
            this.controleAba.Location = new System.Drawing.Point(6, 55);
            this.controleAba.Name = "controleAba";
            this.controleAba.SelectedIndex = 0;
            this.controleAba.Size = new System.Drawing.Size(531, 178);
            this.controleAba.TabIndex = 1;
            this.controleAba.TabStop = false;
            // 
            // abaRotaciona
            // 
            this.abaRotaciona.BackColor = System.Drawing.Color.GhostWhite;
            this.abaRotaciona.Controls.Add(this.btnConfirmar);
            this.abaRotaciona.Controls.Add(this.txtAngulo);
            this.abaRotaciona.Controls.Add(this.lblAngulo);
            this.abaRotaciona.Location = new System.Drawing.Point(4, 22);
            this.abaRotaciona.Name = "abaRotaciona";
            this.abaRotaciona.Padding = new System.Windows.Forms.Padding(3);
            this.abaRotaciona.Size = new System.Drawing.Size(523, 152);
            this.abaRotaciona.TabIndex = 1;
            this.abaRotaciona.Text = "Rotacionar";
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Location = new System.Drawing.Point(386, 115);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(78, 31);
            this.btnConfirmar.TabIndex = 2;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.UseVisualStyleBackColor = true;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // txtAngulo
            // 
            this.txtAngulo.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtAngulo.Location = new System.Drawing.Point(206, 87);
            this.txtAngulo.Name = "txtAngulo";
            this.txtAngulo.Size = new System.Drawing.Size(100, 20);
            this.txtAngulo.TabIndex = 1;
            // 
            // lblAngulo
            // 
            this.lblAngulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAngulo.Location = new System.Drawing.Point(15, 36);
            this.lblAngulo.Name = "lblAngulo";
            this.lblAngulo.Size = new System.Drawing.Size(491, 36);
            this.lblAngulo.TabIndex = 0;
            this.lblAngulo.Text = "Angulo que deve rodar o objeto";
            this.lblAngulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // abaTransl
            // 
            this.abaTransl.Location = new System.Drawing.Point(4, 22);
            this.abaTransl.Name = "abaTransl";
            this.abaTransl.Padding = new System.Windows.Forms.Padding(3);
            this.abaTransl.Size = new System.Drawing.Size(523, 152);
            this.abaTransl.TabIndex = 2;
            this.abaTransl.Text = "Translação";
            this.abaTransl.UseVisualStyleBackColor = true;
            // 
            // abaMovMatriz
            // 
            this.abaMovMatriz.Controls.Add(this.button4);
            this.abaMovMatriz.Controls.Add(this.button3);
            this.abaMovMatriz.Controls.Add(this.button2);
            this.abaMovMatriz.Controls.Add(this.button1);
            this.abaMovMatriz.Controls.Add(this.lblBaixo);
            this.abaMovMatriz.Controls.Add(this.lblEsq);
            this.abaMovMatriz.Controls.Add(this.lblDir);
            this.abaMovMatriz.Controls.Add(this.lblCima);
            this.abaMovMatriz.Location = new System.Drawing.Point(4, 22);
            this.abaMovMatriz.Name = "abaMovMatriz";
            this.abaMovMatriz.Padding = new System.Windows.Forms.Padding(3);
            this.abaMovMatriz.Size = new System.Drawing.Size(523, 152);
            this.abaMovMatriz.TabIndex = 3;
            this.abaMovMatriz.Text = "Mover matriz";
            this.abaMovMatriz.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(52, 100);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(65, 24);
            this.button4.TabIndex = 7;
            this.button4.Text = "Baixo";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(6, 61);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(65, 24);
            this.button3.TabIndex = 6;
            this.button3.Text = "Esq";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(89, 61);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(65, 24);
            this.button2.TabIndex = 5;
            this.button2.Text = "Dir";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(52, 31);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(65, 24);
            this.button1.TabIndex = 4;
            this.button1.Text = "Cima";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblBaixo
            // 
            this.lblBaixo.AutoSize = true;
            this.lblBaixo.Location = new System.Drawing.Point(351, 111);
            this.lblBaixo.Name = "lblBaixo";
            this.lblBaixo.Size = new System.Drawing.Size(13, 13);
            this.lblBaixo.TabIndex = 3;
            this.lblBaixo.Text = "0";
            // 
            // lblEsq
            // 
            this.lblEsq.AutoSize = true;
            this.lblEsq.Location = new System.Drawing.Point(302, 70);
            this.lblEsq.Name = "lblEsq";
            this.lblEsq.Size = new System.Drawing.Size(13, 13);
            this.lblEsq.TabIndex = 2;
            this.lblEsq.Text = "0";
            // 
            // lblDir
            // 
            this.lblDir.AutoSize = true;
            this.lblDir.Location = new System.Drawing.Point(399, 70);
            this.lblDir.Name = "lblDir";
            this.lblDir.Size = new System.Drawing.Size(13, 13);
            this.lblDir.TabIndex = 1;
            this.lblDir.Text = "0";
            // 
            // lblCima
            // 
            this.lblCima.AutoSize = true;
            this.lblCima.Location = new System.Drawing.Point(351, 42);
            this.lblCima.Name = "lblCima";
            this.lblCima.Size = new System.Drawing.Size(13, 13);
            this.lblCima.TabIndex = 0;
            this.lblCima.Text = "0";
            // 
            // lblDesenho
            // 
            this.lblDesenho.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDesenho.Location = new System.Drawing.Point(3, 14);
            this.lblDesenho.Name = "lblDesenho";
            this.lblDesenho.Size = new System.Drawing.Size(534, 38);
            this.lblDesenho.TabIndex = 0;
            this.lblDesenho.Text = "Indice selecionado: ";
            this.lblDesenho.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // abaMovePoliMatriz
            // 
            this.abaMovePoliMatriz.Controls.Add(this.listaDesenhos);
            this.abaMovePoliMatriz.Location = new System.Drawing.Point(4, 22);
            this.abaMovePoliMatriz.Name = "abaMovePoliMatriz";
            this.abaMovePoliMatriz.Padding = new System.Windows.Forms.Padding(3);
            this.abaMovePoliMatriz.Size = new System.Drawing.Size(523, 152);
            this.abaMovePoliMatriz.TabIndex = 4;
            this.abaMovePoliMatriz.Text = "Move Poli Matriz";
            this.abaMovePoliMatriz.UseVisualStyleBackColor = true;
            // 
            // listaDesenhos
            // 
            this.listaDesenhos.FormattingEnabled = true;
            this.listaDesenhos.Location = new System.Drawing.Point(16, 19);
            this.listaDesenhos.Name = "listaDesenhos";
            this.listaDesenhos.Size = new System.Drawing.Size(196, 121);
            this.listaDesenhos.TabIndex = 2;
            // 
            // frmMatrizes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 245);
            this.Controls.Add(this.panel1);
            this.Name = "frmMatrizes";
            this.Text = "frmMatrizes";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmMatrizes_FormClosed);
            this.panel1.ResumeLayout(false);
            this.controleAba.ResumeLayout(false);
            this.abaRotaciona.ResumeLayout(false);
            this.abaRotaciona.PerformLayout();
            this.abaMovMatriz.ResumeLayout(false);
            this.abaMovMatriz.PerformLayout();
            this.abaMovePoliMatriz.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblDesenho;
        private System.Windows.Forms.TabControl controleAba;
        private System.Windows.Forms.TabPage abaRotaciona;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.TabPage abaTransl;
        private System.Windows.Forms.Label lblAngulo;
        private System.Windows.Forms.TextBox txtAngulo;
        private System.Windows.Forms.TabPage abaMovMatriz;
        private System.Windows.Forms.Label lblBaixo;
        private System.Windows.Forms.Label lblEsq;
        private System.Windows.Forms.Label lblDir;
        private System.Windows.Forms.Label lblCima;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TabPage abaMovePoliMatriz;
        private System.Windows.Forms.ListBox listaDesenhos;
    }
}