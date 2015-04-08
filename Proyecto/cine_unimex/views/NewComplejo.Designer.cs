namespace unimex.lenguajesv.cine.views
{
    partial class NewComplejo
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
            this.btnAgregarCom = new System.Windows.Forms.Button();
            this.btnCancelarCom = new System.Windows.Forms.Button();
            this.txtNombreCompl = new System.Windows.Forms.TextBox();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.chkHabilitadoCompl = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAgregarCom
            // 
            this.btnAgregarCom.Location = new System.Drawing.Point(78, 272);
            this.btnAgregarCom.Name = "btnAgregarCom";
            this.btnAgregarCom.Size = new System.Drawing.Size(75, 23);
            this.btnAgregarCom.TabIndex = 0;
            this.btnAgregarCom.Text = "Agregar";
            this.btnAgregarCom.UseVisualStyleBackColor = true;
            this.btnAgregarCom.Click += new System.EventHandler(this.btnAgregarCom_Click);
            // 
            // btnCancelarCom
            // 
            this.btnCancelarCom.Location = new System.Drawing.Point(196, 272);
            this.btnCancelarCom.Name = "btnCancelarCom";
            this.btnCancelarCom.Size = new System.Drawing.Size(75, 23);
            this.btnCancelarCom.TabIndex = 1;
            this.btnCancelarCom.Text = "Cancelar";
            this.btnCancelarCom.UseVisualStyleBackColor = true;
            // 
            // txtNombreCompl
            // 
            this.txtNombreCompl.Location = new System.Drawing.Point(121, 51);
            this.txtNombreCompl.Name = "txtNombreCompl";
            this.txtNombreCompl.Size = new System.Drawing.Size(100, 20);
            this.txtNombreCompl.TabIndex = 2;
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(121, 106);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(100, 20);
            this.txtDireccion.TabIndex = 3;
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(121, 151);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(100, 20);
            this.txtTelefono.TabIndex = 4;
            // 
            // chkHabilitadoCompl
            // 
            this.chkHabilitadoCompl.AutoSize = true;
            this.chkHabilitadoCompl.Location = new System.Drawing.Point(121, 205);
            this.chkHabilitadoCompl.Name = "chkHabilitadoCompl";
            this.chkHabilitadoCompl.Size = new System.Drawing.Size(15, 14);
            this.chkHabilitadoCompl.TabIndex = 5;
            this.chkHabilitadoCompl.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Direccion";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Telefono";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(42, 205);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Habilitado";
            // 
            // NewComplejo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(356, 328);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chkHabilitadoCompl);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.txtDireccion);
            this.Controls.Add(this.txtNombreCompl);
            this.Controls.Add(this.btnCancelarCom);
            this.Controls.Add(this.btnAgregarCom);
            this.Name = "NewComplejo";
            this.Text = "NewComplejo";
            this.Load += new System.EventHandler(this.NewComplejo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAgregarCom;
        private System.Windows.Forms.Button btnCancelarCom;
        private System.Windows.Forms.TextBox txtNombreCompl;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.CheckBox chkHabilitadoCompl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}