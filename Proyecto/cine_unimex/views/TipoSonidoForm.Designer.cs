namespace unimex.lenguajesv.cine.views
{
    partial class TipoSonidoForm
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
            this.dgvTipoSonido = new System.Windows.Forms.DataGridView();
            this.btnNuevoTipoSonido = new System.Windows.Forms.Button();
            this.btnActualizarNew = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.cmbBuscarSonido = new System.Windows.Forms.ComboBox();
            this.chkBuscarSonido = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTipoSonido)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvTipoSonido
            // 
            this.dgvTipoSonido.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvTipoSonido.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTipoSonido.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTipoSonido.Location = new System.Drawing.Point(128, 12);
            this.dgvTipoSonido.Name = "dgvTipoSonido";
            this.dgvTipoSonido.Size = new System.Drawing.Size(306, 277);
            this.dgvTipoSonido.TabIndex = 0;
            // 
            // btnNuevoTipoSonido
            // 
            this.btnNuevoTipoSonido.Location = new System.Drawing.Point(23, 38);
            this.btnNuevoTipoSonido.Name = "btnNuevoTipoSonido";
            this.btnNuevoTipoSonido.Size = new System.Drawing.Size(75, 23);
            this.btnNuevoTipoSonido.TabIndex = 1;
            this.btnNuevoTipoSonido.Text = "Nuevo";
            this.btnNuevoTipoSonido.UseVisualStyleBackColor = true;
            this.btnNuevoTipoSonido.Click += new System.EventHandler(this.btnNuevoTipoSonido_Click);
            // 
            // btnActualizarNew
            // 
            this.btnActualizarNew.Location = new System.Drawing.Point(23, 67);
            this.btnActualizarNew.Name = "btnActualizarNew";
            this.btnActualizarNew.Size = new System.Drawing.Size(75, 23);
            this.btnActualizarNew.TabIndex = 2;
            this.btnActualizarNew.Text = "Actualizar";
            this.btnActualizarNew.UseVisualStyleBackColor = true;
            this.btnActualizarNew.Click += new System.EventHandler(this.btnActualizarNew_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(23, 96);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 3;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // cmbBuscarSonido
            // 
            this.cmbBuscarSonido.FormattingEnabled = true;
            this.cmbBuscarSonido.Location = new System.Drawing.Point(1, 216);
            this.cmbBuscarSonido.Name = "cmbBuscarSonido";
            this.cmbBuscarSonido.Size = new System.Drawing.Size(121, 21);
            this.cmbBuscarSonido.TabIndex = 4;
            this.cmbBuscarSonido.SelectedIndexChanged += new System.EventHandler(this.cmbBuscarSonido_SelectedIndexChanged);
            // 
            // chkBuscarSonido
            // 
            this.chkBuscarSonido.AutoSize = true;
            this.chkBuscarSonido.Location = new System.Drawing.Point(23, 184);
            this.chkBuscarSonido.Name = "chkBuscarSonido";
            this.chkBuscarSonido.Size = new System.Drawing.Size(83, 17);
            this.chkBuscarSonido.TabIndex = 5;
            this.chkBuscarSonido.Text = "Tipo Sonido";
            this.chkBuscarSonido.UseVisualStyleBackColor = true;
            this.chkBuscarSonido.CheckedChanged += new System.EventHandler(this.chkBuscarSonido_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 162);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Buscar :";
            // 
            // TipoSonidoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(453, 308);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chkBuscarSonido);
            this.Controls.Add(this.cmbBuscarSonido);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnActualizarNew);
            this.Controls.Add(this.btnNuevoTipoSonido);
            this.Controls.Add(this.dgvTipoSonido);
            this.Name = "TipoSonidoForm";
            this.Text = "TipoSonidoForm";
            this.Load += new System.EventHandler(this.TipoSonidoForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTipoSonido)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvTipoSonido;
        private System.Windows.Forms.Button btnNuevoTipoSonido;
        private System.Windows.Forms.Button btnActualizarNew;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.ComboBox cmbBuscarSonido;
        private System.Windows.Forms.CheckBox chkBuscarSonido;
        private System.Windows.Forms.Label label1;
    }
}