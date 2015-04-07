namespace unimex.lenguajesv.cine.views
{
    partial class NewProveedores
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewProveedores));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnaceptar = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.checkpro = new System.Windows.Forms.CheckBox();
            this.txtnamepro = new System.Windows.Forms.TextBox();
            this.txtdetallespro = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(29, 123);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre de Proveedor";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(29, 184);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Detalles del Proveedor";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(30, 245);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Habilitado";
            // 
            // btnaceptar
            // 
            this.btnaceptar.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnaceptar.Location = new System.Drawing.Point(279, 315);
            this.btnaceptar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnaceptar.Name = "btnaceptar";
            this.btnaceptar.Size = new System.Drawing.Size(87, 28);
            this.btnaceptar.TabIndex = 3;
            this.btnaceptar.Text = "Aceptar ";
            this.btnaceptar.UseVisualStyleBackColor = true;
            this.btnaceptar.Click += new System.EventHandler(this.btnaceptar_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(32, 315);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(87, 28);
            this.button2.TabIndex = 4;
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // checkpro
            // 
            this.checkpro.AutoSize = true;
            this.checkpro.Location = new System.Drawing.Point(250, 245);
            this.checkpro.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.checkpro.Name = "checkpro";
            this.checkpro.Size = new System.Drawing.Size(15, 14);
            this.checkpro.TabIndex = 5;
            this.checkpro.UseVisualStyleBackColor = true;
            // 
            // txtnamepro
            // 
            this.txtnamepro.Location = new System.Drawing.Point(250, 113);
            this.txtnamepro.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtnamepro.Name = "txtnamepro";
            this.txtnamepro.Size = new System.Drawing.Size(116, 21);
            this.txtnamepro.TabIndex = 6;
            // 
            // txtdetallespro
            // 
            this.txtdetallespro.Location = new System.Drawing.Point(250, 184);
            this.txtdetallespro.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtdetallespro.Name = "txtdetallespro";
            this.txtdetallespro.Size = new System.Drawing.Size(116, 21);
            this.txtdetallespro.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(115, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(186, 32);
            this.label4.TabIndex = 8;
            this.label4.Text = "Proveedores ";
            // 
            // NewProveedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(423, 380);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtdetallespro);
            this.Controls.Add(this.txtnamepro);
            this.Controls.Add(this.checkpro);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnaceptar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "NewProveedores";
            this.Text = "NewProveedores";
            this.Load += new System.EventHandler(this.NewProveedores_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnaceptar;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.CheckBox checkpro;
        private System.Windows.Forms.TextBox txtnamepro;
        private System.Windows.Forms.TextBox txtdetallespro;
        private System.Windows.Forms.Label label4;
    }
}