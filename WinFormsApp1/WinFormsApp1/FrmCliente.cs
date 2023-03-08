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
    public partial class FrmCliente : Form
    {
        public FrmCliente()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtb_Nome.Text == string.Empty || msktxtb_Cpf.Text == string.Empty || txtb_Rua.Text == string.Empty || txtb_Num.Text == string.Empty ||
                txtb_Cidade.Text == string.Empty || txtb_Uf.Text == string.Empty || msktxtb_Telefone.Text == string.Empty ||
                txtb_CodigoCli.Text == string.Empty || msktxtb_Datanasc.Text == string.Empty)
            {
                MessageBox.Show("PREENCHA OS CAMPOS");
            }
            else {
                MessageBox.Show("CLIENTE CADASTRADO");
            }
        }

        private void txtb_Nome_TextChanged(object sender, EventArgs e)
        {
            if (txtb_Nome.Text != string.Empty)
            {
                button1.Enabled = true;
            }
            else
            {
                button1.Enabled = false;
            }
        }

        private void txtb_Cpf_TextChanged(object sender, EventArgs e)
        {
           

        }

        private void txtb_Rua_TextChanged(object sender, EventArgs e)
        {
            if (txtb_Rua.Text != string.Empty)
            {
                button1.Enabled = true;
            }
            else
            {
                button1.Enabled = false;
            }
        }

        private void txtb_Num_TextChanged(object sender, EventArgs e)
        {
            decimal valor;
            bool numero = decimal.TryParse(txtb_Num.Text, out valor);
            if (numero == false)
            {
                txtb_Num.Clear();
                button1.Enabled = false;
            }
            else
            {
                button1.Enabled = true;
            }

        }

        private void txtb_Cidade_TextChanged(object sender, EventArgs e)
        {
            if (txtb_Cidade.Text != string.Empty)
            {
                button1.Enabled = true;
            }
            else
            {
                button1.Enabled = false;
            }
        }

        private void txtb_Uf_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (txtb_Uf.Text != string.Empty)
            {
                button1.Enabled = true;
            }
            else
            {
                button1.Enabled = false;
            }
        }

        private void txtb_Telefone_TextChanged(object sender, EventArgs e)
        {
            

        }

        private void txtb_datanasc_TextChanged(object sender, EventArgs e)
        {
            

        }

        private void txtb_CodigoCli_TextChanged(object sender, EventArgs e)
        {
            decimal valor;
            bool numero = decimal.TryParse(txtb_CodigoCli.Text, out valor);
            if (numero == false)
            {
                //txtb_CodigoCli.Clear();
                button1.Enabled = false;
            }
            else
            {
                button1.Enabled = true;
            }

        }

        private void btn_Limpar_Click(object sender, EventArgs e)
        {
            txtb_Nome.Clear();
            msktxtb_Cpf.Clear();
            txtb_CodigoCli.Clear();
            msktxtb_Datanasc.Clear();
            txtb_Num.Clear();
            msktxtb_Telefone.Clear();
            txtb_Rua.Clear();
            txtb_Uf.Text = "SELECIONE SUA UF";
            txtb_Cidade.Clear();

            //textbox do cep
            maskedTextBox1.Clear();

            txtb_Nome.Focus();
        }

        private void msktxtb_Telefone_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            decimal valor;
            bool numero = decimal.TryParse(msktxtb_Telefone.Text, out valor);
            if (numero == false)
            {
                //msktxtb_Telefone.Clear();
                button1.Enabled = false;
            }
            else
            {
                button1.Enabled = true;
            }
        }

        private void msktxtb_Datanasc_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            decimal valor;
            bool numero = decimal.TryParse(msktxtb_Datanasc.Text, out valor);
            if (numero == false)
            {
                //msktxtb_Datanasc.Clear();
                button1.Enabled = false;
            }
            else
            {
                button1.Enabled = true;
            }
        }

        private void msktxtb_Cpf_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            decimal valor;
            bool numero = decimal.TryParse(msktxtb_Cpf.Text, out valor);
            if (numero == false)
            {
               // msktxtb_Cpf.Clear();
                button1.Enabled = false;
            }
            else
            {
                button1.Enabled = true;
            }
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            decimal valor;                 //maskedTextBox1 é o CEP
            bool numero = decimal.TryParse(maskedTextBox1.Text, out valor);
            if (numero == false)
            {
                // msktxtb_Cpf.Clear();
                button1.Enabled = false;
            }
            else
            {
                button1.Enabled = true;
            }
        }
    }
}
