﻿namespace unimex.lenguajesv.cine.views
{
    partial class ReportePyCDAOForm
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
            this.reporteDgv = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.reporteDgv)).BeginInit();
            this.SuspendLayout();
            // 
            // reporteDgv
            // 
            this.reporteDgv.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.reporteDgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.reporteDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.reporteDgv.Location = new System.Drawing.Point(12, 63);
            this.reporteDgv.Name = "reporteDgv";
            this.reporteDgv.RowTemplate.Height = 24;
            this.reporteDgv.Size = new System.Drawing.Size(550, 378);
            this.reporteDgv.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(554, 40);
            this.label1.TabIndex = 1;
            this.label1.Text = "Reporte por Película y Complejo";
            // 
            // ReportePyCDAOForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(578, 453);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.reporteDgv);
            this.Name = "ReportePyCDAOForm";
            this.Text = "Reporte por Película y Complejo";
            this.Load += new System.EventHandler(this.ReportePyCDAOForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.reporteDgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView reporteDgv;
        private System.Windows.Forms.Label label1;
    }
}