namespace unimex.lenguajesv.cine.views
{
    partial class TipoProyeccionForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TipoProyeccionForm));
            this.dtgTipoProyeccion = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.chkBuscarTP = new System.Windows.Forms.CheckBox();
            this.cbxBuscarTP = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgTipoProyeccion)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgTipoProyeccion
            // 
            this.dtgTipoProyeccion.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgTipoProyeccion.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgTipoProyeccion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgTipoProyeccion.Location = new System.Drawing.Point(98, 85);
            this.dtgTipoProyeccion.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtgTipoProyeccion.Name = "dtgTipoProyeccion";
            this.dtgTipoProyeccion.Size = new System.Drawing.Size(635, 287);
            this.dtgTipoProyeccion.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(65, 53);

            this.button1.Location = new System.Drawing.Point(5, 149);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);

            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(69, 48);
            this.button1.TabIndex = 1;
            this.button1.Text = "Agregar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnActualizar
            // 

            this.btnActualizar.Location = new System.Drawing.Point(65, 104);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(75, 28);

            this.btnActualizar.Location = new System.Drawing.Point(5, 205);
            this.btnActualizar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(69, 54);
            this.btnActualizar.TabIndex = 2;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnEliminar
            // 

            this.btnEliminar.Location = new System.Drawing.Point(65, 138);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 40);

            this.btnEliminar.Location = new System.Drawing.Point(5, 267);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(69, 50);
            this.btnEliminar.TabIndex = 3;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // chkBuscarTP
            // 
            this.chkBuscarTP.AutoSize = true;
            this.chkBuscarTP.Location = new System.Drawing.Point(477, 57);
            this.chkBuscarTP.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chkBuscarTP.Name = "chkBuscarTP";
            this.chkBuscarTP.Size = new System.Drawing.Size(112, 20);
            this.chkBuscarTP.TabIndex = 4;
            this.chkBuscarTP.Text = "Tipo Proyeccion";
            this.chkBuscarTP.UseVisualStyleBackColor = true;
            this.chkBuscarTP.CheckedChanged += new System.EventHandler(this.chkBuscarTP_CheckedChanged);
            // 
            // cbxBuscarTP
            // 
            this.cbxBuscarTP.FormattingEnabled = true;
            this.cbxBuscarTP.Location = new System.Drawing.Point(593, 53);
            this.cbxBuscarTP.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbxBuscarTP.Name = "cbxBuscarTP";
            this.cbxBuscarTP.Size = new System.Drawing.Size(140, 24);
            this.cbxBuscarTP.TabIndex = 5;
            this.cbxBuscarTP.SelectedIndexChanged += new System.EventHandler(this.cbxBuscarTP_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(410, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Buscar :";
            // 
            // TipoProyeccionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(745, 385);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbxBuscarTP);
            this.Controls.Add(this.chkBuscarTP);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dtgTipoProyeccion);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "TipoProyeccionForm";
            this.Text = "TipoProyeccionForm";
            this.Load += new System.EventHandler(this.TipoProyeccionForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgTipoProyeccion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgTipoProyeccion;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.CheckBox chkBuscarTP;
        private System.Windows.Forms.ComboBox cbxBuscarTP;
        private System.Windows.Forms.Label label1;
    }
}