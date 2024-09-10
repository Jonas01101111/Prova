using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prova
{
    public partial class Form1 : Form
    {
        double totaldinheiros;
        int QuantVendas = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btInserir_Click(object sender, EventArgs e)
        {
            double Total = double.Parse(tbQuant.Text) * double.Parse(tbValorU.Text);
            DGVDados.Rows.Add(tbProduto.Text, tbQuant.Text, tbValorU.Text, Total);

            totaldinheiros += Total;
            lbTotalDinheiros.Text = totaldinheiros.ToString("C");

            tbProduto.Clear();
            tbQuant.Clear();
            tbValorU.Clear();
            tbProduto.Focus();

        }

        private void btRemover_Click(object sender, EventArgs e)
        {
            double RemoverSupremo = double.Parse(DGVDados.CurrentRow.Cells["Total"].Value.ToString());
            //grande descoberta!!!!!!

            DGVDados.Rows.RemoveAt(DGVDados.CurrentCell.RowIndex);
            totaldinheiros -= RemoverSupremo;
            lbTotalDinheiros.Text = totaldinheiros.ToString("C");
        }

        private void btAltQuantItem_Click(object sender, EventArgs e)
        {
            totaldinheiros -= double.Parse(DGVDados.CurrentRow.Cells["Total"].Value.ToString());
            DGVDados.CurrentRow.Cells["Quantidades"].Value = tbAltQuantItem.Text;
            double total = double.Parse(DGVDados.CurrentRow.Cells["Quantidades"].Value.ToString()) * double.Parse(DGVDados.CurrentRow.Cells["ValorU"].Value.ToString());
            DGVDados.CurrentRow.Cells["Total"].Value = total;
            totaldinheiros += double.Parse(DGVDados.CurrentRow.Cells["Total"].Value.ToString());
            lbTotalDinheiros.Text = totaldinheiros.ToString("C");
        }

        private void DGVDados_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DGVDados.RowCount > 0)
                tbAltQuantItem.Text = DGVDados.CurrentRow.Cells["Quantidades"].Value.ToString();
        }

        private void btGravaVenda_Click(object sender, EventArgs e)
        {
            DGVDados.RowCount = 0;
            QuantVendas++;
            lbVenda.Text = QuantVendas.ToString();

            lbTotalDinheiros.Text = "";
            totaldinheiros = 0;
            tbAltQuantItem.Clear();
            tbProduto.Clear();
            tbQuant.Clear();
            tbValorU.Clear();
            tbProduto.Focus();

            MessageBox.Show("Venda Resgistrado com Sucesso", "Resgistro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void btCancelaVenda_Click(object sender, EventArgs e)
        {
            DGVDados.RowCount = 0;
            lbTotalDinheiros.Text = "";
            totaldinheiros = 0;
            tbAltQuantItem.Clear();
            tbProduto.Clear();
            tbQuant.Clear();
            tbValorU.Clear();
            tbProduto.Focus();

            MessageBox.Show("Venda Cancelada com Sucesso", "Resgistro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void btFechaTudo_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
