namespace unimex.lenguajesv.cine.views.views
{
    partial class LoginScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginScreen));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.usuarioTxt = new System.Windows.Forms.TextBox();
            this.contrasenaTxt = new System.Windows.Forms.TextBox();
            this.entrarBtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.limpiarBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(96, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre de usuario";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(136, 166);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Contraseña";
            // 
            // usuarioTxt
            // 
            this.usuarioTxt.Location = new System.Drawing.Point(226, 117);
            this.usuarioTxt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.usuarioTxt.Name = "usuarioTxt";
            this.usuarioTxt.Size = new System.Drawing.Size(116, 21);
            this.usuarioTxt.TabIndex = 2;
            // 
            // contrasenaTxt
            // 
            this.contrasenaTxt.Location = new System.Drawing.Point(226, 158);
            this.contrasenaTxt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.contrasenaTxt.Name = "contrasenaTxt";
            this.contrasenaTxt.PasswordChar = '*';
            this.contrasenaTxt.Size = new System.Drawing.Size(116, 21);
            this.contrasenaTxt.TabIndex = 3;
            // 
            // entrarBtn
            // 
            this.entrarBtn.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.entrarBtn.Location = new System.Drawing.Point(99, 208);
            this.entrarBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.entrarBtn.Name = "entrarBtn";
            this.entrarBtn.Size = new System.Drawing.Size(87, 28);
            this.entrarBtn.TabIndex = 4;
            this.entrarBtn.Text = "Entrada";
            this.entrarBtn.UseVisualStyleBackColor = true;
            this.entrarBtn.Click += new System.EventHandler(this.entrarBtn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::unimex.lenguajesv.cine.Properties.Resources.ticket;
            this.pictureBox1.Location = new System.Drawing.Point(407, 59);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(128, 128);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(96, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(261, 32);
            this.label3.TabIndex = 6;
            this.label3.Text = "Entrada de usuario";
            // 
            // limpiarBtn
            // 
            this.limpiarBtn.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.limpiarBtn.Location = new System.Drawing.Point(255, 208);
            this.limpiarBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.limpiarBtn.Name = "limpiarBtn";
            this.limpiarBtn.Size = new System.Drawing.Size(87, 28);
            this.limpiarBtn.TabIndex = 7;
            this.limpiarBtn.Text = "Limpiar";
            this.limpiarBtn.UseVisualStyleBackColor = true;
            this.limpiarBtn.Click += new System.EventHandler(this.limpiarBtn_Click);
            // 
            // LoginScreen
            // 
            this.AcceptButton = this.entrarBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 321);
            this.Controls.Add(this.limpiarBtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.entrarBtn);
            this.Controls.Add(this.contrasenaTxt);
            this.Controls.Add(this.usuarioTxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LoginScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cine Unimex - Entrada de usuarios";
            this.Load += new System.EventHandler(this.LoginScreen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox usuarioTxt;
        private System.Windows.Forms.TextBox contrasenaTxt;
        private System.Windows.Forms.Button entrarBtn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button limpiarBtn;
    }
}