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
            this.idptxt = new System.Windows.Forms.TextBox();
            this.nombrectxt = new System.Windows.Forms.TextBox();
            this.duraciontxt = new System.Windows.Forms.TextBox();
            this.htxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.aceptarbtn = new System.Windows.Forms.Button();
            this.cancelarbtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // idptxt
            // 
            this.idptxt.Location = new System.Drawing.Point(113, 39);
            this.idptxt.Name = "idptxt";
            this.idptxt.Size = new System.Drawing.Size(166, 20);
            this.idptxt.TabIndex = 0;
            // 
            // nombrectxt
            // 
            this.nombrectxt.Location = new System.Drawing.Point(113, 91);
            this.nombrectxt.Name = "nombrectxt";
            this.nombrectxt.Size = new System.Drawing.Size(166, 20);
            this.nombrectxt.TabIndex = 1;
            // 
            // duraciontxt
            // 
            this.duraciontxt.Location = new System.Drawing.Point(113, 148);
            this.duraciontxt.Name = "duraciontxt";
            this.duraciontxt.Size = new System.Drawing.Size(166, 20);
            this.duraciontxt.TabIndex = 2;
            // 
            // htxt
            // 
            this.htxt.Location = new System.Drawing.Point(113, 204);
            this.htxt.Name = "htxt";
            this.htxt.Size = new System.Drawing.Size(166, 20);
            this.htxt.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Id_Pelicula:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Nombre_Corto:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Duracion:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(35, 211);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Habilitado:";
            // 
            // aceptarbtn
            // 
            this.aceptarbtn.Location = new System.Drawing.Point(34, 282);
            this.aceptarbtn.Name = "aceptarbtn";
            this.aceptarbtn.Size = new System.Drawing.Size(75, 23);
            this.aceptarbtn.TabIndex = 8;
            this.aceptarbtn.Text = "Aceptar";
            this.aceptarbtn.UseVisualStyleBackColor = true;
            this.aceptarbtn.Click += new System.EventHandler(this.aceptarbtn_Click);
            // 
            // cancelarbtn
            // 
            this.cancelarbtn.Location = new System.Drawing.Point(204, 282);
            this.cancelarbtn.Name = "cancelarbtn";
            this.cancelarbtn.Size = new System.Drawing.Size(75, 23);
            this.cancelarbtn.TabIndex = 9;
            this.cancelarbtn.Text = "Cancelar";
            this.cancelarbtn.UseVisualStyleBackColor = true;
            this.cancelarbtn.Click += new System.EventHandler(this.cancelarbtn_Click);
            // 
            // NewCortos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(416, 368);
            this.Controls.Add(this.cancelarbtn);
            this.Controls.Add(this.aceptarbtn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.htxt);
            this.Controls.Add(this.duraciontxt);
            this.Controls.Add(this.nombrectxt);
            this.Controls.Add(this.idptxt);
            this.Name = "NewCortos";
            this.Text = "NewCortos";
            this.Load += new System.EventHandler(this.NewCortos_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox idptxt;
        private System.Windows.Forms.TextBox duraciontxt;
        private System.Windows.Forms.TextBox htxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button aceptarbtn;
        private System.Windows.Forms.Button cancelarbtn;
        public System.Windows.Forms.TextBox nombrectxt;
    }
}