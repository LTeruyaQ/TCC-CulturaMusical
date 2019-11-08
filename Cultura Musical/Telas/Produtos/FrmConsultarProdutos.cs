﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cultura_Musical.Telas.Pedidos
{
    public partial class FrmConsultarProdutos : Form
    {
        public FrmConsultarProdutos()
        {
            InitializeComponent();

            Database.Entity.tb_produto pedido = new Database.Entity.tb_produto();

            Business.Business_Pedidos pedidoo = new Business.Business_Pedidos();

           
            List<Database.Entity.tb_produto> con = pedidoo.ListarTudo(pedido);

            dgvListar_Pedidos.DataSource = con;
        }

        public void txtProduto_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string produto = txtProduto.Text;

                Business.Business_Pedidos pedido = new Business.Business_Pedidos();
                List<Database.Entity.tb_produto> con = pedido.ListarProduto(produto);

                dgvListar_Pedidos.DataSource = con;
            }

            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message);
            }

            catch (Exception)
            {
                MessageBox.Show("Oorreu um erro. Tente mais tarde.");
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime data = dtpCompra.Value;

                Business.Business_Pedidos pedido = new Business.Business_Pedidos();
                List<Database.Entity.tb_compra> con = pedido.ListarData(data);

                dgvListar_Pedidos.DataSource = con;
            }

            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message);
            }

            catch (Exception)
            {
                MessageBox.Show("Oorreu um erro. Tente mais tarde.");
            }  
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void dtpCompra_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dgvListar_Pedidos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

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

        private void btnAgenda_Click(object sender, EventArgs e)
        {
            Agenda.FrmConsultarAgenda tela = new Agenda.FrmConsultarAgenda();
            tela.Show();
            this.Hide();
        }

        private void btnColaboradores_Click(object sender, EventArgs e)
        {
            Funcionarios.frmCadastroFuncionarioD tela = new Funcionarios.frmCadastroFuncionarioD();
            tela.Show();
            this.Hide();
        }

        private void btnCRM_Click(object sender, EventArgs e)
        {
            CRM.FrmAdicionarCliente tela = new CRM.FrmAdicionarCliente();
            tela.Show();
            this.Hide();
        }

        private void btnFornecedores_Click(object sender, EventArgs e)
        {
            Fornecedores.FrmAdicionarFornecedor tela = new Fornecedores.FrmAdicionarFornecedor();
            tela.Show();
            this.Hide();
        }

        private void btnHolerite_Click(object sender, EventArgs e)
        {
            Telas.Folha_Pagamento.frmGerarFolhaD tela = new Folha_Pagamento.frmGerarFolhaD();
            tela.Show();
            this.Hide();
        }

        private void btnLogistica_Click(object sender, EventArgs e)
        {
            Logistica.Fluxo_de_Caixa.frmFluxoD tela = new Logistica.Fluxo_de_Caixa.frmFluxoD();
            tela.Show();
            this.Hide();
        }

        private void btnProdutos_Click(object sender, EventArgs e)
        {
            Produtos.frmAdicionarPedidoD tela = new Produtos.frmAdicionarPedidoD();
            tela.Show();
            this.Hide();
        }

        private void btnVendas_Click(object sender, EventArgs e)
        {
            Planos.cbo tela = new Planos.cbo();
            tela.Show();
            this.Hide();
        }

        private void FrmConsultarProdutos_Load(object sender, EventArgs e)
        {

        }
    }
}
