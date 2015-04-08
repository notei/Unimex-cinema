namespace unimex.lenguajesv.cine.views
{
    partial class NewCortos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewCortos));
            this.idptxt = new System.Windows.Forms.TextBox();
            this.nombrectxt = new System.Windows.Forms.TextBox();
            this.duraciontxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.aceptarbtn = new System.Windows.Forms.Button();
            this.cancelarbtn = new System.Windows.Forms.Button();
            this.check = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // idptxt
            // 
            this.idptxt.Location = new System.Drawing.Point(151, 51);
            this.idptxt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.idptxt.Name = "idptxt";
            this.idptxt.Size = new System.Drawing.Size(220, 23);
            this.idptxt.TabIndex = 0;
            // 
            // nombrectxt
            // 
            this.nombrectxt.Location = new System.Drawing.Point(151, 119);
            this.nombrectxt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.nombrectxt.Name = "nombrectxt";
            this.nombrectxt.Size = new System.Drawing.Size(220, 23);
            this.nombrectxt.TabIndex = 1;
            // 
            // duraciontxt
            // 
            this.duraciontxt.Location = new System.Drawing.Point(151, 193);
            this.duraciontxt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.duraciontxt.Name = "duraciontxt";
            this.duraciontxt.Size = new System.Drawing.Size(220, 23);
            this.duraciontxt.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 51);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 19);
            this.label1.TabIndex = 4;
            this.label1.Text = "Id_Pelicula:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 119);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 19);
            this.label2.TabIndex = 5;
            this.label2.Text = "Nombre_Corto:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(47, 193);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 19);
            this.label3.TabIndex = 6;
            this.label3.Text = "Duracion:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(47, 276);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 19);
            this.label4.TabIndex = 7;
            this.label4.Text = "Habilitado:";
            // 
            // aceptarbtn
            // 
            this.aceptarbtn.Location = new System.Drawing.Point(45, 369);
            this.aceptarbtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.aceptarbtn.Name = "aceptarbtn";
            this.aceptarbtn.Size = new System.Drawing.Size(100, 30);
            this.aceptarbtn.TabIndex = 8;
            this.aceptarbtn.Text = "Aceptar";
            this.aceptarbtn.UseVisualStyleBackColor = true;
            this.aceptarbtn.Click += new System.EventHandler(this.aceptarbtn_Click);
            // 
            // cancelarbtn
            // 
            this.cancelarbtn.Location = new System.Drawing.Point(272, 369);
            this.cancelarbtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cancelarbtn.Name = "cancelarbtn";
            this.cancelarbtn.Size = new System.Drawing.Size(100, 30);
            this.cancelarbtn.TabIndex = 9;
            this.cancelarbtn.Text = "Cancelar";
            this.cancelarbtn.UseVisualStyleBackColor = true;
            this.cancelarbtn.Click += new System.EventHandler(this.cancelarbtn_Click);
            // 
            // check
            // 
            this.check.AutoSize = true;
            this.check.Location = new System.Drawing.Point(151, 270);
            this.check.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.check.Name = "check";
            this.check.Size = new System.Drawing.Size(18, 17);
            this.check.TabIndex = 10;
            this.check.UseVisualStyleBackColor = true;
            // 
            // NewCortos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(555, 481);
            this.Controls.Add(this.check);
            this.Controls.Add(this.cancelarbtn);
            this.Controls.Add(this.aceptarbtn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.duraciontxt);
            this.Controls.Add(this.nombrectxt);
            this.Controls.Add(this.idptxt);
            this.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "NewCortos";
            this.Text = "NewCortos";
            this.Load += new System.EventHandler(this.NewCortos_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox idptxt;
        private System.Windows.Forms.TextBox duraciontxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button aceptarbtn;
        private System.Windows.Forms.Button cancelarbtn;
        public System.Windows.Forms.TextBox nombrectxt;
        private System.Windows.Forms.CheckBox check;
    }
}