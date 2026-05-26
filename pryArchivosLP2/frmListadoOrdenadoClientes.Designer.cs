namespace pryArchivosLP2
{
    partial class frmListadoOrdenadoClientes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmListadoOrdenadoClientes));
            this.grpOrden = new System.Windows.Forms.GroupBox();
            this.radDes = new System.Windows.Forms.RadioButton();
            this.radAsc = new System.Windows.Forms.RadioButton();
            this.grpOrdenarPor = new System.Windows.Forms.GroupBox();
            this.radLimite = new System.Windows.Forms.RadioButton();
            this.radDeuda = new System.Windows.Forms.RadioButton();
            this.radCodigo = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dgvGrilla = new System.Windows.Forms.DataGridView();
            this.btnOrdenar = new System.Windows.Forms.Button();
            this.Código = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Deuda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LimiteCredito = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpOrden.SuspendLayout();
            this.grpOrdenarPor.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrilla)).BeginInit();
            this.SuspendLayout();
            // 
            // grpOrden
            // 
            this.grpOrden.Controls.Add(this.radDes);
            this.grpOrden.Controls.Add(this.radAsc);
            this.grpOrden.Location = new System.Drawing.Point(227, 10);
            this.grpOrden.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpOrden.Name = "grpOrden";
            this.grpOrden.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpOrden.Size = new System.Drawing.Size(150, 127);
            this.grpOrden.TabIndex = 0;
            this.grpOrden.TabStop = false;
            this.grpOrden.Text = "Orden";
            // 
            // radDes
            // 
            this.radDes.AutoSize = true;
            this.radDes.Location = new System.Drawing.Point(15, 84);
            this.radDes.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.radDes.Name = "radDes";
            this.radDes.Size = new System.Drawing.Size(89, 17);
            this.radDes.TabIndex = 3;
            this.radDes.TabStop = true;
            this.radDes.Text = "Descendente";
            this.radDes.UseVisualStyleBackColor = true;
            // 
            // radAsc
            // 
            this.radAsc.AutoSize = true;
            this.radAsc.Location = new System.Drawing.Point(15, 34);
            this.radAsc.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.radAsc.Name = "radAsc";
            this.radAsc.Size = new System.Drawing.Size(82, 17);
            this.radAsc.TabIndex = 4;
            this.radAsc.TabStop = true;
            this.radAsc.Text = "Ascendente";
            this.radAsc.UseVisualStyleBackColor = true;
            // 
            // grpOrdenarPor
            // 
            this.grpOrdenarPor.Controls.Add(this.radLimite);
            this.grpOrdenarPor.Controls.Add(this.radDeuda);
            this.grpOrdenarPor.Controls.Add(this.radCodigo);
            this.grpOrdenarPor.Location = new System.Drawing.Point(35, 10);
            this.grpOrdenarPor.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpOrdenarPor.Name = "grpOrdenarPor";
            this.grpOrdenarPor.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpOrdenarPor.Size = new System.Drawing.Size(154, 127);
            this.grpOrdenarPor.TabIndex = 0;
            this.grpOrdenarPor.TabStop = false;
            this.grpOrdenarPor.Text = "Ordenar por";
            // 
            // radLimite
            // 
            this.radLimite.AutoSize = true;
            this.radLimite.Location = new System.Drawing.Point(20, 98);
            this.radLimite.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.radLimite.Name = "radLimite";
            this.radLimite.Size = new System.Drawing.Size(90, 17);
            this.radLimite.TabIndex = 2;
            this.radLimite.TabStop = true;
            this.radLimite.Text = "Límite Crédito";
            this.radLimite.UseVisualStyleBackColor = true;
            // 
            // radDeuda
            // 
            this.radDeuda.AutoSize = true;
            this.radDeuda.Location = new System.Drawing.Point(20, 58);
            this.radDeuda.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.radDeuda.Name = "radDeuda";
            this.radDeuda.Size = new System.Drawing.Size(57, 17);
            this.radDeuda.TabIndex = 1;
            this.radDeuda.TabStop = true;
            this.radDeuda.Text = "Deuda";
            this.radDeuda.UseVisualStyleBackColor = true;
            // 
            // radCodigo
            // 
            this.radCodigo.AutoSize = true;
            this.radCodigo.Location = new System.Drawing.Point(20, 17);
            this.radCodigo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.radCodigo.Name = "radCodigo";
            this.radCodigo.Size = new System.Drawing.Size(58, 17);
            this.radCodigo.TabIndex = 0;
            this.radCodigo.TabStop = true;
            this.radCodigo.Text = "Código";
            this.radCodigo.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dgvGrilla);
            this.groupBox3.Location = new System.Drawing.Point(4, 141);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox3.Size = new System.Drawing.Size(483, 214);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Consulta de Datos";
            // 
            // dgvGrilla
            // 
            this.dgvGrilla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGrilla.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Código,
            this.Nombre,
            this.Deuda,
            this.LimiteCredito});
            this.dgvGrilla.Location = new System.Drawing.Point(7, 17);
            this.dgvGrilla.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvGrilla.Name = "dgvGrilla";
            this.dgvGrilla.RowHeadersWidth = 51;
            this.dgvGrilla.RowTemplate.Height = 24;
            this.dgvGrilla.Size = new System.Drawing.Size(472, 193);
            this.dgvGrilla.TabIndex = 0;
            // 
            // btnOrdenar
            // 
            this.btnOrdenar.Location = new System.Drawing.Point(391, 63);
            this.btnOrdenar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnOrdenar.Name = "btnOrdenar";
            this.btnOrdenar.Size = new System.Drawing.Size(76, 28);
            this.btnOrdenar.TabIndex = 6;
            this.btnOrdenar.Text = "Ordenar";
            this.btnOrdenar.UseVisualStyleBackColor = true;
            this.btnOrdenar.Click += new System.EventHandler(this.btnOrdenar_Click);
            // 
            // Código
            // 
            this.Código.HeaderText = "Código";
            this.Código.MinimumWidth = 6;
            this.Código.Name = "Código";
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.MinimumWidth = 6;
            this.Nombre.Name = "Nombre";
            // 
            // Deuda
            // 
            this.Deuda.HeaderText = "Deuda";
            this.Deuda.MinimumWidth = 6;
            this.Deuda.Name = "Deuda";
            this.Deuda.Width = 110;
            // 
            // LimiteCredito
            // 
            this.LimiteCredito.HeaderText = "Limite Crédito";
            this.LimiteCredito.MinimumWidth = 6;
            this.LimiteCredito.Name = "LimiteCredito";
            this.LimiteCredito.Width = 110;
            // 
            // frmListadoOrdenadoClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(493, 366);
            this.Controls.Add(this.btnOrdenar);
            this.Controls.Add(this.grpOrdenarPor);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.grpOrden);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmListadoOrdenadoClientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Listado Ordenado de Clientes";
            this.Load += new System.EventHandler(this.frmListadoOrdenadoClientes_Load);
            this.grpOrden.ResumeLayout(false);
            this.grpOrden.PerformLayout();
            this.grpOrdenarPor.ResumeLayout(false);
            this.grpOrdenarPor.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrilla)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpOrden;
        private System.Windows.Forms.GroupBox grpOrdenarPor;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dgvGrilla;
        private System.Windows.Forms.RadioButton radAsc;
        private System.Windows.Forms.RadioButton radDes;
        private System.Windows.Forms.RadioButton radLimite;
        private System.Windows.Forms.RadioButton radDeuda;
        private System.Windows.Forms.RadioButton radCodigo;
        private System.Windows.Forms.Button btnOrdenar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Código;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Deuda;
        private System.Windows.Forms.DataGridViewTextBoxColumn LimiteCredito;
    }
}