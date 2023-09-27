namespace Cliente.Interfaces
{
    partial class GUI_TabelaVendas
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
            this.buIncluir = new System.Windows.Forms.Button();
            this.buRecarregar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.vendaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.idVendaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeclienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precototalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeprodutoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantidadeprodutoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // buFechar
            // 
            this.buFechar.Location = new System.Drawing.Point(546, 415);
            this.buFechar.Name = "buFechar";
            this.buFechar.Size = new System.Drawing.Size(91, 23);
            this.buFechar.TabIndex = 17;
            this.buFechar.Text = "Fechar";
            this.buFechar.UseVisualStyleBackColor = true;
            this.buFechar.Click += new System.EventHandler(this.buFechar_Click);
            // 
            // buIncluir
            // 
            this.buIncluir.Location = new System.Drawing.Point(546, 12);
            this.buIncluir.Name = "buIncluir";
            this.buIncluir.Size = new System.Drawing.Size(91, 23);
            this.buIncluir.TabIndex = 14;
            this.buIncluir.Text = "Incluir";
            this.buIncluir.UseVisualStyleBackColor = true;
            this.buIncluir.Click += new System.EventHandler(this.buIncluir_Click);
            // 
            // buRecarregar
            // 
            this.buRecarregar.Location = new System.Drawing.Point(546, 386);
            this.buRecarregar.Name = "buRecarregar";
            this.buRecarregar.Size = new System.Drawing.Size(91, 23);
            this.buRecarregar.TabIndex = 13;
            this.buRecarregar.Text = "Recarregar";
            this.buRecarregar.UseVisualStyleBackColor = true;
            this.buRecarregar.Click += new System.EventHandler(this.buRecarregar_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idVendaDataGridViewTextBoxColumn,
            this.nomeclienteDataGridViewTextBoxColumn,
            this.precototalDataGridViewTextBoxColumn,
            this.nomeprodutoDataGridViewTextBoxColumn,
            this.quantidadeprodutoDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.vendaBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(527, 426);
            this.dataGridView1.TabIndex = 12;
            // 
            // vendaBindingSource
            // 
            this.vendaBindingSource.DataSource = typeof(VendasAPI.Venda);
            // 
            // idVendaDataGridViewTextBoxColumn
            // 
            this.idVendaDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.idVendaDataGridViewTextBoxColumn.DataPropertyName = "IdVenda";
            this.idVendaDataGridViewTextBoxColumn.HeaderText = "ID Venda:";
            this.idVendaDataGridViewTextBoxColumn.Name = "idVendaDataGridViewTextBoxColumn";
            this.idVendaDataGridViewTextBoxColumn.ReadOnly = true;
            this.idVendaDataGridViewTextBoxColumn.Width = 80;
            // 
            // nomeclienteDataGridViewTextBoxColumn
            // 
            this.nomeclienteDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.nomeclienteDataGridViewTextBoxColumn.DataPropertyName = "Nome_cliente";
            this.nomeclienteDataGridViewTextBoxColumn.HeaderText = "Nome Cliente:";
            this.nomeclienteDataGridViewTextBoxColumn.Name = "nomeclienteDataGridViewTextBoxColumn";
            this.nomeclienteDataGridViewTextBoxColumn.ReadOnly = true;
            this.nomeclienteDataGridViewTextBoxColumn.Width = 98;
            // 
            // precototalDataGridViewTextBoxColumn
            // 
            this.precototalDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.precototalDataGridViewTextBoxColumn.DataPropertyName = "Preco_total";
            this.precototalDataGridViewTextBoxColumn.HeaderText = "Preço Total:";
            this.precototalDataGridViewTextBoxColumn.Name = "precototalDataGridViewTextBoxColumn";
            this.precototalDataGridViewTextBoxColumn.ReadOnly = true;
            this.precototalDataGridViewTextBoxColumn.Width = 90;
            // 
            // nomeprodutoDataGridViewTextBoxColumn
            // 
            this.nomeprodutoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.nomeprodutoDataGridViewTextBoxColumn.DataPropertyName = "Nome_produto";
            this.nomeprodutoDataGridViewTextBoxColumn.HeaderText = "Nome Produto:";
            this.nomeprodutoDataGridViewTextBoxColumn.Name = "nomeprodutoDataGridViewTextBoxColumn";
            this.nomeprodutoDataGridViewTextBoxColumn.ReadOnly = true;
            this.nomeprodutoDataGridViewTextBoxColumn.Width = 95;
            // 
            // quantidadeprodutoDataGridViewTextBoxColumn
            // 
            this.quantidadeprodutoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.quantidadeprodutoDataGridViewTextBoxColumn.DataPropertyName = "Quantidade_produto";
            this.quantidadeprodutoDataGridViewTextBoxColumn.HeaderText = "Quantidade Produto:";
            this.quantidadeprodutoDataGridViewTextBoxColumn.Name = "quantidadeprodutoDataGridViewTextBoxColumn";
            this.quantidadeprodutoDataGridViewTextBoxColumn.ReadOnly = true;
            this.quantidadeprodutoDataGridViewTextBoxColumn.Width = 119;
            // 
            // GUI_TabelaVendas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 450);
            this.Controls.Add(this.buFechar);
            this.Controls.Add(this.buIncluir);
            this.Controls.Add(this.buRecarregar);
            this.Controls.Add(this.dataGridView1);
            this.Name = "GUI_TabelaVendas";
            this.Text = "GUI_TabelaVendas";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendaBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buFechar;
        private System.Windows.Forms.Button buIncluir;
        private System.Windows.Forms.Button buRecarregar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource vendaBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idVendaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeclienteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn precototalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeprodutoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantidadeprodutoDataGridViewTextBoxColumn;
    }
}