﻿namespace unimex.lenguajesv.cine.views
{
    partial class PreciosForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PreciosForm));
            this.dgvPrecios = new System.Windows.Forms.DataGridView();
            this.btnAgregarprecio = new System.Windows.Forms.Button();
            this.btnActualizarPrecios = new System.Windows.Forms.Button();
            this.btnBorrarPrecio = new System.Windows.Forms.Button();
            this.checkPreciosbus = new System.Windows.Forms.CheckBox();
            this.cbxPreciosBuscar = new System.Windows.Forms.ComboBox();
            this.checkPreciobolbus = new System.Windows.Forms.CheckBox();
            this.cbxPrecioBuscpre = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrecios)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPrecios
            // 
            this.dgvPrecios.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvPrecios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPrecios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPrecios.Location = new System.Drawing.Point(130, 132);
            this.dgvPrecios.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvPrecios.Name = "dgvPrecios";
            this.dgvPrecios.Size = new System.Drawing.Size(556, 298);
            this.dgvPrecios.TabIndex = 0;
            // 
            // btnAgregarprecio
            // 
            this.btnAgregarprecio.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarprecio.Location = new System.Drawing.Point(25, 129);
            this.btnAgregarprecio.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAgregarprecio.Name = "btnAgregarprecio";
            this.btnAgregarprecio.Size = new System.Drawing.Size(87, 58);
            this.btnAgregarprecio.TabIndex = 1;
            this.btnAgregarprecio.Text = "Agregar";
            this.btnAgregarprecio.UseVisualStyleBackColor = true;
            this.btnAgregarprecio.Click += new System.EventHandler(this.btnAgregarprecio_Click);
            // 
            // btnActualizarPrecios
            // 
            this.btnActualizarPrecios.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizarPrecios.Location = new System.Drawing.Point(25, 252);
            this.btnActualizarPrecios.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnActualizarPrecios.Name = "btnActualizarPrecios";
            this.btnActualizarPrecios.Size = new System.Drawing.Size(87, 58);
            this.btnActualizarPrecios.TabIndex = 2;
            this.btnActualizarPrecios.Text = "Actualizar";
            this.btnActualizarPrecios.UseVisualStyleBackColor = true;
            this.btnActualizarPrecios.Click += new System.EventHandler(this.btnActualizarPrecios_Click);
            // 
            // btnBorrarPrecio
            // 
            this.btnBorrarPrecio.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBorrarPrecio.Location = new System.Drawing.Point(25, 372);
            this.btnBorrarPrecio.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnBorrarPrecio.Name = "btnBorrarPrecio";
            this.btnBorrarPrecio.Size = new System.Drawing.Size(87, 58);
            this.btnBorrarPrecio.TabIndex = 3;
            this.btnBorrarPrecio.Text = "Borrar";
            this.btnBorrarPrecio.UseVisualStyleBackColor = true;
            this.btnBorrarPrecio.Click += new System.EventHandler(this.btnBorrarPrecio_Click);
            // 
            // checkPreciosbus
            // 
            this.checkPreciosbus.AutoSize = true;
            this.checkPreciosbus.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkPreciosbus.Location = new System.Drawing.Point(547, 62);
            this.checkPreciosbus.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.checkPreciosbus.Name = "checkPreciosbus";
            this.checkPreciosbus.Size = new System.Drawing.Size(74, 23);
            this.checkPreciosbus.TabIndex = 4;
            this.checkPreciosbus.Text = "Boleto";
            this.checkPreciosbus.UseVisualStyleBackColor = true;
            this.checkPreciosbus.CheckedChanged += new System.EventHandler(this.checkPreciosbus_CheckedChanged);
            // 
            // cbxPreciosBuscar
            // 
            this.cbxPreciosBuscar.FormattingEnabled = true;
            this.cbxPreciosBuscar.Location = new System.Drawing.Point(546, 90);
            this.cbxPreciosBuscar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbxPreciosBuscar.Name = "cbxPreciosBuscar";
            this.cbxPreciosBuscar.Size = new System.Drawing.Size(140, 27);
            this.cbxPreciosBuscar.TabIndex = 5;
            this.cbxPreciosBuscar.SelectedIndexChanged += new System.EventHandler(this.cbxPreciosBuscar_SelectedIndexChanged);
            // 
            // checkPreciobolbus
            // 
            this.checkPreciobolbus.AutoSize = true;
            this.checkPreciobolbus.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkPreciobolbus.Location = new System.Drawing.Point(384, 62);
            this.checkPreciobolbus.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.checkPreciobolbus.Name = "checkPreciobolbus";
            this.checkPreciobolbus.Size = new System.Drawing.Size(143, 23);
            this.checkPreciobolbus.TabIndex = 6;
            this.checkPreciobolbus.Text = "Precio de Boleto";
            this.checkPreciobolbus.UseVisualStyleBackColor = true;
            this.checkPreciobolbus.CheckedChanged += new System.EventHandler(this.checkPreciobolbus_CheckedChanged);
            // 
            // cbxPrecioBuscpre
            // 
            this.cbxPrecioBuscpre.FormattingEnabled = true;
            this.cbxPrecioBuscpre.Location = new System.Drawing.Point(384, 90);
            this.cbxPrecioBuscpre.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbxPrecioBuscpre.Name = "cbxPrecioBuscpre";
            this.cbxPrecioBuscpre.Size = new System.Drawing.Size(140, 27);
            this.cbxPrecioBuscpre.TabIndex = 7;
            this.cbxPrecioBuscpre.SelectedIndexChanged += new System.EventHandler(this.cbxPrecioBuscpre_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(248, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 19);
            this.label1.TabIndex = 8;
            this.label1.Text = "Busqueda :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(122, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(566, 40);
            this.label2.TabIndex = 9;
            this.label2.Text = "CATÁLOGO PRECIOS DE BOLETOS";
            // 
            // PreciosForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(698, 440);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbxPrecioBuscpre);
            this.Controls.Add(this.checkPreciobolbus);
            this.Controls.Add(this.cbxPreciosBuscar);
            this.Controls.Add(this.checkPreciosbus);
            this.Controls.Add(this.btnBorrarPrecio);
            this.Controls.Add(this.btnActualizarPrecios);
            this.Controls.Add(this.btnAgregarprecio);
            this.Controls.Add(this.dgvPrecios);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "PreciosForm";
            this.Text = "Precios de Boletos";
            this.Load += new System.EventHandler(this.PreciosForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrecios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPrecios;
        private System.Windows.Forms.Button btnAgregarprecio;
        private System.Windows.Forms.Button btnActualizarPrecios;
        private System.Windows.Forms.Button btnBorrarPrecio;
        private System.Windows.Forms.CheckBox checkPreciosbus;
        private System.Windows.Forms.ComboBox cbxPreciosBuscar;
        private System.Windows.Forms.CheckBox checkPreciobolbus;
        private System.Windows.Forms.ComboBox cbxPrecioBuscpre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}