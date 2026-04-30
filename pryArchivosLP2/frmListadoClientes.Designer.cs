namespace pryArchivosLP2
{
    partial class frmListadoClientes
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
            this.grbConsulta = new System.Windows.Forms.GroupBox();
            this.dgvClientes = new System.Windows.Forms.DataGridView();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDeuda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLimite = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblPromedioRTA = new System.Windows.Forms.Label();
            this.lblCantRTA = new System.Windows.Forms.Label();
            this.lblPromedio = new System.Windows.Forms.Label();
            this.lblTotalDeuda = new System.Windows.Forms.Label();
            this.lblTotalDeudaRTA = new System.Windows.Forms.Label();
            this.lblClientes = new System.Windows.Forms.Label();
            this.btnReportar = new System.Windows.Forms.Button();
            this.grbConsulta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // grbConsulta
            // 
            this.grbConsulta.Controls.Add(this.btnReportar);
            this.grbConsulta.Controls.Add(this.dgvClientes);
            this.grbConsulta.Controls.Add(this.lblPromedioRTA);
            this.grbConsulta.Controls.Add(this.lblCantRTA);
            this.grbConsulta.Controls.Add(this.lblPromedio);
            this.grbConsulta.Controls.Add(this.lblTotalDeuda);
            this.grbConsulta.Controls.Add(this.lblTotalDeudaRTA);
            this.grbConsulta.Controls.Add(this.lblClientes);
            this.grbConsulta.Location = new System.Drawing.Point(1, 2);
            this.grbConsulta.Name = "grbConsulta";
            this.grbConsulta.Size = new System.Drawing.Size(494, 420);
            this.grbConsulta.TabIndex = 14;
            this.grbConsulta.TabStop = false;
            this.grbConsulta.Text = "Consulta de Datos";
            // 
            // dgvClientes
            // 
            this.dgvClientes.AllowUserToDeleteRows = false;
            this.dgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.colNombre,
            this.colDeuda,
            this.colLimite});
            this.dgvClientes.Location = new System.Drawing.Point(6, 38);
            this.dgvClientes.Name = "dgvClientes";
            this.dgvClientes.RowHeadersVisible = false;
            this.dgvClientes.Size = new System.Drawing.Size(470, 182);
            this.dgvClientes.TabIndex = 5;
            // 
            // Codigo
            // 
            this.Codigo.HeaderText = "Código";
            this.Codigo.Name = "Codigo";
            // 
            // colNombre
            // 
            this.colNombre.HeaderText = "Nombre";
            this.colNombre.Name = "colNombre";
            this.colNombre.Width = 170;
            // 
            // colDeuda
            // 
            this.colDeuda.HeaderText = "Deuda";
            this.colDeuda.Name = "colDeuda";
            // 
            // colLimite
            // 
            this.colLimite.HeaderText = "Limite Crédito";
            this.colLimite.Name = "colLimite";
            // 
            // lblPromedioRTA
            // 
            this.lblPromedioRTA.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblPromedioRTA.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPromedioRTA.Location = new System.Drawing.Point(382, 332);
            this.lblPromedioRTA.Name = "lblPromedioRTA";
            this.lblPromedioRTA.Size = new System.Drawing.Size(94, 26);
            this.lblPromedioRTA.TabIndex = 11;
            // 
            // lblCantRTA
            // 
            this.lblCantRTA.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCantRTA.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantRTA.Location = new System.Drawing.Point(382, 290);
            this.lblCantRTA.Name = "lblCantRTA";
            this.lblCantRTA.Size = new System.Drawing.Size(94, 26);
            this.lblCantRTA.TabIndex = 9;
            // 
            // lblPromedio
            // 
            this.lblPromedio.AutoSize = true;
            this.lblPromedio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPromedio.Location = new System.Drawing.Point(263, 333);
            this.lblPromedio.Name = "lblPromedio";
            this.lblPromedio.Size = new System.Drawing.Size(113, 16);
            this.lblPromedio.TabIndex = 10;
            this.lblPromedio.Text = "Promedio Deuda:";
            // 
            // lblTotalDeuda
            // 
            this.lblTotalDeuda.AutoSize = true;
            this.lblTotalDeuda.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalDeuda.Location = new System.Drawing.Point(261, 252);
            this.lblTotalDeuda.Name = "lblTotalDeuda";
            this.lblTotalDeuda.Size = new System.Drawing.Size(85, 16);
            this.lblTotalDeuda.TabIndex = 6;
            this.lblTotalDeuda.Text = "Total Deuda:";
            // 
            // lblTotalDeudaRTA
            // 
            this.lblTotalDeudaRTA.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTotalDeudaRTA.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalDeudaRTA.Location = new System.Drawing.Point(382, 242);
            this.lblTotalDeudaRTA.Name = "lblTotalDeudaRTA";
            this.lblTotalDeudaRTA.Size = new System.Drawing.Size(94, 26);
            this.lblTotalDeudaRTA.TabIndex = 7;
            // 
            // lblClientes
            // 
            this.lblClientes.AutoSize = true;
            this.lblClientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClientes.Location = new System.Drawing.Point(261, 291);
            this.lblClientes.Name = "lblClientes";
            this.lblClientes.Size = new System.Drawing.Size(115, 16);
            this.lblClientes.TabIndex = 8;
            this.lblClientes.Text = "Cantidad Clientes:";
            // 
            // btnReportar
            // 
            this.btnReportar.Location = new System.Drawing.Point(401, 387);
            this.btnReportar.Name = "btnReportar";
            this.btnReportar.Size = new System.Drawing.Size(75, 27);
            this.btnReportar.TabIndex = 13;
            this.btnReportar.Text = "Reportar";
            this.btnReportar.UseVisualStyleBackColor = true;
            this.btnReportar.Click += new System.EventHandler(this.btnReportar_Click);
            // 
            // frmListadoClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 431);
            this.Controls.Add(this.grbConsulta);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "frmListadoClientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Listado Clientes";
            this.Load += new System.EventHandler(this.frmListadoClientes_Load);
            this.grbConsulta.ResumeLayout(false);
            this.grbConsulta.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbConsulta;
        private System.Windows.Forms.DataGridView dgvClientes;
        private System.Windows.Forms.Label lblPromedioRTA;
        private System.Windows.Forms.Label lblCantRTA;
        private System.Windows.Forms.Label lblPromedio;
        private System.Windows.Forms.Label lblTotalDeuda;
        private System.Windows.Forms.Label lblTotalDeudaRTA;
        private System.Windows.Forms.Label lblClientes;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDeuda;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLimite;
        private System.Windows.Forms.Button btnReportar;
    }
}