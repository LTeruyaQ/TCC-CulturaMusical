using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cultura_Musical.Telas.CRM
{
    public partial class FrmAdicionarCliente : Form
    {
        public FrmAdicionarCliente()
        {
            InitializeComponent();

            Database.Entity.tb_cliente cliente = new Database.Entity.tb_cliente();
            cliente.nmr_cliente = Convert.ToInt32(nudnumero.Value);
            cliente.nm_cliente = txtnome.Text;
            cliente.nm_responsavel = txtresponsavel.Text;
            cliente.ds_bairro = txtBairro.Text;
            cliente.ds_cep = mskCEP.Text;
            cliente.ds_cpf = txtcpf.Text;
            cliente.ds_periodo = cboperiodo.Text;
            cliente.ds_observacao = txtobservacao.Text;
            cliente.ds_rg = txtRG.Text;
            cliente.ds_telefone = mskTel1.Text;
            cliente.dt_nascimento = dtpNascimento.Value.Date;
            cliente.ds_estado = txtEstado.Text;

            Business.Business_Cliente bus = new Business.Business_Cliente();
            bus.CadastrarCliente(cliente);
        }
    }
}
