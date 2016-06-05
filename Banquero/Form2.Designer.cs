namespace Banquero
{
    partial class DialogoSecuencias
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
            this.Secuenciasseguras = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Secuenciasseguras
            // 
            this.Secuenciasseguras.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Secuenciasseguras.ForeColor = System.Drawing.Color.Maroon;
            this.Secuenciasseguras.FormattingEnabled = true;
            this.Secuenciasseguras.HorizontalScrollbar = true;
            this.Secuenciasseguras.Location = new System.Drawing.Point(25, 57);
            this.Secuenciasseguras.Name = "Secuenciasseguras";
            this.Secuenciasseguras.Size = new System.Drawing.Size(141, 173);
            this.Secuenciasseguras.TabIndex = 19;
            this.Secuenciasseguras.DoubleClick += new System.EventHandler(this.Secuenciasseguras_DoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label1.Location = new System.Drawing.Point(13, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "Doble clic en secuencia a mostrar";
            // 
            // DialogoSecuencias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Maroon;
            this.ClientSize = new System.Drawing.Size(187, 242);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Secuenciasseguras);
            this.Name = "DialogoSecuencias";
            this.Text = "Secuencias seguras";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.ListBox Secuenciasseguras;
    }
}