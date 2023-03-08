namespace WinFormsApp1
{
    partial class FrmCliente
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.txtb_Uf = new System.Windows.Forms.ComboBox();
            this.txtb_Cidade = new System.Windows.Forms.TextBox();
            this.txtb_Rua = new System.Windows.Forms.TextBox();
            this.txtb_Nome = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Limpar = new System.Windows.Forms.Button();
            this.msktxtb_Telefone = new System.Windows.Forms.MaskedTextBox();
            this.msktxtb_Datanasc = new System.Windows.Forms.MaskedTextBox();
            this.msktxtb_Cpf = new System.Windows.Forms.MaskedTextBox();
            this.txtb_CodigoCli = new System.Windows.Forms.TextBox();
            this.txtb_Num = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.dgv_Cliente = new System.Windows.Forms.DataGridView();
            this.label12 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Cliente)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DimGray;
            this.button1.BackgroundImage = global::WinFormsApp1.Properties.Resources._22878751;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(460, 620);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(86, 45);
            this.button1.TabIndex = 40;
            this.button1.Text = "Cadastrar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Showcard Gothic", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label10.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label10.Location = new System.Drawing.Point(160, 23);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(290, 79);
            this.label10.TabIndex = 38;
            this.label10.Text = "CLIENTE";
            // 
            // txtb_Uf
            // 
            this.txtb_Uf.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtb_Uf.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtb_Uf.FormattingEnabled = true;
            this.txtb_Uf.Items.AddRange(new object[] {
            "AC",
            "AL",
            "AP",
            "AM",
            "BA",
            "CE",
            "DF",
            "GO",
            "ES",
            "MA",
            "MT",
            "MS",
            "MG",
            "PA",
            "PB",
            "PR",
            "PE",
            "PI",
            "RJ",
            "RN",
            "RS",
            "RO",
            "RR",
            "SP",
            "SC",
            "SE",
            "TO"});
            this.txtb_Uf.Location = new System.Drawing.Point(132, 359);
            this.txtb_Uf.Name = "txtb_Uf";
            this.txtb_Uf.Size = new System.Drawing.Size(141, 25);
            this.txtb_Uf.TabIndex = 35;
            this.txtb_Uf.SelectedIndexChanged += new System.EventHandler(this.txtb_Uf_SelectedIndexChanged);
            // 
            // txtb_Cidade
            // 
            this.txtb_Cidade.Location = new System.Drawing.Point(132, 308);
            this.txtb_Cidade.Name = "txtb_Cidade";
            this.txtb_Cidade.Size = new System.Drawing.Size(270, 27);
            this.txtb_Cidade.TabIndex = 34;
            this.txtb_Cidade.TextChanged += new System.EventHandler(this.txtb_Cidade_TextChanged);
            // 
            // txtb_Rua
            // 
            this.txtb_Rua.Location = new System.Drawing.Point(132, 220);
            this.txtb_Rua.Name = "txtb_Rua";
            this.txtb_Rua.Size = new System.Drawing.Size(446, 27);
            this.txtb_Rua.TabIndex = 32;
            this.txtb_Rua.TextChanged += new System.EventHandler(this.txtb_Rua_TextChanged);
            // 
            // txtb_Nome
            // 
            this.txtb_Nome.Location = new System.Drawing.Point(132, 133);
            this.txtb_Nome.Name = "txtb_Nome";
            this.txtb_Nome.Size = new System.Drawing.Size(446, 27);
            this.txtb_Nome.TabIndex = 30;
            this.txtb_Nome.TextChanged += new System.EventHandler(this.txtb_Nome_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.ForeColor = System.Drawing.Color.Crimson;
            this.label9.Location = new System.Drawing.Point(41, 499);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(63, 21);
            this.label9.TabIndex = 29;
            this.label9.Text = "Código:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.Color.Crimson;
            this.label8.Location = new System.Drawing.Point(41, 448);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(153, 21);
            this.label8.TabIndex = 28;
            this.label8.Text = "Data de Nascimento:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.Color.Crimson;
            this.label7.Location = new System.Drawing.Point(41, 406);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 21);
            this.label7.TabIndex = 27;
            this.label7.Text = "Telefone:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.Crimson;
            this.label6.Location = new System.Drawing.Point(41, 363);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 21);
            this.label6.TabIndex = 26;
            this.label6.Text = "UF:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.Crimson;
            this.label5.Location = new System.Drawing.Point(41, 314);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 21);
            this.label5.TabIndex = 25;
            this.label5.Text = "Cidade:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.Crimson;
            this.label4.Location = new System.Drawing.Point(41, 266);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 21);
            this.label4.TabIndex = 24;
            this.label4.Text = "Nº:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.Crimson;
            this.label3.Location = new System.Drawing.Point(41, 222);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 21);
            this.label3.TabIndex = 23;
            this.label3.Text = "Rua:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Crimson;
            this.label2.Location = new System.Drawing.Point(41, 180);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 21);
            this.label2.TabIndex = 22;
            this.label2.Text = "CPF:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Crimson;
            this.label1.Location = new System.Drawing.Point(41, 133);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 21);
            this.label1.TabIndex = 21;
            this.label1.Text = "Nome:";
            // 
            // btn_Limpar
            // 
            this.btn_Limpar.BackgroundImage = global::WinFormsApp1.Properties.Resources._22878751;
            this.btn_Limpar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Limpar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Limpar.ForeColor = System.Drawing.Color.White;
            this.btn_Limpar.Location = new System.Drawing.Point(460, 691);
            this.btn_Limpar.Name = "btn_Limpar";
            this.btn_Limpar.Size = new System.Drawing.Size(87, 45);
            this.btn_Limpar.TabIndex = 41;
            this.btn_Limpar.Text = "Limpar";
            this.btn_Limpar.UseVisualStyleBackColor = true;
            this.btn_Limpar.Click += new System.EventHandler(this.btn_Limpar_Click);
            // 
            // msktxtb_Telefone
            // 
            this.msktxtb_Telefone.Location = new System.Drawing.Point(132, 400);
            this.msktxtb_Telefone.Mask = "(000) 00000-0000";
            this.msktxtb_Telefone.Name = "msktxtb_Telefone";
            this.msktxtb_Telefone.Size = new System.Drawing.Size(107, 27);
            this.msktxtb_Telefone.TabIndex = 42;
            this.msktxtb_Telefone.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.msktxtb_Telefone.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.msktxtb_Telefone_MaskInputRejected);
            // 
            // msktxtb_Datanasc
            // 
            this.msktxtb_Datanasc.Location = new System.Drawing.Point(212, 448);
            this.msktxtb_Datanasc.Mask = "00/00/0000";
            this.msktxtb_Datanasc.Name = "msktxtb_Datanasc";
            this.msktxtb_Datanasc.Size = new System.Drawing.Size(80, 27);
            this.msktxtb_Datanasc.TabIndex = 43;
            this.msktxtb_Datanasc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.msktxtb_Datanasc.ValidatingType = typeof(System.DateTime);
            this.msktxtb_Datanasc.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.msktxtb_Datanasc_MaskInputRejected);
            // 
            // msktxtb_Cpf
            // 
            this.msktxtb_Cpf.Location = new System.Drawing.Point(132, 178);
            this.msktxtb_Cpf.Mask = "000,000,000-00";
            this.msktxtb_Cpf.Name = "msktxtb_Cpf";
            this.msktxtb_Cpf.Size = new System.Drawing.Size(100, 27);
            this.msktxtb_Cpf.TabIndex = 44;
            this.msktxtb_Cpf.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.msktxtb_Cpf_MaskInputRejected);
            // 
            // txtb_CodigoCli
            // 
            this.txtb_CodigoCli.Location = new System.Drawing.Point(132, 499);
            this.txtb_CodigoCli.Name = "txtb_CodigoCli";
            this.txtb_CodigoCli.Size = new System.Drawing.Size(446, 27);
            this.txtb_CodigoCli.TabIndex = 37;
            this.txtb_CodigoCli.TextChanged += new System.EventHandler(this.txtb_CodigoCli_TextChanged);
            // 
            // txtb_Num
            // 
            this.txtb_Num.Location = new System.Drawing.Point(132, 260);
            this.txtb_Num.Name = "txtb_Num";
            this.txtb_Num.Size = new System.Drawing.Size(100, 27);
            this.txtb_Num.TabIndex = 33;
            this.txtb_Num.TextChanged += new System.EventHandler(this.txtb_Num_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.ForeColor = System.Drawing.Color.Crimson;
            this.label11.Location = new System.Drawing.Point(44, 548);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(37, 20);
            this.label11.TabIndex = 45;
            this.label11.Text = "CEP:";
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.BackColor = System.Drawing.Color.White;
            this.maskedTextBox1.Location = new System.Drawing.Point(132, 548);
            this.maskedTextBox1.Mask = "00000-999";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(100, 27);
            this.maskedTextBox1.TabIndex = 46;
            this.maskedTextBox1.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox1_MaskInputRejected);
            // 
            // dgv_Cliente
            // 
            this.dgv_Cliente.BackgroundColor = System.Drawing.Color.Black;
            this.dgv_Cliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Cliente.GridColor = System.Drawing.SystemColors.Control;
            this.dgv_Cliente.Location = new System.Drawing.Point(44, 620);
            this.dgv_Cliente.Name = "dgv_Cliente";
            this.dgv_Cliente.RowTemplate.Height = 25;
            this.dgv_Cliente.Size = new System.Drawing.Size(371, 129);
            this.dgv_Cliente.TabIndex = 47;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.ForeColor = System.Drawing.Color.Crimson;
            this.label12.Location = new System.Drawing.Point(41, 585);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(67, 20);
            this.label12.TabIndex = 48;
            this.label12.Text = "CLIENTE:";
            // 
            // FrmCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.BackgroundImage = global::WinFormsApp1.Properties.Resources._22878751;
            this.ClientSize = new System.Drawing.Size(650, 778);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.dgv_Cliente);
            this.Controls.Add(this.maskedTextBox1);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.msktxtb_Cpf);
            this.Controls.Add(this.msktxtb_Datanasc);
            this.Controls.Add(this.msktxtb_Telefone);
            this.Controls.Add(this.btn_Limpar);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtb_CodigoCli);
            this.Controls.Add(this.txtb_Uf);
            this.Controls.Add(this.txtb_Cidade);
            this.Controls.Add(this.txtb_Num);
            this.Controls.Add(this.txtb_Rua);
            this.Controls.Add(this.txtb_Nome);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmCliente";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Cliente)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button button1;
        private Label label10;
        private ComboBox txtb_Uf;
        private TextBox txtb_Cidade;
        private TextBox txtb_Rua;
        private TextBox txtb_Nome;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button btn_Limpar;
        private MaskedTextBox msktxtb_Telefone;
        private MaskedTextBox msktxtb_Datanasc;
        private MaskedTextBox msktxtb_Cpf;
        private TextBox txtb_CodigoCli;
        private TextBox txtb_Num;
        private Label label11;
        private MaskedTextBox maskedTextBox1;
        private DataGridView dgv_Cliente;
        private Label label12;
    }
}