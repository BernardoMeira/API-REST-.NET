namespace Cliente.Interfaces
{
    partial class GUI_CadastroVenda
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
            this.label6 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.produtoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbValorTotal = new System.Windows.Forms.TextBox();
            this.tbNomeCliente = new System.Windows.Forms.TextBox();
            this.tbCodigo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbQuantidade = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.buOk = new System.Windows.Forms.Button();
            this.buCancelar = new System.Windows.Forms.Button();
            this.tbIDProduto = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbQuantidadeEstoque = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tbValorUnitario = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.produtoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 82);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 13);
            this.label6.TabIndex = 23;
            this.label6.Text = "Produto:";
            // 
            // comboBox1
            // 
            this.comboBox1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.produtoBindingSource, "IdProduto", true));
            this.comboBox1.DataSource = this.produtoBindingSource;
            this.comboBox1.DisplayMember = "nome";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(106, 78);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(151, 21);
            this.comboBox1.TabIndex = 22;
            this.comboBox1.ValueMember = "IdProduto";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // produtoBindingSource
            // 
            this.produtoBindingSource.DataSource = typeof(ProdutoAPI.Produto);
            // 
            // tbValorTotal
            // 
            this.tbValorTotal.Location = new System.Drawing.Point(272, 185);
            this.tbValorTotal.Name = "tbValorTotal";
            this.tbValorTotal.Size = new System.Drawing.Size(156, 20);
            this.tbValorTotal.TabIndex = 20;
            this.tbValorTotal.TextChanged += new System.EventHandler(this.tbValorTotal_TextChanged);
            // 
            // tbNomeCliente
            // 
            this.tbNomeCliente.Location = new System.Drawing.Point(106, 43);
            this.tbNomeCliente.Name = "tbNomeCliente";
            this.tbNomeCliente.Size = new System.Drawing.Size(322, 20);
            this.tbNomeCliente.TabIndex = 19;
            // 
            // tbCodigo
            // 
            this.tbCodigo.Location = new System.Drawing.Point(106, 9);
            this.tbCodigo.Name = "tbCodigo";
            this.tbCodigo.Size = new System.Drawing.Size(322, 20);
            this.tbCodigo.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(205, 188);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Valor Total:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Nome do Cliente:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Código:";
            // 
            // tbQuantidade
            // 
            this.tbQuantidade.Location = new System.Drawing.Point(334, 79);
            this.tbQuantidade.Name = "tbQuantidade";
            this.tbQuantidade.Size = new System.Drawing.Size(94, 20);
            this.tbQuantidade.TabIndex = 25;
            this.tbQuantidade.TextChanged += new System.EventHandler(this.tbQuantidade_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(263, 82);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 13);
            this.label7.TabIndex = 24;
            this.label7.Text = "Quantidade:";
            // 
            // buOk
            // 
            this.buOk.Location = new System.Drawing.Point(272, 211);
            this.buOk.Name = "buOk";
            this.buOk.Size = new System.Drawing.Size(75, 23);
            this.buOk.TabIndex = 27;
            this.buOk.Text = "Ok";
            this.buOk.UseVisualStyleBackColor = true;
            this.buOk.Click += new System.EventHandler(this.buOk_Click);
            // 
            // buCancelar
            // 
            this.buCancelar.Location = new System.Drawing.Point(353, 211);
            this.buCancelar.Name = "buCancelar";
            this.buCancelar.Size = new System.Drawing.Size(75, 23);
            this.buCancelar.TabIndex = 26;
            this.buCancelar.Text = "Cancelar";
            this.buCancelar.UseVisualStyleBackColor = true;
            this.buCancelar.Click += new System.EventHandler(this.buCancelar_Click);
            // 
            // tbIDProduto
            // 
            this.tbIDProduto.Location = new System.Drawing.Point(15, 126);
            this.tbIDProduto.Name = "tbIDProduto";
            this.tbIDProduto.Size = new System.Drawing.Size(170, 20);
            this.tbIDProduto.TabIndex = 28;
            this.tbIDProduto.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 29;
            this.label2.Text = "ID Produto:";
            // 
            // tbQuantidadeEstoque
            // 
            this.tbQuantidadeEstoque.Location = new System.Drawing.Point(15, 165);
            this.tbQuantidadeEstoque.Name = "tbQuantidadeEstoque";
            this.tbQuantidadeEstoque.Size = new System.Drawing.Size(170, 20);
            this.tbQuantidadeEstoque.TabIndex = 30;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 149);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 13);
            this.label5.TabIndex = 31;
            this.label5.Text = "Quantidade Estoque:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 192);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 13);
            this.label8.TabIndex = 32;
            this.label8.Text = "Valor Unitário:";
            // 
            // tbValorUnitario
            // 
            this.tbValorUnitario.Location = new System.Drawing.Point(15, 208);
            this.tbValorUnitario.Name = "tbValorUnitario";
            this.tbValorUnitario.Size = new System.Drawing.Size(170, 20);
            this.tbValorUnitario.TabIndex = 33;
            // 
            // GUI_CadastroVenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 246);
            this.Controls.Add(this.tbValorUnitario);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbQuantidadeEstoque);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbIDProduto);
            this.Controls.Add(this.buOk);
            this.Controls.Add(this.buCancelar);
            this.Controls.Add(this.tbQuantidade);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.tbValorTotal);
            this.Controls.Add(this.tbNomeCliente);
            this.Controls.Add(this.tbCodigo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "GUI_CadastroVenda";
            this.Text = "GUI_CadastroVenda";
            this.Load += new System.EventHandler(this.GUI_CadastroVenda_Load);
            ((System.ComponentModel.ISupportInitialize)(this.produtoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox tbValorTotal;
        private System.Windows.Forms.TextBox tbNomeCliente;
        private System.Windows.Forms.TextBox tbCodigo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbQuantidade;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button buOk;
        private System.Windows.Forms.Button buCancelar;
        private System.Windows.Forms.BindingSource produtoBindingSource;
        private System.Windows.Forms.TextBox tbIDProduto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbQuantidadeEstoque;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbValorUnitario;
    }
}