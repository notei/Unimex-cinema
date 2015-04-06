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
            // TipoSonidoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(453, 308);
            this.Controls.Add(this.btnNuevoTipoSonido);
            this.Controls.Add(this.dgvTipoSonido);
            this.Name = "TipoSonidoForm";
            this.Text = "TipoSonidoForm";
            this.Load += new System.EventHandler(this.TipoSonidoForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTipoSonido)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvTipoSonido;
        private System.Windows.Forms.Button btnNuevoTipoSonido;
    }
}