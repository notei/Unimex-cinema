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
            this.Idproducto = new System.Windows.Forms.Label();
            this.lblnombre = new System.Windows.Forms.Label();
            this.Lbldescripcion = new System.Windows.Forms.Label();
            this.btnradio = new System.Windows.Forms.RadioButton();
            this.txtidproducto = new System.Windows.Forms.TextBox();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.txtdescripcion = new System.Windows.Forms.TextBox();
            this.btnaceptar = new System.Windows.Forms.Button();
            this.btncancelar = new System.Windows.Forms.Button();
            this.txthabilitar = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Idproducto
            // 
            this.Idproducto.AutoSize = true;
            this.Idproducto.Location = new System.Drawing.Point(23, 43);
            this.Idproducto.Name = "Idproducto";
            this.Idproducto.Size = new System.Drawing.Size(64, 13);
            this.Idproducto.TabIndex = 0;
            this.Idproducto.Text = "Id_producto";
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
            // btnradio
            // 
            this.btnradio.AutoSize = true;
            this.btnradio.Location = new System.Drawing.Point(231, 232);
            this.btnradio.Name = "btnradio";
            this.btnradio.Size = new System.Drawing.Size(14, 13);
            this.btnradio.TabIndex = 3;
            this.btnradio.TabStop = true;
            this.btnradio.UseVisualStyleBackColor = true;
            // 
            // txtidproducto
            // 
            this.txtidproducto.Location = new System.Drawing.Point(278, 36);
            this.txtidproducto.Name = "txtidproducto";
            this.txtidproducto.Size = new System.Drawing.Size(100, 20);
            this.txtidproducto.TabIndex = 4;
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
            // NewProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(719, 392);
            this.Controls.Add(this.txthabilitar);
            this.Controls.Add(this.btncancelar);
            this.Controls.Add(this.btnaceptar);
            this.Controls.Add(this.txtdescripcion);
            this.Controls.Add(this.txtnombre);
            this.Controls.Add(this.txtidproducto);
            this.Controls.Add(this.btnradio);
            this.Controls.Add(this.Lbldescripcion);
            this.Controls.Add(this.lblnombre);
            this.Controls.Add(this.Idproducto);
            this.Name = "NewProductos";
            this.Text = "NewProductos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Idproducto;
        private System.Windows.Forms.Label lblnombre;
        private System.Windows.Forms.Label Lbldescripcion;
        private System.Windows.Forms.RadioButton btnradio;
        private System.Windows.Forms.TextBox txtidproducto;
        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.TextBox txtdescripcion;
        private System.Windows.Forms.Button btnaceptar;
        private System.Windows.Forms.Button btncancelar;
        private System.Windows.Forms.Label txthabilitar;
    }
}