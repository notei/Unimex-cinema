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
            this.label1 = new System.Windows.Forms.Label();
            this.buscarPeliculaCB = new System.Windows.Forms.ComboBox();
            this.peliChb = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.ProyeccionesDgv)).BeginInit();
            this.SuspendLayout();
            // 
            // ProyeccionesDgv
            // 
            this.ProyeccionesDgv.AllowUserToAddRows = false;
            this.ProyeccionesDgv.AllowUserToDeleteRows = false;
            this.ProyeccionesDgv.AllowUserToOrderColumns = true;
            this.ProyeccionesDgv.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ProyeccionesDgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ProyeccionesDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ProyeccionesDgv.Location = new System.Drawing.Point(111, 128);
            this.ProyeccionesDgv.Name = "ProyeccionesDgv";
            this.ProyeccionesDgv.ReadOnly = true;
            this.ProyeccionesDgv.RowTemplate.Height = 24;
            this.ProyeccionesDgv.Size = new System.Drawing.Size(823, 372);
            this.ProyeccionesDgv.TabIndex = 0;
            // 
            // NewProy
            // 
            this.NewProy.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewProy.Location = new System.Drawing.Point(12, 198);
            this.NewProy.Name = "NewProy";
            this.NewProy.Size = new System.Drawing.Size(93, 63);
            this.NewProy.TabIndex = 1;
            this.NewProy.Text = "Nuevo";
            this.NewProy.UseVisualStyleBackColor = true;
            this.NewProy.Click += new System.EventHandler(this.NewProy_Click);
            // 
            // updateBtn
            // 
            this.updateBtn.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateBtn.Location = new System.Drawing.Point(12, 310);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(93, 63);
            this.updateBtn.TabIndex = 2;
            this.updateBtn.Text = "Actualizar";
            this.updateBtn.UseVisualStyleBackColor = true;
            this.updateBtn.Click += new System.EventHandler(this.updateBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(345, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(234, 39);
            this.label1.TabIndex = 3;
            this.label1.Text = "Proyecciones";
            // 
            // buscarPeliculaCB
            // 
            this.buscarPeliculaCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.buscarPeliculaCB.FormattingEnabled = true;
            this.buscarPeliculaCB.Location = new System.Drawing.Point(772, 98);
            this.buscarPeliculaCB.Name = "buscarPeliculaCB";
            this.buscarPeliculaCB.Size = new System.Drawing.Size(162, 24);
            this.buscarPeliculaCB.TabIndex = 4;
            this.buscarPeliculaCB.SelectedIndexChanged += new System.EventHandler(this.buscarPeliculaCB_SelectedIndexChanged);
            // 
            // peliChb
            // 
            this.peliChb.AutoSize = true;
            this.peliChb.Location = new System.Drawing.Point(683, 100);
            this.peliChb.Name = "peliChb";
            this.peliChb.Size = new System.Drawing.Size(83, 21);
            this.peliChb.TabIndex = 5;
            this.peliChb.Text = "Película:";
            this.peliChb.UseVisualStyleBackColor = true;
            this.peliChb.CheckedChanged += new System.EventHandler(this.peliChb_CheckedChanged);
            // 
            // ProyeccionesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(946, 512);
            this.Controls.Add(this.peliChb);
            this.Controls.Add(this.buscarPeliculaCB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.updateBtn);
            this.Controls.Add(this.NewProy);
            this.Controls.Add(this.ProyeccionesDgv);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ProyeccionesForm";
            this.Text = "Proyecciones";
            this.Load += new System.EventHandler(this.ProyeccionesForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ProyeccionesDgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView ProyeccionesDgv;
        private System.Windows.Forms.Button NewProy;
        private System.Windows.Forms.Button updateBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox buscarPeliculaCB;
        private System.Windows.Forms.CheckBox peliChb;
    }
}