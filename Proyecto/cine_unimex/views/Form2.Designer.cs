namespace unimex.lenguajesv.cine.views
{
    partial class Form2
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
            this.operando1txt = new System.Windows.Forms.NumericUpDown();
            this.operando2txt = new System.Windows.Forms.NumericUpDown();
            this.operando3txt = new System.Windows.Forms.NumericUpDown();
            this.operando4txt = new System.Windows.Forms.NumericUpDown();
            this.sumabtn = new System.Windows.Forms.Button();
            this.resultado = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.operando1txt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.operando2txt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.operando3txt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.operando4txt)).BeginInit();
            this.SuspendLayout();
            // 
            // operando1txt
            // 
            this.operando1txt.Location = new System.Drawing.Point(64, 91);
            this.operando1txt.Name = "operando1txt";
            this.operando1txt.Size = new System.Drawing.Size(87, 20);
            this.operando1txt.TabIndex = 4;
            // 
            // operando2txt
            // 
            this.operando2txt.Location = new System.Drawing.Point(64, 224);
            this.operando2txt.Name = "operando2txt";
            this.operando2txt.Size = new System.Drawing.Size(87, 20);
            this.operando2txt.TabIndex = 5;
            // 
            // operando3txt
            // 
            this.operando3txt.Location = new System.Drawing.Point(306, 91);
            this.operando3txt.Name = "operando3txt";
            this.operando3txt.Size = new System.Drawing.Size(87, 20);
            this.operando3txt.TabIndex = 6;
            // 
            // operando4txt
            // 
            this.operando4txt.Location = new System.Drawing.Point(306, 224);
            this.operando4txt.Name = "operando4txt";
            this.operando4txt.Size = new System.Drawing.Size(87, 20);
            this.operando4txt.TabIndex = 7;
            // 
            // sumabtn
            // 
            this.sumabtn.Location = new System.Drawing.Point(159, 276);
            this.sumabtn.Name = "sumabtn";
            this.sumabtn.Size = new System.Drawing.Size(145, 23);
            this.sumabtn.TabIndex = 28;
            this.sumabtn.Text = "Realizar Corte de Caja";
            this.sumabtn.UseVisualStyleBackColor = true;
            this.sumabtn.Click += new System.EventHandler(this.sumabtn_Click);
            // 
            // resultado
            // 
            this.resultado.Location = new System.Drawing.Point(194, 319);
            this.resultado.Name = "resultado";
            this.resultado.Size = new System.Drawing.Size(63, 20);
            this.resultado.TabIndex = 30;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 405);
            this.Controls.Add(this.resultado);
            this.Controls.Add(this.sumabtn);
            this.Controls.Add(this.operando4txt);
            this.Controls.Add(this.operando3txt);
            this.Controls.Add(this.operando2txt);
            this.Controls.Add(this.operando1txt);
            this.Name = "Form2";
            this.Text = "Corte de Caja";
            ((System.ComponentModel.ISupportInitialize)(this.operando1txt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.operando2txt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.operando3txt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.operando4txt)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown operando1txt;
        private System.Windows.Forms.NumericUpDown operando2txt;
        private System.Windows.Forms.NumericUpDown operando3txt;
        private System.Windows.Forms.NumericUpDown operando4txt;
        private System.Windows.Forms.Button sumabtn;
        private System.Windows.Forms.TextBox resultado;
    }
}