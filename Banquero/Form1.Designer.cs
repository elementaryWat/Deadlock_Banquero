﻿namespace Banquero
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.TCantidadP = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TCantidadR = new System.Windows.Forms.TextBox();
            this.Asignados = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.Disponibles = new System.Windows.Forms.DataGridView();
            this.Id_recurso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CantidadR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Necesidades = new System.Windows.Forms.DataGridView();
            this.Maximos = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.Estadoseguro = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.datosDeInicioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Ejercicio1 = new System.Windows.Forms.ToolStripMenuItem();
            this.Secuenciassegurass = new System.Windows.Forms.ToolStripMenuItem();
            this.IngSolicitud = new System.Windows.Forms.ToolStripMenuItem();
            this.RetMat = new System.Windows.Forms.ToolStripMenuItem();
            this.TEstado = new System.Windows.Forms.Label();
            this.Instantaneas = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Asignados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Disponibles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Necesidades)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Maximos)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Instantaneas)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TCantidadP
            // 
            this.TCantidadP.Location = new System.Drawing.Point(187, 45);
            this.TCantidadP.MaxLength = 2;
            this.TCantidadP.Name = "TCantidadP";
            this.TCantidadP.Size = new System.Drawing.Size(100, 20);
            this.TCantidadP.TabIndex = 0;
            this.TCantidadP.Text = "0";
            this.TCantidadP.TextChanged += new System.EventHandler(this.CantidadP_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label1.Location = new System.Drawing.Point(52, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Cantidad de procesos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label2.Location = new System.Drawing.Point(500, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Cantidad de recursos";
            // 
            // TCantidadR
            // 
            this.TCantidadR.Location = new System.Drawing.Point(630, 45);
            this.TCantidadR.MaxLength = 2;
            this.TCantidadR.Name = "TCantidadR";
            this.TCantidadR.Size = new System.Drawing.Size(100, 20);
            this.TCantidadR.TabIndex = 3;
            this.TCantidadR.Text = "0";
            this.TCantidadR.TextChanged += new System.EventHandler(this.CantidadR_TextChanged);
            // 
            // Asignados
            // 
            this.Asignados.AllowUserToAddRows = false;
            this.Asignados.AllowUserToDeleteRows = false;
            this.Asignados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.Asignados.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.Asignados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Asignados.Location = new System.Drawing.Point(406, 118);
            this.Asignados.Name = "Asignados";
            this.Asignados.RowHeadersWidth = 50;
            this.Asignados.Size = new System.Drawing.Size(200, 175);
            this.Asignados.TabIndex = 5;
            this.Asignados.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.ValMA_CellValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label3.Location = new System.Drawing.Point(403, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Recursos asignados";
            // 
            // Disponibles
            // 
            this.Disponibles.AllowUserToAddRows = false;
            this.Disponibles.AllowUserToDeleteRows = false;
            this.Disponibles.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.Disponibles.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.Disponibles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Disponibles.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id_recurso,
            this.CantidadR});
            this.Disponibles.Location = new System.Drawing.Point(11, 118);
            this.Disponibles.Name = "Disponibles";
            this.Disponibles.Size = new System.Drawing.Size(183, 175);
            this.Disponibles.TabIndex = 9;
            this.Disponibles.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.Disponibles_CellValueChanged);
            // 
            // Id_recurso
            // 
            this.Id_recurso.HeaderText = "Id_recurso";
            this.Id_recurso.Name = "Id_recurso";
            this.Id_recurso.Width = 82;
            // 
            // CantidadR
            // 
            this.CantidadR.HeaderText = "Cantidad";
            this.CantidadR.Name = "CantidadR";
            this.CantidadR.Width = 74;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label4.Location = new System.Drawing.Point(11, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Disponibles";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label5.Location = new System.Drawing.Point(197, 94);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Maximos";
            // 
            // Necesidades
            // 
            this.Necesidades.AllowUserToAddRows = false;
            this.Necesidades.AllowUserToDeleteRows = false;
            this.Necesidades.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.Necesidades.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.Necesidades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Necesidades.Location = new System.Drawing.Point(612, 118);
            this.Necesidades.Name = "Necesidades";
            this.Necesidades.ReadOnly = true;
            this.Necesidades.RowHeadersWidth = 50;
            this.Necesidades.Size = new System.Drawing.Size(200, 175);
            this.Necesidades.TabIndex = 12;
            // 
            // Maximos
            // 
            this.Maximos.AllowUserToAddRows = false;
            this.Maximos.AllowUserToDeleteRows = false;
            this.Maximos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.Maximos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.Maximos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Maximos.Location = new System.Drawing.Point(200, 118);
            this.Maximos.Name = "Maximos";
            this.Maximos.RowHeadersWidth = 50;
            this.Maximos.Size = new System.Drawing.Size(200, 175);
            this.Maximos.TabIndex = 8;
            this.Maximos.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.ValMA_CellValueChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label6.Location = new System.Drawing.Point(609, 94);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Necesidades";
            // 
            // Estadoseguro
            // 
            this.Estadoseguro.BackColor = System.Drawing.Color.MidnightBlue;
            this.Estadoseguro.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.Estadoseguro.Location = new System.Drawing.Point(348, 317);
            this.Estadoseguro.Name = "Estadoseguro";
            this.Estadoseguro.Size = new System.Drawing.Size(101, 34);
            this.Estadoseguro.TabIndex = 14;
            this.Estadoseguro.Text = "Estado del sistema";
            this.Estadoseguro.UseVisualStyleBackColor = false;
            this.Estadoseguro.Click += new System.EventHandler(this.Estadoseguro_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.MidnightBlue;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.datosDeInicioToolStripMenuItem,
            this.Secuenciassegurass,
            this.IngSolicitud,
            this.RetMat});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(824, 24);
            this.menuStrip1.TabIndex = 15;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // datosDeInicioToolStripMenuItem
            // 
            this.datosDeInicioToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Ejercicio1});
            this.datosDeInicioToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.datosDeInicioToolStripMenuItem.Name = "datosDeInicioToolStripMenuItem";
            this.datosDeInicioToolStripMenuItem.Size = new System.Drawing.Size(97, 20);
            this.datosDeInicioToolStripMenuItem.Text = "Datos de inicio";
            // 
            // Ejercicio1
            // 
            this.Ejercicio1.BackColor = System.Drawing.Color.MidnightBlue;
            this.Ejercicio1.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.Ejercicio1.Name = "Ejercicio1";
            this.Ejercicio1.Size = new System.Drawing.Size(127, 22);
            this.Ejercicio1.Text = "Ejercicio 1";
            this.Ejercicio1.Click += new System.EventHandler(this.Ejercicio1_Click);
            // 
            // Secuenciassegurass
            // 
            this.Secuenciassegurass.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.Secuenciassegurass.Name = "Secuenciassegurass";
            this.Secuenciassegurass.Size = new System.Drawing.Size(179, 20);
            this.Secuenciassegurass.Text = "Secuencias de estados seguras";
            this.Secuenciassegurass.Visible = false;
            this.Secuenciassegurass.Click += new System.EventHandler(this.Secuenciassegurass_Click);
            // 
            // IngSolicitud
            // 
            this.IngSolicitud.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.IngSolicitud.Name = "IngSolicitud";
            this.IngSolicitud.Size = new System.Drawing.Size(109, 20);
            this.IngSolicitud.Text = "Ingresar solicitud";
            this.IngSolicitud.Visible = false;
            this.IngSolicitud.Click += new System.EventHandler(this.IngSolicitud_Click);
            // 
            // RetMat
            // 
            this.RetMat.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.RetMat.Name = "RetMat";
            this.RetMat.Size = new System.Drawing.Size(207, 20);
            this.RetMat.Text = "Retornar matrices a datos originales";
            this.RetMat.Visible = false;
            this.RetMat.Click += new System.EventHandler(this.RetMat_Click);
            // 
            // TEstado
            // 
            this.TEstado.AutoSize = true;
            this.TEstado.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.TEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TEstado.Location = new System.Drawing.Point(466, 326);
            this.TEstado.Name = "TEstado";
            this.TEstado.Size = new System.Drawing.Size(0, 16);
            this.TEstado.TabIndex = 19;
            // 
            // Instantaneas
            // 
            this.Instantaneas.AllowUserToDeleteRows = false;
            this.Instantaneas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.Instantaneas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Instantaneas.Location = new System.Drawing.Point(6, 463);
            this.Instantaneas.Name = "Instantaneas";
            this.Instantaneas.Size = new System.Drawing.Size(807, 186);
            this.Instantaneas.TabIndex = 20;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.MidnightBlue;
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.groupBox1.Location = new System.Drawing.Point(227, 395);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(334, 62);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Referencias";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.CornflowerBlue;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Maroon;
            this.label8.Location = new System.Drawing.Point(186, 25);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(119, 16);
            this.label8.TabIndex = 1;
            this.label8.Text = "Vector Finalizados";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.IndianRed;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(30, 25);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(98, 16);
            this.label7.TabIndex = 0;
            this.label7.Text = "Vector Trabajo";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Maroon;
            this.ClientSize = new System.Drawing.Size(824, 361);
            this.Controls.Add(this.Necesidades);
            this.Controls.Add(this.Asignados);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Maximos);
            this.Controls.Add(this.Instantaneas);
            this.Controls.Add(this.Disponibles);
            this.Controls.Add(this.TEstado);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Estadoseguro);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TCantidadR);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TCantidadP);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(840, 700);
            this.MinimumSize = new System.Drawing.Size(840, 400);
            this.Name = "Form1";
            this.Text = "Algoritmo del banquero";
            ((System.ComponentModel.ISupportInitialize)(this.Asignados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Disponibles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Necesidades)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Maximos)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Instantaneas)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TCantidadP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TCantidadR;
        private System.Windows.Forms.DataGridView Asignados;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView Disponibles;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView Necesidades;
        private System.Windows.Forms.DataGridView Maximos;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_recurso;
        private System.Windows.Forms.DataGridViewTextBoxColumn CantidadR;
        private System.Windows.Forms.Button Estadoseguro;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem datosDeInicioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Ejercicio1;
        private System.Windows.Forms.Label TEstado;
        private System.Windows.Forms.ToolStripMenuItem Secuenciassegurass;
        private System.Windows.Forms.DataGridView Instantaneas;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ToolStripMenuItem IngSolicitud;
        private System.Windows.Forms.ToolStripMenuItem RetMat;
    }
}

