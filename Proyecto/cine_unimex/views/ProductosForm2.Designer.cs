namespace unimex.lenguajesv.cine.views
{
    partial class ProductosForm2
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
            this.ProductosDgv = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.ProductosDgv)).BeginInit();
            this.SuspendLayout();
            // 
            // ProductosDgv
            // 
            this.ProductosDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ProductosDgv.Location = new System.Drawing.Point(52, 15);
            this.ProductosDgv.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ProductosDgv.Name = "ProductosDgv";
            this.ProductosDgv.Size = new System.Drawing.Size(548, 250);
            this.ProductosDgv.TabIndex = 0;
            this.ProductosDgv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // ProductosForm2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(647, 453);
            this.Controls.Add(this.ProductosDgv);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ProductosForm2";
            this.Text = "ProductosForm2";
            this.Load += new System.EventHandler(this.ProductosForm2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ProductosDgv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView ProductosDgv;
    }
}