﻿namespace unimex.lenguajesv.cine.views
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewProyecciones));
            this.Horario = new System.Windows.Forms.DateTimePicker();
            this.Cancelbtn = new System.Windows.Forms.Button();
            this.acceptbtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.peliculaCb = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.complejosCb = new System.Windows.Forms.ComboBox();
            this.salasCB = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Horario
            // 
            this.Horario.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Horario.Location = new System.Drawing.Point(98, 200);
            this.Horario.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Horario.Name = "Horario";
            this.Horario.Size = new System.Drawing.Size(200, 23);
            this.Horario.TabIndex = 3;
            // 
            // Cancelbtn
            // 
            this.Cancelbtn.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cancelbtn.Location = new System.Drawing.Point(12, 267);
            this.Cancelbtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Cancelbtn.Name = "Cancelbtn";
            this.Cancelbtn.Size = new System.Drawing.Size(110, 58);
            this.Cancelbtn.TabIndex = 4;
            this.Cancelbtn.Text = "&Cancelar";
            this.Cancelbtn.UseVisualStyleBackColor = true;
            this.Cancelbtn.Click += new System.EventHandler(this.Cancelbtn_Click);
            // 
            // acceptbtn
            // 
            this.acceptbtn.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.acceptbtn.Location = new System.Drawing.Point(181, 267);
            this.acceptbtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.acceptbtn.Name = "acceptbtn";
            this.acceptbtn.Size = new System.Drawing.Size(110, 58);
            this.acceptbtn.TabIndex = 5;
            this.acceptbtn.Text = "&Aceptar";
            this.acceptbtn.UseVisualStyleBackColor = true;
            this.acceptbtn.Click += new System.EventHandler(this.acceptbtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 19);
            this.label1.TabIndex = 5;
            this.label1.Text = "Sala:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 165);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 19);
            this.label2.TabIndex = 6;
            this.label2.Text = "Pelicula:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 205);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 19);
            this.label3.TabIndex = 7;
            this.label3.Text = "Horario:";
            // 
            // peliculaCb
            // 
            this.peliculaCb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.peliculaCb.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.peliculaCb.FormattingEnabled = true;
            this.peliculaCb.Location = new System.Drawing.Point(98, 162);
            this.peliculaCb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.peliculaCb.Name = "peliculaCb";
            this.peliculaCb.Size = new System.Drawing.Size(151, 25);
            this.peliculaCb.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 19);
            this.label4.TabIndex = 9;
            this.label4.Text = "Complejo:";
            // 
            // complejosCb
            // 
            this.complejosCb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.complejosCb.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.complejosCb.FormattingEnabled = true;
            this.complejosCb.Location = new System.Drawing.Point(98, 82);
            this.complejosCb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.complejosCb.Name = "complejosCb";
            this.complejosCb.Size = new System.Drawing.Size(151, 25);
            this.complejosCb.TabIndex = 0;
            this.complejosCb.SelectedIndexChanged += new System.EventHandler(this.complejosCb_SelectedIndexChanged);
            // 
            // salasCB
            // 
            this.salasCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.salasCB.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salasCB.FormattingEnabled = true;
            this.salasCB.Location = new System.Drawing.Point(98, 122);
            this.salasCB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.salasCB.Name = "salasCB";
            this.salasCB.Size = new System.Drawing.Size(151, 25);
            this.salasCB.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(71, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(178, 39);
            this.label5.TabIndex = 10;
            this.label5.Text = "Actualizar";
            // 
            // NewProyecciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(320, 336);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.salasCB);
            this.Controls.Add(this.complejosCb);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.peliculaCb);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.acceptbtn);
            this.Controls.Add(this.Cancelbtn);
            this.Controls.Add(this.Horario);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "NewProyecciones";
            this.Text = "Nueva Proyección";
            this.Load += new System.EventHandler(this.NewProyecciones_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker Horario;
        private System.Windows.Forms.Button Cancelbtn;
        private System.Windows.Forms.Button acceptbtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox peliculaCb;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox complejosCb;
        private System.Windows.Forms.ComboBox salasCB;
        private System.Windows.Forms.Label label5;
    }
}