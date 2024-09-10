using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prova_3Bimestre
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        double ValorT;
        double quantidade;
        double valor;
        int VendaCount;

        private void Inserir_Click(object sender, EventArgs e)
        {
            dgvProdutos.Rows.Add(TXTproduto.Text, TXTquantidade.Text, TXTvunitario.Text);
            quantidade = double.Parse(TXTquantidade.Text);
            valor = double.Parse(TXTvunitario.Text);
            ValorT += quantidade * valor;
            ValorTotal.Text = ValorT.ToString();

            TXTproduto.Clear();
            TXTquantidade.Clear();
            TXTvunitario.Clear();
            TXTQuantidadeAlterada.Clear();
        }

        private void Remover_Click(object sender, EventArgs e)
        {
            TXTproduto.Clear();
            TXTquantidade.Clear();
            TXTvunitario.Clear();
            TXTQuantidadeAlterada.Clear();
        }

        private void AlterarQuant_Click(object sender, EventArgs e)
        {
            if (TXTQuantidadeAlterada.Text != "" && dgvProdutos.CurrentRow != null)
            {
                double novaQuantidade;
                if (double.TryParse(TXTQuantidadeAlterada.Text, out novaQuantidade))
                {
                    double antigaQuantidade = Convert.ToDouble(dgvProdutos.CurrentRow.Cells[1].Value);
                    double valor = Convert.ToDouble(dgvProdutos.CurrentRow.Cells[2].Value);

                    ValorT -= antigaQuantidade * valor;

                    dgvProdutos.CurrentRow.Cells[1].Value = TXTQuantidadeAlterada.Text;
                    MessageBox.Show("Quantidade alterada com sucesso", "Exclusão",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                    ValorT += novaQuantidade * valor;
                    ValorTotal.Text = ValorT.ToString();
                }

                    
            }
        }

        private void dgvProdutos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvProdutos.RowCount > 0)
            {
                TXTQuantidadeAlterada.Text = dgvProdutos.CurrentRow.Cells[1].Value.ToString();
            }
        }

        private void GravarVenda_Click(object sender, EventArgs e)
        {
            TXTproduto.Clear();
            TXTquantidade.Clear();
            TXTvunitario.Clear();
            TXTQuantidadeAlterada.Clear();
            dgvProdutos.Rows.Clear();
            ValorTotal.Text = "";
            ValorT = 0;
            VendaCount += 1;
            Venda.Text = VendaCount.ToString();
        }

        private void CancelarVenda_Click(object sender, EventArgs e)
        {
            TXTproduto.Clear();
            TXTquantidade.Clear();
            TXTvunitario.Clear();
            TXTQuantidadeAlterada.Clear();
            dgvProdutos.Rows.Clear();
            ValorTotal.Text = "";
        }

        private void FinalizarSistema_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
