using Cliente.Servicos;
using Equin.ApplicationFramework;
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
    public partial class GUI_TabelaProdutos : Form
    {
        public GUI_TabelaProdutos()
        {
            InitializeComponent();
        }

        private void buIncluir_Click(object sender, EventArgs e)
        {
            Produto produto = new Produto();
            GUI_CadastroProduto GUI_Produto = new GUI_CadastroProduto("Incluir", produto);
            GUI_Produto.ShowDialog();
        }

        private async void buAlterar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count != 0)
            {

                Produto produto = new Produto();
                DataGridViewRow row = this.dataGridView1.SelectedRows[0];
                string index = row.Cells["idProdutoDataGridViewTextBoxColumn"].Value.ToString();
                produto = await ProdutoAPIServicos.GETProduto(index);
                GUI_CadastroProduto GUI_Produto = new GUI_CadastroProduto("Alterar", produto);
                GUI_Produto.ShowDialog();
            }
        }

        private async void buExcluir_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count != 0)
            {
                Produto produto = new Produto();
                DataGridViewRow row = this.dataGridView1.SelectedRows[0];
                string index = row.Cells["idProdutoDataGridViewTextBoxColumn"].Value.ToString();
                DialogResult dialogResult = MessageBox.Show("Deseja excluir?", "", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    await ProdutoAPIServicos.DELETEProduto(index);
                }
            }
        }

        private async void buRecarregar_Click(object sender, EventArgs e)
        {
            List<Produto> produtos = await ProdutoAPIServicos.GETProdutos();
            BindingListView<Produto> view = new BindingListView<Produto>(produtos);
            dataGridView1.DataSource = view;
        }

        private void buFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
