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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.operando1txt = new System.Windows.Forms.NumericUpDown();
            this.operando2txt = new System.Windows.Forms.NumericUpDown();
            this.operando3txt = new System.Windows.Forms.NumericUpDown();
            this.operando4txt = new System.Windows.Forms.NumericUpDown();
            this.sumabtn = new System.Windows.Forms.Button();
            this.resultado = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.operando1txt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.operando2txt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.operando3txt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.operando4txt)).BeginInit();
            this.SuspendLayout();
            // 
            // operando1txt
            // 
            this.operando1txt.Location = new System.Drawing.Point(29, 132);
            this.operando1txt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.operando1txt.Name = "operando1txt";
            this.operando1txt.Size = new System.Drawing.Size(101, 21);
            this.operando1txt.TabIndex = 4;
            // 
            // operando2txt
            // 
            this.operando2txt.Location = new System.Drawing.Point(29, 228);
            this.operando2txt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.operando2txt.Name = "operando2txt";
            this.operando2txt.Size = new System.Drawing.Size(101, 21);
            this.operando2txt.TabIndex = 5;
            // 
            // operando3txt
            // 
            this.operando3txt.Location = new System.Drawing.Point(209, 132);
            this.operando3txt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.operando3txt.Name = "operando3txt";
            this.operando3txt.Size = new System.Drawing.Size(101, 21);
            this.operando3txt.TabIndex = 6;
            // 
            // operando4txt
            // 
            this.operando4txt.Location = new System.Drawing.Point(209, 228);
            this.operando4txt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.operando4txt.Name = "operando4txt";
            this.operando4txt.Size = new System.Drawing.Size(101, 21);
            this.operando4txt.TabIndex = 7;
            // 
            // sumabtn
            // 
            this.sumabtn.Location = new System.Drawing.Point(103, 277);
            this.sumabtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.sumabtn.Name = "sumabtn";
            this.sumabtn.Size = new System.Drawing.Size(145, 51);
            this.sumabtn.TabIndex = 28;
            this.sumabtn.Text = "Realizar Corte de Caja";
            this.sumabtn.UseVisualStyleBackColor = true;
            this.sumabtn.Click += new System.EventHandler(this.sumabtn_Click);
            // 
            // resultado
            // 
            this.resultado.Location = new System.Drawing.Point(128, 345);
            this.resultado.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.resultado.Name = "resultado";
            this.resultado.Size = new System.Drawing.Size(102, 21);
            this.resultado.TabIndex = 30;
            this.resultado.TextChanged += new System.EventHandler(this.resultado_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(206, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 16);
            this.label1.TabIndex = 31;
            this.label1.Text = "Taquilla Tarjeta";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(206, 196);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 16);
            this.label2.TabIndex = 32;
            this.label2.Text = "Dulcería Tarjeta";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 16);
            this.label3.TabIndex = 33;
            this.label3.Text = "Taquilla Efectivo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 196);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 16);
            this.label4.TabIndex = 34;
            this.label4.Text = "Dulcería Efectivo ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(78, 34);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(202, 32);
            this.label5.TabIndex = 35;
            this.label5.Text = "Corte de Caja";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 397);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.resultado);
            this.Controls.Add(this.sumabtn);
            this.Controls.Add(this.operando4txt);
            this.Controls.Add(this.operando3txt);
            this.Controls.Add(this.operando2txt);
            this.Controls.Add(this.operando1txt);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}