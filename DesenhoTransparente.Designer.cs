
namespace TrabalhoGrafica2
{
    partial class DesenhoTransparente
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
            this.painel = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // painel
            // 
            this.painel.Location = new System.Drawing.Point(15, 5);
            this.painel.Name = "painel";
            this.painel.Size = new System.Drawing.Size(500, 500);
            this.painel.TabIndex = 0;
            this.painel.Paint += new System.Windows.Forms.PaintEventHandler(this.painel_Paint);
            // 
            // DesenhoTransparente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(517, 511);
            this.ControlBox = false;
            this.Controls.Add(this.painel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DesenhoTransparente";
            this.Opacity = 0.95D;
            this.ShowIcon = false;
            this.Text = "DesenhoTransparente";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.DesenhoTransparente_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.DesenhoTransparente_Paint);
            this.Controls.SetChildIndex(this.painel, 0);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Panel painel;
    }
}