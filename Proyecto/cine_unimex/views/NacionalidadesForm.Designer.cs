namespace unimex.lenguajesv.cine.views
{
    partial class NacionalidadesForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NacionalidadesForm));
            this.dgvNacionalidades = new System.Windows.Forms.DataGridView();
            this.btnAgregarNac = new System.Windows.Forms.Button();
            this.btnActualizarNa = new System.Windows.Forms.Button();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNacionalidades)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvNacionalidades
            // 
            this.dgvNacionalidades.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvNacionalidades.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvNacionalidades.BackgroundColor = System.Drawing.Color.Silver;
            this.dgvNacionalidades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNacionalidades.Location = new System.Drawing.Point(141, 78);
            this.dgvNacionalidades.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvNacionalidades.Name = "dgvNacionalidades";
            this.dgvNacionalidades.Size = new System.Drawing.Size(392, 251);
            this.dgvNacionalidades.TabIndex = 0;
            this.dgvNacionalidades.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvNacionalidades_CellContentClick);
            // 
            // btnAgregarNac
            // 
            this.btnAgregarNac.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarNac.Location = new System.Drawing.Point(13, 78);
            this.btnAgregarNac.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAgregarNac.Name = "btnAgregarNac";
            this.btnAgregarNac.Size = new System.Drawing.Size(87, 28);
            this.btnAgregarNac.TabIndex = 1;
            this.btnAgregarNac.Text = "Agregar";
            this.btnAgregarNac.UseVisualStyleBackColor = true;
            this.btnAgregarNac.Click += new System.EventHandler(this.btnAgregarNac_Click);
            // 
            // btnActualizarNa
            // 
            this.btnActualizarNa.Location = new System.Drawing.Point(13, 130);
            this.btnActualizarNa.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnActualizarNa.Name = "btnActualizarNa";
            this.btnActualizarNa.Size = new System.Drawing.Size(87, 28);
            this.btnActualizarNa.TabIndex = 2;
            this.btnActualizarNa.Text = "Actualizar";
            this.btnActualizarNa.UseVisualStyleBackColor = true;
            this.btnActualizarNa.Click += new System.EventHandler(this.btnActualizarNa_Click);
            // 
            // btnBorrar
            // 
            this.btnBorrar.Location = new System.Drawing.Point(12, 179);
            this.btnBorrar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(87, 28);
            this.btnBorrar.TabIndex = 3;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.UseVisualStyleBackColor = true;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(176, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(222, 32);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nacionalidades";
            // 
            // NacionalidadesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(561, 360);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.btnActualizarNa);
            this.Controls.Add(this.btnAgregarNac);
            this.Controls.Add(this.dgvNacionalidades);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "NacionalidadesForm";
            this.Text = "Nacionalidades";
            this.Load += new System.EventHandler(this.NacionalidadesForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNacionalidades)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvNacionalidades;
        private System.Windows.Forms.Button btnAgregarNac;
        private System.Windows.Forms.Button btnActualizarNa;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.Label label1;
    }
}