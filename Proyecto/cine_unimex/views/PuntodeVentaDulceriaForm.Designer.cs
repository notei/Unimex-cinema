namespace unimex.lenguajesv.cine.views
{
    partial class PuntodeVentaDulceriaForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbProductosPVD = new System.Windows.Forms.ComboBox();
            this.cmbCombosPVD = new System.Windows.Forms.ComboBox();
            this.btnAceptarPVD = new System.Windows.Forms.Button();
            this.btnCancelarPVD = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(63, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(332, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Punto de Venta Dulceria";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Productos:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(60, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Combos:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 175);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Registrar pago:";
            // 
            // cmbProductosPVD
            // 
            this.cmbProductosPVD.FormattingEnabled = true;
            this.cmbProductosPVD.Location = new System.Drawing.Point(123, 102);
            this.cmbProductosPVD.Name = "cmbProductosPVD";
            this.cmbProductosPVD.Size = new System.Drawing.Size(121, 24);
            this.cmbProductosPVD.TabIndex = 4;
            // 
            // cmbCombosPVD
            // 
            this.cmbCombosPVD.FormattingEnabled = true;
            this.cmbCombosPVD.Location = new System.Drawing.Point(123, 133);
            this.cmbCombosPVD.Name = "cmbCombosPVD";
            this.cmbCombosPVD.Size = new System.Drawing.Size(121, 24);
            this.cmbCombosPVD.TabIndex = 5;
            // 
            // btnAceptarPVD
            // 
            this.btnAceptarPVD.Location = new System.Drawing.Point(325, 234);
            this.btnAceptarPVD.Name = "btnAceptarPVD";
            this.btnAceptarPVD.Size = new System.Drawing.Size(75, 23);
            this.btnAceptarPVD.TabIndex = 6;
            this.btnAceptarPVD.Text = "Aceptar";
            this.btnAceptarPVD.UseVisualStyleBackColor = true;
            // 
            // btnCancelarPVD
            // 
            this.btnCancelarPVD.Location = new System.Drawing.Point(223, 234);
            this.btnCancelarPVD.Name = "btnCancelarPVD";
            this.btnCancelarPVD.Size = new System.Drawing.Size(75, 23);
            this.btnCancelarPVD.TabIndex = 7;
            this.btnCancelarPVD.Text = "Cancelar";
            this.btnCancelarPVD.UseVisualStyleBackColor = true;
            this.btnCancelarPVD.Click += new System.EventHandler(this.btnCancelarPVD_Click);
            // 
            // PuntodeVentaDulceriaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(422, 271);
            this.Controls.Add(this.btnCancelarPVD);
            this.Controls.Add(this.btnAceptarPVD);
            this.Controls.Add(this.cmbCombosPVD);
            this.Controls.Add(this.cmbProductosPVD);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "PuntodeVentaDulceriaForm";
            this.Text = "Punto de Venta Dulceria";
            this.Load += new System.EventHandler(this.PuntodeVentaDulceriaForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbProductosPVD;
        private System.Windows.Forms.ComboBox cmbCombosPVD;
        private System.Windows.Forms.Button btnAceptarPVD;
        private System.Windows.Forms.Button btnCancelarPVD;

    }
}