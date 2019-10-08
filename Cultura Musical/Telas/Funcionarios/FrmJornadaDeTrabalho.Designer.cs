namespace Cultura_Musical.Telas.Funcionario
{
    partial class FrmJornadaDeTrabalho
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbo = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.rdnHFlexivel = new System.Windows.Forms.RadioButton();
            this.rdnHNoturna = new System.Windows.Forms.RadioButton();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.txtIDFuncionario = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.dtpTotHorasNotunras = new System.Windows.Forms.DateTimePicker();
            this.dtpTotHorasDiurnas = new System.Windows.Forms.DateTimePicker();
            this.dtpDuracaoJornada = new System.Windows.Forms.DateTimePicker();
            this.dtpSaidaJornada = new System.Windows.Forms.DateTimePicker();
            this.dtpEntradaJornada = new System.Windows.Forms.DateTimePicker();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbo);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.textBox3);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(60, 431);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(426, 133);
            this.groupBox1.TabIndex = 37;
            this.groupBox1.TabStop = false;
            // 
            // cbo
            // 
            this.cbo.FormattingEnabled = true;
            this.cbo.Items.AddRange(new object[] {
            "Intervalo em Horário Fixo"});
            this.cbo.Location = new System.Drawing.Point(226, 33);
            this.cbo.Name = "cbo";
            this.cbo.Size = new System.Drawing.Size(121, 21);
            this.cbo.TabIndex = 24;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(16, 93);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(107, 13);
            this.label10.TabIndex = 23;
            this.label10.Text = "Término do Intervalo:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 69);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 13);
            this.label6.TabIndex = 22;
            this.label6.Text = "Início do Intervalo:";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(161, 35);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(23, 20);
            this.textBox3.TabIndex = 21;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 35);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(139, 13);
            this.label5.TabIndex = 21;
            this.label5.Text = "Intervalo/ Tipo de Intervalo:";
            // 
            // rdnHFlexivel
            // 
            this.rdnHFlexivel.AutoSize = true;
            this.rdnHFlexivel.Checked = true;
            this.rdnHFlexivel.Location = new System.Drawing.Point(361, 91);
            this.rdnHFlexivel.Name = "rdnHFlexivel";
            this.rdnHFlexivel.Size = new System.Drawing.Size(99, 17);
            this.rdnHFlexivel.TabIndex = 36;
            this.rdnHFlexivel.TabStop = true;
            this.rdnHFlexivel.Text = "Horário Flexível";
            this.rdnHFlexivel.UseVisualStyleBackColor = true;
            // 
            // rdnHNoturna
            // 
            this.rdnHNoturna.AutoSize = true;
            this.rdnHNoturna.Checked = true;
            this.rdnHNoturna.Location = new System.Drawing.Point(360, 114);
            this.rdnHNoturna.Name = "rdnHNoturna";
            this.rdnHNoturna.Size = new System.Drawing.Size(100, 17);
            this.rdnHNoturna.TabIndex = 35;
            this.rdnHNoturna.TabStop = true;
            this.rdnHNoturna.Text = "Horário Noturno";
            this.rdnHNoturna.UseVisualStyleBackColor = true;
            // 
            // txtDescricao
            // 
            this.txtDescricao.Location = new System.Drawing.Point(215, 151);
            this.txtDescricao.Multiline = true;
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(310, 99);
            this.txtDescricao.TabIndex = 34;
            // 
            // txtIDFuncionario
            // 
            this.txtIDFuncionario.Location = new System.Drawing.Point(215, 116);
            this.txtIDFuncionario.Name = "txtIDFuncionario";
            this.txtIDFuncionario.Size = new System.Drawing.Size(23, 20);
            this.txtIDFuncionario.TabIndex = 28;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(57, 275);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(88, 13);
            this.label9.TabIndex = 27;
            this.label9.Text = "Entrada Jornada:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(57, 311);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 13);
            this.label8.TabIndex = 26;
            this.label8.Text = "Saída Jornada:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(57, 345);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(126, 13);
            this.label7.TabIndex = 25;
            this.label7.Text = "Total de Horas Noturnas:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(57, 415);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(139, 13);
            this.label4.TabIndex = 24;
            this.label4.Text = "Duração da Jornada (horas)";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(53, 380);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 13);
            this.label3.TabIndex = 23;
            this.label3.Text = "Total de Horas Diurnas:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(57, 154);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 22;
            this.label2.Text = "Descrição:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 13);
            this.label1.TabIndex = 21;
            this.label1.Text = "Código do funcionário:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(142, 28);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(230, 25);
            this.label11.TabIndex = 38;
            this.label11.Text = "Jornada de Trabalho";
            // 
            // dtpTotHorasNotunras
            // 
            this.dtpTotHorasNotunras.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpTotHorasNotunras.Location = new System.Drawing.Point(215, 339);
            this.dtpTotHorasNotunras.Name = "dtpTotHorasNotunras";
            this.dtpTotHorasNotunras.Size = new System.Drawing.Size(69, 20);
            this.dtpTotHorasNotunras.TabIndex = 45;
            // 
            // dtpTotHorasDiurnas
            // 
            this.dtpTotHorasDiurnas.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpTotHorasDiurnas.Location = new System.Drawing.Point(215, 374);
            this.dtpTotHorasDiurnas.Name = "dtpTotHorasDiurnas";
            this.dtpTotHorasDiurnas.Size = new System.Drawing.Size(69, 20);
            this.dtpTotHorasDiurnas.TabIndex = 46;
            // 
            // dtpDuracaoJornada
            // 
            this.dtpDuracaoJornada.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpDuracaoJornada.Location = new System.Drawing.Point(215, 415);
            this.dtpDuracaoJornada.Name = "dtpDuracaoJornada";
            this.dtpDuracaoJornada.Size = new System.Drawing.Size(69, 20);
            this.dtpDuracaoJornada.TabIndex = 47;
            // 
            // dtpSaidaJornada
            // 
            this.dtpSaidaJornada.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpSaidaJornada.Location = new System.Drawing.Point(215, 305);
            this.dtpSaidaJornada.Name = "dtpSaidaJornada";
            this.dtpSaidaJornada.Size = new System.Drawing.Size(69, 20);
            this.dtpSaidaJornada.TabIndex = 48;
            // 
            // dtpEntradaJornada
            // 
            this.dtpEntradaJornada.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpEntradaJornada.Location = new System.Drawing.Point(215, 269);
            this.dtpEntradaJornada.Name = "dtpEntradaJornada";
            this.dtpEntradaJornada.Size = new System.Drawing.Size(69, 20);
            this.dtpEntradaJornada.TabIndex = 49;
            // 
            // FrmJornadaDeTrabalho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(552, 576);
            this.Controls.Add(this.dtpEntradaJornada);
            this.Controls.Add(this.dtpSaidaJornada);
            this.Controls.Add(this.dtpDuracaoJornada);
            this.Controls.Add(this.dtpTotHorasDiurnas);
            this.Controls.Add(this.dtpTotHorasNotunras);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.rdnHFlexivel);
            this.Controls.Add(this.rdnHNoturna);
            this.Controls.Add(this.txtDescricao);
            this.Controls.Add(this.txtIDFuncionario);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmJornadaDeTrabalho";
            this.Text = "FrmJornadaDeTrabalho";
            this.Load += new System.EventHandler(this.FrmJornadaDeTrabalho_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbo;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton rdnHFlexivel;
        private System.Windows.Forms.RadioButton rdnHNoturna;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.TextBox txtIDFuncionario;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DateTimePicker dtpTotHorasNotunras;
        private System.Windows.Forms.DateTimePicker dtpTotHorasDiurnas;
        private System.Windows.Forms.DateTimePicker dtpDuracaoJornada;
        private System.Windows.Forms.DateTimePicker dtpSaidaJornada;
        private System.Windows.Forms.DateTimePicker dtpEntradaJornada;
    }
}