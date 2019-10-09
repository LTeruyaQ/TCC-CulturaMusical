namespace Cultura_Musical.Telas
{
    partial class FrmLogin
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.btnConfirmar_Login = new System.Windows.Forms.Button();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Stencil", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(92, 129);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Usuário:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Stencil", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(105, 185);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Senha:";
            // 
            // txtSenha
            // 
            this.txtSenha.BackColor = System.Drawing.SystemColors.HotTrack;
            this.txtSenha.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSenha.ForeColor = System.Drawing.SystemColors.Info;
            this.txtSenha.Location = new System.Drawing.Point(165, 180);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(129, 26);
            this.txtSenha.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Stencil", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(171, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 38);
            this.label3.TabIndex = 4;
            this.label3.Text = "Login";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Cultura_Musical.Properties.Resources.giphy;
            this.pictureBox1.Location = new System.Drawing.Point(-90, -17);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(555, 342);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // txtUsuario
            // 
            this.txtUsuario.BackColor = System.Drawing.SystemColors.HotTrack;
            this.txtUsuario.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuario.ForeColor = System.Drawing.SystemColors.Info;
            this.txtUsuario.Location = new System.Drawing.Point(165, 124);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(129, 26);
            this.txtUsuario.TabIndex = 2;
            // 
            // btnConfirmar_Login
            // 
            this.btnConfirmar_Login.BackColor = System.Drawing.Color.Transparent;
            this.btnConfirmar_Login.Font = new System.Drawing.Font("Stencil", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmar_Login.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnConfirmar_Login.Image = global::Cultura_Musical.Properties.Resources.giphy;
            this.btnConfirmar_Login.Location = new System.Drawing.Point(180, 247);
            this.btnConfirmar_Login.Name = "btnConfirmar_Login";
            this.btnConfirmar_Login.Size = new System.Drawing.Size(104, 32);
            this.btnConfirmar_Login.TabIndex = 6;
            this.btnConfirmar_Login.Text = "Confirmar";
            this.btnConfirmar_Login.UseVisualStyleBackColor = false;
          
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.BackColor = System.Drawing.Color.Transparent;
            this.linkLabel2.LinkColor = System.Drawing.SystemColors.ButtonFace;
            this.linkLabel2.Location = new System.Drawing.Point(187, 221);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(88, 13);
            this.linkLabel2.TabIndex = 8;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "Novo funcionário";
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Red;
            this.BackgroundImage = global::Cultura_Musical.Properties.Resources.giphy;
            this.ClientSize = new System.Drawing.Size(464, 320);
            this.Controls.Add(this.linkLabel2);
            this.Controls.Add(this.btnConfirmar_Login);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmLogin";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Button btnConfirmar_Login;
        private System.Windows.Forms.LinkLabel linkLabel2;
    }
}