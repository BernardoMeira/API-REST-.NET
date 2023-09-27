namespace Cliente
{
    partial class MenuPrincipal
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
            this.buFornecedor = new System.Windows.Forms.Button();
            this.buVendas = new System.Windows.Forms.Button();
            this.buFechar = new System.Windows.Forms.Button();
            this.buProduto = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buFornecedor
            // 
            this.buFornecedor.Location = new System.Drawing.Point(12, 96);
            this.buFornecedor.Name = "buFornecedor";
            this.buFornecedor.Size = new System.Drawing.Size(122, 23);
            this.buFornecedor.TabIndex = 0;
            this.buFornecedor.Text = "Fornecedor";
            this.buFornecedor.UseVisualStyleBackColor = true;
            this.buFornecedor.Click += new System.EventHandler(this.buFornecedor_Click);
            // 
            // buVendas
            // 
            this.buVendas.Location = new System.Drawing.Point(284, 96);
            this.buVendas.Name = "buVendas";
            this.buVendas.Size = new System.Drawing.Size(122, 23);
            this.buVendas.TabIndex = 1;
            this.buVendas.Text = "Vendas";
            this.buVendas.UseVisualStyleBackColor = true;
            this.buVendas.Click += new System.EventHandler(this.buVendas_Click);
            // 
            // buFechar
            // 
            this.buFechar.Location = new System.Drawing.Point(148, 188);
            this.buFechar.Name = "buFechar";
            this.buFechar.Size = new System.Drawing.Size(122, 23);
            this.buFechar.TabIndex = 2;
            this.buFechar.Text = "Fechar";
            this.buFechar.UseVisualStyleBackColor = true;
            this.buFechar.Click += new System.EventHandler(this.buFechar_Click);
            // 
            // buProduto
            // 
            this.buProduto.Location = new System.Drawing.Point(148, 96);
            this.buProduto.Name = "buProduto";
            this.buProduto.Size = new System.Drawing.Size(122, 23);
            this.buProduto.TabIndex = 3;
            this.buProduto.Text = "Produtos";
            this.buProduto.UseVisualStyleBackColor = true;
            this.buProduto.Click += new System.EventHandler(this.buProduto_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(126, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 29);
            this.label1.TabIndex = 4;
            this.label1.Text = "Menu Principal";
            // 
            // MenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(418, 223);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buProduto);
            this.Controls.Add(this.buFechar);
            this.Controls.Add(this.buVendas);
            this.Controls.Add(this.buFornecedor);
            this.Name = "MenuPrincipal";
            this.Text = "MenuPrincipal";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buFornecedor;
        private System.Windows.Forms.Button buVendas;
        private System.Windows.Forms.Button buFechar;
        private System.Windows.Forms.Button buProduto;
        private System.Windows.Forms.Label label1;
    }
}