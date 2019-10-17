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
    public partial class FrmAdicionarProduto : Form
    {
        public FrmAdicionarProduto()
        {
            InitializeComponent();
        }


        Database.Database_Produtos DB = new Database.Database_Produtos();
        private void button1_Click(object sender, EventArgs e)
        {
            Database.Entity.tb_produto_compra altproduto = new Database.Entity.tb_produto_compra();

            altproduto.nm_produto = textBox1.Text;

            altproduto.qtd_produto = Convert.ToInt32(numericUpDown1.Value);

            Business.Business_Produtos produtos = new Business.Business_Produtos();
            produtos.CadastrarProduto(altproduto);

            MessageBox.Show("Produto cadastrado com sucesso");
        }

        private void FrmAdicionarProduto_Load(object sender, EventArgs e)
        {
         
        }
    }
}
