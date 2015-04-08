namespace unimex.lenguajesv.cine.views
{
    partial class ComplejoForm
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
            this.dgvComplejos = new System.Windows.Forms.DataGridView();
            this.btnAgregarCompl = new System.Windows.Forms.Button();
            this.btnActualizarCom = new System.Windows.Forms.Button();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.chkBuscarCom = new System.Windows.Forms.CheckBox();
            this.cmbBuscarCom = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvComplejos)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvComplejos
            // 
            this.dgvComplejos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvComplejos.Location = new System.Drawing.Point(236, 62);
            this.dgvComplejos.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvComplejos.Name = "dgvComplejos";
            this.dgvComplejos.Size = new System.Drawing.Size(427, 375);
            this.dgvComplejos.TabIndex = 0;
            // 
            // btnAgregarCompl
            // 
            this.btnAgregarCompl.Location = new System.Drawing.Point(31, 107);
            this.btnAgregarCompl.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAgregarCompl.Name = "btnAgregarCompl";
            this.btnAgregarCompl.Size = new System.Drawing.Size(87, 28);
            this.btnAgregarCompl.TabIndex = 1;
            this.btnAgregarCompl.Text = "Agregar";
            this.btnAgregarCompl.UseVisualStyleBackColor = true;
            this.btnAgregarCompl.Click += new System.EventHandler(this.btnAgregarCompl_Click);
            // 
            // btnActualizarCom
            // 
            this.btnActualizarCom.Location = new System.Drawing.Point(31, 158);
            this.btnActualizarCom.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnActualizarCom.Name = "btnActualizarCom";
            this.btnActualizarCom.Size = new System.Drawing.Size(87, 28);
            this.btnActualizarCom.TabIndex = 2;
            this.btnActualizarCom.Text = "Actualizar";
            this.btnActualizarCom.UseVisualStyleBackColor = true;
            this.btnActualizarCom.Click += new System.EventHandler(this.btnActualizarCom_Click);
            // 
            // btnBorrar
            // 
            this.btnBorrar.Location = new System.Drawing.Point(31, 214);
            this.btnBorrar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(87, 28);
            this.btnBorrar.TabIndex = 3;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.UseVisualStyleBackColor = true;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // chkBuscarCom
            // 
            this.chkBuscarCom.AutoSize = true;
            this.chkBuscarCom.Location = new System.Drawing.Point(31, 290);
            this.chkBuscarCom.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chkBuscarCom.Name = "chkBuscarCom";
            this.chkBuscarCom.Size = new System.Drawing.Size(79, 20);
            this.chkBuscarCom.TabIndex = 4;
            this.chkBuscarCom.Text = "Complejo";
            this.chkBuscarCom.UseVisualStyleBackColor = true;
            this.chkBuscarCom.CheckedChanged += new System.EventHandler(this.chkBuscarCom_CheckedChanged);
            // 
            // cmbBuscarCom
            // 
            this.cmbBuscarCom.FormattingEnabled = true;
            this.cmbBuscarCom.Location = new System.Drawing.Point(14, 330);
            this.cmbBuscarCom.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbBuscarCom.Name = "cmbBuscarCom";
            this.cmbBuscarCom.Size = new System.Drawing.Size(140, 24);
            this.cmbBuscarCom.TabIndex = 5;
            this.cmbBuscarCom.SelectedIndexChanged += new System.EventHandler(this.cmbBuscarCom_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(199, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(292, 33);
            this.label1.TabIndex = 6;
            this.label1.Text = "Catálogo Complejos";
            // 
            // ComplejoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(703, 469);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbBuscarCom);
            this.Controls.Add(this.chkBuscarCom);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.btnActualizarCom);
            this.Controls.Add(this.btnAgregarCompl);
            this.Controls.Add(this.dgvComplejos);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "ComplejoForm";
            this.Text = "ComplejoForm";
            this.Load += new System.EventHandler(this.ComplejoForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvComplejos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvComplejos;
        private System.Windows.Forms.Button btnAgregarCompl;
        private System.Windows.Forms.Button btnActualizarCom;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.CheckBox chkBuscarCom;
        private System.Windows.Forms.ComboBox cmbBuscarCom;
        private System.Windows.Forms.Label label1;
    }
}