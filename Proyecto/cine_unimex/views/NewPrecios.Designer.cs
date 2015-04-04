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
            this.txtNombrenew = new System.Windows.Forms.TextBox();
            this.txtDescnew = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPrecionew = new System.Windows.Forms.TextBox();
            this.btnAgregarnew = new System.Windows.Forms.Button();
            this.btnCancelarnew = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtNombrenew
            // 
            this.txtNombrenew.Location = new System.Drawing.Point(97, 60);
            this.txtNombrenew.Name = "txtNombrenew";
            this.txtNombrenew.Size = new System.Drawing.Size(100, 20);
            this.txtNombrenew.TabIndex = 0;
            // 
            // txtDescnew
            // 
            this.txtDescnew.Location = new System.Drawing.Point(97, 114);
            this.txtDescnew.Multiline = true;
            this.txtDescnew.Name = "txtDescnew";
            this.txtDescnew.Size = new System.Drawing.Size(117, 76);
            this.txtDescnew.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nombre :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Descripción :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 231);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Precio : $";
            // 
            // txtPrecionew
            // 
            this.txtPrecionew.Location = new System.Drawing.Point(97, 228);
            this.txtPrecionew.Name = "txtPrecionew";
            this.txtPrecionew.Size = new System.Drawing.Size(100, 20);
            this.txtPrecionew.TabIndex = 5;
            // 
            // btnAgregarnew
            // 
            this.btnAgregarnew.Location = new System.Drawing.Point(42, 279);
            this.btnAgregarnew.Name = "btnAgregarnew";
            this.btnAgregarnew.Size = new System.Drawing.Size(75, 23);
            this.btnAgregarnew.TabIndex = 6;
            this.btnAgregarnew.Text = "Agregar";
            this.btnAgregarnew.UseVisualStyleBackColor = true;
            this.btnAgregarnew.Click += new System.EventHandler(this.btnAgregarnew_Click);
            // 
            // btnCancelarnew
            // 
            this.btnCancelarnew.Location = new System.Drawing.Point(177, 279);
            this.btnCancelarnew.Name = "btnCancelarnew";
            this.btnCancelarnew.Size = new System.Drawing.Size(75, 23);
            this.btnCancelarnew.TabIndex = 7;
            this.btnCancelarnew.Text = "Agregar";
            this.btnCancelarnew.UseVisualStyleBackColor = true;
            this.btnCancelarnew.Click += new System.EventHandler(this.btnCancelarnew_Click);
            // 
            // NewPrecios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 325);
            this.Controls.Add(this.btnCancelarnew);
            this.Controls.Add(this.btnAgregarnew);
            this.Controls.Add(this.txtPrecionew);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDescnew);
            this.Controls.Add(this.txtNombrenew);
            this.Name = "NewPrecios";
            this.Text = "Nuevo Precio";
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
    }
}