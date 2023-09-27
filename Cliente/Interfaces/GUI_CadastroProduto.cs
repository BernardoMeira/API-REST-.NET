using Cliente.Servicos;
using Equin.ApplicationFramework;
using FornecedorAPI;
using ProdutoAPI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cliente.Interfaces
{
    public partial class GUI_CadastroProduto : Form
    {
        private Produto produto;
        private string operacaoCadastro;
        public GUI_CadastroProduto(string operacaoCadastro, Produto produto)
        {
            this.operacaoCadastro = operacaoCadastro;   
            this.produto = produto;
            InitializeComponent();

            if (operacaoCadastro == "Alterar")
            {
                tbNome.Text = produto.Nome;
                tbCodigo.Text = produto.IdProduto;
                tbQuantidadeEstoque.Text = produto.Quantidade_estoque.ToString();
                tbPreco.Text = produto.Preco.ToString();
                tbDescricao.Text = produto.Descricao;
                tbCategoria.Text = produto.Categoria;
                comboBox1.Text = produto.Nome_fornecedor;
            }
            if (operacaoCadastro == "Incluir" || operacaoCadastro == "Alterar")
            {
                tbCodigo.Enabled = false;
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private async void GUI_CadastroProduto_Load(object sender, EventArgs e)
        {
            List<Fornecedor> fornecedores = await FornecedorAPIServicos.GETFornecedores();
            BindingListView<Fornecedor> view = new BindingListView<Fornecedor>(fornecedores);
            comboBox1.DataSource = view;
        }

        private async void buOk_Click(object sender, EventArgs e)
        {
            if (tbNome.Text == ("")|| tbQuantidadeEstoque.Text == ("") 
                || tbPreco.Text == ("") || tbDescricao.Text == ("") 
                || comboBox1.Text == ("") || tbCategoria.Text == (""))
            {
                MessageBox.Show("Um dos campos exigidos não está preenchido!");
            }
            else if (operacaoCadastro != "Consultar")
            {
                produto.Nome = tbNome.Text;
                produto.Quantidade_estoque = (Int32.Parse(tbQuantidadeEstoque.Text));
                produto.Preco = (Double.Parse(tbPreco.Text));
                produto.Descricao = tbDescricao.Text;
                produto.Nome_fornecedor = comboBox1.Text;
                produto.Categoria = tbCategoria.Text;

                if (operacaoCadastro == "Incluir")
                {
                    produto.IdProduto = "";
                    await ProdutoAPIServicos.POSTProduto(produto);
                }
                else if (operacaoCadastro == "Alterar")
                {
                    await ProdutoAPIServicos.PUTProduto(produto);
                }
            }
            this.Close();
        }

        private void buCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
