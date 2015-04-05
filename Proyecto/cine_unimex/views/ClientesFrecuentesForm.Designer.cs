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
            // ClientesFrecuentesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(490, 303);
            this.Controls.Add(this.btnNuevoCFform);
            this.Controls.Add(this.dgvClienteFrecuente);
            this.Name = "ClientesFrecuentesForm";
            this.Text = "ClientesFrecuentesForm";
            this.Load += new System.EventHandler(this.ClientesFrecuentesForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvClienteFrecuente)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvClienteFrecuente;
        private System.Windows.Forms.Button btnNuevoCFform;
    }
}