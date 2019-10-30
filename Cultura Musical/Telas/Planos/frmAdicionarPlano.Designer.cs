namespace Cultura_Musical.Telas.Planos
{
    partial class frmAdicionarPlano
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
            this.txtnome = new System.Windows.Forms.Label();
            this.nudqtd = new System.Windows.Forms.NumericUpDown();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtdesc = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.nudpreço = new System.Windows.Forms.NumericUpDown();
            this.txtduração = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudqtd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudpreço)).BeginInit();
            this.SuspendLayout();
            // 
            // txtnome
            // 
            this.txtnome.AutoSize = true;
            this.txtnome.Location = new System.Drawing.Point(35, 43);
            this.txtnome.Name = "txtnome";
            this.txtnome.Size = new System.Drawing.Size(38, 13);
            this.txtnome.TabIndex = 0;
            this.txtnome.Text = "Nome:";
            // 
            // nudqtd
            // 
            this.nudqtd.Location = new System.Drawing.Point(117, 97);
            this.nudqtd.Name = "nudqtd";
            this.nudqtd.Size = new System.Drawing.Size(120, 20);
            this.nudqtd.TabIndex = 1;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(117, 43);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(120, 20);
            this.textBox1.TabIndex = 2;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Quantidade:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 162);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Descrição:";
            // 
            // txtdesc
            // 
            this.txtdesc.Location = new System.Drawing.Point(117, 162);
            this.txtdesc.Name = "txtdesc";
            this.txtdesc.Size = new System.Drawing.Size(120, 20);
            this.txtdesc.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(268, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Valor:";
            // 
            // nudpreço
            // 
            this.nudpreço.Location = new System.Drawing.Point(331, 44);
            this.nudpreço.Name = "nudpreço";
            this.nudpreço.Size = new System.Drawing.Size(120, 20);
            this.nudpreço.TabIndex = 6;
            // 
            // txtduração
            // 
            this.txtduração.Location = new System.Drawing.Point(332, 104);
            this.txtduração.Name = "txtduração";
            this.txtduração.Size = new System.Drawing.Size(119, 20);
            this.txtduração.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(268, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Duração:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(208, 274);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmAdicionarPlano
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 351);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtduração);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.nudpreço);
            this.Controls.Add(this.txtdesc);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.nudqtd);
            this.Controls.Add(this.txtnome);
            this.Name = "frmAdicionarPlano";
            this.Text = "frmAdicionarPlano";
            ((System.ComponentModel.ISupportInitialize)(this.nudqtd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudpreço)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txtnome;
        private System.Windows.Forms.NumericUpDown nudqtd;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtdesc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nudpreço;
        private System.Windows.Forms.TextBox txtduração;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
    }
}