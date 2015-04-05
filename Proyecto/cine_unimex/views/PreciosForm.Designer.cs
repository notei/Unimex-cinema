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
            this.btnAgregarprecio.Location = new System.Drawing.Point(23, 52);
            this.btnAgregarprecio.Name = "btnAgregarprecio";
            this.btnAgregarprecio.Size = new System.Drawing.Size(75, 23);
            this.btnAgregarprecio.TabIndex = 1;
            this.btnAgregarprecio.Text = "Agregar";
            this.btnAgregarprecio.UseVisualStyleBackColor = true;
            this.btnAgregarprecio.Click += new System.EventHandler(this.btnAgregarprecio_Click);
            // 
            // btnActualizarPrecios
            // 
            this.btnActualizarPrecios.Location = new System.Drawing.Point(23, 93);
            this.btnActualizarPrecios.Name = "btnActualizarPrecios";
            this.btnActualizarPrecios.Size = new System.Drawing.Size(75, 23);
            this.btnActualizarPrecios.TabIndex = 2;
            this.btnActualizarPrecios.Text = "Actualizar";
            this.btnActualizarPrecios.UseVisualStyleBackColor = true;
            this.btnActualizarPrecios.Click += new System.EventHandler(this.btnActualizarPrecios_Click);
            // 
            // btnBorrarPrecio
            // 
            this.btnBorrarPrecio.Location = new System.Drawing.Point(23, 134);
            this.btnBorrarPrecio.Name = "btnBorrarPrecio";
            this.btnBorrarPrecio.Size = new System.Drawing.Size(75, 23);
            this.btnBorrarPrecio.TabIndex = 3;
            this.btnBorrarPrecio.Text = "Borrar";
            this.btnBorrarPrecio.UseVisualStyleBackColor = true;
            this.btnBorrarPrecio.Click += new System.EventHandler(this.btnBorrarPrecio_Click);
            // 
            // PreciosForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(518, 333);
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

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPrecios;
        private System.Windows.Forms.Button btnAgregarprecio;
        private System.Windows.Forms.Button btnActualizarPrecios;
        private System.Windows.Forms.Button btnBorrarPrecio;
    }
}