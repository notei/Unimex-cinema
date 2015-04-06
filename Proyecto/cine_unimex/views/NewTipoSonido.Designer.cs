namespace unimex.lenguajesv.cine.views
{
    partial class NewTipoSonido
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTipoSonidoNew = new System.Windows.Forms.TextBox();
            this.txtDescripcionNew = new System.Windows.Forms.TextBox();
            this.chkHabilitadoNew = new System.Windows.Forms.CheckBox();
            this.btnNuevoNew = new System.Windows.Forms.Button();
            this.btnCancelarNew = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tipo de Sonido :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Descripción :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 191);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Habilitado :";
            // 
            // txtTipoSonidoNew
            // 
            this.txtTipoSonidoNew.Location = new System.Drawing.Point(115, 48);
            this.txtTipoSonidoNew.Name = "txtTipoSonidoNew";
            this.txtTipoSonidoNew.Size = new System.Drawing.Size(100, 20);
            this.txtTipoSonidoNew.TabIndex = 3;
            // 
            // txtDescripcionNew
            // 
            this.txtDescripcionNew.Location = new System.Drawing.Point(115, 107);
            this.txtDescripcionNew.Multiline = true;
            this.txtDescripcionNew.Name = "txtDescripcionNew";
            this.txtDescripcionNew.Size = new System.Drawing.Size(100, 56);
            this.txtDescripcionNew.TabIndex = 4;
            // 
            // chkHabilitadoNew
            // 
            this.chkHabilitadoNew.AutoSize = true;
            this.chkHabilitadoNew.Location = new System.Drawing.Point(115, 187);
            this.chkHabilitadoNew.Name = "chkHabilitadoNew";
            this.chkHabilitadoNew.Size = new System.Drawing.Size(15, 14);
            this.chkHabilitadoNew.TabIndex = 5;
            this.chkHabilitadoNew.UseVisualStyleBackColor = true;
            // 
            // btnNuevoNew
            // 
            this.btnNuevoNew.Location = new System.Drawing.Point(55, 236);
            this.btnNuevoNew.Name = "btnNuevoNew";
            this.btnNuevoNew.Size = new System.Drawing.Size(75, 23);
            this.btnNuevoNew.TabIndex = 6;
            this.btnNuevoNew.Text = "Nuevo";
            this.btnNuevoNew.UseVisualStyleBackColor = true;
            this.btnNuevoNew.Click += new System.EventHandler(this.btnNuevoNew_Click);
            // 
            // btnCancelarNew
            // 
            this.btnCancelarNew.Location = new System.Drawing.Point(189, 235);
            this.btnCancelarNew.Name = "btnCancelarNew";
            this.btnCancelarNew.Size = new System.Drawing.Size(75, 23);
            this.btnCancelarNew.TabIndex = 7;
            this.btnCancelarNew.Text = "Cancelar";
            this.btnCancelarNew.UseVisualStyleBackColor = true;
            this.btnCancelarNew.Click += new System.EventHandler(this.btnCancelarNew_Click);
            // 
            // NewTipoSonido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(315, 291);
            this.Controls.Add(this.btnCancelarNew);
            this.Controls.Add(this.btnNuevoNew);
            this.Controls.Add(this.chkHabilitadoNew);
            this.Controls.Add(this.txtDescripcionNew);
            this.Controls.Add(this.txtTipoSonidoNew);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "NewTipoSonido";
            this.Text = "NewTipoSonido";
            this.Load += new System.EventHandler(this.NewTipoSonido_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTipoSonidoNew;
        private System.Windows.Forms.TextBox txtDescripcionNew;
        private System.Windows.Forms.CheckBox chkHabilitadoNew;
        private System.Windows.Forms.Button btnNuevoNew;
        private System.Windows.Forms.Button btnCancelarNew;
    }
}