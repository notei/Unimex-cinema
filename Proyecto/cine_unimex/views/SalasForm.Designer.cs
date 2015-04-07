namespace unimex.lenguajesv.cine.views
{
    partial class SalasForm
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
            this.dataG = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.btnact = new System.Windows.Forms.Button();
            this.combox1 = new System.Windows.Forms.ComboBox();
            this.Checksala = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataG)).BeginInit();
            this.SuspendLayout();
            // 
            // dataG
            // 
            this.dataG.AllowUserToAddRows = false;
            this.dataG.AllowUserToDeleteRows = false;
            this.dataG.AllowUserToOrderColumns = true;
            this.dataG.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataG.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataG.Location = new System.Drawing.Point(208, 117);
            this.dataG.Name = "dataG";
            this.dataG.RowTemplate.Height = 24;
            this.dataG.Size = new System.Drawing.Size(733, 492);
            this.dataG.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(39, 140);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 33);
            this.button1.TabIndex = 1;
            this.button1.Text = "Insertar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnact
            // 
            this.btnact.Location = new System.Drawing.Point(39, 302);
            this.btnact.Name = "btnact";
            this.btnact.Size = new System.Drawing.Size(90, 28);
            this.btnact.TabIndex = 2;
            this.btnact.Text = "Actualizar";
            this.btnact.UseVisualStyleBackColor = true;
            this.btnact.Click += new System.EventHandler(this.btnact_Click);
            // 
            // combox1
            // 
            this.combox1.FormattingEnabled = true;
            this.combox1.Location = new System.Drawing.Point(797, 61);
            this.combox1.Name = "combox1";
            this.combox1.Size = new System.Drawing.Size(121, 24);
            this.combox1.TabIndex = 3;
            this.combox1.SelectedIndexChanged += new System.EventHandler(this.combox1_SelectedIndexChanged);
            // 
            // Checksala
            // 
            this.Checksala.AutoSize = true;
            this.Checksala.Location = new System.Drawing.Point(675, 61);
            this.Checksala.Name = "Checksala";
            this.Checksala.Size = new System.Drawing.Size(65, 21);
            this.Checksala.TabIndex = 4;
            this.Checksala.Text = "Salas";
            this.Checksala.UseVisualStyleBackColor = true;
            this.Checksala.CheckedChanged += new System.EventHandler(this.Checksala_CheckedChanged);
            // 
            // SalasForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(953, 629);
            this.Controls.Add(this.Checksala);
            this.Controls.Add(this.combox1);
            this.Controls.Add(this.btnact);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataG);
            this.Name = "SalasForm";
            this.Text = "SalasForm";
            this.Load += new System.EventHandler(this.ComplejosForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataG)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataG;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnact;
        private System.Windows.Forms.ComboBox combox1;
        private System.Windows.Forms.CheckBox Checksala;

    }
}