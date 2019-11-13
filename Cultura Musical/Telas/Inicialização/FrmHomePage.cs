using IBM.Cloud.SDK.Core.Authentication.Iam;
using IBM.Watson.SpeechToText.v1;
using IBM.Watson.TextToSpeech.v1;
using Stannieman.AudioPlayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cultura_Musical.Telas
{
    public partial class FrmHomePage : Form
    {
        public FrmHomePage()
        {
            InitializeComponent();
        }

        //API_s.IBM_Voice ibm = new API_s.IBM_Voice();

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void FrmHomePage_Load(object sender, EventArgs e)
        {

        }

        private void userControl11_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void btnFalar_Click(object sender, EventArgs e)
        {
            //ibm.IniciarOuvir();
        }

        private void btnParar_Click(object sender, EventArgs e)
        {
            //string texto = ibm.PararOuvir();
            //lblFalar.Text = texto;            
        }

        private void lblFalar_TextChanged(object sender, EventArgs e)
        {

        }

        private void inserirToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Telas.Funcionarios.frmCadastroFuncionarioD tela = new Funcionarios.frmCadastroFuncionarioD();
            tela.Show();
            this.Hide();

        }

        private void consultarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Telas.Funcionarios.frmConsultarFuncionarioD tela = new Funcionarios.frmConsultarFuncionarioD();
            tela.Show();
            this.Hide();
        }

        private void alterarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            
        }

        private void removerToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void inserirToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Telas.Produtos.frmAdicionarPedidoD tela = new Produtos.frmAdicionarPedidoD();
            tela.Show();
            this.Hide();
        }

        private void consultarToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Telas.Produtos.frmConsultarPedidoD tela = new Produtos.frmConsultarPedidoD();
            tela.Show();
            this.Hide();
        }

        private void inserirToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            Telas.Fornecedores.FrmAdicionarFornecedor tela = new Fornecedores.FrmAdicionarFornecedor();
            tela.Show();
            this.Hide();
        }

        private void consultarToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            Telas.Fornecedores.FrmConsultarFornecedores tela = new Fornecedores.FrmConsultarFornecedores();
            tela.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Telas.Folha_Pagamento.frmGerarFolhaD tela = new Folha_Pagamento.frmGerarFolhaD();
            tela.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void alterarToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            
        }

        private void cmsProdutos_Opening(object sender, CancelEventArgs e)
        {
        }

        private void inserirToolStripMenuItem2_Click_1(object sender, EventArgs e)
        {
            Telas.Produtos.frmAdicionarPedidoD tela = new Produtos.frmAdicionarPedidoD();
            tela.Show();
            this.Hide();
        }

        private void inserirToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            Telas.Planos.frmAdicionarPlano tela = new Planos.frmAdicionarPlano();
            tela.Show();
            this.Hide();
        }

        private void lblFechar_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("Realmente deseja fechar o sistema ?", "Cultura Musical",
                     MessageBoxButtons.YesNo,
                     MessageBoxIcon.Warning);

            if (r == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void lblMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            Telas.Folha_Pagamento.frmGerarFolhaD tela = new Folha_Pagamento.frmGerarFolhaD();
            tela.Show();
            this.Hide();

        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            Telas.Logistica.Fluxo_de_Caixa.frmFluxoD tela = new Logistica.Fluxo_de_Caixa.frmFluxoD();
            tela.Show();
            this.Hide();
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {

        }

        private void btnOuvir_Click(object sender, EventArgs e)
        {
            string texto = txtFrase.Text;

            this.FalarTextoDigitado(texto);
        }

        private async void FalarTextoDigitado(string texto)
        {


            IamAuthenticator authenticator = new IamAuthenticator(
                apikey: "o2 - D_Y6DWPSK_Wtm519CBijV_BcA19Uo0hw4Ia6q0_pa");

            TextToSpeechService service = new TextToSpeechService(authenticator);
            service.SetServiceUrl("https://stream.watsonplatform.net/text-to-speech/api");

            var result = service.Synthesize(
                text: texto,
                accept: "audio/wav",
                voice: "pt-BR_IsabelaVoice"
                );

            using (FileStream fs = File.Create("culturamusical_texto_voz.wav"))
            {
                result.Result.WriteTo(fs);
                fs.Close();
                result.Result.Close();
            }

            AudioPlayer player = new AudioPlayer();
            await player.SetFileAsync("culturamusical_texto_voz.wav", "culturamusical_texto_voz.wav");
            await player.PlayAsync();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            mciSendString("open new Type waveaudio alias meuaudio", null, 0, IntPtr.Zero);
            mciSendString("record meuaudio", null,0,IntPtr.Zero);

            IamAuthenticator authenticator = new IamAuthenticator(
                apikey: "4noTfRXdr0y33fvxNlAMiWH8oE2_DPbnBZ78sz_LvlKx");

            SpeechToTextService service = new SpeechToTextService(authenticator);
            service.SetServiceUrl("https://stream.watsonplatform.net/speech-to-text/api ");

            var result = service.Recognize(
                audio: File.ReadAllBytes("culturamusical_texto_voz.wav"),
                contentType: "audio/wav",
               model: "pt-BR_NarrowbandModel"
                );

            string textoIbm = result.Result.Results.First().Alternatives.First().Transcript;

            txtFrase.Text = textoIbm;

               

        }

        [System.Runtime.InteropServices.DllImport("winm.dll")]

        private static extern long mciSendString(string comando, StringBuilder sb, int length, IntPtr cb);

        private void button9_Click(object sender, EventArgs e)
        {
            mciSendString("save meuaudio cultura_voz.wav", null, 0, IntPtr.Zero);
            mciSendString("close meuaudio", null, 0, IntPtr.Zero);
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            button1.BackColor = Color.SkyBlue;
            button1.ForeColor = Color.Black;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.BackColor = Color.Black;
            button1.ForeColor = Color.White;
        }

        private void button2_MouseEnter(object sender, EventArgs e)
        {
            button2.BackColor = Color.SkyBlue;
            button2.ForeColor = Color.Black;
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            button2.BackColor = Color.Black;
            button2.ForeColor = Color.White;
        }

        private void button4_MouseEnter(object sender, EventArgs e)
        {
            button4.BackColor = Color.SkyBlue;
            button4.ForeColor = Color.Black;
        }

        private void button4_MouseLeave(object sender, EventArgs e)
        {
            button4.BackColor = Color.Black;
            button4.ForeColor = Color.White;
        }

        private void button3_MouseEnter(object sender, EventArgs e)
        {
            button3.BackColor = Color.SkyBlue;
            button3.ForeColor = Color.Black;
        }

        private void button3_MouseLeave(object sender, EventArgs e)
        {
            button3.BackColor = Color.Black;
            button3.ForeColor = Color.White;
        }

        private void button5_MouseEnter(object sender, EventArgs e)
        {
            button5.BackColor = Color.SkyBlue;
            button5.ForeColor = Color.Black;
        }

        private void button5_MouseLeave(object sender, EventArgs e)
        {
            button5.BackColor = Color.Black;
            button5.ForeColor = Color.White;
        }

        private void button6_MouseEnter(object sender, EventArgs e)
        {
            button6.BackColor = Color.SkyBlue;
            button6.ForeColor = Color.Black;
        }

        private void button6_MouseLeave(object sender, EventArgs e)
        {
            button6.BackColor = Color.Black;
            button6.ForeColor = Color.White;
        }

        private void button7_MouseEnter(object sender, EventArgs e)
        {
            button7.BackColor = Color.SkyBlue;
            button7.ForeColor = Color.Black;
        }

        private void button7_MouseLeave(object sender, EventArgs e)
        {
            button7.BackColor = Color.Black;
            button7.ForeColor = Color.White;
        }

        private void button8_MouseEnter(object sender, EventArgs e)
        {
            button8.BackColor = Color.SkyBlue;
            button8.ForeColor = Color.Black;
        }

        private void button8_MouseLeave(object sender, EventArgs e)
        {
            button8.BackColor = Color.Black;
            button8.ForeColor = Color.White;
        }
    }
}
