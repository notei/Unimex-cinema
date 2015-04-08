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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CortosForm));
            this.dgvcortos = new System.Windows.Forms.DataGridView();
            this.Agregarbtn = new System.Windows.Forms.Button();
            this.updatebtn = new System.Windows.Forms.Button();
            this.btnBorrar = new System.Windows.Forms.Button();
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
            this.dgvcortos.Location = new System.Drawing.Point(192, 16);
            this.dgvcortos.Margin = new System.Windows.Forms.Padding(4);
            this.dgvcortos.Name = "dgvcortos";
            this.dgvcortos.Size = new System.Drawing.Size(969, 506);
            this.dgvcortos.TabIndex = 0;
            // 
            // Agregarbtn
            // 
            this.Agregarbtn.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Agregarbtn.Location = new System.Drawing.Point(63, 73);
            this.Agregarbtn.Margin = new System.Windows.Forms.Padding(4);
            this.Agregarbtn.Name = "Agregarbtn";
            this.Agregarbtn.Size = new System.Drawing.Size(100, 30);
            this.Agregarbtn.TabIndex = 1;
            this.Agregarbtn.Text = "Agregar";
            this.Agregarbtn.UseVisualStyleBackColor = true;
            this.Agregarbtn.Click += new System.EventHandler(this.Agregarbtn_Click);
            // 
            // updatebtn
            // 
            this.updatebtn.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updatebtn.Location = new System.Drawing.Point(63, 182);
            this.updatebtn.Margin = new System.Windows.Forms.Padding(4);
            this.updatebtn.Name = "updatebtn";
            this.updatebtn.Size = new System.Drawing.Size(100, 30);
            this.updatebtn.TabIndex = 2;
            this.updatebtn.Text = "Actualizar";
            this.updatebtn.UseVisualStyleBackColor = true;
            this.updatebtn.Click += new System.EventHandler(this.updatebtn_Click);
            // 
            // btnBorrar
            // 
            this.btnBorrar.Location = new System.Drawing.Point(63, 262);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(100, 24);
            this.btnBorrar.TabIndex = 3;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.UseVisualStyleBackColor = true;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // CortosForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1192, 538);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.updatebtn);
            this.Controls.Add(this.Agregarbtn);
            this.Controls.Add(this.dgvcortos);
            this.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "CortosForm";
            this.Text = "CortosForm";
            this.Load += new System.EventHandler(this.CortosForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvcortos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvcortos;
        private System.Windows.Forms.Button Agregarbtn;
        private System.Windows.Forms.Button updatebtn;
        private System.Windows.Forms.Button btnBorrar;
    }
}