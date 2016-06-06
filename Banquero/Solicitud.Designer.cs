namespace Banquero
{
    partial class Solicitud
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Solicitud));
            this.label1 = new System.Windows.Forms.Label();
            this.DetSol = new System.Windows.Forms.DataGridView();
            this.BSolic = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.Listaprocesos = new System.Windows.Forms.ComboBox();
            this.IdRecurso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CantidadR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DetSol)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label1.Location = new System.Drawing.Point(21, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 13);
            this.label1.TabIndex = 21;
            this.label1.Text = "Ingrese los datos de la solicitud";
            // 
            // DetSol
            // 
            this.DetSol.AllowUserToAddRows = false;
            this.DetSol.AllowUserToDeleteRows = false;
            this.DetSol.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.DetSol.CausesValidation = false;
            this.DetSol.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DetSol.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdRecurso,
            this.CantidadR});
            this.DetSol.Location = new System.Drawing.Point(13, 88);
            this.DetSol.Name = "DetSol";
            this.DetSol.Size = new System.Drawing.Size(185, 204);
            this.DetSol.TabIndex = 22;
            this.DetSol.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.DetSol_CellValueChanged);
            // 
            // BSolic
            // 
            this.BSolic.BackColor = System.Drawing.Color.MidnightBlue;
            this.BSolic.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.BSolic.Location = new System.Drawing.Point(69, 298);
            this.BSolic.Name = "BSolic";
            this.BSolic.Size = new System.Drawing.Size(75, 23);
            this.BSolic.TabIndex = 23;
            this.BSolic.Text = "Solicitar";
            this.BSolic.UseVisualStyleBackColor = false;
            this.BSolic.Click += new System.EventHandler(this.BSolic_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label2.Location = new System.Drawing.Point(12, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 13);
            this.label2.TabIndex = 24;
            this.label2.Text = "Proceso que solicita";
            // 
            // Listaprocesos
            // 
            this.Listaprocesos.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Listaprocesos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Listaprocesos.ForeColor = System.Drawing.Color.Maroon;
            this.Listaprocesos.FormattingEnabled = true;
            this.Listaprocesos.Location = new System.Drawing.Point(120, 22);
            this.Listaprocesos.Name = "Listaprocesos";
            this.Listaprocesos.Size = new System.Drawing.Size(78, 21);
            this.Listaprocesos.TabIndex = 25;
            // 
            // IdRecurso
            // 
            this.IdRecurso.HeaderText = "Id_Recurso";
            this.IdRecurso.Name = "IdRecurso";
            this.IdRecurso.ReadOnly = true;
            this.IdRecurso.Width = 87;
            // 
            // CantidadR
            // 
            this.CantidadR.HeaderText = "Cantidad";
            this.CantidadR.Name = "CantidadR";
            this.CantidadR.Width = 74;
            // 
            // Solicitud
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Maroon;
            this.ClientSize = new System.Drawing.Size(211, 332);
            this.Controls.Add(this.Listaprocesos);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BSolic);
            this.Controls.Add(this.DetSol);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Solicitud";
            this.Text = "Solicitud";
            ((System.ComponentModel.ISupportInitialize)(this.DetSol)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView DetSol;
        private System.Windows.Forms.Button BSolic;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox Listaprocesos;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdRecurso;
        private System.Windows.Forms.DataGridViewTextBoxColumn CantidadR;
    }
}