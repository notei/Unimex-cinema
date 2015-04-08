namespace unimex.lenguajesv.cine.views
{
    partial class NewSalas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewSalas));
            this.txtCom = new System.Windows.Forms.TextBox();
            this.txtSala = new System.Windows.Forms.TextBox();
            this.txtCap = new System.Windows.Forms.TextBox();
            this.lblcomplejo = new System.Windows.Forms.Label();
            this.lblNombreSa = new System.Windows.Forms.Label();
            this.lblCapacidad = new System.Windows.Forms.Label();
            this.lblButa = new System.Windows.Forms.Label();
            this.lblSonido = new System.Windows.Forms.Label();
            this.lblProyeccion = new System.Windows.Forms.Label();
            this.btnAc = new System.Windows.Forms.Button();
            this.btnCa = new System.Windows.Forms.Button();
            this.salasCb = new System.Windows.Forms.ComboBox();
            this.SalaCb2 = new System.Windows.Forms.ComboBox();
            this.chebox = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtCom
            // 
            this.txtCom.Location = new System.Drawing.Point(163, 90);
            this.txtCom.Name = "txtCom";
            this.txtCom.Size = new System.Drawing.Size(315, 22);
            this.txtCom.TabIndex = 0;
            // 
            // txtSala
            // 
            this.txtSala.Location = new System.Drawing.Point(163, 134);
            this.txtSala.Name = "txtSala";
            this.txtSala.Size = new System.Drawing.Size(315, 22);
            this.txtSala.TabIndex = 1;
            // 
            // txtCap
            // 
            this.txtCap.Location = new System.Drawing.Point(163, 179);
            this.txtCap.Name = "txtCap";
            this.txtCap.Size = new System.Drawing.Size(315, 22);
            this.txtCap.TabIndex = 2;
            // 
            // lblcomplejo
            // 
            this.lblcomplejo.AutoSize = true;
            this.lblcomplejo.Location = new System.Drawing.Point(30, 105);
            this.lblcomplejo.Name = "lblcomplejo";
            this.lblcomplejo.Size = new System.Drawing.Size(83, 17);
            this.lblcomplejo.TabIndex = 6;
            this.lblcomplejo.Text = "id_complejo";
            // 
            // lblNombreSa
            // 
            this.lblNombreSa.AutoSize = true;
            this.lblNombreSa.Location = new System.Drawing.Point(30, 139);
            this.lblNombreSa.Name = "lblNombreSa";
            this.lblNombreSa.Size = new System.Drawing.Size(90, 17);
            this.lblNombreSa.TabIndex = 7;
            this.lblNombreSa.Text = "nombre_sala";
            // 
            // lblCapacidad
            // 
            this.lblCapacidad.AutoSize = true;
            this.lblCapacidad.Location = new System.Drawing.Point(30, 182);
            this.lblCapacidad.Name = "lblCapacidad";
            this.lblCapacidad.Size = new System.Drawing.Size(73, 17);
            this.lblCapacidad.TabIndex = 8;
            this.lblCapacidad.Text = "capacidad";
            // 
            // lblButa
            // 
            this.lblButa.AutoSize = true;
            this.lblButa.Location = new System.Drawing.Point(30, 232);
            this.lblButa.Name = "lblButa";
            this.lblButa.Size = new System.Drawing.Size(137, 17);
            this.lblButa.TabIndex = 9;
            this.lblButa.Text = "butacas_numeradas";
            // 
            // lblSonido
            // 
            this.lblSonido.AutoSize = true;
            this.lblSonido.Location = new System.Drawing.Point(30, 280);
            this.lblSonido.Name = "lblSonido";
            this.lblSonido.Size = new System.Drawing.Size(100, 17);
            this.lblSonido.TabIndex = 10;
            this.lblSonido.Text = "id_tipo_sonido";
            // 
            // lblProyeccion
            // 
            this.lblProyeccion.AutoSize = true;
            this.lblProyeccion.Location = new System.Drawing.Point(33, 341);
            this.lblProyeccion.Name = "lblProyeccion";
            this.lblProyeccion.Size = new System.Drawing.Size(134, 17);
            this.lblProyeccion.TabIndex = 11;
            this.lblProyeccion.Text = "id_tipo_proyecccion";
            // 
            // btnAc
            // 
            this.btnAc.Location = new System.Drawing.Point(45, 450);
            this.btnAc.Name = "btnAc";
            this.btnAc.Size = new System.Drawing.Size(85, 23);
            this.btnAc.TabIndex = 12;
            this.btnAc.Text = "Aceptar";
            this.btnAc.UseVisualStyleBackColor = true;
            this.btnAc.Click += new System.EventHandler(this.btnAc_Click);
            // 
            // btnCa
            // 
            this.btnCa.Location = new System.Drawing.Point(403, 450);
            this.btnCa.Name = "btnCa";
            this.btnCa.Size = new System.Drawing.Size(75, 23);
            this.btnCa.TabIndex = 13;
            this.btnCa.Text = "Cancelar";
            this.btnCa.UseVisualStyleBackColor = true;
            this.btnCa.Click += new System.EventHandler(this.btnCa_Click);
            // 
            // salasCb
            // 
            this.salasCb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.salasCb.FormattingEnabled = true;
            this.salasCb.Location = new System.Drawing.Point(163, 280);
            this.salasCb.Name = "salasCb";
            this.salasCb.Size = new System.Drawing.Size(315, 24);
            this.salasCb.TabIndex = 14;
            // 
            // SalaCb2
            // 
            this.SalaCb2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SalaCb2.FormattingEnabled = true;
            this.SalaCb2.Location = new System.Drawing.Point(163, 338);
            this.SalaCb2.Name = "SalaCb2";
            this.SalaCb2.Size = new System.Drawing.Size(315, 24);
            this.SalaCb2.TabIndex = 15;
            // 
            // chebox
            // 
            this.chebox.AutoSize = true;
            this.chebox.Location = new System.Drawing.Point(173, 232);
            this.chebox.Name = "chebox";
            this.chebox.Size = new System.Drawing.Size(18, 17);
            this.chebox.TabIndex = 16;
            this.chebox.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(255, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 40);
            this.label1.TabIndex = 17;
            this.label1.Text = "SalasCon";
            // 
            // NewSalas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(768, 492);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chebox);
            this.Controls.Add(this.SalaCb2);
            this.Controls.Add(this.salasCb);
            this.Controls.Add(this.btnCa);
            this.Controls.Add(this.btnAc);
            this.Controls.Add(this.lblProyeccion);
            this.Controls.Add(this.lblSonido);
            this.Controls.Add(this.lblButa);
            this.Controls.Add(this.lblCapacidad);
            this.Controls.Add(this.lblNombreSa);
            this.Controls.Add(this.lblcomplejo);
            this.Controls.Add(this.txtCap);
            this.Controls.Add(this.txtSala);
            this.Controls.Add(this.txtCom);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "NewSalas";
            this.Text = "NewSalas";
            this.Load += new System.EventHandler(this.NewSalas_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCom;
        private System.Windows.Forms.TextBox txtSala;
        private System.Windows.Forms.TextBox txtCap;
        private System.Windows.Forms.Label lblcomplejo;
        private System.Windows.Forms.Label lblNombreSa;
        private System.Windows.Forms.Label lblCapacidad;
        private System.Windows.Forms.Label lblButa;
        private System.Windows.Forms.Label lblSonido;
        private System.Windows.Forms.Label lblProyeccion;
        private System.Windows.Forms.Button btnAc;
        private System.Windows.Forms.Button btnCa;
        private System.Windows.Forms.ComboBox salasCb;
        private System.Windows.Forms.ComboBox SalaCb2;
        private System.Windows.Forms.CheckBox chebox;
        private System.Windows.Forms.Label label1;
    }
}