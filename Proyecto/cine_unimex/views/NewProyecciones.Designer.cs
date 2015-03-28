namespace unimex.lenguajesv.cine.views
{
    partial class NewProyecciones
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
            this.idsalaTXT = new System.Windows.Forms.TextBox();
            this.idpeliculaTXT = new System.Windows.Forms.TextBox();
            this.Horario = new System.Windows.Forms.DateTimePicker();
            this.Cancelbtn = new System.Windows.Forms.Button();
            this.acceptbtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // idsalaTXT
            // 
            this.idsalaTXT.Location = new System.Drawing.Point(95, 59);
            this.idsalaTXT.Name = "idsalaTXT";
            this.idsalaTXT.Size = new System.Drawing.Size(151, 22);
            this.idsalaTXT.TabIndex = 0;
            // 
            // idpeliculaTXT
            // 
            this.idpeliculaTXT.Location = new System.Drawing.Point(95, 108);
            this.idpeliculaTXT.Name = "idpeliculaTXT";
            this.idpeliculaTXT.Size = new System.Drawing.Size(151, 22);
            this.idpeliculaTXT.TabIndex = 1;
            // 
            // Horario
            // 
            this.Horario.Location = new System.Drawing.Point(95, 155);
            this.Horario.Name = "Horario";
            this.Horario.Size = new System.Drawing.Size(200, 22);
            this.Horario.TabIndex = 2;
            // 
            // Cancelbtn
            // 
            this.Cancelbtn.Location = new System.Drawing.Point(8, 226);
            this.Cancelbtn.Name = "Cancelbtn";
            this.Cancelbtn.Size = new System.Drawing.Size(75, 28);
            this.Cancelbtn.TabIndex = 3;
            this.Cancelbtn.Text = "&Cancelar";
            this.Cancelbtn.UseVisualStyleBackColor = true;
            this.Cancelbtn.Click += new System.EventHandler(this.Cancelbtn_Click);
            // 
            // acceptbtn
            // 
            this.acceptbtn.Location = new System.Drawing.Point(171, 226);
            this.acceptbtn.Name = "acceptbtn";
            this.acceptbtn.Size = new System.Drawing.Size(75, 28);
            this.acceptbtn.TabIndex = 4;
            this.acceptbtn.Text = "&Aceptar";
            this.acceptbtn.UseVisualStyleBackColor = true;
            this.acceptbtn.Click += new System.EventHandler(this.acceptbtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "idsala:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "idpelicula:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "horario:";
            // 
            // NewProyecciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(309, 295);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.acceptbtn);
            this.Controls.Add(this.Cancelbtn);
            this.Controls.Add(this.Horario);
            this.Controls.Add(this.idpeliculaTXT);
            this.Controls.Add(this.idsalaTXT);
            this.Name = "NewProyecciones";
            this.Text = "NewProyecciones";
            this.Load += new System.EventHandler(this.NewProyecciones_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox idsalaTXT;
        private System.Windows.Forms.TextBox idpeliculaTXT;
        private System.Windows.Forms.DateTimePicker Horario;
        private System.Windows.Forms.Button Cancelbtn;
        private System.Windows.Forms.Button acceptbtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}