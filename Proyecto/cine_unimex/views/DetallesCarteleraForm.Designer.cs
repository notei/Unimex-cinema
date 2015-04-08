namespace unimex.lenguajesv.cine.views
{
    partial class DetallesCarteleraForm
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
            this.dgvDetallesCartelera = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetallesCartelera)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDetallesCartelera
            // 
            this.dgvDetallesCartelera.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDetallesCartelera.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDetallesCartelera.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetallesCartelera.Location = new System.Drawing.Point(89, 24);
            this.dgvDetallesCartelera.Name = "dgvDetallesCartelera";
            this.dgvDetallesCartelera.Size = new System.Drawing.Size(520, 318);
            this.dgvDetallesCartelera.TabIndex = 0;
            // 
            // DetallesCarteleraForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(636, 367);
            this.Controls.Add(this.dgvDetallesCartelera);
            this.Name = "DetallesCarteleraForm";
            this.Text = "DetallesCarteleraForm";
            this.Load += new System.EventHandler(this.DetallesCarteleraForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetallesCartelera)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDetallesCartelera;
    }
}