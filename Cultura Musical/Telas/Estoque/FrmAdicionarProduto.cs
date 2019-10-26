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

        Database.Database_Estoque DB = new Database.Database_Estoque();

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Database.Entity.tb_produto addprod = new Database.Entity.tb_produto();

                addprod.nm_produto = txtProduto.Text;
                addprod.vl_preco = Convert.ToInt32(nudPreco.Value);
                addprod.qtd_produto = Convert.ToInt32(nudQtd.Value);

                Business.Business_Estoque produtos = new Business.Business_Estoque();
                produtos.CadastrarProduto(addprod);

                MessageBox.Show("Produto cadastrado com sucesso");
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro, certifique-se de não esqueceu de nehum campo");
            }
        }
    }
}
