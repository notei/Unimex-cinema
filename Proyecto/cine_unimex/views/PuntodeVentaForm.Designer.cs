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
            this.label3 = new System.Windows.Forms.Label();
            this.cmbTipoBoletoPV = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAceptarPV = new System.Windows.Forms.Button();
            this.btnCancelarPV = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dgvPV = new System.Windows.Forms.DataGridView();
            this.listBox1 = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPV)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 324);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Tipo de Boleto:";
            // 
            // cmbTipoBoletoPV
            // 
            this.cmbTipoBoletoPV.FormattingEnabled = true;
            this.cmbTipoBoletoPV.Location = new System.Drawing.Point(164, 321);
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
            this.btnAceptarPV.Location = new System.Drawing.Point(629, 445);
            this.btnAceptarPV.Name = "btnAceptarPV";
            this.btnAceptarPV.Size = new System.Drawing.Size(75, 23);
            this.btnAceptarPV.TabIndex = 12;
            this.btnAceptarPV.Text = "Aceptar";
            this.btnAceptarPV.UseVisualStyleBackColor = true;
            this.btnAceptarPV.Click += new System.EventHandler(this.btnAceptarPV_Click);
            // 
            // btnCancelarPV
            // 
            this.btnCancelarPV.Location = new System.Drawing.Point(536, 445);
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
            this.label7.Location = new System.Drawing.Point(36, 370);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(123, 16);
            this.label7.TabIndex = 14;
            this.label7.Text = "Cantidad de Boletos:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(39, 411);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(101, 16);
            this.label8.TabIndex = 15;
            this.label8.Text = "Registrar el pago:";
            // 
            // dgvPV
            // 
            this.dgvPV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPV.Location = new System.Drawing.Point(42, 118);
            this.dgvPV.Name = "dgvPV";
            this.dgvPV.Size = new System.Drawing.Size(418, 168);
            this.dgvPV.TabIndex = 16;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(498, 78);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(132, 308);
            this.listBox1.TabIndex = 17;
            // 
            // PuntodeVentaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(724, 480);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.dgvPV);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnCancelarPV);
            this.Controls.Add(this.btnAceptarPV);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbTipoBoletoPV);
            this.Controls.Add(this.label3);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "PuntodeVentaForm";
            this.Text = "Punto de Venta Boletos";
            this.Load += new System.EventHandler(this.PuntodeVentaForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbTipoBoletoPV;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAceptarPV;
        private System.Windows.Forms.Button btnCancelarPV;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dgvPV;
        private System.Windows.Forms.ListBox listBox1;
    }
}