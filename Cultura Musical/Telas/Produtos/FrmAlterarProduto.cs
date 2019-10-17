﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cultura_Musical.Telas.Produtos
{
    public partial class FrmAlterarProduto : Form
    {
        public FrmAlterarProduto()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void FrmAlterarProduto_Load(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
     
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Database.Entity.tb_produto_compra altproduto = new Database.Entity.tb_produto_compra();

            altproduto.nm_produto = cboProduto.Text;
            altproduto.nm_produto = cboProdutoAlt.Text;
            altproduto.qtd_produto = Convert.ToInt32(nudQtd.Value);

            Business.Business_Produtos produtos = new Business.Business_Produtos();
            produtos.AlterarProduto(altproduto);

            MessageBox.Show("Produto alterado com sucesso");
        }
    }
}
