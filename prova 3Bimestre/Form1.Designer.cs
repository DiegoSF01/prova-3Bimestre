namespace prova_3Bimestre
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.Venda = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.ValorTotal = new System.Windows.Forms.Label();
            this.TXTproduto = new System.Windows.Forms.TextBox();
            this.TXTquantidade = new System.Windows.Forms.TextBox();
            this.TXTvunitario = new System.Windows.Forms.TextBox();
            this.TXTQuantidadeAlterada = new System.Windows.Forms.TextBox();
            this.Inserir = new System.Windows.Forms.Button();
            this.Remover = new System.Windows.Forms.Button();
            this.AlterarQuant = new System.Windows.Forms.Button();
            this.GravarVenda = new System.Windows.Forms.Button();
            this.CancelarVenda = new System.Windows.Forms.Button();
            this.FinalizarSistema = new System.Windows.Forms.Button();
            this.dgvProdutos = new System.Windows.Forms.DataGridView();
            this.Produto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VUnitario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutos)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Venda:";
            // 
            // Venda
            // 
            this.Venda.AutoSize = true;
            this.Venda.ForeColor = System.Drawing.Color.Red;
            this.Venda.Location = new System.Drawing.Point(108, 44);
            this.Venda.Name = "Venda";
            this.Venda.Size = new System.Drawing.Size(0, 13);
            this.Venda.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(56, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Produto:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(56, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Quantidade:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(56, 176);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "V.Unitario:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(56, 508);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(198, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Alterar Quantidade do Item Selecionado:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(56, 567);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Total de Vendas:";
            // 
            // ValorTotal
            // 
            this.ValorTotal.AutoSize = true;
            this.ValorTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ValorTotal.ForeColor = System.Drawing.Color.Blue;
            this.ValorTotal.Location = new System.Drawing.Point(160, 560);
            this.ValorTotal.Name = "ValorTotal";
            this.ValorTotal.Size = new System.Drawing.Size(0, 20);
            this.ValorTotal.TabIndex = 7;
            // 
            // TXTproduto
            // 
            this.TXTproduto.Location = new System.Drawing.Point(111, 85);
            this.TXTproduto.Name = "TXTproduto";
            this.TXTproduto.Size = new System.Drawing.Size(566, 20);
            this.TXTproduto.TabIndex = 8;
            // 
            // TXTquantidade
            // 
            this.TXTquantidade.Location = new System.Drawing.Point(124, 130);
            this.TXTquantidade.Name = "TXTquantidade";
            this.TXTquantidade.Size = new System.Drawing.Size(151, 20);
            this.TXTquantidade.TabIndex = 9;
            // 
            // TXTvunitario
            // 
            this.TXTvunitario.Location = new System.Drawing.Point(124, 173);
            this.TXTvunitario.Name = "TXTvunitario";
            this.TXTvunitario.Size = new System.Drawing.Size(151, 20);
            this.TXTvunitario.TabIndex = 10;
            // 
            // TXTQuantidadeAlterada
            // 
            this.TXTQuantidadeAlterada.Location = new System.Drawing.Point(257, 505);
            this.TXTQuantidadeAlterada.Name = "TXTQuantidadeAlterada";
            this.TXTQuantidadeAlterada.Size = new System.Drawing.Size(151, 20);
            this.TXTQuantidadeAlterada.TabIndex = 11;
            // 
            // Inserir
            // 
            this.Inserir.Location = new System.Drawing.Point(399, 129);
            this.Inserir.Name = "Inserir";
            this.Inserir.Size = new System.Drawing.Size(118, 64);
            this.Inserir.TabIndex = 12;
            this.Inserir.Text = "Inserir";
            this.Inserir.UseVisualStyleBackColor = true;
            this.Inserir.Click += new System.EventHandler(this.Inserir_Click);
            // 
            // Remover
            // 
            this.Remover.Location = new System.Drawing.Point(559, 129);
            this.Remover.Name = "Remover";
            this.Remover.Size = new System.Drawing.Size(118, 64);
            this.Remover.TabIndex = 13;
            this.Remover.Text = "Remover";
            this.Remover.UseVisualStyleBackColor = true;
            this.Remover.Click += new System.EventHandler(this.Remover_Click);
            // 
            // AlterarQuant
            // 
            this.AlterarQuant.Location = new System.Drawing.Point(435, 501);
            this.AlterarQuant.Name = "AlterarQuant";
            this.AlterarQuant.Size = new System.Drawing.Size(109, 27);
            this.AlterarQuant.TabIndex = 14;
            this.AlterarQuant.Text = "Alterar Quantidade";
            this.AlterarQuant.UseVisualStyleBackColor = true;
            this.AlterarQuant.Click += new System.EventHandler(this.AlterarQuant_Click);
            // 
            // GravarVenda
            // 
            this.GravarVenda.Location = new System.Drawing.Point(120, 631);
            this.GravarVenda.Name = "GravarVenda";
            this.GravarVenda.Size = new System.Drawing.Size(118, 52);
            this.GravarVenda.TabIndex = 15;
            this.GravarVenda.Text = "Gravar Venda";
            this.GravarVenda.UseVisualStyleBackColor = true;
            this.GravarVenda.Click += new System.EventHandler(this.GravarVenda_Click);
            // 
            // CancelarVenda
            // 
            this.CancelarVenda.Location = new System.Drawing.Point(291, 631);
            this.CancelarVenda.Name = "CancelarVenda";
            this.CancelarVenda.Size = new System.Drawing.Size(120, 52);
            this.CancelarVenda.TabIndex = 16;
            this.CancelarVenda.Text = "Cancelar Venda";
            this.CancelarVenda.UseVisualStyleBackColor = true;
            this.CancelarVenda.Click += new System.EventHandler(this.CancelarVenda_Click);
            // 
            // FinalizarSistema
            // 
            this.FinalizarSistema.Location = new System.Drawing.Point(474, 631);
            this.FinalizarSistema.Name = "FinalizarSistema";
            this.FinalizarSistema.Size = new System.Drawing.Size(120, 52);
            this.FinalizarSistema.TabIndex = 17;
            this.FinalizarSistema.Text = "Finalizar Sistema";
            this.FinalizarSistema.UseVisualStyleBackColor = true;
            this.FinalizarSistema.Click += new System.EventHandler(this.FinalizarSistema_Click);
            // 
            // dgvProdutos
            // 
            this.dgvProdutos.AllowUserToAddRows = false;
            this.dgvProdutos.AllowUserToDeleteRows = false;
            this.dgvProdutos.AllowUserToOrderColumns = true;
            this.dgvProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProdutos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Produto,
            this.Quantidade,
            this.VUnitario});
            this.dgvProdutos.Location = new System.Drawing.Point(59, 227);
            this.dgvProdutos.Name = "dgvProdutos";
            this.dgvProdutos.ReadOnly = true;
            this.dgvProdutos.Size = new System.Drawing.Size(618, 243);
            this.dgvProdutos.TabIndex = 18;
            this.dgvProdutos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProdutos_CellClick);
            // 
            // Produto
            // 
            this.Produto.HeaderText = "Produto";
            this.Produto.Name = "Produto";
            this.Produto.ReadOnly = true;
            // 
            // Quantidade
            // 
            this.Quantidade.HeaderText = "Quantidade";
            this.Quantidade.Name = "Quantidade";
            this.Quantidade.ReadOnly = true;
            // 
            // VUnitario
            // 
            this.VUnitario.HeaderText = "V.Unitario";
            this.VUnitario.Name = "VUnitario";
            this.VUnitario.ReadOnly = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(727, 738);
            this.Controls.Add(this.dgvProdutos);
            this.Controls.Add(this.FinalizarSistema);
            this.Controls.Add(this.CancelarVenda);
            this.Controls.Add(this.GravarVenda);
            this.Controls.Add(this.AlterarQuant);
            this.Controls.Add(this.Remover);
            this.Controls.Add(this.Inserir);
            this.Controls.Add(this.TXTQuantidadeAlterada);
            this.Controls.Add(this.TXTvunitario);
            this.Controls.Add(this.TXTquantidade);
            this.Controls.Add(this.TXTproduto);
            this.Controls.Add(this.ValorTotal);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Venda);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Venda;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label ValorTotal;
        private System.Windows.Forms.TextBox TXTproduto;
        private System.Windows.Forms.TextBox TXTquantidade;
        private System.Windows.Forms.TextBox TXTvunitario;
        private System.Windows.Forms.TextBox TXTQuantidadeAlterada;
        private System.Windows.Forms.Button Inserir;
        private System.Windows.Forms.Button Remover;
        private System.Windows.Forms.Button AlterarQuant;
        private System.Windows.Forms.Button GravarVenda;
        private System.Windows.Forms.Button CancelarVenda;
        private System.Windows.Forms.Button FinalizarSistema;
        private System.Windows.Forms.DataGridView dgvProdutos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Produto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn VUnitario;
    }
}

