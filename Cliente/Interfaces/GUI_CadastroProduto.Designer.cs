namespace Cliente.Interfaces
{
    partial class GUI_CadastroProduto
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
            this.buCancelar = new System.Windows.Forms.Button();
            this.buOk = new System.Windows.Forms.Button();
            this.tbDescricao = new System.Windows.Forms.TextBox();
            this.tbPreco = new System.Windows.Forms.TextBox();
            this.tbQuantidadeEstoque = new System.Windows.Forms.TextBox();
            this.tbNome = new System.Windows.Forms.TextBox();
            this.tbCodigo = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.fornecedorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbCategoria = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.fornecedorBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // buCancelar
            // 
            this.buCancelar.Location = new System.Drawing.Point(436, 193);
            this.buCancelar.Name = "buCancelar";
            this.buCancelar.Size = new System.Drawing.Size(75, 23);
            this.buCancelar.TabIndex = 27;
            this.buCancelar.Text = "Cancelar";
            this.buCancelar.UseVisualStyleBackColor = true;
            this.buCancelar.Click += new System.EventHandler(this.buCancelar_Click);
            // 
            // buOk
            // 
            this.buOk.Location = new System.Drawing.Point(355, 193);
            this.buOk.Name = "buOk";
            this.buOk.Size = new System.Drawing.Size(75, 23);
            this.buOk.TabIndex = 26;
            this.buOk.Text = "Ok";
            this.buOk.UseVisualStyleBackColor = true;
            this.buOk.Click += new System.EventHandler(this.buOk_Click);
            // 
            // tbDescricao
            // 
            this.tbDescricao.Location = new System.Drawing.Point(71, 42);
            this.tbDescricao.Name = "tbDescricao";
            this.tbDescricao.Size = new System.Drawing.Size(438, 20);
            this.tbDescricao.TabIndex = 25;
            // 
            // tbPreco
            // 
            this.tbPreco.Location = new System.Drawing.Point(302, 167);
            this.tbPreco.Name = "tbPreco";
            this.tbPreco.Size = new System.Drawing.Size(207, 20);
            this.tbPreco.TabIndex = 24;
            // 
            // tbQuantidadeEstoque
            // 
            this.tbQuantidadeEstoque.Location = new System.Drawing.Point(135, 167);
            this.tbQuantidadeEstoque.Name = "tbQuantidadeEstoque";
            this.tbQuantidadeEstoque.Size = new System.Drawing.Size(114, 20);
            this.tbQuantidadeEstoque.TabIndex = 22;
            // 
            // tbNome
            // 
            this.tbNome.Location = new System.Drawing.Point(302, 8);
            this.tbNome.Name = "tbNome";
            this.tbNome.Size = new System.Drawing.Size(209, 20);
            this.tbNome.TabIndex = 21;
            // 
            // tbCodigo
            // 
            this.tbCodigo.Location = new System.Drawing.Point(71, 8);
            this.tbCodigo.Name = "tbCodigo";
            this.tbCodigo.Size = new System.Drawing.Size(178, 20);
            this.tbCodigo.TabIndex = 20;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 45);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 13);
            this.label6.TabIndex = 19;
            this.label6.Text = "Descrição:";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 102);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "Fornecedor:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(258, 170);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Preço:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 170);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Quantidade em Estoque:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(255, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Nome:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Código:";
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.fornecedorBindingSource;
            this.comboBox1.DisplayMember = "Nome";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(71, 99);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(440, 21);
            this.comboBox1.TabIndex = 28;
            this.comboBox1.ValueMember = "Nome";
            // 
            // fornecedorBindingSource
            // 
            this.fornecedorBindingSource.DataSource = typeof(FornecedorAPI.Fornecedor);
            // 
            // tbCategoria
            // 
            this.tbCategoria.Location = new System.Drawing.Point(71, 71);
            this.tbCategoria.Name = "tbCategoria";
            this.tbCategoria.Size = new System.Drawing.Size(438, 20);
            this.tbCategoria.TabIndex = 30;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 74);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 13);
            this.label7.TabIndex = 29;
            this.label7.Text = "Categoria:";
            // 
            // GUI_CadastroProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(521, 223);
            this.Controls.Add(this.tbCategoria);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.buCancelar);
            this.Controls.Add(this.buOk);
            this.Controls.Add(this.tbDescricao);
            this.Controls.Add(this.tbPreco);
            this.Controls.Add(this.tbQuantidadeEstoque);
            this.Controls.Add(this.tbNome);
            this.Controls.Add(this.tbCodigo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "GUI_CadastroProduto";
            this.Text = "GUI_CadastroProduto";
            this.Load += new System.EventHandler(this.GUI_CadastroProduto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.fornecedorBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buCancelar;
        private System.Windows.Forms.Button buOk;
        private System.Windows.Forms.TextBox tbDescricao;
        private System.Windows.Forms.TextBox tbPreco;
        private System.Windows.Forms.TextBox tbQuantidadeEstoque;
        private System.Windows.Forms.TextBox tbNome;
        private System.Windows.Forms.TextBox tbCodigo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.BindingSource fornecedorBindingSource;
        private System.Windows.Forms.TextBox tbCategoria;
        private System.Windows.Forms.Label label7;
    }
}