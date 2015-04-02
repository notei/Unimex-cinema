namespace unimex.lenguajesv.cine.views
{
    partial class ProyeccionesForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProyeccionesForm));
            this.ProyeccionesDgv = new System.Windows.Forms.DataGridView();
            this.NewProy = new System.Windows.Forms.Button();
            this.updateBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ProyeccionesDgv)).BeginInit();
            this.SuspendLayout();
            // 
            // ProyeccionesDgv
            // 
            this.ProyeccionesDgv.AllowUserToAddRows = false;
            this.ProyeccionesDgv.AllowUserToDeleteRows = false;
            this.ProyeccionesDgv.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ProyeccionesDgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ProyeccionesDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ProyeccionesDgv.Location = new System.Drawing.Point(112, 12);
            this.ProyeccionesDgv.Name = "ProyeccionesDgv";
            this.ProyeccionesDgv.ReadOnly = true;
            this.ProyeccionesDgv.RowTemplate.Height = 24;
            this.ProyeccionesDgv.Size = new System.Drawing.Size(620, 335);
            this.ProyeccionesDgv.TabIndex = 0;
            // 
            // NewProy
            // 
            this.NewProy.Location = new System.Drawing.Point(13, 54);
            this.NewProy.Name = "NewProy";
            this.NewProy.Size = new System.Drawing.Size(75, 27);
            this.NewProy.TabIndex = 1;
            this.NewProy.Text = "Nuevo";
            this.NewProy.UseVisualStyleBackColor = true;
            this.NewProy.Click += new System.EventHandler(this.NewProy_Click);
            // 
            // updateBtn
            // 
            this.updateBtn.Location = new System.Drawing.Point(13, 133);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(75, 23);
            this.updateBtn.TabIndex = 2;
            this.updateBtn.Text = "Actualizar";
            this.updateBtn.UseVisualStyleBackColor = true;
            this.updateBtn.Click += new System.EventHandler(this.updateBtn_Click);
            // 
            // ProyeccionesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(744, 359);
            this.Controls.Add(this.updateBtn);
            this.Controls.Add(this.NewProy);
            this.Controls.Add(this.ProyeccionesDgv);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ProyeccionesForm";
            this.Text = "Proyecciones";
            this.Load += new System.EventHandler(this.ProyeccionesForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ProyeccionesDgv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView ProyeccionesDgv;
        private System.Windows.Forms.Button NewProy;
        private System.Windows.Forms.Button updateBtn;
    }
}