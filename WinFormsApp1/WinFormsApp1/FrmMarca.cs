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
    public partial class FrmMarca : Form
    {
        public FrmMarca()
        {
            InitializeComponent();
        }

        private void btn_conteudoMarca_Click(object sender, EventArgs e)
        {
            if (txtb_CodMarca.Text == string.Empty || txtb_NomeMarca.Text == string.Empty || txtb_DescMarca.Text == string.Empty)
            {
                MessageBox.Show("Preencha os Campos");
            }
            else
            {
                MessageBox.Show("Marca CAdastrada");
            }
        }

        private void FrmMarca_Load(object sender, EventArgs e)
        {

        }

        private void txtb_CodMarca_TextChanged(object sender, EventArgs e)
        {
            decimal valor;
            bool numero = decimal.TryParse(txtb_CodMarca.Text, out valor);
            if (numero == false)
            {
                //txtb_CodMarca.Clear();
                btn_conteudoMarca.Enabled = false;
            }
            else
            {
                btn_conteudoMarca.Enabled = true;
            }
        }

        private void txtb_DescMarca_TextChanged(object sender, EventArgs e)
        {
            if (txtb_DescMarca.Text != string.Empty)
            {
                btn_conteudoMarca.Enabled = false;
            }
            else
            {
                btn_conteudoMarca.Enabled = true;
            }
        }

        private void txtb_NomeMarca_TextChanged(object sender, EventArgs e)
        {
            if (txtb_NomeMarca.Text == string.Empty)
            {
                btn_conteudoMarca.Enabled = false;
            }
            else
            {
                btn_conteudoMarca.Enabled = true;
            }
        }

        private void btn_Limpar_Click(object sender, EventArgs e)
        {
            txtb_CodMarca.Clear();
            txtb_NomeMarca.Clear();
            txtb_DescMarca.Clear();

            txtb_CodMarca.Focus();
        }
    }
}
