namespace unimex.lenguajesv.cine.views
{
    partial class NewUsuarios
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.nombreuser = new System.Windows.Forms.TextBox();
            this.apuser = new System.Windows.Forms.TextBox();
            this.nomus = new System.Windows.Forms.TextBox();
            this.passuser = new System.Windows.Forms.TextBox();
            this.idtuser = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Apellido Peterno";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(43, 191);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Nombre ususario";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(43, 237);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Contraseña";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(43, 286);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Id Tip Usuario";
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(305, 390);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 6;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click_1);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(41, 390);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 7;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click_1);
            // 
            // nombreuser
            // 
            this.nombreuser.Location = new System.Drawing.Point(257, 78);
            this.nombreuser.Name = "nombreuser";
            this.nombreuser.Size = new System.Drawing.Size(100, 20);
            this.nombreuser.TabIndex = 9;
            // 
            // apuser
            // 
            this.apuser.Location = new System.Drawing.Point(257, 131);
            this.apuser.Name = "apuser";
            this.apuser.Size = new System.Drawing.Size(100, 20);
            this.apuser.TabIndex = 10;
            // 
            // nomus
            // 
            this.nomus.Location = new System.Drawing.Point(257, 184);
            this.nomus.Name = "nomus";
            this.nomus.Size = new System.Drawing.Size(100, 20);
            this.nomus.TabIndex = 11;
            // 
            // passuser
            // 
            this.passuser.Location = new System.Drawing.Point(257, 234);
            this.passuser.Name = "passuser";
            this.passuser.Size = new System.Drawing.Size(100, 20);
            this.passuser.TabIndex = 12;
            // 
            // idtuser
            // 
            this.idtuser.Location = new System.Drawing.Point(257, 281);
            this.idtuser.Name = "idtuser";
            this.idtuser.Size = new System.Drawing.Size(100, 20);
            this.idtuser.TabIndex = 13;
            // 
            // NewUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 443);
            this.Controls.Add(this.idtuser);
            this.Controls.Add(this.passuser);
            this.Controls.Add(this.nomus);
            this.Controls.Add(this.apuser);
            this.Controls.Add(this.nombreuser);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "NewUsuarios";
            this.Text = "NewUsuarios";
            this.Load += new System.EventHandler(this.NewUsuarios_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.TextBox nombreuser;
        private System.Windows.Forms.TextBox apuser;
        private System.Windows.Forms.TextBox nomus;
        private System.Windows.Forms.TextBox passuser;
        private System.Windows.Forms.TextBox idtuser;
    }
}