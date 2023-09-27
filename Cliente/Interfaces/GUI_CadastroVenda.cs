using Cliente.Servicos;
using Equin.ApplicationFramework;
using ProdutoAPI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VendasAPI;

namespace Cliente.Interfaces
{
    public partial class GUI_CadastroVenda : Form
    {
        private Produto produto;
        private Venda venda;
        private string idProduto;
        private string operacaoCadastro;
        public GUI_CadastroVenda(string operacaoCadastro, Venda venda)
        {
            this.operacaoCadastro = operacaoCadastro;
            this.venda = venda;
            InitializeComponent();
            /*
            if (operacaoCadastro == "Alterar")
            {
                tbNomeCliente.Text = venda.Nome_cliente;
                tbCodigo.Text = venda.IdVenda;
                tbQuantidade.Text = venda.Quantidade_produto.ToString();
                tbValorTotal.Text = venda.Preco_total.ToString();
                comboBox1.Text = venda.Nome_produto;
            }
            */
            if (operacaoCadastro == "Incluir" || operacaoCadastro == "Alterar")
            {
                tbCodigo.Enabled = false;
                tbIDProduto.Enabled = false;
                tbQuantidadeEstoque.Enabled = false;
                tbValorUnitario.Enabled = false;
            }
        }

        private async void buOk_Click(object sender, EventArgs e)
        {
            if (tbNomeCliente.Text == ("") || tbQuantidade.Text == ("")
                || tbValorTotal.Text == ("") || comboBox1.Text == (""))
            {
                MessageBox.Show("Um dos campos exigidos não está preenchido!");
            }
            else if (operacaoCadastro != "Consultar")
            {
                venda.Nome_cliente = tbNomeCliente.Text;
                venda.Quantidade_produto = (Int32.Parse(tbQuantidade.Text));
                venda.Preco_total = (Double.Parse(tbValorTotal.Text));
                venda.Nome_produto = comboBox1.Text;

                if (operacaoCadastro == "Incluir")
                {
                    venda.IdVenda = "";
                    produto.Quantidade_estoque -= venda.Quantidade_produto;

                    await VendasAPIServicos.POSTVenda(venda);
                    await ProdutoAPIServicos.PUTProduto(produto);
                }
            }
            this.Close();
        }

        private void buCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void GUI_CadastroVenda_Load(object sender, EventArgs e)
        {
            List<Produto> produtos = await ProdutoAPIServicos.GETProdutos();
            BindingListView<Produto> view = new BindingListView<Produto>(produtos);
            comboBox1.DataSource = view;
        }

        private async void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox cmb = (ComboBox)sender;
            idProduto = cmb.SelectedValue.ToString();
            tbIDProduto.Text = idProduto;
            produto = await ProdutoAPIServicos.GETProduto(idProduto);
            tbQuantidadeEstoque.Text = produto.Quantidade_estoque.ToString();
            tbValorUnitario.Text = produto.Preco.ToString();
            if (tbQuantidade.Text != ""){
                tbValorTotal.Text = (produto.Preco * Int32.Parse(tbQuantidade.Text)).ToString();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbValorTotal_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbQuantidade_TextChanged(object sender, EventArgs e)
        {
            if (tbQuantidade.Text != "")
            {
                tbValorTotal.Text = (produto.Preco * Int32.Parse(tbQuantidade.Text)).ToString();
            }
        }
    }
}
