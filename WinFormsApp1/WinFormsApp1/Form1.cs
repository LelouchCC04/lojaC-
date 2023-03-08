using System.Drawing;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        decimal subtotal, total, valun, quant;
        string pgto,parcela;

        //criar função\método para posicionar\inserir em qualquer lugar do código sem redundâncias
        public void add_marcas()//adiciona itens no combobox
        {
            cbMarca.Items.Add("Selecione a marca");
            cbMarca.Items.Add("1");
            cbMarca.Items.Add("2");
        }
        public void limpaPar()
        {
            //limpa labels
            lblNota.Text = "";
            lblNota.Enabled = false;
            groupBox1.Enabled = false;
            groupBox2.Enabled = false;
            txtValorU.Enabled = false;
            txtSubtotal.Enabled = false;
            txtValor.Enabled = false;

            //limpar radiobutton parcelas
            rbCred.Checked = false;
            rbCred10.Checked = false;
            rbCred3.Checked = false;
            rbCred6.Checked = false;
            rbVista.Checked = false;

            btnCalcular.Enabled = false;
            
            //limpa valor parcelas
            txtVista.Clear();
            txtCred10.Clear();
            txtCred3.Clear();
            txtCred6.Clear();
        }
        public void limpar()
        {
            //limpa caixa de texto e radiobuttons
            limpaPar();
            txtQuantidade.Clear();
            txtSubtotal.Clear();
            txtValor.Clear();
            txtValorU.Clear();
            rbDinheiro.Checked = false;
            //limpa labels
            lblNota.Text = "--------- SEJA BEM-VINDO -------------"+
                            "\n---------- BOAS COMPRAS ------------";
            //Limpa marca e produtos
            cbMarca.SelectedItem = "Selecione a marca";
            cbProduto.Items.Clear();
        }

        public void limparQtd()
        {
            //limpa labels
            lblNota.Text = "";
            lblNota.Enabled = false;
            groupBox1.Enabled = false;
            groupBox2.Enabled = false;
            txtValorU.Enabled = false;
            txtSubtotal.Enabled = false;
            txtValor.Enabled = false;

            //limpar radiobutton parcelas
            rbCred.Checked = false;
            rbCred10.Checked = false;
            rbCred3.Checked = false;
            rbCred6.Checked = false;
            rbVista.Checked = false;

            btnCalcular.Enabled = false;

            //limpa valor parcelas
            txtVista.Clear();
            txtCred10.Clear();
            txtCred3.Clear();
            txtCred6.Clear();

           
        }
       
        public Form1()//inicialização da janela
        {
            InitializeComponent();
            add_marcas();
            lblstripData.Text = DateTime.Now.ToShortDateString();
            cbMarca.SelectedItem="Selecione a marca";
            limpaPar();
        }
        
        private void timer1_Tick(object sender, EventArgs e)
        {
            lblstripHora.Text = DateTime.Now.ToLongTimeString();
        }
        private void cbMarca_SelectedIndexChanged(object sender, EventArgs e)//seleção de marca
        {
            if (cbMarca.Text == "1")
            {
                limpaPar();
                txtQuantidade.Clear();
                txtSubtotal.Clear();
                txtValor.Clear();
                txtValorU.Clear();
                cbProduto.Items.Clear();
                cbProduto.Items.Add("a");
                cbProduto.Items.Add("b");
            }
            if (cbMarca.Text == "2")
            {
                limpaPar();
                txtQuantidade.Clear();
                txtSubtotal.Clear();
                txtValor.Clear();
                txtValorU.Clear();
                cbProduto.Items.Clear();
                cbProduto.Items.Add("c");
                cbProduto.Items.Add("d");
            }
        }

        private void rbDinheiro_CheckedChanged(object sender, EventArgs e)
        {
            
            try
            {
                
                rbVista.Enabled= false;
                rbCred3.Enabled = false;
                rbCred6.Enabled = false;
                rbCred10.Enabled = false;
                
                btnCalcular.Enabled = true;

                total = subtotal - (subtotal * 5) / 100;
                txtValor.Text = total.ToString("N2");
                pgto = "Dinheiro";
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void rbCred_CheckedChanged(object sender, EventArgs e)
        {
            txtValor.Text = txtSubtotal.Text;
            decimal total = Convert.ToDecimal(txtValor.Text);
            if (total <= 350)
            {
                rbVista.Enabled = true;
                


                rbCred3.Enabled = false;
                txtCred3.Enabled = false;
                rbCred6.Enabled = false;
                txtCred6.Enabled = false;
                rbCred10.Enabled = false;
                txtCred10.Enabled = false;

                
              
            }
            else if (total >= 350 && total < 1500)
            {
                rbVista.Enabled = true;

                

                rbCred3.Enabled = true;
                txtCred3.Enabled = true;
                rbCred6.Enabled = false;
                txtCred6.Enabled = false;
                rbCred10.Enabled = false;
                txtCred10.Enabled = false;
                

            }
            else if (total >= 1500 && total < 5000)
            {
                rbVista.Enabled = true;

               

                rbCred3.Enabled = true;
                txtCred3.Enabled = true;
                rbCred6.Enabled = true;
                txtCred6.Enabled = true;
                rbCred10.Enabled = false;
                txtCred10.Enabled = false;
            }
            else if (total > 5000)
            {
                rbVista.Enabled = true;

                

                rbCred3.Enabled = true;
                txtCred3.Enabled = true;
                rbCred6.Enabled = true;
                txtCred6.Enabled = true;
                rbCred10.Enabled = true;
                txtCred10.Enabled = true;
            }

            try
            {
                
                rbVista.Enabled = true;
                rbCred3.Enabled = true;
                rbCred6.Enabled = true;
                rbCred10.Enabled = true;

                txtValor.Clear();

                txtVista.Text = subtotal.ToString("N2");
                txtCred3.Text = (subtotal / 3).ToString("N2");
                txtCred6.Text = (subtotal / 6).ToString("N2");
                txtCred10.Text = (subtotal / 10).ToString("N2");
                pgto = "Crédito";
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            limpar();
           

        }

        private void rbVista_CheckedChanged(object sender, EventArgs e)
        {          
            total = subtotal;
            txtValor.Text= total.ToString("N2");
            btnCalcular.Enabled = true;

        }

        private void rbCred3_CheckedChanged(object sender, EventArgs e)
        {
            parcela = "em 3x";
            total = subtotal / 3;
            txtValor.Text = total.ToString("N2");
            btnCalcular.Enabled = true;

        }

        private void rbCred6_CheckedChanged(object sender, EventArgs e)
        {
            parcela = "em 6x";
            total = subtotal / 6;
            txtValor.Text = total.ToString("N2");
            btnCalcular.Enabled = true;

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void txtValor_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void rbCred10_CheckedChanged(object sender, EventArgs e)
        {
            parcela = "em 10x";
            total = subtotal / 10;
            txtValor.Text = total.ToString("N2");
            btnCalcular.Enabled = true;

        }

        private void cbProduto_SelectedIndexChanged(object sender, EventArgs e)//seleção de produto
        {
            

            limpaPar();
            txtQuantidade.Clear();
            txtSubtotal.Clear();
            txtValor.Clear();
            txtValorU.Clear();

            switch (cbProduto.Text)
            {
                case "a": valun= 250; 
                    break;
                case "b": valun= 200;
                    break;
                case "c": valun= 150; 
                    break;
                case "d": valun= 300; 
                    break;
                default:txtValorU.Text = "";
                    break;
            }
            txtValorU.Text = valun.ToString();
        }

        private void txtQuantidade_TextChanged(object sender, EventArgs e)
        {
            

            try
            {
                rbVista.Enabled = false;
                rbCred3.Enabled= false;
                rbCred6.Enabled= false;
                rbCred10.Enabled= false;


                quant = Convert.ToDecimal(txtQuantidade.Text);
                valun = Convert.ToDecimal(txtValorU.Text);
                subtotal = quant * valun;
                txtSubtotal.Text = subtotal.ToString();
                groupBox1.Enabled = true;
                groupBox2.Enabled = true;
                
            }
            catch (Exception)
            {

            }
            
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            lblNota.Enabled = true;


            if (rbDinheiro.Checked==true)
            {
                

                lblNota.Text =
                "*********************************\n" +
                "Produto: " + cbProduto.Text +
                "\nQuantidade: " + quant.ToString() +
                "\nValor Unitario: " + valun.ToString("C")  +
                "\nValor Total: " + total.ToString("C") + "****" +
                "\n***************************************" +
                "\nForma de Pgto: " + pgto + " " + parcela + "****" +
                "\n********************************\n" +
                DateTime.Now.ToShortDateString() + "  " +
                DateTime.Now.ToLongTimeString();

                
                

            }
            else if(rbCred.Checked==true)
            {
                lblNota.Text =
                "**********************************\n" +
                "Produto: " + cbProduto.Text +
                "\nQuantidade: " + quant.ToString() +
                "\nValor Unitario: " + valun.ToString("C") +
                "\nValor Total: " + subtotal.ToString("C") +
                "\nValor da parcela: " + total.ToString("C") +
                "\n*********************************" +
                "\nForma de Pgto: " + pgto + " " + parcela +
                "\n*********************************\n" +
                DateTime.Now.ToShortDateString() + "  " +
                DateTime.Now.ToLongTimeString();

                
            }
            else if(rbVista.Checked==true)
            {
                lblNota.Text =
                "***********************\n" +
                "Produto: " + cbProduto.Text +
                "\nQuantidade: " + quant.ToString() +
                "\nValor Unitario: " + valun.ToString("C") +
                "\nValor Total: " + subtotal.ToString("C") +
                "\nValor da parcela: " + total.ToString("C") +
                "\n**********************" +
                "\nForma de Pgto: " + pgto + " " + parcela +
                "\n**********************\n" +
                DateTime.Now.ToShortDateString() + "  " +
                DateTime.Now.ToLongTimeString();

               

            }
            else if (rbCred3.Checked == true)
            {
                lblNota.Text =
                "***********************\n" +
                "Produto: " + cbProduto.Text +
                "\nQuantidade: " + quant.ToString() +
                "\nValor Unitario: " + valun.ToString("C") +
                "\nValor Total: " + subtotal.ToString("C") +
                "\nValor da parcela: " + total.ToString("C") +
                "\n**********************" +
                "\nForma de Pgto: " + pgto + " " + parcela +
                "\n**********************\n" +
                DateTime.Now.ToShortDateString() + "  " +
                DateTime.Now.ToLongTimeString();

                

            }
            else if (rbCred6.Checked == true)
            {
                lblNota.Text =
                "***********************\n" +
                "Produto: " + cbProduto.Text +
                "\nQuantidade: " + quant.ToString() +
                "\nValor Unitario: " + valun.ToString("C") +
                "\nValor Total: " + total.ToString("C") +
                "\n**********************" +
                "\nForma de Pgto: " + pgto +
                "\n**********************\n" +
                DateTime.Now.ToShortDateString() + "  " +
                DateTime.Now.ToLongTimeString();

                

            }
            else if (rbCred10.Checked == true)
            {
                lblNota.Text =
                "***********************\n" +
                "Produto: " + cbProduto.Text +
                "\nQuantidade: " + quant.ToString() +
                "\nValor Unitario: " + valun.ToString("C") +
                "\nValor Total: " + total.ToString("C") +
                "\n**********************" +
                "\nForma de Pgto: " + pgto +
                "\n**********************\n" +
                DateTime.Now.ToShortDateString() + "  " +
                DateTime.Now.ToLongTimeString();

                

            }

        }
    }
}