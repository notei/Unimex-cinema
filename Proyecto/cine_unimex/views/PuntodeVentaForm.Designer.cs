namespace unimex.lenguajesv.cine.views
{
    partial class PuntodeVentaForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PuntodeVentaForm));
            this.cmbComplejosPV = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbPeliculaPV = new System.Windows.Forms.ComboBox();
            this.cmbSalaPV = new System.Windows.Forms.ComboBox();
            this.cmbHorarioPV = new System.Windows.Forms.ComboBox();
            this.cmbTipoBoletoPV = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAceptarPV = new System.Windows.Forms.Button();
            this.btnCancelarPV = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmbComplejosPV
            // 
            this.cmbComplejosPV.FormattingEnabled = true;
            this.cmbComplejosPV.Location = new System.Drawing.Point(161, 87);
            this.cmbComplejosPV.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbComplejosPV.Name = "cmbComplejosPV";
            this.cmbComplejosPV.Size = new System.Drawing.Size(121, 24);
            this.cmbComplejosPV.TabIndex = 0;
            this.cmbComplejosPV.SelectedIndexChanged += new System.EventHandler(this.cmbComplejosPV_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Complejos:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 284);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Tipo de Boleto:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 236);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Horario:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(33, 193);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 16);
            this.label5.TabIndex = 5;
            this.label5.Text = "Sala:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(36, 148);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 16);
            this.label6.TabIndex = 6;
            this.label6.Text = "Pelicula:";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // cmbPeliculaPV
            // 
            this.cmbPeliculaPV.FormattingEnabled = true;
            this.cmbPeliculaPV.Location = new System.Drawing.Point(161, 140);
            this.cmbPeliculaPV.Name = "cmbPeliculaPV";
            this.cmbPeliculaPV.Size = new System.Drawing.Size(121, 24);
            this.cmbPeliculaPV.TabIndex = 7;
            // 
            // cmbSalaPV
            // 
            this.cmbSalaPV.FormattingEnabled = true;
            this.cmbSalaPV.Location = new System.Drawing.Point(161, 185);
            this.cmbSalaPV.Name = "cmbSalaPV";
            this.cmbSalaPV.Size = new System.Drawing.Size(121, 24);
            this.cmbSalaPV.TabIndex = 8;
            // 
            // cmbHorarioPV
            // 
            this.cmbHorarioPV.FormattingEnabled = true;
            this.cmbHorarioPV.Location = new System.Drawing.Point(161, 236);
            this.cmbHorarioPV.Name = "cmbHorarioPV";
            this.cmbHorarioPV.Size = new System.Drawing.Size(121, 24);
            this.cmbHorarioPV.TabIndex = 9;
            // 
            // cmbTipoBoletoPV
            // 
            this.cmbTipoBoletoPV.FormattingEnabled = true;
            this.cmbTipoBoletoPV.Location = new System.Drawing.Point(161, 281);
            this.cmbTipoBoletoPV.Name = "cmbTipoBoletoPV";
            this.cmbTipoBoletoPV.Size = new System.Drawing.Size(121, 24);
            this.cmbTipoBoletoPV.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(111, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(317, 32);
            this.label2.TabIndex = 11;
            this.label2.Text = "Punto de Venta Boletos";
            // 
            // btnAceptarPV
            // 
            this.btnAceptarPV.Location = new System.Drawing.Point(415, 421);
            this.btnAceptarPV.Name = "btnAceptarPV";
            this.btnAceptarPV.Size = new System.Drawing.Size(75, 23);
            this.btnAceptarPV.TabIndex = 12;
            this.btnAceptarPV.Text = "Aceptar";
            this.btnAceptarPV.UseVisualStyleBackColor = true;
            // 
            // btnCancelarPV
            // 
            this.btnCancelarPV.Location = new System.Drawing.Point(322, 421);
            this.btnCancelarPV.Name = "btnCancelarPV";
            this.btnCancelarPV.Size = new System.Drawing.Size(75, 23);
            this.btnCancelarPV.TabIndex = 13;
            this.btnCancelarPV.Text = "Cancelar";
            this.btnCancelarPV.UseVisualStyleBackColor = true;
            this.btnCancelarPV.Click += new System.EventHandler(this.btnCancelarPV_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(33, 330);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(123, 16);
            this.label7.TabIndex = 14;
            this.label7.Text = "Cantidad de Boletos:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(36, 371);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(101, 16);
            this.label8.TabIndex = 15;
            this.label8.Text = "Registrar el pago:";
            // 
            // PuntodeVentaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(496, 454);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnCancelarPV);
            this.Controls.Add(this.btnAceptarPV);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbTipoBoletoPV);
            this.Controls.Add(this.cmbHorarioPV);
            this.Controls.Add(this.cmbSalaPV);
            this.Controls.Add(this.cmbPeliculaPV);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbComplejosPV);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "PuntodeVentaForm";
            this.Text = "Punto de Venta Boletos";
            this.Load += new System.EventHandler(this.PuntodeVentaForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbComplejosPV;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbPeliculaPV;
        private System.Windows.Forms.ComboBox cmbSalaPV;
        private System.Windows.Forms.ComboBox cmbHorarioPV;
        private System.Windows.Forms.ComboBox cmbTipoBoletoPV;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAceptarPV;
        private System.Windows.Forms.Button btnCancelarPV;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}