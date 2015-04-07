namespace unimex.lenguajesv.cine.views
{
    partial class ProveedoresForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProveedoresForm));
            this.viewProveedor = new System.Windows.Forms.DataGridView();
            this.btnmodificar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.checkProveedor = new System.Windows.Forms.CheckBox();
            this.cbxbuscarproveedor = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.viewProveedor)).BeginInit();
            this.SuspendLayout();
            // 
            // viewProveedor
            // 
            this.viewProveedor.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.viewProveedor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.viewProveedor.Location = new System.Drawing.Point(201, 95);
            this.viewProveedor.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.viewProveedor.Name = "viewProveedor";
            this.viewProveedor.Size = new System.Drawing.Size(553, 286);
            this.viewProveedor.TabIndex = 0;
            // 
            // btnmodificar
            // 
            this.btnmodificar.Location = new System.Drawing.Point(26, 89);
            this.btnmodificar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnmodificar.Name = "btnmodificar";
            this.btnmodificar.Size = new System.Drawing.Size(87, 28);
            this.btnmodificar.TabIndex = 1;
            this.btnmodificar.Text = "Nuevo";
            this.btnmodificar.UseVisualStyleBackColor = true;
            this.btnmodificar.Click += new System.EventHandler(this.btnmodificar_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(26, 160);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 28);
            this.button1.TabIndex = 2;
            this.button1.Text = "Actualizar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(26, 228);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(87, 28);
            this.button2.TabIndex = 3;
            this.button2.Text = "Borrar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // checkProveedor
            // 
            this.checkProveedor.AutoSize = true;
            this.checkProveedor.Location = new System.Drawing.Point(27, 300);
            this.checkProveedor.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.checkProveedor.Name = "checkProveedor";
            this.checkProveedor.Size = new System.Drawing.Size(84, 20);
            this.checkProveedor.TabIndex = 4;
            this.checkProveedor.Text = "Proveedor";
            this.checkProveedor.UseVisualStyleBackColor = true;
            this.checkProveedor.CheckedChanged += new System.EventHandler(this.checkProveedor_CheckedChanged);
            // 
            // cbxbuscarproveedor
            // 
            this.cbxbuscarproveedor.FormattingEnabled = true;
            this.cbxbuscarproveedor.Location = new System.Drawing.Point(27, 354);
            this.cbxbuscarproveedor.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbxbuscarproveedor.Name = "cbxbuscarproveedor";
            this.cbxbuscarproveedor.Size = new System.Drawing.Size(140, 24);
            this.cbxbuscarproveedor.TabIndex = 5;
            this.cbxbuscarproveedor.SelectedIndexChanged += new System.EventHandler(this.cbxbuscarproveedor_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(293, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 32);
            this.label1.TabIndex = 6;
            this.label1.Text = "Proveedores";
            // 
            // ProveedoresForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 421);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbxbuscarproveedor);
            this.Controls.Add(this.checkProveedor);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnmodificar);
            this.Controls.Add(this.viewProveedor);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "ProveedoresForm";
            this.Text = "ProveedoresForm";
            this.Load += new System.EventHandler(this.ProveedoresForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.viewProveedor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView viewProveedor;
        private System.Windows.Forms.Button btnmodificar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.CheckBox checkProveedor;
        private System.Windows.Forms.ComboBox cbxbuscarproveedor;
        private System.Windows.Forms.Label label1;
    }
}