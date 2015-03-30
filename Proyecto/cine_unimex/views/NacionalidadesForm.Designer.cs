namespace unimex.lenguajesv.cine.views
{
    partial class NacionalidadesForm
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
            this.dgvNacionalidades = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNacionalidades)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvNacionalidades
            // 
            this.dgvNacionalidades.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvNacionalidades.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvNacionalidades.BackgroundColor = System.Drawing.Color.Silver;
            this.dgvNacionalidades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNacionalidades.Location = new System.Drawing.Point(130, 39);
            this.dgvNacionalidades.Name = "dgvNacionalidades";
            this.dgvNacionalidades.Size = new System.Drawing.Size(240, 150);
            this.dgvNacionalidades.TabIndex = 0;
            // 
            // NacionalidadesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(392, 252);
            this.Controls.Add(this.dgvNacionalidades);
            this.Name = "NacionalidadesForm";
            this.Text = "NacionalidadesForm";
            this.Load += new System.EventHandler(this.NacionalidadesForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNacionalidades)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvNacionalidades;
    }
}