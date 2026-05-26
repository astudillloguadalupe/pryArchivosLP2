namespace pryArchivosLP2
{
    partial class frmDeudores
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
            this.dgvConsulta = new System.Windows.Forms.GroupBox();
            this.dgvClientes = new System.Windows.Forms.DataGridView();
            this.lblPromedioRTA = new System.Windows.Forms.Label();
            this.lblCantidadRTA = new System.Windows.Forms.Label();
            this.lblPromDeuda = new System.Windows.Forms.Label();
            this.lblTotalCli = new System.Windows.Forms.Label();
            this.lblTotalDeudaRTA = new System.Windows.Forms.Label();
            this.lblClientes = new System.Windows.Forms.Label();
            this.colCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDeuda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLimite = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvConsulta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvConsulta
            // 
            this.dgvConsulta.Controls.Add(this.dgvClientes);
            this.dgvConsulta.Controls.Add(this.lblPromedioRTA);
            this.dgvConsulta.Controls.Add(this.lblCantidadRTA);
            this.dgvConsulta.Controls.Add(this.lblPromDeuda);
            this.dgvConsulta.Controls.Add(this.lblTotalCli);
            this.dgvConsulta.Controls.Add(this.lblTotalDeudaRTA);
            this.dgvConsulta.Controls.Add(this.lblClientes);
            this.dgvConsulta.Location = new System.Drawing.Point(12, 12);
            this.dgvConsulta.Name = "dgvConsulta";
            this.dgvConsulta.Size = new System.Drawing.Size(494, 380);
            this.dgvConsulta.TabIndex = 15;
            this.dgvConsulta.TabStop = false;
            this.dgvConsulta.Text = "Consulta de Datos";
            // 
            // dgvClientes
            // 
            this.dgvClientes.AllowUserToDeleteRows = false;
            this.dgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colCodigo,
            this.colNombre,
            this.colDeuda,
            this.colLimite});
            this.dgvClientes.Location = new System.Drawing.Point(6, 38);
            this.dgvClientes.Name = "dgvClientes";
            this.dgvClientes.RowHeadersVisible = false;
            this.dgvClientes.RowHeadersWidth = 51;
            this.dgvClientes.Size = new System.Drawing.Size(470, 182);
            this.dgvClientes.TabIndex = 5;
            this.dgvClientes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvClientes_CellContentClick);
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
            // lblCantidadRTA
            // 
            this.lblCantidadRTA.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCantidadRTA.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidadRTA.Location = new System.Drawing.Point(382, 290);
            this.lblCantidadRTA.Name = "lblCantidadRTA";
            this.lblCantidadRTA.Size = new System.Drawing.Size(94, 26);
            this.lblCantidadRTA.TabIndex = 9;
            this.lblCantidadRTA.Click += new System.EventHandler(this.lblCantidadRTA_Click);
            // 
            // lblPromDeuda
            // 
            this.lblPromDeuda.AutoSize = true;
            this.lblPromDeuda.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPromDeuda.Location = new System.Drawing.Point(249, 333);
            this.lblPromDeuda.Name = "lblPromDeuda";
            this.lblPromDeuda.Size = new System.Drawing.Size(113, 16);
            this.lblPromDeuda.TabIndex = 10;
            this.lblPromDeuda.Text = "Promedio Deuda:";
            // 
            // lblTotalCli
            // 
            this.lblTotalCli.AutoSize = true;
            this.lblTotalCli.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalCli.Location = new System.Drawing.Point(249, 252);
            this.lblTotalCli.Name = "lblTotalCli";
            this.lblTotalCli.Size = new System.Drawing.Size(85, 16);
            this.lblTotalCli.TabIndex = 6;
            this.lblTotalCli.Text = "Total Deuda:";
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
            this.lblClientes.Location = new System.Drawing.Point(249, 290);
            this.lblClientes.Name = "lblClientes";
            this.lblClientes.Size = new System.Drawing.Size(127, 16);
            this.lblClientes.TabIndex = 8;
            this.lblClientes.Text = "Cantidad Deudores:";
            // 
            // colCodigo
            // 
            this.colCodigo.HeaderText = "Código";
            this.colCodigo.MinimumWidth = 6;
            this.colCodigo.Name = "colCodigo";
            // 
            // colNombre
            // 
            this.colNombre.HeaderText = "Nombre";
            this.colNombre.MinimumWidth = 6;
            this.colNombre.Name = "colNombre";
            // 
            // colDeuda
            // 
            this.colDeuda.HeaderText = "Deuda";
            this.colDeuda.MinimumWidth = 6;
            this.colDeuda.Name = "colDeuda";
            this.colDeuda.Width = 125;
            // 
            // colLimite
            // 
            this.colLimite.HeaderText = "Limite Crédito";
            this.colLimite.MinimumWidth = 6;
            this.colLimite.Name = "colLimite";
            this.colLimite.Width = 125;
            // 
            // frmDeudores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(515, 400);
            this.Controls.Add(this.dgvConsulta);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "frmDeudores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Clientes Deudores";
            this.Load += new System.EventHandler(this.frmDeudores_Load);
            this.dgvConsulta.ResumeLayout(false);
            this.dgvConsulta.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox dgvConsulta;
        private System.Windows.Forms.DataGridView dgvClientes;
        private System.Windows.Forms.Label lblPromedioRTA;
        private System.Windows.Forms.Label lblCantidadRTA;
        private System.Windows.Forms.Label lblPromDeuda;
        private System.Windows.Forms.Label lblTotalCli;
        private System.Windows.Forms.Label lblTotalDeudaRTA;
        private System.Windows.Forms.Label lblClientes;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDeuda;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLimite;
    }
}