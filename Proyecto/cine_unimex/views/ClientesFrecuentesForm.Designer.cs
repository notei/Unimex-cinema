namespace unimex.lenguajesv.cine.views
{
    partial class ClientesFrecuentesForm
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
            this.dgvClienteFrecuente = new System.Windows.Forms.DataGridView();
            this.btnNuevoCFform = new System.Windows.Forms.Button();
            this.btnActualizarCF = new System.Windows.Forms.Button();
            this.btnBorrarNew = new System.Windows.Forms.Button();
            this.checNombreCF = new System.Windows.Forms.CheckBox();
            this.cmbNombreCF = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClienteFrecuente)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvClienteFrecuente
            // 
            this.dgvClienteFrecuente.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvClienteFrecuente.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvClienteFrecuente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClienteFrecuente.Location = new System.Drawing.Point(134, 24);
            this.dgvClienteFrecuente.Name = "dgvClienteFrecuente";
            this.dgvClienteFrecuente.Size = new System.Drawing.Size(344, 257);
            this.dgvClienteFrecuente.TabIndex = 0;
            // 
            // btnNuevoCFform
            // 
            this.btnNuevoCFform.Location = new System.Drawing.Point(22, 44);
            this.btnNuevoCFform.Name = "btnNuevoCFform";
            this.btnNuevoCFform.Size = new System.Drawing.Size(75, 23);
            this.btnNuevoCFform.TabIndex = 1;
            this.btnNuevoCFform.Text = "Nuevo";
            this.btnNuevoCFform.UseVisualStyleBackColor = true;
            this.btnNuevoCFform.Click += new System.EventHandler(this.btnNuevoCFform_Click);
            // 
            // btnActualizarCF
            // 
            this.btnActualizarCF.Location = new System.Drawing.Point(22, 85);
            this.btnActualizarCF.Name = "btnActualizarCF";
            this.btnActualizarCF.Size = new System.Drawing.Size(75, 23);
            this.btnActualizarCF.TabIndex = 2;
            this.btnActualizarCF.Text = "Actualizar";
            this.btnActualizarCF.UseVisualStyleBackColor = true;
            this.btnActualizarCF.Click += new System.EventHandler(this.btnActualizarCF_Click);
            // 
            // btnBorrarNew
            // 
            this.btnBorrarNew.Location = new System.Drawing.Point(22, 124);
            this.btnBorrarNew.Name = "btnBorrarNew";
            this.btnBorrarNew.Size = new System.Drawing.Size(75, 23);
            this.btnBorrarNew.TabIndex = 3;
            this.btnBorrarNew.Text = "Borrar";
            this.btnBorrarNew.UseVisualStyleBackColor = true;
            this.btnBorrarNew.Click += new System.EventHandler(this.btnBorrarNew_Click);
            // 
            // checNombreCF
            // 
            this.checNombreCF.AutoSize = true;
            this.checNombreCF.Location = new System.Drawing.Point(22, 171);
            this.checNombreCF.Name = "checNombreCF";
            this.checNombreCF.Size = new System.Drawing.Size(63, 17);
            this.checNombreCF.TabIndex = 4;
            this.checNombreCF.Text = "Nombre";
            this.checNombreCF.UseVisualStyleBackColor = true;
            this.checNombreCF.CheckedChanged += new System.EventHandler(this.checNombreCF_CheckedChanged);
            // 
            // cmbNombreCF
            // 
            this.cmbNombreCF.FormattingEnabled = true;
            this.cmbNombreCF.Location = new System.Drawing.Point(7, 194);
            this.cmbNombreCF.Name = "cmbNombreCF";
            this.cmbNombreCF.Size = new System.Drawing.Size(121, 21);
            this.cmbNombreCF.TabIndex = 5;
            this.cmbNombreCF.SelectedIndexChanged += new System.EventHandler(this.cmbNombreCF_SelectedIndexChanged);
            // 
            // ClientesFrecuentesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(490, 303);
            this.Controls.Add(this.cmbNombreCF);
            this.Controls.Add(this.checNombreCF);
            this.Controls.Add(this.btnBorrarNew);
            this.Controls.Add(this.btnActualizarCF);
            this.Controls.Add(this.btnNuevoCFform);
            this.Controls.Add(this.dgvClienteFrecuente);
            this.Name = "ClientesFrecuentesForm";
            this.Text = "ClientesFrecuentesForm";
            this.Load += new System.EventHandler(this.ClientesFrecuentesForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvClienteFrecuente)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvClienteFrecuente;
        private System.Windows.Forms.Button btnNuevoCFform;
        private System.Windows.Forms.Button btnActualizarCF;
        private System.Windows.Forms.Button btnBorrarNew;
        private System.Windows.Forms.CheckBox checNombreCF;
        private System.Windows.Forms.ComboBox cmbNombreCF;
    }
}