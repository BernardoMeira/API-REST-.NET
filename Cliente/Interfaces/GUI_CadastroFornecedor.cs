using Cliente.Servicos;
using FornecedorAPI;
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
    public partial class GUI_CadastroFornecedor : Form
    {
        private string operacaoCadastro;
        private Fornecedor fornecedor;
        public GUI_CadastroFornecedor(string operacaoCadastro, Fornecedor fornecedor)
        {
            this.operacaoCadastro = operacaoCadastro;
            this.fornecedor = fornecedor;
            InitializeComponent();

            if (operacaoCadastro == "Alterar" || operacaoCadastro == "Consultar")
            {
                tbNome.Text = fornecedor.Nome;
                tbCodigo.Text = fornecedor.IdFornecedor;
                tbTelefone.Text = fornecedor.Telefone;
                tbEmail.Text = fornecedor.Email;
                tbCep.Text = fornecedor.Cep;
                tbCpfCnpj.Text = fornecedor.Cpf_cnpj;
                tbCidade.Text = fornecedor.Cidade;
                tbBairro.Text = fornecedor.Bairro;
                tbEstado.Text = fornecedor.Estado;
                tbComplemento.Text = fornecedor.Complemento;
                tbLogradouro.Text = fornecedor.Logradouro;
                tbNumero.Text = fornecedor.Numero.ToString();
            }
            if (operacaoCadastro == "Consultar")
            {
                buCancelar.Enabled = false;
                tbNome.Enabled = false;
                tbTelefone.Enabled = false;
                tbEmail.Enabled = false;
                tbCep.Enabled = false;
                tbBairro.Enabled = false;
                tbCidade.Enabled = false;
                tbBairro.Enabled = false;
                tbEstado.Enabled = false;
                tbComplemento.Enabled = false;
                tbLogradouro.Enabled = false;
                tbCpfCnpj.Enabled = false;
                tbNumero.Enabled = false;
            }
            if (operacaoCadastro == "Consultar" || operacaoCadastro == "Alterar" || operacaoCadastro == "Incluir")
            {
                tbCodigo.Enabled = false;
            }
        }

        private async void buOk_Click(object sender, EventArgs e)
        {
            {
                if (tbNome.Text == ("") || tbTelefone.Text == ("")
                        || tbEmail.Text == ("") || tbEstado.Text == ("")
                        || tbCep.Text == ("") || tbCidade.Text == ("")
                        || tbBairro.Text == ("") || tbCpfCnpj.Text == (""))
                {
                    MessageBox.Show("Um dos campos exigidos não está preenchido!");
                }
                else if (operacaoCadastro != "Consultar")
                {
                    fornecedor.Nome = tbNome.Text;
                    fornecedor.Telefone = tbTelefone.Text;
                    fornecedor.Email = tbEmail.Text;
                    fornecedor.Cep = tbCep.Text;
                    fornecedor.Bairro =tbBairro.Text;
                    fornecedor.Cidade = tbCidade.Text;
                    fornecedor.Cpf_cnpj = tbCpfCnpj.Text;
                    fornecedor.Logradouro = tbLogradouro.Text;
                    fornecedor.Numero = (Int32.Parse(tbNumero.Text));
                    fornecedor.Complemento = tbComplemento.Text;
                    fornecedor.Estado = tbEstado.Text;

                    if (operacaoCadastro == "Incluir")
                    {
                        fornecedor.IdFornecedor = "";
                        await FornecedorAPIServicos.POSTFornecedor(fornecedor);
                    }
                    else if (operacaoCadastro == "Alterar")
                    {
                       await FornecedorAPIServicos.PUTFornecedor(fornecedor);
                    }
                }
                this.Close();
            }
        }

        private void buCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
