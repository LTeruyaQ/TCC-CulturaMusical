namespace Cultura_Musical.Telas.Logistica.Fluxo_de_Caixa
{
    partial class FrmConsultarEntradasESaidas
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
            this.dgvFluxo_de_Caixa = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFluxo_de_Caixa)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvFluxo_de_Caixa
            // 
            this.dgvFluxo_de_Caixa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFluxo_de_Caixa.Location = new System.Drawing.Point(131, 116);
            this.dgvFluxo_de_Caixa.Name = "dgvFluxo_de_Caixa";
            this.dgvFluxo_de_Caixa.Size = new System.Drawing.Size(512, 309);
            this.dgvFluxo_de_Caixa.TabIndex = 1;
            this.dgvFluxo_de_Caixa.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFluxo_de_Caixa_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Stencil", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(153, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Fluxo de Caixa";
            // 
            // FrmConsultarEntradasESaidas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(813, 562);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvFluxo_de_Caixa);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmConsultarEntradasESaidas";
            this.Text = "FrmConsultarEntradasESaidas";
            ((System.ComponentModel.ISupportInitialize)(this.dgvFluxo_de_Caixa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvFluxo_de_Caixa;
        private System.Windows.Forms.Label label1;
    }
}