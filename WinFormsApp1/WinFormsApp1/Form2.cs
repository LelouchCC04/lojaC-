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
    public partial class FrmProdutos : Form
    {
        public FrmProdutos()
        {
            InitializeComponent();
        }

        private void btn_VoltarMenu_Click(object sender, EventArgs e)
        {
            FrmMenu menu = new FrmMenu();
            this.Hide();

            menu.ShowDialog();
            
        }

        private void btn_Limpar_Click(object sender, EventArgs e)
        {
            txtb_Codigo.Clear();
            txtb_Descricao.Clear();
            txtb_Nome.Clear();
           
        }
    }
}
