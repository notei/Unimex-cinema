namespace unimex.lenguajesv.cine.views
{
    partial class NewProductos
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
            this.lblnombre = new System.Windows.Forms.Label();
            this.Lbldescripcion = new System.Windows.Forms.Label();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.txtdescripcion = new System.Windows.Forms.TextBox();
            this.btnaceptar = new System.Windows.Forms.Button();
            this.btncancelar = new System.Windows.Forms.Button();
            this.txthabilitar = new System.Windows.Forms.Label();
            this.btncheck = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // lblnombre
            // 
            this.lblnombre.AutoSize = true;
            this.lblnombre.Location = new System.Drawing.Point(20, 107);
            this.lblnombre.Name = "lblnombre";
            this.lblnombre.Size = new System.Drawing.Size(44, 13);
            this.lblnombre.TabIndex = 1;
            this.lblnombre.Text = "Nombre";
            // 
            // Lbldescripcion
            // 
            this.Lbldescripcion.AutoSize = true;
            this.Lbldescripcion.Location = new System.Drawing.Point(23, 168);
            this.Lbldescripcion.Name = "Lbldescripcion";
            this.Lbldescripcion.Size = new System.Drawing.Size(63, 13);
            this.Lbldescripcion.TabIndex = 2;
            this.Lbldescripcion.Text = "Descripcion";
            // 
            // txtnombre
            // 
            this.txtnombre.Location = new System.Drawing.Point(278, 107);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(100, 20);
            this.txtnombre.TabIndex = 5;
            // 
            // txtdescripcion
            // 
            this.txtdescripcion.Location = new System.Drawing.Point(278, 168);
            this.txtdescripcion.Name = "txtdescripcion";
            this.txtdescripcion.Size = new System.Drawing.Size(100, 20);
            this.txtdescripcion.TabIndex = 6;
            // 
            // btnaceptar
            // 
            this.btnaceptar.Location = new System.Drawing.Point(170, 324);
            this.btnaceptar.Name = "btnaceptar";
            this.btnaceptar.Size = new System.Drawing.Size(75, 23);
            this.btnaceptar.TabIndex = 8;
            this.btnaceptar.Text = "Aceptar";
            this.btnaceptar.UseVisualStyleBackColor = true;
            this.btnaceptar.Click += new System.EventHandler(this.btnaceptar_Click);
            // 
            // btncancelar
            // 
            this.btncancelar.Location = new System.Drawing.Point(406, 324);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(75, 23);
            this.btncancelar.TabIndex = 9;
            this.btncancelar.Text = "Cancelar";
            this.btncancelar.UseVisualStyleBackColor = true;
            this.btncancelar.Click += new System.EventHandler(this.btncancelar_Click);
            // 
            // txthabilitar
            // 
            this.txthabilitar.AutoSize = true;
            this.txthabilitar.Location = new System.Drawing.Point(23, 232);
            this.txthabilitar.Name = "txthabilitar";
            this.txthabilitar.Size = new System.Drawing.Size(45, 13);
            this.txthabilitar.TabIndex = 10;
            this.txthabilitar.Text = "Habilitar";
            // 
            // btncheck
            // 
            this.btncheck.AutoSize = true;
            this.btncheck.Location = new System.Drawing.Point(268, 232);
            this.btncheck.Name = "btncheck";
            this.btncheck.Size = new System.Drawing.Size(15, 14);
            this.btncheck.TabIndex = 11;
            this.btncheck.UseVisualStyleBackColor = true;
            // 
            // NewProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(719, 392);
            this.Controls.Add(this.btncheck);
            this.Controls.Add(this.txthabilitar);
            this.Controls.Add(this.btncancelar);
            this.Controls.Add(this.btnaceptar);
            this.Controls.Add(this.txtdescripcion);
            this.Controls.Add(this.txtnombre);
            this.Controls.Add(this.Lbldescripcion);
            this.Controls.Add(this.lblnombre);
            this.Name = "NewProductos";
            this.Text = "NewProductos";
            this.Load += new System.EventHandler(this.NewProductos_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblnombre;
        private System.Windows.Forms.Label Lbldescripcion;
        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.TextBox txtdescripcion;
        private System.Windows.Forms.Button btnaceptar;
        private System.Windows.Forms.Button btncancelar;
        private System.Windows.Forms.Label txthabilitar;
        private System.Windows.Forms.CheckBox btncheck;
    }
}