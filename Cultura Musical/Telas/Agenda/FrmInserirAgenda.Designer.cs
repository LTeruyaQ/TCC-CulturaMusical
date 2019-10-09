namespace Cultura_Musical.Telas
{
    partial class FrmAgenda
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
            this.txtCPF = new System.Windows.Forms.MaskedTextBox();
            this.txtRG = new System.Windows.Forms.MaskedTextBox();
            this.txt = new System.Windows.Forms.MaskedTextBox();
            this.txtCelular = new System.Windows.Forms.MaskedTextBox();
            this.txtTelefone = new System.Windows.Forms.MaskedTextBox();
            this.dtpNascimento = new System.Windows.Forms.DateTimePicker();
            this.label15 = new System.Windows.Forms.Label();
            this.dtpRegistro = new System.Windows.Forms.DateTimePicker();
            this.label14 = new System.Windows.Forms.Label();
            this.txtSite = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.cboGrupo = new System.Windows.Forms.ComboBox();
            this.txtUF = new System.Windows.Forms.TextBox();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.txtBairro = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtEndereco = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtCPF
            // 
            this.txtCPF.Location = new System.Drawing.Point(69, 495);
            this.txtCPF.Mask = "00000000000";
            this.txtCPF.Name = "txtCPF";
            this.txtCPF.Size = new System.Drawing.Size(74, 20);
            this.txtCPF.TabIndex = 65;
            // 
            // txtRG
            // 
            this.txtRG.Location = new System.Drawing.Point(69, 431);
            this.txtRG.Mask = "00.000.000-0";
            this.txtRG.Name = "txtRG";
            this.txtRG.Size = new System.Drawing.Size(74, 20);
            this.txtRG.TabIndex = 64;
            // 
            // txt
            // 
            this.txt.Location = new System.Drawing.Point(166, 278);
            this.txt.Mask = "00000-00";
            this.txt.Name = "txt";
            this.txt.Size = new System.Drawing.Size(74, 20);
            this.txt.TabIndex = 63;
            // 
            // txtCelular
            // 
            this.txtCelular.Location = new System.Drawing.Point(185, 141);
            this.txtCelular.Mask = "(99) 00000-0000";
            this.txtCelular.Name = "txtCelular";
            this.txtCelular.Size = new System.Drawing.Size(74, 20);
            this.txtCelular.TabIndex = 62;
            // 
            // txtTelefone
            // 
            this.txtTelefone.Location = new System.Drawing.Point(69, 141);
            this.txtTelefone.Mask = "(99) 0000-0000";
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(74, 20);
            this.txtTelefone.TabIndex = 61;
            // 
            // dtpNascimento
            // 
            this.dtpNascimento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNascimento.Location = new System.Drawing.Point(374, 353);
            this.dtpNascimento.Name = "dtpNascimento";
            this.dtpNascimento.Size = new System.Drawing.Size(96, 20);
            this.dtpNascimento.TabIndex = 60;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(371, 325);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(107, 13);
            this.label15.TabIndex = 59;
            this.label15.Text = "Data de Nascimento:";
            // 
            // dtpRegistro
            // 
            this.dtpRegistro.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpRegistro.Location = new System.Drawing.Point(227, 353);
            this.dtpRegistro.Name = "dtpRegistro";
            this.dtpRegistro.Size = new System.Drawing.Size(96, 20);
            this.dtpRegistro.TabIndex = 58;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(233, 325);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(90, 13);
            this.label14.TabIndex = 57;
            this.label14.Text = "Data de Registro:";
            // 
            // txtSite
            // 
            this.txtSite.Location = new System.Drawing.Point(277, 495);
            this.txtSite.Name = "txtSite";
            this.txtSite.Size = new System.Drawing.Size(74, 20);
            this.txtSite.TabIndex = 56;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(274, 470);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(28, 13);
            this.label13.TabIndex = 55;
            this.label13.Text = "Site:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(66, 470);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(62, 13);
            this.label12.TabIndex = 54;
            this.label12.Text = "CPF/CNPJ:";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(277, 431);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(74, 20);
            this.txtEmail.TabIndex = 53;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(274, 399);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 52;
            this.label5.Text = "E-mail:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(66, 399);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(26, 13);
            this.label11.TabIndex = 51;
            this.label11.Text = "RG:";
            // 
            // cboGrupo
            // 
            this.cboGrupo.FormattingEnabled = true;
            this.cboGrupo.Location = new System.Drawing.Point(69, 353);
            this.cboGrupo.Name = "cboGrupo";
            this.cboGrupo.Size = new System.Drawing.Size(74, 21);
            this.cboGrupo.TabIndex = 50;
            // 
            // txtUF
            // 
            this.txtUF.Location = new System.Drawing.Point(277, 278);
            this.txtUF.Name = "txtUF";
            this.txtUF.Size = new System.Drawing.Size(74, 20);
            this.txtUF.TabIndex = 49;
            // 
            // txtCidade
            // 
            this.txtCidade.Location = new System.Drawing.Point(69, 278);
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(74, 20);
            this.txtCidade.TabIndex = 48;
            // 
            // txtBairro
            // 
            this.txtBairro.Location = new System.Drawing.Point(277, 212);
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(74, 20);
            this.txtBairro.TabIndex = 47;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(274, 182);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(37, 13);
            this.label10.TabIndex = 46;
            this.label10.Text = "Bairro:";
            // 
            // txtEndereco
            // 
            this.txtEndereco.Location = new System.Drawing.Point(69, 212);
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.Size = new System.Drawing.Size(168, 20);
            this.txtEndereco.TabIndex = 45;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(110, 77);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(213, 20);
            this.txtNome.TabIndex = 44;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(274, 248);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(24, 13);
            this.label9.TabIndex = 43;
            this.label9.Text = "UF:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(66, 325);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(39, 13);
            this.label8.TabIndex = 42;
            this.label8.Text = "Grupo:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(163, 248);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 13);
            this.label7.TabIndex = 41;
            this.label7.Text = "CEP:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(66, 248);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 40;
            this.label6.Text = "Cidade:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(66, 182);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 39;
            this.label4.Text = "Endereço:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(182, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 38;
            this.label3.Text = "Celular:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(66, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 37;
            this.label2.Text = "Telefone:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(66, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 36;
            this.label1.Text = "Nome:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(147, 22);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(165, 25);
            this.label16.TabIndex = 66;
            this.label16.Text = "Inserir Agenda";
            // 
            // FrmAgenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(505, 536);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.txtCPF);
            this.Controls.Add(this.txtRG);
            this.Controls.Add(this.txt);
            this.Controls.Add(this.txtCelular);
            this.Controls.Add(this.txtTelefone);
            this.Controls.Add(this.dtpNascimento);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.dtpRegistro);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.txtSite);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.cboGrupo);
            this.Controls.Add(this.txtUF);
            this.Controls.Add(this.txtCidade);
            this.Controls.Add(this.txtBairro);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtEndereco);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmAgenda";
            this.Text = "FrmAgenda";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox txtCPF;
        private System.Windows.Forms.MaskedTextBox txtRG;
        private System.Windows.Forms.MaskedTextBox txt;
        private System.Windows.Forms.MaskedTextBox txtCelular;
        private System.Windows.Forms.MaskedTextBox txtTelefone;
        private System.Windows.Forms.DateTimePicker dtpNascimento;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.DateTimePicker dtpRegistro;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtSite;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cboGrupo;
        private System.Windows.Forms.TextBox txtUF;
        private System.Windows.Forms.TextBox txtCidade;
        private System.Windows.Forms.TextBox txtBairro;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtEndereco;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label16;
    }
}