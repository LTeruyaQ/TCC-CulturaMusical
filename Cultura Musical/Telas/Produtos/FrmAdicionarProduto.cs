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
    public partial class FrmAdicionarProduto : Form
    {
        public FrmAdicionarProduto()
        {
            InitializeComponent();
        }

        Business.Business_Pedidos top = new Business.Business_Pedidos();

        private void button1_Click(object sender, EventArgs e)
        {
           
            Database.Entity.tb_produto pedido  = new Database.Entity.tb_produto();

            pedido.nm_produto = txtProduto.Text;
            pedido.qtd_produto = Convert.ToInt32(nudQtd.Value);
            pedido.vl_preco = Convert.ToInt32(nudPreco.Value);

            Database.Entity.tb_compra compra = new Database.Entity.tb_compra();
            compra.dt_compra = dtpCompra.Value;

            Database.Entity.tb_fornecedor forn = new Database.Entity.tb_fornecedor();
            cboFornecedor.DisplayMember = forn.nm_fornecedor;

            cboFornecedor.DataSource = forn;

            
            top.cadastrar(pedido,forn,compra);

            MessageBox.Show("Salvo com sucesso");
        }
    }
}