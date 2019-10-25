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
            this.label14 = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label24 = new System.Windows.Forms.Label();
            this.txtRG = new System.Windows.Forms.MaskedTextBox();
            this.txtTelefone = new System.Windows.Forms.MaskedTextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label25 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label28 = new System.Windows.Forms.Label();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.dtpAlmoco = new System.Windows.Forms.DateTimePicker();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.dtpEntrada = new System.Windows.Forms.DateTimePicker();
            this.dtpSaida = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtMascara = new System.Windows.Forms.MaskedTextBox();
            this.rdnCNPJ = new System.Windows.Forms.RadioButton();
            this.rdnCPF = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.nudVa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudVt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudVr)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSalario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumero)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cboGenero
            // 
            this.cboGenero.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboGenero.FormattingEnabled = true;
            this.cboGenero.Items.AddRange(new object[] {
            "Masculino",
            "Feminino"});
            this.cboGenero.Location = new System.Drawing.Point(78, 120);
            this.cboGenero.Name = "cboGenero";
            this.cboGenero.Size = new System.Drawing.Size(101, 21);
            this.cboGenero.TabIndex = 58;
            // 
            // txtCEP
            // 
            this.txtCEP.Location = new System.Drawing.Point(115, 48);
            this.txtCEP.Mask = "00000-000";
            this.txtCEP.Name = "txtCEP";
            this.txtCEP.Size = new System.Drawing.Size(100, 20);
            this.txtCEP.TabIndex = 57;
            this.txtCEP.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.txtCEP_MaskInputRejected);
            this.txtCEP.Leave += new System.EventHandler(this.txtCEP_Leave);
            // 
            // dtpContratacao
            // 
            this.dtpContratacao.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpContratacao.Location = new System.Drawing.Point(156, 37);
            this.dtpContratacao.Name = "dtpContratacao";
            this.dtpContratacao.Size = new System.Drawing.Size(100, 20);
            this.dtpContratacao.TabIndex = 56;
            // 
            // txtCargo
            // 
            this.txtCargo.Location = new System.Drawing.Point(235, 83);
            this.txtCargo.Name = "txtCargo";
            this.txtCargo.Size = new System.Drawing.Size(100, 20);
            this.txtCargo.TabIndex = 52;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(27, 122);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(45, 13);
            this.label10.TabIndex = 46;
            this.label10.Text = "Genêro:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(190, 86);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(38, 13);
            this.label9.TabIndex = 45;
            this.label9.Text = "Cargo:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(77, 51);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(31, 13);
            this.label8.TabIndex = 44;
            this.label8.Text = "CEP:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(307, 43);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 13);
            this.label7.TabIndex = 43;
            this.label7.Text = "Salário:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 13);
            this.label3.TabIndex = 39;
            this.label3.Text = "Data de Contratação:";
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Location = new System.Drawing.Point(167, 275);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(156, 63);
            this.btnCadastrar.TabIndex = 35;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(311, 58);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 13);
            this.label6.TabIndex = 64;
            this.label6.Text = "Rua:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(65, 123);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(43, 13);
            this.label15.TabIndex = 65;
            this.label15.Text = "Estado:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(306, 130);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(37, 13);
            this.label16.TabIndex = 66;
            this.label16.Text = "Bairro:";
            // 
            // txtBairro
            // 
            this.txtBairro.Location = new System.Drawing.Point(349, 123);
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(100, 20);
            this.txtBairro.TabIndex = 67;
            // 
            // txtEstado
            // 
            this.txtEstado.Location = new System.Drawing.Point(114, 120);
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.Size = new System.Drawing.Size(100, 20);
            this.txtEstado.TabIndex = 68;
            // 
            // txtRua
            // 
            this.txtRua.Location = new System.Drawing.Point(349, 51);
            this.txtRua.Name = "txtRua";
            this.txtRua.Size = new System.Drawing.Size(100, 20);
            this.txtRua.TabIndex = 69;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(33, 53);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(24, 13);
            this.label18.TabIndex = 72;
            this.label18.Text = "VA:";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(32, 159);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(24, 13);
            this.label19.TabIndex = 74;
            this.label19.Text = "VT:";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(33, 109);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(25, 13);
            this.label20.TabIndex = 76;
            this.label20.Text = "VR:";
            // 
            // nudVa
            // 
            this.nudVa.Location = new System.Drawing.Point(66, 51);
            this.nudVa.Name = "nudVa";
            this.nudVa.Size = new System.Drawing.Size(120, 20);
            this.nudVa.TabIndex = 79;
            // 
            // nudVt
            // 
            this.nudVt.Location = new System.Drawing.Point(66, 157);
            this.nudVt.Name = "nudVt";
            this.nudVt.Size = new System.Drawing.Size(120, 20);
            this.nudVt.TabIndex = 80;
            // 
            // nudVr
            // 
            this.nudVr.Location = new System.Drawing.Point(66, 107);
            this.nudVr.Name = "nudVr";
            this.nudVr.Size = new System.Drawing.Size(120, 20);
            this.nudVr.TabIndex = 81;
            // 
            // nudSalario
            // 
            this.nudSalario.Location = new System.Drawing.Point(355, 38);
            this.nudSalario.Name = "nudSalario";
            this.nudSalario.Size = new System.Drawing.Size(101, 20);
            this.nudSalario.TabIndex = 82;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(56, 211);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(47, 13);
            this.label21.TabIndex = 83;
            this.label21.Text = "Número:";
            // 
            // nudNumero
            // 
            this.nudNumero.Location = new System.Drawing.Point(116, 209);
            this.nudNumero.Name = "nudNumero";
            this.nudNumero.Size = new System.Drawing.Size(99, 20);
            this.nudNumero.TabIndex = 85;
            // 
            // txtComplemento
            // 
            this.txtComplemento.Location = new System.Drawing.Point(349, 211);
            this.txtComplemento.Name = "txtComplemento";
            this.txtComplemento.Size = new System.Drawing.Size(100, 20);
            this.txtComplemento.TabIndex = 87;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(269, 214);
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
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Controls.Add(this.dateTimePicker2);
            this.tabPage2.Controls.Add(this.label24);
            this.tabPage2.Controls.Add(this.txtRG);
            this.tabPage2.Controls.Add(this.txtTelefone);
            this.tabPage2.Controls.Add(this.txtEmail);
            this.tabPage2.Controls.Add(this.label25);
            this.tabPage2.Controls.Add(this.label26);
            this.tabPage2.Controls.Add(this.label27);
            this.tabPage2.Controls.Add(this.txtNome);
            this.tabPage2.Controls.Add(this.label28);
            this.tabPage2.Controls.Add(this.cboGenero);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(513, 414);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Dados Pessoais";
            this.tabPage2.UseVisualStyleBackColor = true;
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
            // dateTimePicker2
            // 
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker2.Location = new System.Drawing.Point(342, 188);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(100, 20);
            this.dateTimePicker2.TabIndex = 88;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(226, 194);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(107, 13);
            this.label24.TabIndex = 87;
            this.label24.Text = "Data de Nascimento:";
            // 
            // txtRG
            // 
            this.txtRG.Location = new System.Drawing.Point(79, 188);
            this.txtRG.Mask = "00.000.000-0";
            this.txtRG.Name = "txtRG";
            this.txtRG.Size = new System.Drawing.Size(100, 20);
            this.txtRG.TabIndex = 86;
            // 
            // txtTelefone
            // 
            this.txtTelefone.Location = new System.Drawing.Point(342, 122);
            this.txtTelefone.Mask = "(99)0000-0000";
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(100, 20);
            this.txtTelefone.TabIndex = 85;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(342, 65);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(100, 20);
            this.txtEmail.TabIndex = 84;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(41, 188);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(29, 13);
            this.label25.TabIndex = 83;
            this.label25.Text = "R.G:";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(297, 68);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(38, 13);
            this.label26.TabIndex = 82;
            this.label26.Text = "E-mail:";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(283, 122);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(52, 13);
            this.label27.TabIndex = 81;
            this.label27.Text = "Telefone:";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(79, 65);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(100, 20);
            this.txtNome.TabIndex = 80;
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(35, 65);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(38, 13);
            this.label28.TabIndex = 79;
            this.label28.Text = "Nome:";
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dtpAlmoco);
            this.tabPage1.Controls.Add(this.dtpContratacao);
            this.tabPage1.Controls.Add(this.label11);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label12);
            this.tabPage1.Controls.Add(this.label13);
            this.tabPage1.Controls.Add(this.dtpEntrada);
            this.tabPage1.Controls.Add(this.nudSalario);
            this.tabPage1.Controls.Add(this.dtpSaida);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.txtCargo);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(513, 414);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "Contratação";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.txtCEP);
            this.tabPage4.Controls.Add(this.txtComplemento);
            this.tabPage4.Controls.Add(this.label8);
            this.tabPage4.Controls.Add(this.label22);
            this.tabPage4.Controls.Add(this.label6);
            this.tabPage4.Controls.Add(this.nudNumero);
            this.tabPage4.Controls.Add(this.label15);
            this.tabPage4.Controls.Add(this.label21);
            this.tabPage4.Controls.Add(this.label16);
            this.tabPage4.Controls.Add(this.txtBairro);
            this.tabPage4.Controls.Add(this.txtEstado);
            this.tabPage4.Controls.Add(this.txtRua);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(513, 414);
            this.tabPage4.TabIndex = 4;
            this.tabPage4.Text = "Informações Residenciais";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.nudVa);
            this.tabPage5.Controls.Add(this.nudVr);
            this.tabPage5.Controls.Add(this.btnCadastrar);
            this.tabPage5.Controls.Add(this.label18);
            this.tabPage5.Controls.Add(this.nudVt);
            this.tabPage5.Controls.Add(this.label19);
            this.tabPage5.Controls.Add(this.label20);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(513, 414);
            this.tabPage5.TabIndex = 5;
            this.tabPage5.Text = "Benefícios";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // dtpAlmoco
            // 
            this.dtpAlmoco.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpAlmoco.Location = new System.Drawing.Point(389, 285);
            this.dtpAlmoco.Name = "dtpAlmoco";
            this.dtpAlmoco.Size = new System.Drawing.Size(101, 20);
            this.dtpAlmoco.TabIndex = 93;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(286, 285);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(97, 13);
            this.label11.TabIndex = 89;
            this.label11.Text = "Horário de Almoço:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(36, 285);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(99, 13);
            this.label12.TabIndex = 90;
            this.label12.Text = "Horário de Entrada:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(138, 349);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(91, 13);
            this.label13.TabIndex = 91;
            this.label13.Text = "Horário de Saída:";
            // 
            // dtpEntrada
            // 
            this.dtpEntrada.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpEntrada.Location = new System.Drawing.Point(141, 285);
            this.dtpEntrada.Name = "dtpEntrada";
            this.dtpEntrada.Size = new System.Drawing.Size(100, 20);
            this.dtpEntrada.TabIndex = 92;
            // 
            // dtpSaida
            // 
            this.dtpSaida.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpSaida.Location = new System.Drawing.Point(235, 347);
            this.dtpSaida.Name = "dtpSaida";
            this.dtpSaida.Size = new System.Drawing.Size(100, 20);
            this.dtpSaida.TabIndex = 94;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtMascara);
            this.groupBox1.Controls.Add(this.rdnCNPJ);
            this.groupBox1.Controls.Add(this.rdnCPF);
            this.groupBox1.Location = new System.Drawing.Point(38, 248);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(462, 100);
            this.groupBox1.TabIndex = 89;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tipo";
            // 
            // txtMascara
            // 
            this.txtMascara.Location = new System.Drawing.Point(85, 35);
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
            this.rdnCPF.Location = new System.Drawing.Point(21, 52);
            this.rdnCPF.Name = "rdnCPF";
            this.rdnCPF.Size = new System.Drawing.Size(45, 17);
            this.rdnCPF.TabIndex = 65;
            this.rdnCPF.Text = "CPF";
            this.rdnCPF.UseVisualStyleBackColor = true;
            // 
            // dtpNascimento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(545, 507);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.label14);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "dtpNascimento";
            this.Text = "Cadastro de Funcionário";
            ((System.ComponentModel.ISupportInitialize)(this.nudVa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudVt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudVr)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSalario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumero)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
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
    }
}