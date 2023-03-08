using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class FrmMenu : Form
    {
        //FrmMenu menu = new FrmMenu();
        public FrmMenu()
        {
            InitializeComponent();
        }

        private void FrmMenu_Load(object sender, EventArgs e)
        {
            
        }

        private void btn_Cliente_Click(object sender, EventArgs e)
        {
            
            FrmCliente cliente= new FrmCliente();
            this.Hide();
            cliente.ShowDialog();
        }

        private void btn_Produto_Click(object sender, EventArgs e)
        {
            FrmProdutos produtos= new FrmProdutos();
            this.Hide();

            produtos.ShowDialog();
            
        }

        private void btn_Venda_Click(object sender, EventArgs e)
        {
            Form1 vendas = new Form1();
            this.Hide();

            vendas.ShowDialog();
        }

        private void btn_Marca_Click(object sender, EventArgs e)
        {
            FrmMarca marca=new FrmMarca();
            this.Hide();

            marca.ShowDialog();
        }

        private void btn_Fornecedor_Click(object sender, EventArgs e)
        {
            FrmFornecedor fornecedor=new FrmFornecedor();
            this.Hide();

            fornecedor.ShowDialog();
            
        }
    }
}
