using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cultura_Musical.Telas.Funcionarios
{
    public partial class frmAlterarFuncionario : Form
    {
        Business.Business_Funcionarios Bus = new Business.Business_Funcionarios();

        public frmAlterarFuncionario()
        {
            InitializeComponent();

            Database.Entity.tb_funcionario funcionario = new Database.Entity.tb_funcionario();

            this.CarregarCampos(funcionario);
        }

        private void CarregarCampos(Database.Entity.tb_funcionario funcionario)
        {
            txtNome.Text = funcionario.nm_funcionario;
            dtpNascimento.Value = funcionario.dt_nascimento.Date;
            dtpContratacao.Value= funcionario.dt_contratacao.Date;
            nudSalario.Value = Convert.ToDecimal(funcionario.vl_salario);
            txtTelefone.Text = funcionario.ds_telefone;
            txtEmail.Text = funcionario.ds_email;
            txtRG.Text = funcionario.ds_rg;
            txtMascara.Text = funcionario.ds_cpf;
            txtCEP.Text = funcionario.ds_cep;
            txtCargo.Text = funcionario.ds_cargo;
            txtRua.Text = funcionario.ds_rua;
            cboEstado.Text = funcionario.ds_estado;
            txtCidade.Text = funcionario.ds_cidade;
            txtComplemento.Text = funcionario.ds_complemento;
            txtBairro.Text = funcionario.ds_bairro;            
            nudNumero.Value = Convert.ToInt32(funcionario.nmr_funcionario);
            picFoto.Image = CarregarImagem(funcionario.ft_funcionario);

            Bus.BuscarFuncionario(funcionario);

        }


        private Image CarregarImagem(byte[] imagem)
        {
            if(imagem == null)
            {
                return null;
            }

            using (var ms = new System.IO.MemoryStream(imagem))
            {
                return System.Drawing.Image.FromStream(ms);

            }
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

        private void frmAlterarFuncionario_Load(object sender, EventArgs e)
        {

        }

        Business.Business_Funcionarios colaboradorBus = new Business.Business_Funcionarios();
        Business.Business_Jornada JornadaBus = new Business.Business_Jornada();
        Business.Business_Beneficio BeneficioBus = new Business.Business_Beneficio();


        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                Database.Entity.tb_funcionario funcionario = new Database.Entity.tb_funcionario();
                Database.Entity.tb_jornada Jornada = new Database.Entity.tb_jornada();
                Database.Entity.tb_beneficio Beneficios = new Database.Entity.tb_beneficio();

                Beneficios.ds_gratificacao = 0;
                Beneficios.ds_va = 6;
                Beneficios.ds_vt = 8;
                Beneficios.ds_convenio = 0;
                BeneficioBus.InserirBeneficio(Beneficios);


                funcionario.nm_funcionario = txtNome.Text;
                funcionario.dt_nascimento = dtpNascimento.Value.Date;
                funcionario.dt_contratacao = dtpContratacao.Value.Date;
                funcionario.vl_salario = Convert.ToDecimal(nudSalario.Value);
                funcionario.ds_telefone = txtTelefone.Text;
                funcionario.ds_email = txtEmail.Text;
                funcionario.ds_rg = txtRG.Text;
                funcionario.ds_cpf = txtMascara.Text;
                funcionario.ds_cep = txtCEP.Text;
                funcionario.ds_cargo = txtCargo.Text;
                funcionario.ds_rua = txtRua.Text;
                funcionario.ds_estado = cboEstado.Text;
                funcionario.ds_cidade = txtCidade.Text;
                funcionario.ds_complemento = txtComplemento.Text;
                funcionario.ds_bairro = txtBairro.Text;
                funcionario.id_beneficio = Beneficios.id_beneficio;
                funcionario.nmr_funcionario = Convert.ToInt32(nudNumero.Value);
                funcionario.ft_funcionario = this.LerImagem();

                string genero = cboGenero.Text;

                if (genero == "masculino")
                {
                    funcionario.ds_genero = "m";
                }
                else
                {
                    funcionario.ds_genero = "f";
                }

                colaboradorBus.CadastroFuncionario(funcionario);
                Database.Entity.tb_funcionario Func = colaboradorBus.BuscarFuncionario(funcionario);

                Jornada.hr_entrada = dtpEntrada.Value.TimeOfDay;
                Jornada.hr_intervalo = dtpAlmoco.Value.TimeOfDay;
                Jornada.hr_volta_intervalo = dtpRetorno.Value.TimeOfDay;
                Jornada.hr_saida = dtpSaida.Value.TimeOfDay;
                Jornada.id_funcionario = Func.id_funcionario;

                JornadaBus.InserirJornada(Jornada);

                MessageBox.Show("Funcionário cadastrado com sucesso.");

                DialogResult r = MessageBox.Show("Funcionário cadastrado com sucesso.", "Cultura Musical",
                  MessageBoxButtons.OK,
                  MessageBoxIcon.Information);

                this.LimparCampos();
            }

            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void LimparCampos()
        {

            txtNome.Text = string.Empty;
            dtpNascimento.Value = DateTime.Today;
            dtpContratacao.Value = DateTime.Today;
            nudSalario.Value = 0;
            txtTelefone.Text = string.Empty;
            txtEmail.Text = string.Empty;
            txtRG.Text = string.Empty;
            txtMascara.Text = string.Empty;
            txtCEP.Text = string.Empty;
            txtCargo.Text = string.Empty;
            txtRua.Text = string.Empty;
            cboEstado.Text = string.Empty;
            txtCidade.Text = string.Empty;
            txtComplemento.Text = string.Empty;
            txtBairro.Text = string.Empty;
            nudNumero.Value = 0;
        }


        private byte[] LerImagem()
        {
            if (picFoto.Image == null)
            {
                return null;
            }

            using (var ms = new System.IO.MemoryStream())
            {
                picFoto.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                return ms.ToArray();
            }

        }
    }
    
}
