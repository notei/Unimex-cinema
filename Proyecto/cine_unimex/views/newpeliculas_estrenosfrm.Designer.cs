namespace unimex.lenguajesv.cine.Resources
{
    partial class peliculas_estrenosfrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(peliculas_estrenosfrm));
            this.txtfecha = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txthabilitado = new System.Windows.Forms.NumericUpDown();
            this.txtestreno = new System.Windows.Forms.NumericUpDown();
            this.txtpelicula = new System.Windows.Forms.NumericUpDown();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.txthabilitado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtestreno)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtpelicula)).BeginInit();
            this.SuspendLayout();
            // 
            // txtfecha
            // 
            this.txtfecha.Location = new System.Drawing.Point(153, 168);
            this.txtfecha.Name = "txtfecha";
            this.txtfecha.Size = new System.Drawing.Size(100, 20);
            this.txtfecha.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "id_estreno";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "id_pelicula";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 171);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Fecha_estreno";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(49, 220);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "habilitado";
            // 
            // txthabilitado
            // 
            this.txthabilitado.Location = new System.Drawing.Point(153, 218);
            this.txthabilitado.Name = "txthabilitado";
            this.txthabilitado.Size = new System.Drawing.Size(120, 20);
            this.txthabilitado.TabIndex = 7;
            // 
            // txtestreno
            // 
            this.txtestreno.Location = new System.Drawing.Point(153, 58);
            this.txtestreno.Name = "txtestreno";
            this.txtestreno.Size = new System.Drawing.Size(120, 20);
            this.txtestreno.TabIndex = 8;
            // 
            // txtpelicula
            // 
            this.txtpelicula.Location = new System.Drawing.Point(153, 114);
            this.txtpelicula.Name = "txtpelicula";
            this.txtpelicula.Size = new System.Drawing.Size(120, 20);
            this.txtpelicula.TabIndex = 9;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(72, 292);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 10;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(223, 288);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 11;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // peliculas_estrenosfrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(358, 331);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.txtpelicula);
            this.Controls.Add(this.txtestreno);
            this.Controls.Add(this.txthabilitado);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtfecha);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "peliculas_estrenosfrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "peliculas_estrenosfrm";
            this.Load += new System.EventHandler(this.peliculas_estrenosfrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txthabilitado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtestreno)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtpelicula)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtfecha;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown txthabilitado;
        private System.Windows.Forms.NumericUpDown txtestreno;
        private System.Windows.Forms.NumericUpDown txtpelicula;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAgregar;
    }
}