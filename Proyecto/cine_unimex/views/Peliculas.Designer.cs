﻿namespace unimex.lenguajesv.cine.views
{
    partial class Peliculas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Peliculas));
            this.btnAgregar = new System.Windows.Forms.Button();
            this.peliculasdgv = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbNombreCF = new System.Windows.Forms.ComboBox();
            this.checNombreCF = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.peliculasdgv)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAgregar
            // 
            this.btnAgregar.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.Location = new System.Drawing.Point(33, 84);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Padding = new System.Windows.Forms.Padding(2);
            this.btnAgregar.Size = new System.Drawing.Size(80, 51);
            this.btnAgregar.TabIndex = 3;
            this.btnAgregar.Text = "Nuevo";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // peliculasdgv
            // 
            this.peliculasdgv.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.peliculasdgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.peliculasdgv.BackgroundColor = System.Drawing.Color.Silver;
            this.peliculasdgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.peliculasdgv.Location = new System.Drawing.Point(133, 77);
            this.peliculasdgv.Name = "peliculasdgv";
            this.peliculasdgv.Size = new System.Drawing.Size(596, 187);
            this.peliculasdgv.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(33, 145);
            this.button1.Name = "button1";
            this.button1.Padding = new System.Windows.Forms.Padding(2);
            this.button1.Size = new System.Drawing.Size(80, 51);
            this.button1.TabIndex = 4;
            this.button1.Text = "Actualizar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(33, 206);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(80, 51);
            this.button2.TabIndex = 5;
            this.button2.Text = "Eliminar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(331, 29);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(128, 32);
            this.label5.TabIndex = 11;
            this.label5.Text = "Peliculas";
            // 
            // cmbNombreCF
            // 
            this.cmbNombreCF.FormattingEnabled = true;
            this.cmbNombreCF.Location = new System.Drawing.Point(609, 53);
            this.cmbNombreCF.Name = "cmbNombreCF";
            this.cmbNombreCF.Size = new System.Drawing.Size(121, 21);
            this.cmbNombreCF.TabIndex = 13;
            this.cmbNombreCF.SelectedIndexChanged += new System.EventHandler(this.cmbNombreCF_SelectedIndexChanged);
            // 
            // checNombreCF
            // 
            this.checNombreCF.AutoSize = true;
            this.checNombreCF.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checNombreCF.Location = new System.Drawing.Point(533, 54);
            this.checNombreCF.Name = "checNombreCF";
            this.checNombreCF.Size = new System.Drawing.Size(70, 20);
            this.checNombreCF.TabIndex = 12;
            this.checNombreCF.Text = "Nombre";
            this.checNombreCF.UseVisualStyleBackColor = true;
            this.checNombreCF.CheckedChanged += new System.EventHandler(this.checNombreCF_CheckedChanged);
            // 
            // Peliculas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(741, 322);
            this.Controls.Add(this.cmbNombreCF);
            this.Controls.Add(this.checNombreCF);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.peliculasdgv);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Peliculas";
            this.Text = "Peliculas";
            this.Load += new System.EventHandler(this.Peliculas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.peliculasdgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.DataGridView peliculasdgv;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbNombreCF;
        private System.Windows.Forms.CheckBox checNombreCF;
    }
}