using Cliente.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cliente
{
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();
        }

        private void buFechar_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void buFornecedor_Click(object sender, EventArgs e)
        {
            GUI_TabelaFornecedor Fornecedor = new GUI_TabelaFornecedor();
            Fornecedor.ShowDialog();
        }

        private void buProduto_Click(object sender, EventArgs e)
        {
            GUI_TabelaProdutos Produto = new GUI_TabelaProdutos();
            Produto.ShowDialog();
        }

        private void buVendas_Click(object sender, EventArgs e)
        {
            GUI_TabelaVendas Vendas = new GUI_TabelaVendas();
            Vendas.ShowDialog();
        }
    }
}
