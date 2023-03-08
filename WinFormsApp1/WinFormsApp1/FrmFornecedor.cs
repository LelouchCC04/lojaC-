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
    public partial class FrmFornecedor : Form
    {
        

        public FrmFornecedor()
        {
            InitializeComponent();
        }

        private void btn_CadastraFor_Click(object sender, EventArgs e)
        {
            
            if (txtb_NomeFor.Text == string.Empty || msktxtb_Cnpj.Text == string.Empty || txtb_RuaFor.Text == string.Empty || txtb_NumFor.Text == string.Empty ||
               msktxtb_Telefone.Text == string.Empty ||
                txtb_Codigo.Text == string.Empty)
            {
                MessageBox.Show("PREENCHA OS CAMPOS");
            }
            else
            {
                MessageBox.Show("CLIENTE CADASTRADO");
            }

        }

        private void FrmFornecedor_Load(object sender, EventArgs e)
        {

        }

        private void txtb_Codigo_TextChanged(object sender, EventArgs e)
        {
            decimal valor;
            bool numero = decimal.TryParse(txtb_Codigo.Text, out valor);
            if (numero == false) {
                //txtb_Codigo.Clear();
                btn_CadastraFor.Enabled = false;
            }
            else
            {
                btn_CadastraFor.Enabled = true;
            }
            
        }

        private void txtb_NomeFor_TextChanged(object sender, EventArgs e)
        {
            if (txtb_NomeFor.Text != string.Empty)
            {
                btn_CadastraFor.Enabled = true;
            }
            else
            {
                btn_CadastraFor.Enabled = false;
            }
        }

        private void txtb_RuaFor_TextChanged(object sender, EventArgs e)
        {
            if (txtb_RuaFor.Text != string.Empty)
            {
                btn_CadastraFor.Enabled = true;
            }
            else
            {
                btn_CadastraFor.Enabled = false;
            }
        }

        private void txtb_NumFor_TextChanged(object sender, EventArgs e)
        {
            decimal valor;
            bool numero = decimal.TryParse(txtb_NumFor.Text, out valor);
            if (numero == false)
            {
                //txtb_NumFor.Clear();
                btn_CadastraFor.Enabled = false;
            }
            else
            {
                btn_CadastraFor.Enabled = true;
            }

        }

        private void txtb_TelefoneFor_TextChanged(object sender, EventArgs e)
        {
            decimal valor;
            bool numero = decimal.TryParse(msktxtb_Telefone.Text, out valor);
            if (numero == false)
            {
               // msktxtb_Telefone.Clear();
                btn_CadastraFor.Enabled = false;
            }
            else
            {
                btn_CadastraFor.Enabled = true;
            }

        }

        private void txtb_CnpjFor_TextChanged(object sender, EventArgs e)
        {
            decimal valor;
            bool numero = decimal.TryParse(msktxtb_Cnpj.Text, out valor);
            if (numero == false)
            {
                //msktxtb_Cnpj.Clear();
                btn_CadastraFor.Enabled = false;
            }
            else
            {
                btn_CadastraFor.Enabled = true;
            }

        }

        private void btn_Limpar_Click(object sender, EventArgs e)
        {

        }

        private void btn_Menu_Click(object sender, EventArgs e)
        {
            
            FrmMenu menu = new FrmMenu();
            this.Hide();

            menu.ShowDialog();
           


        }
    }
}
