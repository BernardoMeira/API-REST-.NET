using Cliente.Servicos;
using Equin.ApplicationFramework;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VendasAPI;

namespace Cliente.Interfaces
{
    public partial class GUI_TabelaVendas : Form
    {
        public GUI_TabelaVendas()
        {
            InitializeComponent();
        }

        private void buFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void buRecarregar_Click(object sender, EventArgs e)
        {
            List<Venda> vendas = await VendasAPIServicos.GETVendas();
            BindingListView<Venda> view = new BindingListView<Venda>(vendas);
            dataGridView1.DataSource = view;
        }

        private void buIncluir_Click(object sender, EventArgs e)
        {
            Venda venda = new Venda();
            GUI_CadastroVenda GUI_Venda = new GUI_CadastroVenda("Incluir", venda);
            GUI_Venda.ShowDialog();
        }
    }
}
