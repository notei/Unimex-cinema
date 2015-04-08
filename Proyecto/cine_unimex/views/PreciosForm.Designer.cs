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
            this.label2 = new System.Windows.Forms.Label();
            this.cbxPrecioBuscpre = new System.Windows.Forms.ComboBox();
            this.checkPreciobolbus = new System.Windows.Forms.CheckBox();
            this.cbxPreciosBuscar = new System.Windows.Forms.ComboBox();
            this.checkPreciosbus = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBorrarPrecio = new System.Windows.Forms.Button();
            this.btnActualizarPrecios = new System.Windows.Forms.Button();
            this.btnAgregarprecio = new System.Windows.Forms.Button();
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
            this.dgvPrecios.Location = new System.Drawing.Point(129, 153);
            this.dgvPrecios.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvPrecios.Name = "dgvPrecios";
            this.dgvPrecios.Size = new System.Drawing.Size(559, 361);
            this.dgvPrecios.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(39, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(566, 40);
            this.label2.TabIndex = 9;
            this.label2.Text = "CATÁLOGO PRECIOS DE BOLETOS";
            // 
            // cbxPrecioBuscpre
            // 
            this.cbxPrecioBuscpre.FormattingEnabled = true;
            this.cbxPrecioBuscpre.Location = new System.Drawing.Point(533, 118);
            this.cbxPrecioBuscpre.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbxPrecioBuscpre.Name = "cbxPrecioBuscpre";
            this.cbxPrecioBuscpre.Size = new System.Drawing.Size(140, 27);
            this.cbxPrecioBuscpre.TabIndex = 13;
            // 
            // checkPreciobolbus
            // 
            this.checkPreciobolbus.AutoSize = true;
            this.checkPreciobolbus.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkPreciobolbus.Location = new System.Drawing.Point(533, 90);
            this.checkPreciobolbus.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.checkPreciobolbus.Name = "checkPreciobolbus";
            this.checkPreciobolbus.Size = new System.Drawing.Size(143, 23);
            this.checkPreciobolbus.TabIndex = 12;
            this.checkPreciobolbus.Text = "Precio de Boleto";
            this.checkPreciobolbus.UseVisualStyleBackColor = true;
            // 
            // cbxPreciosBuscar
            // 
            this.cbxPreciosBuscar.FormattingEnabled = true;
            this.cbxPreciosBuscar.Location = new System.Drawing.Point(375, 118);
            this.cbxPreciosBuscar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbxPreciosBuscar.Name = "cbxPreciosBuscar";
            this.cbxPreciosBuscar.Size = new System.Drawing.Size(140, 27);
            this.cbxPreciosBuscar.TabIndex = 11;
            // 
            // checkPreciosbus
            // 
            this.checkPreciosbus.AutoSize = true;
            this.checkPreciosbus.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkPreciosbus.Location = new System.Drawing.Point(376, 90);
            this.checkPreciosbus.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.checkPreciosbus.Name = "checkPreciosbus";
            this.checkPreciosbus.Size = new System.Drawing.Size(74, 23);
            this.checkPreciosbus.TabIndex = 10;
            this.checkPreciosbus.Text = "Boleto";
            this.checkPreciosbus.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(258, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 19);
            this.label1.TabIndex = 17;
            this.label1.Text = "Busqueda :";
            // 
            // btnBorrarPrecio
            // 
            this.btnBorrarPrecio.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBorrarPrecio.Location = new System.Drawing.Point(12, 421);
            this.btnBorrarPrecio.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnBorrarPrecio.Name = "btnBorrarPrecio";
            this.btnBorrarPrecio.Size = new System.Drawing.Size(87, 65);
            this.btnBorrarPrecio.TabIndex = 16;
            this.btnBorrarPrecio.Text = "Borrar";
            this.btnBorrarPrecio.UseVisualStyleBackColor = true;
            // 
            // btnActualizarPrecios
            // 
            this.btnActualizarPrecios.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizarPrecios.Location = new System.Drawing.Point(12, 309);
            this.btnActualizarPrecios.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnActualizarPrecios.Name = "btnActualizarPrecios";
            this.btnActualizarPrecios.Size = new System.Drawing.Size(87, 65);
            this.btnActualizarPrecios.TabIndex = 15;
            this.btnActualizarPrecios.Text = "Actualizar";
            this.btnActualizarPrecios.UseVisualStyleBackColor = true;
            // 
            // btnAgregarprecio
            // 
            this.btnAgregarprecio.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarprecio.Location = new System.Drawing.Point(12, 194);
            this.btnAgregarprecio.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAgregarprecio.Name = "btnAgregarprecio";
            this.btnAgregarprecio.Size = new System.Drawing.Size(87, 65);
            this.btnAgregarprecio.TabIndex = 14;
            this.btnAgregarprecio.Text = "Agregar";
            this.btnAgregarprecio.UseVisualStyleBackColor = true;
            // 
            // PreciosForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(698, 564);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnBorrarPrecio);
            this.Controls.Add(this.btnActualizarPrecios);
            this.Controls.Add(this.btnAgregarprecio);
            this.Controls.Add(this.cbxPrecioBuscpre);
            this.Controls.Add(this.checkPreciobolbus);
            this.Controls.Add(this.cbxPreciosBuscar);
            this.Controls.Add(this.checkPreciosbus);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvPrecios);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "PreciosForm";
            this.Text = "Precios de Boletos";
            this.Load += new System.EventHandler(this.PreciosForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrecios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPrecios;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbxPrecioBuscpre;
        private System.Windows.Forms.CheckBox checkPreciobolbus;
        private System.Windows.Forms.ComboBox cbxPreciosBuscar;
        private System.Windows.Forms.CheckBox checkPreciosbus;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBorrarPrecio;
        private System.Windows.Forms.Button btnActualizarPrecios;
        private System.Windows.Forms.Button btnAgregarprecio;
    }
}