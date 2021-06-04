namespace TrabalhoGrafica2
{
    partial class frnGrafica
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
            this.paineldesenho = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnMatrizes = new System.Windows.Forms.Button();
            this.btnBaixo = new System.Windows.Forms.Button();
            this.btnCima = new System.Windows.Forms.Button();
            this.btnDir = new System.Windows.Forms.Button();
            this.btnEsq = new System.Windows.Forms.Button();
            this.btnRemover = new System.Windows.Forms.Button();
            this.listaDesenhos = new System.Windows.Forms.ListBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel1.Controls.Add(this.paineldesenho);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Location = new System.Drawing.Point(2, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(834, 642);
            this.panel1.TabIndex = 0;
            // 
            // paineldesenho
            // 
            this.paineldesenho.BackColor = System.Drawing.SystemColors.Window;
            this.paineldesenho.Location = new System.Drawing.Point(222, 12);
            this.paineldesenho.Name = "paineldesenho";
            this.paineldesenho.Size = new System.Drawing.Size(588, 585);
            this.paineldesenho.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(386, 599);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(258, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Largura : 500                 Altura : 500";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel3.Controls.Add(this.btnMatrizes);
            this.panel3.Controls.Add(this.btnBaixo);
            this.panel3.Controls.Add(this.btnCima);
            this.panel3.Controls.Add(this.btnDir);
            this.panel3.Controls.Add(this.btnEsq);
            this.panel3.Controls.Add(this.btnRemover);
            this.panel3.Controls.Add(this.listaDesenhos);
            this.panel3.Controls.Add(this.btnAdd);
            this.panel3.Location = new System.Drawing.Point(10, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(206, 597);
            this.panel3.TabIndex = 1;
            // 
            // btnMatrizes
            // 
            this.btnMatrizes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMatrizes.Location = new System.Drawing.Point(3, 469);
            this.btnMatrizes.Name = "btnMatrizes";
            this.btnMatrizes.Size = new System.Drawing.Size(203, 31);
            this.btnMatrizes.TabIndex = 8;
            this.btnMatrizes.Text = "Transformar Matrizes";
            this.btnMatrizes.UseVisualStyleBackColor = true;
            this.btnMatrizes.Click += new System.EventHandler(this.btnMatrizes_Click);
            // 
            // btnBaixo
            // 
            this.btnBaixo.Location = new System.Drawing.Point(75, 147);
            this.btnBaixo.Name = "btnBaixo";
            this.btnBaixo.Size = new System.Drawing.Size(50, 23);
            this.btnBaixo.TabIndex = 6;
            this.btnBaixo.Text = "*";
            this.btnBaixo.UseVisualStyleBackColor = true;
            this.btnBaixo.Click += new System.EventHandler(this.btnBaixo_Click);
            // 
            // btnCima
            // 
            this.btnCima.Location = new System.Drawing.Point(76, 80);
            this.btnCima.Name = "btnCima";
            this.btnCima.Size = new System.Drawing.Size(50, 23);
            this.btnCima.TabIndex = 5;
            this.btnCima.Text = "^";
            this.btnCima.UseVisualStyleBackColor = true;
            this.btnCima.Click += new System.EventHandler(this.btnCima_Click);
            // 
            // btnDir
            // 
            this.btnDir.Location = new System.Drawing.Point(117, 105);
            this.btnDir.Name = "btnDir";
            this.btnDir.Size = new System.Drawing.Size(30, 40);
            this.btnDir.TabIndex = 4;
            this.btnDir.Text = ">>";
            this.btnDir.UseVisualStyleBackColor = true;
            this.btnDir.Click += new System.EventHandler(this.btnDir_Click);
            // 
            // btnEsq
            // 
            this.btnEsq.Location = new System.Drawing.Point(50, 104);
            this.btnEsq.Name = "btnEsq";
            this.btnEsq.Size = new System.Drawing.Size(30, 40);
            this.btnEsq.TabIndex = 3;
            this.btnEsq.Text = "<<";
            this.btnEsq.UseVisualStyleBackColor = true;
            this.btnEsq.Click += new System.EventHandler(this.btnEsq_Click);
            // 
            // btnRemover
            // 
            this.btnRemover.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnRemover.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemover.Location = new System.Drawing.Point(0, 37);
            this.btnRemover.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.btnRemover.Name = "btnRemover";
            this.btnRemover.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.btnRemover.Size = new System.Drawing.Size(206, 37);
            this.btnRemover.TabIndex = 2;
            this.btnRemover.Text = "Remover";
            this.btnRemover.UseVisualStyleBackColor = true;
            this.btnRemover.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // listaDesenhos
            // 
            this.listaDesenhos.FormattingEnabled = true;
            this.listaDesenhos.Location = new System.Drawing.Point(26, 180);
            this.listaDesenhos.Name = "listaDesenhos";
            this.listaDesenhos.Size = new System.Drawing.Size(149, 238);
            this.listaDesenhos.TabIndex = 1;
            // 
            // btnAdd
            // 
            this.btnAdd.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(0, 0);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.btnAdd.Size = new System.Drawing.Size(206, 37);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Adicionar ";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // frnGrafica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(827, 630);
            this.Controls.Add(this.panel1);
            this.Name = "frnGrafica";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listaDesenhos;
        private System.Windows.Forms.Button btnRemover;
        private System.Windows.Forms.Button btnEsq;
        private System.Windows.Forms.Button btnCima;
        private System.Windows.Forms.Button btnDir;
        private System.Windows.Forms.Button btnBaixo;
        public System.Windows.Forms.Panel panel3;
        public System.Windows.Forms.Panel paineldesenho;
        private System.Windows.Forms.Button btnMatrizes;
    }
}

