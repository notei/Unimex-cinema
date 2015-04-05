namespace unimex.lenguajesv.cine.views
{
    partial class PreciosForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PreciosForm));
            this.dgvPrecios = new System.Windows.Forms.DataGridView();
            this.btnAgregarprecio = new System.Windows.Forms.Button();
            this.btnActualizarPrecios = new System.Windows.Forms.Button();
            this.btnBorrarPrecio = new System.Windows.Forms.Button();
            this.checkPreciosbus = new System.Windows.Forms.CheckBox();
            this.cbxPreciosBuscar = new System.Windows.Forms.ComboBox();
            this.checkPreciobolbus = new System.Windows.Forms.CheckBox();
            this.cbxPrecioBuscpre = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrecios)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPrecios
            // 
            this.dgvPrecios.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvPrecios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPrecios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPrecios.Location = new System.Drawing.Point(138, 12);
            this.dgvPrecios.Name = "dgvPrecios";
            this.dgvPrecios.Size = new System.Drawing.Size(368, 294);
            this.dgvPrecios.TabIndex = 0;
            // 
            // btnAgregarprecio
            // 
            this.btnAgregarprecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarprecio.Location = new System.Drawing.Point(23, 30);
            this.btnAgregarprecio.Name = "btnAgregarprecio";
            this.btnAgregarprecio.Size = new System.Drawing.Size(75, 23);
            this.btnAgregarprecio.TabIndex = 1;
            this.btnAgregarprecio.Text = "Agregar";
            this.btnAgregarprecio.UseVisualStyleBackColor = true;
            this.btnAgregarprecio.Click += new System.EventHandler(this.btnAgregarprecio_Click);
            // 
            // btnActualizarPrecios
            // 
            this.btnActualizarPrecios.Location = new System.Drawing.Point(23, 73);
            this.btnActualizarPrecios.Name = "btnActualizarPrecios";
            this.btnActualizarPrecios.Size = new System.Drawing.Size(75, 23);
            this.btnActualizarPrecios.TabIndex = 2;
            this.btnActualizarPrecios.Text = "Actualizar";
            this.btnActualizarPrecios.UseVisualStyleBackColor = true;
            this.btnActualizarPrecios.Click += new System.EventHandler(this.btnActualizarPrecios_Click);
            // 
            // btnBorrarPrecio
            // 
            this.btnBorrarPrecio.Location = new System.Drawing.Point(23, 114);
            this.btnBorrarPrecio.Name = "btnBorrarPrecio";
            this.btnBorrarPrecio.Size = new System.Drawing.Size(75, 23);
            this.btnBorrarPrecio.TabIndex = 3;
            this.btnBorrarPrecio.Text = "Borrar";
            this.btnBorrarPrecio.UseVisualStyleBackColor = true;
            this.btnBorrarPrecio.Click += new System.EventHandler(this.btnBorrarPrecio_Click);
            // 
            // checkPreciosbus
            // 
            this.checkPreciosbus.AutoSize = true;
            this.checkPreciosbus.Location = new System.Drawing.Point(12, 180);
            this.checkPreciosbus.Name = "checkPreciosbus";
            this.checkPreciosbus.Size = new System.Drawing.Size(56, 17);
            this.checkPreciosbus.TabIndex = 4;
            this.checkPreciosbus.Text = "Boleto";
            this.checkPreciosbus.UseVisualStyleBackColor = true;
            this.checkPreciosbus.CheckedChanged += new System.EventHandler(this.checkPreciosbus_CheckedChanged);
            // 
            // cbxPreciosBuscar
            // 
            this.cbxPreciosBuscar.FormattingEnabled = true;
            this.cbxPreciosBuscar.Location = new System.Drawing.Point(11, 203);
            this.cbxPreciosBuscar.Name = "cbxPreciosBuscar";
            this.cbxPreciosBuscar.Size = new System.Drawing.Size(121, 21);
            this.cbxPreciosBuscar.TabIndex = 5;
            this.cbxPreciosBuscar.SelectedIndexChanged += new System.EventHandler(this.cbxPreciosBuscar_SelectedIndexChanged);
            // 
            // checkPreciobolbus
            // 
            this.checkPreciobolbus.AutoSize = true;
            this.checkPreciobolbus.Location = new System.Drawing.Point(11, 239);
            this.checkPreciobolbus.Name = "checkPreciobolbus";
            this.checkPreciobolbus.Size = new System.Drawing.Size(104, 17);
            this.checkPreciobolbus.TabIndex = 6;
            this.checkPreciobolbus.Text = "Precio de Boleto";
            this.checkPreciobolbus.UseVisualStyleBackColor = true;
            this.checkPreciobolbus.CheckedChanged += new System.EventHandler(this.checkPreciobolbus_CheckedChanged);
            // 
            // cbxPrecioBuscpre
            // 
            this.cbxPrecioBuscpre.FormattingEnabled = true;
            this.cbxPrecioBuscpre.Location = new System.Drawing.Point(11, 262);
            this.cbxPrecioBuscpre.Name = "cbxPrecioBuscpre";
            this.cbxPrecioBuscpre.Size = new System.Drawing.Size(121, 21);
            this.cbxPrecioBuscpre.TabIndex = 7;
            this.cbxPrecioBuscpre.SelectedIndexChanged += new System.EventHandler(this.cbxPrecioBuscpre_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 150);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Busqueda :";
            // 
            // PreciosForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(518, 333);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbxPrecioBuscpre);
            this.Controls.Add(this.checkPreciobolbus);
            this.Controls.Add(this.cbxPreciosBuscar);
            this.Controls.Add(this.checkPreciosbus);
            this.Controls.Add(this.btnBorrarPrecio);
            this.Controls.Add(this.btnActualizarPrecios);
            this.Controls.Add(this.btnAgregarprecio);
            this.Controls.Add(this.dgvPrecios);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PreciosForm";
            this.Text = "Precios de Boletos";
            this.Load += new System.EventHandler(this.PreciosForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrecios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPrecios;
        private System.Windows.Forms.Button btnAgregarprecio;
        private System.Windows.Forms.Button btnActualizarPrecios;
        private System.Windows.Forms.Button btnBorrarPrecio;
        private System.Windows.Forms.CheckBox checkPreciosbus;
        private System.Windows.Forms.ComboBox cbxPreciosBuscar;
        private System.Windows.Forms.CheckBox checkPreciobolbus;
        private System.Windows.Forms.ComboBox cbxPrecioBuscpre;
        private System.Windows.Forms.Label label1;
    }
}