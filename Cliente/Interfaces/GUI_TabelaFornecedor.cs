using Cliente.Servicos;
using Equin.ApplicationFramework;
using FornecedorAPI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Configuration;
using System.Windows.Forms;

namespace Cliente.Interfaces
{
    public partial class GUI_TabelaFornecedor : Form
    {
        public GUI_TabelaFornecedor()
        {
            InitializeComponent();
        }

        private void GUI_TabelaFornecedor_Activated(object sender, EventArgs e)
        {

        }

        private async void buRecarregar_Click(object sender, EventArgs e)
        {
            List<Fornecedor> fornecedores = await FornecedorAPIServicos.GETFornecedores();
            BindingListView<Fornecedor> view = new BindingListView<Fornecedor>(fornecedores);
            dataGridView1.DataSource = view;
        }

        private void GUI_TabelaFornecedor_Load(object sender, EventArgs e)
        {

        }

        private void buIncluir_Click(object sender, EventArgs e)
        {
            Fornecedor fornecedor = new Fornecedor();
            GUI_CadastroFornecedor GUI_Fornecedor = new GUI_CadastroFornecedor("Incluir", fornecedor);
            GUI_Fornecedor.ShowDialog();
        }

        private async void buAlterar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count != 0)
            {
                
                Fornecedor fornecedor = new Fornecedor();
                DataGridViewRow row = this.dataGridView1.SelectedRows[0];
                string index = row.Cells["idFornecedorDataGridViewTextBoxColumn"].Value.ToString();
                fornecedor = await FornecedorAPIServicos.GETFornecedor(index);
                GUI_CadastroFornecedor GUI_Fornecedor = new GUI_CadastroFornecedor("Alterar", fornecedor);
                GUI_Fornecedor.ShowDialog();
            }
        }

        private async void buExcluir_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count != 0)
            {
                Fornecedor fornecedor = new Fornecedor();
                DataGridViewRow row = this.dataGridView1.SelectedRows[0];
                string index = row.Cells["idFornecedorDataGridViewTextBoxColumn"].Value.ToString();
                DialogResult dialogResult = MessageBox.Show("Deseja excluir?", "", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    await FornecedorAPIServicos.DELETEFornecedor(index);
                }
            }
        }

        private void buFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
