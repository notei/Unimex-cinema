namespace unimex.lenguajesv.cine.views
{
    partial class PuntodeVentaElegirComplejo
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
            this.cmbElegirComplejo = new System.Windows.Forms.ComboBox();
            this.btnAcptarPVCompl = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmbElegirComplejo
            // 
            this.cmbElegirComplejo.FormattingEnabled = true;
            this.cmbElegirComplejo.Location = new System.Drawing.Point(143, 73);
            this.cmbElegirComplejo.Name = "cmbElegirComplejo";
            this.cmbElegirComplejo.Size = new System.Drawing.Size(121, 24);
            this.cmbElegirComplejo.TabIndex = 0;
            // 
            // btnAcptarPVCompl
            // 
            this.btnAcptarPVCompl.Location = new System.Drawing.Point(62, 255);
            this.btnAcptarPVCompl.Name = "btnAcptarPVCompl";
            this.btnAcptarPVCompl.Size = new System.Drawing.Size(75, 23);
            this.btnAcptarPVCompl.TabIndex = 1;
            this.btnAcptarPVCompl.Text = "Aceptar";
            this.btnAcptarPVCompl.UseVisualStyleBackColor = true;
            this.btnAcptarPVCompl.Click += new System.EventHandler(this.btnAcptarPVCompl_Click);
            // 
            // PuntodeVentaElegirComplejo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(331, 322);
            this.Controls.Add(this.btnAcptarPVCompl);
            this.Controls.Add(this.cmbElegirComplejo);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "PuntodeVentaElegirComplejo";
            this.Text = "Elegir Complejo";
            this.Load += new System.EventHandler(this.PuntodeVentaElegirComplejo_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbElegirComplejo;
        private System.Windows.Forms.Button btnAcptarPVCompl;
    }
}