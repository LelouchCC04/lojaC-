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

    public partial class FormLogin : Form
    {




        public FormLogin()
        {           
            InitializeComponent();

            
        }
        

        private void btn_Logar_Click(object sender, EventArgs e)
        {
            
            string usuario = txtb_Usuario.Text, senha = txtb_Senha.Text;

            if (usuario == string.Empty && senha == string.Empty)
            {
                
                MessageBox.Show("POR FAVOR, PREENCHA TODOS OS CAMPOS");
            }
            else
            {
                
                if (usuario != "admin" && senha != "123")
                {
                    
                    FrmMenu menu = new FrmMenu();
                    this.Hide();
                    menu.ShowDialog();
                    

                }
                else
                {
                    MessageBox.Show("SENHA/USUARIO INVALIDO!");
                }
            }
        }

        private void btn_Limpar_Click(object sender, EventArgs e)
        {
            txtb_Senha.Clear();
            txtb_Usuario.Clear();
        }

        private void btn_Cadastrar_Click(object sender, EventArgs e)
        {
            
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
