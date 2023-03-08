namespace WinFormsApp1
{
    partial class FrmFornecedor
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtb_Codigo = new System.Windows.Forms.TextBox();
            this.txtb_NomeFor = new System.Windows.Forms.TextBox();
            this.txtb_RuaFor = new System.Windows.Forms.TextBox();
            this.txtb_NumFor = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btn_CadastraFor = new System.Windows.Forms.Button();
            this.msktxtb_Telefone = new System.Windows.Forms.MaskedTextBox();
            this.msktxtb_Cnpj = new System.Windows.Forms.MaskedTextBox();
            this.dgv_Fornecedor = new System.Windows.Forms.DataGridView();
            this.label8 = new System.Windows.Forms.Label();
            this.btn_Limpar = new System.Windows.Forms.Button();
            this.btn_Menu = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Fornecedor)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Lavender;
            this.label1.Location = new System.Drawing.Point(80, 152);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Código:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Lavender;
            this.label2.Location = new System.Drawing.Point(80, 206);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nome:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.Lavender;
            this.label3.Location = new System.Drawing.Point(80, 260);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "Rua:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.Lavender;
            this.label4.Location = new System.Drawing.Point(411, 266);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 21);
            this.label4.TabIndex = 3;
            this.label4.Text = "Nº:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.Lavender;
            this.label5.Location = new System.Drawing.Point(80, 313);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 21);
            this.label5.TabIndex = 4;
            this.label5.Text = "Telefone:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.Lavender;
            this.label6.Location = new System.Drawing.Point(363, 319);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 21);
            this.label6.TabIndex = 5;
            this.label6.Text = "CNPJ:";
            // 
            // txtb_Codigo
            // 
            this.txtb_Codigo.Location = new System.Drawing.Point(187, 150);
            this.txtb_Codigo.Name = "txtb_Codigo";
            this.txtb_Codigo.Size = new System.Drawing.Size(401, 27);
            this.txtb_Codigo.TabIndex = 6;
            this.txtb_Codigo.TextChanged += new System.EventHandler(this.txtb_Codigo_TextChanged);
            // 
            // txtb_NomeFor
            // 
            this.txtb_NomeFor.Location = new System.Drawing.Point(187, 200);
            this.txtb_NomeFor.Name = "txtb_NomeFor";
            this.txtb_NomeFor.Size = new System.Drawing.Size(401, 27);
            this.txtb_NomeFor.TabIndex = 7;
            this.txtb_NomeFor.TextChanged += new System.EventHandler(this.txtb_NomeFor_TextChanged);
            // 
            // txtb_RuaFor
            // 
            this.txtb_RuaFor.Location = new System.Drawing.Point(187, 260);
            this.txtb_RuaFor.Name = "txtb_RuaFor";
            this.txtb_RuaFor.Size = new System.Drawing.Size(207, 27);
            this.txtb_RuaFor.TabIndex = 8;
            this.txtb_RuaFor.TextChanged += new System.EventHandler(this.txtb_RuaFor_TextChanged);
            // 
            // txtb_NumFor
            // 
            this.txtb_NumFor.Location = new System.Drawing.Point(468, 260);
            this.txtb_NumFor.Name = "txtb_NumFor";
            this.txtb_NumFor.Size = new System.Drawing.Size(120, 27);
            this.txtb_NumFor.TabIndex = 9;
            this.txtb_NumFor.TextChanged += new System.EventHandler(this.txtb_NumFor_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Showcard Gothic", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(80, 30);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(451, 79);
            this.label7.TabIndex = 12;
            this.label7.Text = "fornecedor";
            // 
            // btn_CadastraFor
            // 
            this.btn_CadastraFor.BackgroundImage = global::WinFormsApp1.Properties.Resources.retrowave;
            this.btn_CadastraFor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_CadastraFor.ForeColor = System.Drawing.Color.White;
            this.btn_CadastraFor.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btn_CadastraFor.Location = new System.Drawing.Point(511, 494);
            this.btn_CadastraFor.Name = "btn_CadastraFor";
            this.btn_CadastraFor.Size = new System.Drawing.Size(110, 43);
            this.btn_CadastraFor.TabIndex = 13;
            this.btn_CadastraFor.Text = "Cadastrar";
            this.btn_CadastraFor.UseVisualStyleBackColor = true;
            this.btn_CadastraFor.Click += new System.EventHandler(this.btn_CadastraFor_Click);
            // 
            // msktxtb_Telefone
            // 
            this.msktxtb_Telefone.Location = new System.Drawing.Point(187, 311);
            this.msktxtb_Telefone.Mask = "(99) 00000-0000";
            this.msktxtb_Telefone.Name = "msktxtb_Telefone";
            this.msktxtb_Telefone.Size = new System.Drawing.Size(124, 27);
            this.msktxtb_Telefone.TabIndex = 14;
            // 
            // msktxtb_Cnpj
            // 
            this.msktxtb_Cnpj.Location = new System.Drawing.Point(428, 313);
            this.msktxtb_Cnpj.Mask = " XX, XXX, XXX/0001-XX";
            this.msktxtb_Cnpj.Name = "msktxtb_Cnpj";
            this.msktxtb_Cnpj.Size = new System.Drawing.Size(160, 27);
            this.msktxtb_Cnpj.TabIndex = 15;
            // 
            // dgv_Fornecedor
            // 
            this.dgv_Fornecedor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Fornecedor.Location = new System.Drawing.Point(80, 453);
            this.dgv_Fornecedor.Name = "dgv_Fornecedor";
            this.dgv_Fornecedor.RowTemplate.Height = 25;
            this.dgv_Fornecedor.Size = new System.Drawing.Size(363, 309);
            this.dgv_Fornecedor.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.ForeColor = System.Drawing.Color.Lavender;
            this.label8.Location = new System.Drawing.Point(80, 408);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(106, 20);
            this.label8.TabIndex = 17;
            this.label8.Text = "FORNECEDOR:";
            // 
            // btn_Limpar
            // 
            this.btn_Limpar.BackgroundImage = global::WinFormsApp1.Properties.Resources.retrowave;
            this.btn_Limpar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Limpar.ForeColor = System.Drawing.Color.White;
            this.btn_Limpar.Location = new System.Drawing.Point(511, 584);
            this.btn_Limpar.Name = "btn_Limpar";
            this.btn_Limpar.Size = new System.Drawing.Size(110, 43);
            this.btn_Limpar.TabIndex = 18;
            this.btn_Limpar.Text = "Limpar";
            this.btn_Limpar.UseVisualStyleBackColor = true;
            this.btn_Limpar.Click += new System.EventHandler(this.btn_Limpar_Click);
            // 
            // btn_Menu
            // 
            this.btn_Menu.BackgroundImage = global::WinFormsApp1.Properties.Resources.retrowave;
            this.btn_Menu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Menu.ForeColor = System.Drawing.Color.White;
            this.btn_Menu.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btn_Menu.Location = new System.Drawing.Point(511, 675);
            this.btn_Menu.Name = "btn_Menu";
            this.btn_Menu.Size = new System.Drawing.Size(110, 43);
            this.btn_Menu.TabIndex = 19;
            this.btn_Menu.Text = "MENU";
            this.btn_Menu.UseVisualStyleBackColor = true;
            this.btn_Menu.Click += new System.EventHandler(this.btn_Menu_Click);
            // 
            // FrmFornecedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WinFormsApp1.Properties.Resources.retrowave;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(660, 774);
            this.Controls.Add(this.btn_Menu);
            this.Controls.Add(this.btn_Limpar);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dgv_Fornecedor);
            this.Controls.Add(this.msktxtb_Cnpj);
            this.Controls.Add(this.msktxtb_Telefone);
            this.Controls.Add(this.btn_CadastraFor);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtb_NumFor);
            this.Controls.Add(this.txtb_RuaFor);
            this.Controls.Add(this.txtb_NomeFor);
            this.Controls.Add(this.txtb_Codigo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmFornecedor";
            this.Text = "Fornecedor";
            this.Load += new System.EventHandler(this.FrmFornecedor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Fornecedor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox txtb_Codigo;
        private TextBox txtb_NomeFor;
        private TextBox txtb_RuaFor;
        private TextBox txtb_NumFor;
        private Label label7;
        private Button btn_CadastraFor;
        private MaskedTextBox msktxtb_Telefone;
        private MaskedTextBox msktxtb_Cnpj;
        private DataGridView dgv_Fornecedor;
        private Label label8;
        private Button btn_Limpar;
        private Button btn_Menu;
    }
}