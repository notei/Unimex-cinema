namespace unimex.lenguajesv.cine.views
{
    partial class CarteleraForm
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
            this.dgvCartelera = new System.Windows.Forms.DataGridView();
            this.btnDetallesCar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCartelera)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvCartelera
            // 
            this.dgvCartelera.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvCartelera.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCartelera.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCartelera.Location = new System.Drawing.Point(152, 12);
            this.dgvCartelera.Name = "dgvCartelera";
            this.dgvCartelera.Size = new System.Drawing.Size(471, 344);
            this.dgvCartelera.TabIndex = 0;
            // 
            // btnDetallesCar
            // 
            this.btnDetallesCar.Location = new System.Drawing.Point(31, 94);
            this.btnDetallesCar.Name = "btnDetallesCar";
            this.btnDetallesCar.Size = new System.Drawing.Size(75, 23);
            this.btnDetallesCar.TabIndex = 1;
            this.btnDetallesCar.Text = "Detalles";
            this.btnDetallesCar.UseVisualStyleBackColor = true;
            this.btnDetallesCar.Click += new System.EventHandler(this.btnDetallesCar_Click);
            // 
            // CarteleraForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(635, 368);
            this.Controls.Add(this.btnDetallesCar);
            this.Controls.Add(this.dgvCartelera);
            this.Name = "CarteleraForm";
            this.Text = "CarteleraForm";
            this.Load += new System.EventHandler(this.CarteleraForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCartelera)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCartelera;
        private System.Windows.Forms.Button btnDetallesCar;
    }
}