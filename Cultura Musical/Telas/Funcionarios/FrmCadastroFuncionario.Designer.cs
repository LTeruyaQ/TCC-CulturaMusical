namespace Cultura_Musical.Telas
{
    partial class dtpNascimento
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
            this.cboGenero = new System.Windows.Forms.ComboBox();
            this.txtCEP = new System.Windows.Forms.MaskedTextBox();
            this.dtpContratacao = new System.Windows.Forms.DateTimePicker();
            this.txtCargo = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.txtBairro = new System.Windows.Forms.TextBox();
            this.txtEstado = new System.Windows.Forms.TextBox();
            this.txtRua = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.nudVa = new System.Windows.Forms.NumericUpDown();
            this.nudVt = new System.Windows.Forms.NumericUpDown();
            this.nudVr = new System.Windows.Forms.NumericUpDown();
            this.nudSalario = new System.Windows.Forms.NumericUpDown();
            this.label21 = new System.Windows.Forms.Label();
            this.nudNumero = new System.Windows.Forms.NumericUpDown();
            this.txtComplemento = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label28 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label26 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtRG = new System.Windows.Forms.MaskedTextBox();
            this.label25 = new System.Windows.Forms.Label();
            this.txtTelefone = new System.Windows.Forms.MaskedTextBox();
            this.label27 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.txtMascara = new System.Windows.Forms.MaskedTextBox();
            this.rdnCNPJ = new System.Windows.Forms.RadioButton();
            this.rdnCPF = new System.Windows.Forms.RadioButton();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpSaida = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dtpEntrada = new System.Windows.Forms.DateTimePicker();
            this.dtpAlmoco = new System.Windows.Forms.DateTimePicker();
            this.label13 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.label14 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudVa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudVt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudVr)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSalario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumero)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.SuspendLayout();
            // 
            // cboGenero
            // 
            this.cboGenero.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboGenero.FormattingEnabled = true;
            this.cboGenero.Items.AddRange(new object[] {
            "Masculino",
            "Feminino"});
            this.cboGenero.Location = new System.Drawing.Point(73, 82);
            this.cboGenero.Name = "cboGenero";
            this.cboGenero.Size = new System.Drawing.Size(101, 21);
            this.cboGenero.TabIndex = 58;
            // 
            // txtCEP
            // 
            this.txtCEP.Location = new System.Drawing.Point(57, 28);
            this.txtCEP.Mask = "00000-000";
            this.txtCEP.Name = "txtCEP";
            this.txtCEP.Size = new System.Drawing.Size(100, 20);
            this.txtCEP.TabIndex = 57;
            this.txtCEP.Leave += new System.EventHandler(this.txtCEP_Leave);
            // 
            // dtpContratacao
            // 
            this.dtpContratacao.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpContratacao.Location = new System.Drawing.Point(296, 32);
            this.dtpContratacao.Name = "dtpContratacao";
            this.dtpContratacao.Size = new System.Drawing.Size(100, 20);
            this.dtpContratacao.TabIndex = 56;
            // 
            // txtCargo
            // 
            this.txtCargo.Location = new System.Drawing.Point(65, 63);
            this.txtCargo.Name = "txtCargo";
            this.txtCargo.Size = new System.Drawing.Size(100, 20);
            this.txtCargo.TabIndex = 52;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(22, 84);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(45, 13);
            this.label10.TabIndex = 46;
            this.label10.Text = "Genêro:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(23, 66);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(38, 13);
            this.label9.TabIndex = 45;
            this.label9.Text = "Cargo:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(19, 31);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(31, 13);
            this.label8.TabIndex = 44;
            this.label8.Text = "CEP:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(19, 32);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 13);
            this.label7.TabIndex = 43;
            this.label7.Text = "Salário:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(293, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 39;
            this.label3.Text = "Data de Inicio:";
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Location = new System.Drawing.Point(373, 505);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(156, 59);
            this.btnCadastrar.TabIndex = 35;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(25, 105);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 13);
            this.label6.TabIndex = 64;
            this.label6.Text = "Rua:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(19, 34);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(43, 13);
            this.label15.TabIndex = 65;
            this.label15.Text = "Estado:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(25, 68);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(37, 13);
            this.label16.TabIndex = 66;
            this.label16.Text = "Bairro:";
            // 
            // txtBairro
            // 
            this.txtBairro.Location = new System.Drawing.Point(68, 65);
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(100, 20);
            this.txtBairro.TabIndex = 67;
            // 
            // txtEstado
            // 
            this.txtEstado.Location = new System.Drawing.Point(68, 31);
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.Size = new System.Drawing.Size(100, 20);
            this.txtEstado.TabIndex = 68;
            // 
            // txtRua
            // 
            this.txtRua.Location = new System.Drawing.Point(68, 98);
            this.txtRua.Name = "txtRua";
            this.txtRua.Size = new System.Drawing.Size(223, 20);
            this.txtRua.TabIndex = 69;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(16, 51);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(24, 13);
            this.label18.TabIndex = 72;
            this.label18.Text = "VA:";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(15, 157);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(24, 13);
            this.label19.TabIndex = 74;
            this.label19.Text = "VT:";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(16, 107);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(25, 13);
            this.label20.TabIndex = 76;
            this.label20.Text = "VR:";
            // 
            // nudVa
            // 
            this.nudVa.Location = new System.Drawing.Point(49, 49);
            this.nudVa.Name = "nudVa";
            this.nudVa.Size = new System.Drawing.Size(120, 20);
            this.nudVa.TabIndex = 79;
            // 
            // nudVt
            // 
            this.nudVt.Location = new System.Drawing.Point(49, 155);
            this.nudVt.Name = "nudVt";
            this.nudVt.Size = new System.Drawing.Size(120, 20);
            this.nudVt.TabIndex = 80;
            // 
            // nudVr
            // 
            this.nudVr.Location = new System.Drawing.Point(49, 105);
            this.nudVr.Name = "nudVr";
            this.nudVr.Size = new System.Drawing.Size(120, 20);
            this.nudVr.TabIndex = 81;
            // 
            // nudSalario
            // 
            this.nudSalario.Location = new System.Drawing.Point(65, 25);
            this.nudSalario.Name = "nudSalario";
            this.nudSalario.Size = new System.Drawing.Size(101, 20);
            this.nudSalario.TabIndex = 82;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(235, 31);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(47, 13);
            this.label21.TabIndex = 83;
            this.label21.Text = "Número:";
            // 
            // nudNumero
            // 
            this.nudNumero.Location = new System.Drawing.Point(295, 29);
            this.nudNumero.Name = "nudNumero";
            this.nudNumero.Size = new System.Drawing.Size(99, 20);
            this.nudNumero.TabIndex = 85;
            // 
            // txtComplemento
            // 
            this.txtComplemento.Location = new System.Drawing.Point(294, 68);
            this.txtComplemento.Name = "txtComplemento";
            this.txtComplemento.Size = new System.Drawing.Size(100, 20);
            this.txtComplemento.TabIndex = 87;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(218, 71);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(74, 13);
            this.label22.TabIndex = 86;
            this.label22.Text = "Complemento:";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Location = new System.Drawing.Point(12, 55);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(521, 440);
            this.tabControl1.TabIndex = 88;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(513, 414);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Dados Pessoais";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label28);
            this.groupBox2.Controls.Add(this.txtNome);
            this.groupBox2.Controls.Add(this.dateTimePicker2);
            this.groupBox2.Controls.Add(this.label26);
            this.groupBox2.Controls.Add(this.label24);
            this.groupBox2.Controls.Add(this.txtEmail);
            this.groupBox2.Controls.Add(this.txtRG);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label25);
            this.groupBox2.Controls.Add(this.txtTelefone);
            this.groupBox2.Controls.Add(this.cboGenero);
            this.groupBox2.Controls.Add(this.label27);
            this.groupBox2.Location = new System.Drawing.Point(30, 70);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(462, 179);
            this.groupBox2.TabIndex = 90;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Dados pessoais";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(28, 37);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(38, 13);
            this.label28.TabIndex = 79;
            this.label28.Text = "Nome:";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(72, 34);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(100, 20);
            this.txtNome.TabIndex = 80;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker2.Location = new System.Drawing.Point(320, 122);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(100, 20);
            this.dateTimePicker2.TabIndex = 88;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(275, 37);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(38, 13);
            this.label26.TabIndex = 82;
            this.label26.Text = "E-mail:";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(204, 128);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(107, 13);
            this.label24.TabIndex = 87;
            this.label24.Text = "Data de Nascimento:";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(320, 34);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(100, 20);
            this.txtEmail.TabIndex = 84;
            // 
            // txtRG
            // 
            this.txtRG.Location = new System.Drawing.Point(75, 122);
            this.txtRG.Mask = "00.000.000-0";
            this.txtRG.Name = "txtRG";
            this.txtRG.Size = new System.Drawing.Size(100, 20);
            this.txtRG.TabIndex = 86;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(37, 122);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(29, 13);
            this.label25.TabIndex = 83;
            this.label25.Text = "R.G:";
            // 
            // txtTelefone
            // 
            this.txtTelefone.Location = new System.Drawing.Point(320, 82);
            this.txtTelefone.Mask = "(99)0000-0000";
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(100, 20);
            this.txtTelefone.TabIndex = 85;
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(261, 82);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(52, 13);
            this.label27.TabIndex = 81;
            this.label27.Text = "Telefone:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.maskedTextBox1);
            this.groupBox1.Controls.Add(this.txtMascara);
            this.groupBox1.Controls.Add(this.rdnCNPJ);
            this.groupBox1.Controls.Add(this.rdnCPF);
            this.groupBox1.Location = new System.Drawing.Point(30, 289);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(462, 100);
            this.groupBox1.TabIndex = 89;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tipo";
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(80, 56);
            this.maskedTextBox1.Mask = "000000000/0000-00";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(109, 20);
            this.maskedTextBox1.TabIndex = 68;
            this.maskedTextBox1.Visible = false;
            // 
            // txtMascara
            // 
            this.txtMascara.Location = new System.Drawing.Point(79, 16);
            this.txtMascara.Mask = "000000000/0000-00";
            this.txtMascara.Name = "txtMascara";
            this.txtMascara.Size = new System.Drawing.Size(109, 20);
            this.txtMascara.TabIndex = 67;
            this.txtMascara.Visible = false;
            // 
            // rdnCNPJ
            // 
            this.rdnCNPJ.AutoSize = true;
            this.rdnCNPJ.Location = new System.Drawing.Point(21, 19);
            this.rdnCNPJ.Name = "rdnCNPJ";
            this.rdnCNPJ.Size = new System.Drawing.Size(52, 17);
            this.rdnCNPJ.TabIndex = 66;
            this.rdnCNPJ.Text = "CNPJ";
            this.rdnCNPJ.UseVisualStyleBackColor = true;
            // 
            // rdnCPF
            // 
            this.rdnCPF.AutoSize = true;
            this.rdnCPF.Location = new System.Drawing.Point(22, 59);
            this.rdnCPF.Name = "rdnCPF";
            this.rdnCPF.Size = new System.Drawing.Size(45, 17);
            this.rdnCPF.TabIndex = 65;
            this.rdnCPF.Text = "CPF";
            this.rdnCPF.UseVisualStyleBackColor = true;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox4);
            this.tabPage1.Controls.Add(this.groupBox3);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(513, 414);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "Contratação";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.dtpContratacao);
            this.groupBox4.Controls.Add(this.txtCargo);
            this.groupBox4.Controls.Add(this.nudSalario);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Location = new System.Drawing.Point(23, 119);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(462, 153);
            this.groupBox4.TabIndex = 98;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "groupBox4";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.dtpSaida);
            this.groupBox3.Controls.Add(this.dateTimePicker1);
            this.groupBox3.Controls.Add(this.dtpEntrada);
            this.groupBox3.Controls.Add(this.dtpAlmoco);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Location = new System.Drawing.Point(23, 296);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(462, 96);
            this.groupBox3.TabIndex = 97;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Escala";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(11, 26);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(99, 13);
            this.label12.TabIndex = 90;
            this.label12.Text = "Horário de Entrada:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(243, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 13);
            this.label1.TabIndex = 95;
            this.label1.Text = "Horário de Retoeno:";
            // 
            // dtpSaida
            // 
            this.dtpSaida.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpSaida.Location = new System.Drawing.Point(116, 52);
            this.dtpSaida.Name = "dtpSaida";
            this.dtpSaida.Size = new System.Drawing.Size(100, 20);
            this.dtpSaida.TabIndex = 94;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePicker1.Location = new System.Drawing.Point(352, 52);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(100, 20);
            this.dateTimePicker1.TabIndex = 96;
            // 
            // dtpEntrada
            // 
            this.dtpEntrada.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpEntrada.Location = new System.Drawing.Point(116, 26);
            this.dtpEntrada.Name = "dtpEntrada";
            this.dtpEntrada.Size = new System.Drawing.Size(100, 20);
            this.dtpEntrada.TabIndex = 92;
            // 
            // dtpAlmoco
            // 
            this.dtpAlmoco.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpAlmoco.Location = new System.Drawing.Point(352, 26);
            this.dtpAlmoco.Name = "dtpAlmoco";
            this.dtpAlmoco.Size = new System.Drawing.Size(101, 20);
            this.dtpAlmoco.TabIndex = 93;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(19, 54);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(91, 13);
            this.label13.TabIndex = 91;
            this.label13.Text = "Horário de Saída:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(249, 26);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(97, 13);
            this.label11.TabIndex = 89;
            this.label11.Text = "Horário de Almoço:";
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.groupBox6);
            this.tabPage4.Controls.Add(this.groupBox5);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(513, 414);
            this.tabPage4.TabIndex = 4;
            this.tabPage4.Text = "Informações Residenciais";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.label8);
            this.groupBox6.Controls.Add(this.txtCEP);
            this.groupBox6.Location = new System.Drawing.Point(48, 95);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(407, 59);
            this.groupBox6.TabIndex = 89;
            this.groupBox6.TabStop = false;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label15);
            this.groupBox5.Controls.Add(this.txtEstado);
            this.groupBox5.Controls.Add(this.txtComplemento);
            this.groupBox5.Controls.Add(this.label21);
            this.groupBox5.Controls.Add(this.nudNumero);
            this.groupBox5.Controls.Add(this.label22);
            this.groupBox5.Controls.Add(this.label6);
            this.groupBox5.Controls.Add(this.txtRua);
            this.groupBox5.Controls.Add(this.label16);
            this.groupBox5.Controls.Add(this.txtBairro);
            this.groupBox5.Location = new System.Drawing.Point(48, 148);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(407, 141);
            this.groupBox5.TabIndex = 88;
            this.groupBox5.TabStop = false;
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.groupBox7);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(513, 414);
            this.tabPage5.TabIndex = 5;
            this.tabPage5.Text = "Benefícios";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.label18);
            this.groupBox7.Controls.Add(this.nudVa);
            this.groupBox7.Controls.Add(this.label20);
            this.groupBox7.Controls.Add(this.nudVr);
            this.groupBox7.Controls.Add(this.label19);
            this.groupBox7.Controls.Add(this.nudVt);
            this.groupBox7.Location = new System.Drawing.Point(39, 49);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(427, 241);
            this.groupBox7.TabIndex = 82;
            this.groupBox7.TabStop = false;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Stencil", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(175, 9);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(212, 44);
            this.label14.TabIndex = 78;
            this.label14.Text = "CADASTRO";
            // 
            // dtpNascimento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(545, 576);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.label14);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "dtpNascimento";
            this.Text = "Cadastro de Funcionário";
            this.Load += new System.EventHandler(this.DtpNascimento_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudVa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudVt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudVr)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSalario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumero)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.tabPage5.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cboGenero;
        private System.Windows.Forms.MaskedTextBox txtCEP;
        private System.Windows.Forms.DateTimePicker dtpContratacao;
        private System.Windows.Forms.TextBox txtCargo;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtBairro;
        private System.Windows.Forms.TextBox txtEstado;
        private System.Windows.Forms.TextBox txtRua;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.NumericUpDown nudVa;
        private System.Windows.Forms.NumericUpDown nudVt;
        private System.Windows.Forms.NumericUpDown nudVr;
        private System.Windows.Forms.NumericUpDown nudSalario;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.NumericUpDown nudNumero;
        private System.Windows.Forms.TextBox txtComplemento;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.MaskedTextBox txtRG;
        private System.Windows.Forms.MaskedTextBox txtTelefone;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.DateTimePicker dtpAlmoco;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DateTimePicker dtpEntrada;
        private System.Windows.Forms.DateTimePicker dtpSaida;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.MaskedTextBox txtMascara;
        private System.Windows.Forms.RadioButton rdnCNPJ;
        private System.Windows.Forms.RadioButton rdnCPF;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox7;
    }
}