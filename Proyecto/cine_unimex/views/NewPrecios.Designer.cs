namespace unimex.lenguajesv.cine.views
{
    partial class NewPrecios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewPrecios));
            this.txtNombrenew = new System.Windows.Forms.TextBox();
            this.txtDescnew = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPrecionew = new System.Windows.Forms.TextBox();
            this.btnAgregarnew = new System.Windows.Forms.Button();
            this.btnCancelarnew = new System.Windows.Forms.Button();
            this.lblNewPrecios = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtNombrenew
            // 
            this.txtNombrenew.Location = new System.Drawing.Point(188, 58);
            this.txtNombrenew.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNombrenew.Name = "txtNombrenew";
            this.txtNombrenew.Size = new System.Drawing.Size(116, 21);
            this.txtNombrenew.TabIndex = 0;
            // 
            // txtDescnew
            // 
            this.txtDescnew.Location = new System.Drawing.Point(188, 100);
            this.txtDescnew.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtDescnew.Multiline = true;
            this.txtDescnew.Name = "txtDescnew";
            this.txtDescnew.Size = new System.Drawing.Size(136, 93);
            this.txtDescnew.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(69, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nombre del Boleto :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(106, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Descripción :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(124, 217);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Precio  $";
            // 
            // txtPrecionew
            // 
            this.txtPrecionew.Location = new System.Drawing.Point(188, 213);
            this.txtPrecionew.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPrecionew.Name = "txtPrecionew";
            this.txtPrecionew.Size = new System.Drawing.Size(116, 21);
            this.txtPrecionew.TabIndex = 5;
            // 
            // btnAgregarnew
            // 
            this.btnAgregarnew.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarnew.Location = new System.Drawing.Point(90, 262);
            this.btnAgregarnew.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAgregarnew.Name = "btnAgregarnew";
            this.btnAgregarnew.Size = new System.Drawing.Size(87, 28);
            this.btnAgregarnew.TabIndex = 6;
            this.btnAgregarnew.Text = "Agregar";
            this.btnAgregarnew.UseVisualStyleBackColor = true;
            this.btnAgregarnew.Click += new System.EventHandler(this.btnAgregarnew_Click);
            // 
            // btnCancelarnew
            // 
            this.btnCancelarnew.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelarnew.Location = new System.Drawing.Point(256, 262);
            this.btnCancelarnew.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCancelarnew.Name = "btnCancelarnew";
            this.btnCancelarnew.Size = new System.Drawing.Size(87, 28);
            this.btnCancelarnew.TabIndex = 7;
            this.btnCancelarnew.Text = "Cancelar";
            this.btnCancelarnew.UseVisualStyleBackColor = true;
            this.btnCancelarnew.Click += new System.EventHandler(this.btnCancelarnew_Click);
            // 
            // lblNewPrecios
            // 
            this.lblNewPrecios.AutoSize = true;
            this.lblNewPrecios.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNewPrecios.Location = new System.Drawing.Point(12, 9);
            this.lblNewPrecios.Name = "lblNewPrecios";
            this.lblNewPrecios.Size = new System.Drawing.Size(0, 33);
            this.lblNewPrecios.TabIndex = 8;
            // 
            // NewPrecios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(418, 328);
            this.Controls.Add(this.lblNewPrecios);
            this.Controls.Add(this.btnCancelarnew);
            this.Controls.Add(this.btnAgregarnew);
            this.Controls.Add(this.txtPrecionew);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDescnew);
            this.Controls.Add(this.txtNombrenew);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "NewPrecios";
            this.Text = "Nuevo Precio";
            this.Load += new System.EventHandler(this.NewPrecios_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNombrenew;
        private System.Windows.Forms.TextBox txtDescnew;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPrecionew;
        private System.Windows.Forms.Button btnAgregarnew;
        private System.Windows.Forms.Button btnCancelarnew;
        private System.Windows.Forms.Label lblNewPrecios;
    }
}