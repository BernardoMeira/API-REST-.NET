namespace Cliente.Interfaces
{
    partial class GUI_TabelaProdutos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.buFechar = new System.Windows.Forms.Button();
            this.buExcluir = new System.Windows.Forms.Button();
            this.buAlterar = new System.Windows.Forms.Button();
            this.buIncluir = new System.Windows.Forms.Button();
            this.buRecarregar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idProdutoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomefornecedorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoriaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descricaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantidadeestoqueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.produtoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // buFechar
            // 
            this.buFechar.Location = new System.Drawing.Point(697, 415);
            this.buFechar.Name = "buFechar";
            this.buFechar.Size = new System.Drawing.Size(91, 23);
            this.buFechar.TabIndex = 11;
            this.buFechar.Text = "Fechar";
            this.buFechar.UseVisualStyleBackColor = true;
            this.buFechar.Click += new System.EventHandler(this.buFechar_Click);
            // 
            // buExcluir
            // 
            this.buExcluir.Location = new System.Drawing.Point(697, 70);
            this.buExcluir.Name = "buExcluir";
            this.buExcluir.Size = new System.Drawing.Size(91, 23);
            this.buExcluir.TabIndex = 10;
            this.buExcluir.Text = "Excluir";
            this.buExcluir.UseVisualStyleBackColor = true;
            this.buExcluir.Click += new System.EventHandler(this.buExcluir_Click);
            // 
            // buAlterar
            // 
            this.buAlterar.Location = new System.Drawing.Point(697, 41);
            this.buAlterar.Name = "buAlterar";
            this.buAlterar.Size = new System.Drawing.Size(91, 23);
            this.buAlterar.TabIndex = 9;
            this.buAlterar.Text = "Alterar";
            this.buAlterar.UseVisualStyleBackColor = true;
            this.buAlterar.Click += new System.EventHandler(this.buAlterar_Click);
            // 
            // buIncluir
            // 
            this.buIncluir.Location = new System.Drawing.Point(697, 12);
            this.buIncluir.Name = "buIncluir";
            this.buIncluir.Size = new System.Drawing.Size(91, 23);
            this.buIncluir.TabIndex = 8;
            this.buIncluir.Text = "Incluir";
            this.buIncluir.UseVisualStyleBackColor = true;
            this.buIncluir.Click += new System.EventHandler(this.buIncluir_Click);
            // 
            // buRecarregar
            // 
            this.buRecarregar.Location = new System.Drawing.Point(697, 386);
            this.buRecarregar.Name = "buRecarregar";
            this.buRecarregar.Size = new System.Drawing.Size(91, 23);
            this.buRecarregar.TabIndex = 7;
            this.buRecarregar.Text = "Recarregar";
            this.buRecarregar.UseVisualStyleBackColor = true;
            this.buRecarregar.Click += new System.EventHandler(this.buRecarregar_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idProdutoDataGridViewTextBoxColumn,
            this.nomeDataGridViewTextBoxColumn,
            this.nomefornecedorDataGridViewTextBoxColumn,
            this.categoriaDataGridViewTextBoxColumn,
            this.descricaoDataGridViewTextBoxColumn,
            this.precoDataGridViewTextBoxColumn,
            this.quantidadeestoqueDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.produtoBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(13, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(670, 426);
            this.dataGridView1.TabIndex = 6;
            // 
            // idProdutoDataGridViewTextBoxColumn
            // 
            this.idProdutoDataGridViewTextBoxColumn.DataPropertyName = "IdProduto";
            this.idProdutoDataGridViewTextBoxColumn.HeaderText = "ID:";
            this.idProdutoDataGridViewTextBoxColumn.Name = "idProdutoDataGridViewTextBoxColumn";
            this.idProdutoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nomeDataGridViewTextBoxColumn
            // 
            this.nomeDataGridViewTextBoxColumn.DataPropertyName = "Nome";
            this.nomeDataGridViewTextBoxColumn.HeaderText = "Nome:";
            this.nomeDataGridViewTextBoxColumn.Name = "nomeDataGridViewTextBoxColumn";
            this.nomeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nomefornecedorDataGridViewTextBoxColumn
            // 
            this.nomefornecedorDataGridViewTextBoxColumn.DataPropertyName = "Nome_fornecedor";
            this.nomefornecedorDataGridViewTextBoxColumn.HeaderText = "Nome Fornecedor:";
            this.nomefornecedorDataGridViewTextBoxColumn.Name = "nomefornecedorDataGridViewTextBoxColumn";
            this.nomefornecedorDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // categoriaDataGridViewTextBoxColumn
            // 
            this.categoriaDataGridViewTextBoxColumn.DataPropertyName = "Categoria";
            this.categoriaDataGridViewTextBoxColumn.HeaderText = "Categoria:";
            this.categoriaDataGridViewTextBoxColumn.Name = "categoriaDataGridViewTextBoxColumn";
            this.categoriaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // descricaoDataGridViewTextBoxColumn
            // 
            this.descricaoDataGridViewTextBoxColumn.DataPropertyName = "Descricao";
            this.descricaoDataGridViewTextBoxColumn.HeaderText = "Descrição:";
            this.descricaoDataGridViewTextBoxColumn.Name = "descricaoDataGridViewTextBoxColumn";
            this.descricaoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // precoDataGridViewTextBoxColumn
            // 
            this.precoDataGridViewTextBoxColumn.DataPropertyName = "Preco";
            this.precoDataGridViewTextBoxColumn.HeaderText = "Preço:";
            this.precoDataGridViewTextBoxColumn.Name = "precoDataGridViewTextBoxColumn";
            this.precoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // quantidadeestoqueDataGridViewTextBoxColumn
            // 
            this.quantidadeestoqueDataGridViewTextBoxColumn.DataPropertyName = "Quantidade_estoque";
            this.quantidadeestoqueDataGridViewTextBoxColumn.HeaderText = "Quantidade Estoque:";
            this.quantidadeestoqueDataGridViewTextBoxColumn.Name = "quantidadeestoqueDataGridViewTextBoxColumn";
            this.quantidadeestoqueDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // produtoBindingSource
            // 
            this.produtoBindingSource.DataSource = typeof(ProdutoAPI.Produto);
            // 
            // GUI_TabelaProdutos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buFechar);
            this.Controls.Add(this.buExcluir);
            this.Controls.Add(this.buAlterar);
            this.Controls.Add(this.buIncluir);
            this.Controls.Add(this.buRecarregar);
            this.Controls.Add(this.dataGridView1);
            this.Name = "GUI_TabelaProdutos";
            this.Text = "GUI_TabelaProdutos";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buFechar;
        private System.Windows.Forms.Button buExcluir;
        private System.Windows.Forms.Button buAlterar;
        private System.Windows.Forms.Button buIncluir;
        private System.Windows.Forms.Button buRecarregar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idProdutoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomefornecedorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoriaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descricaoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn precoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantidadeestoqueDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource produtoBindingSource;
    }
}