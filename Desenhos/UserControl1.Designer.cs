﻿namespace TrabalhoGrafica2.Desenhos
{
    partial class ControleNovo
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.painel = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // painel
            // 
            this.painel.Location = new System.Drawing.Point(0, 270);
            this.painel.Name = "painel";
            this.painel.Size = new System.Drawing.Size(300, 230);
            this.painel.TabIndex = 0;
            // 
            // ControleNovo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.painel);
            this.ForeColor = System.Drawing.Color.Transparent;
            this.Name = "ControleNovo";
            this.Size = new System.Drawing.Size(400, 400);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Panel painel;
    }
}