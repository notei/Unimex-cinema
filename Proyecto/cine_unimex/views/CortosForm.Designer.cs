namespace unimex.lenguajesv.cine.views
{
    partial class CortosForm
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
            this.dgvcortos = new System.Windows.Forms.DataGridView();
            this.Agregarbtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvcortos)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvcortos
            // 
            this.dgvcortos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvcortos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvcortos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvcortos.Location = new System.Drawing.Point(144, 12);
            this.dgvcortos.Name = "dgvcortos";
            this.dgvcortos.Size = new System.Drawing.Size(727, 387);
            this.dgvcortos.TabIndex = 0;
            // 
            // Agregarbtn
            // 
            this.Agregarbtn.Location = new System.Drawing.Point(47, 56);
            this.Agregarbtn.Name = "Agregarbtn";
            this.Agregarbtn.Size = new System.Drawing.Size(75, 23);
            this.Agregarbtn.TabIndex = 1;
            this.Agregarbtn.Text = "Agregar";
            this.Agregarbtn.UseVisualStyleBackColor = true;
            this.Agregarbtn.Click += new System.EventHandler(this.Agregarbtn_Click);
            // 
            // CortosForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(894, 411);
            this.Controls.Add(this.Agregarbtn);
            this.Controls.Add(this.dgvcortos);
            this.Name = "CortosForm";
            this.Text = "CortosForm";
            this.Load += new System.EventHandler(this.CortosForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvcortos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvcortos;
        private System.Windows.Forms.Button Agregarbtn;
    }
}