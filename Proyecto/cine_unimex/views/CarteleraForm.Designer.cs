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
            this.dgvCartelera.Location = new System.Drawing.Point(97, 42);
            this.dgvCartelera.Name = "dgvCartelera";
            this.dgvCartelera.Size = new System.Drawing.Size(326, 274);
            this.dgvCartelera.TabIndex = 0;
            // 
            // CarteleraForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(490, 356);
            this.Controls.Add(this.dgvCartelera);
            this.Name = "CarteleraForm";
            this.Text = "CarteleraForm";
            this.Load += new System.EventHandler(this.CarteleraForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCartelera)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCartelera;
    }
}