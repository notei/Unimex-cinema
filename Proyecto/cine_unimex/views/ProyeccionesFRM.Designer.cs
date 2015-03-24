namespace unimex.lenguajesv.cine.views
{
    partial class ProyeccionesFRM
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
            this.ProyeccionesDgv = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.ProyeccionesDgv)).BeginInit();
            this.SuspendLayout();
            // 
            // ProyeccionesDgv
            // 
            this.ProyeccionesDgv.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ProyeccionesDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ProyeccionesDgv.Location = new System.Drawing.Point(33, 12);
            this.ProyeccionesDgv.Name = "ProyeccionesDgv";
            this.ProyeccionesDgv.RowTemplate.Height = 24;
            this.ProyeccionesDgv.Size = new System.Drawing.Size(526, 317);
            this.ProyeccionesDgv.TabIndex = 0;
            // 
            // ProyeccionesFRM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(571, 341);
            this.Controls.Add(this.ProyeccionesDgv);
            this.Name = "ProyeccionesFRM";
            this.Text = "ProyeccionesFRM";
            this.Load += new System.EventHandler(this.ProyeccionesFRM_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ProyeccionesDgv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView ProyeccionesDgv;
    }
}