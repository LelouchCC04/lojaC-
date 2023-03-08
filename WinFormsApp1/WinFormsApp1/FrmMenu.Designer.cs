namespace WinFormsApp1
{
    partial class FrmMenu
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
            this.btn_Cliente = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Produto = new System.Windows.Forms.Button();
            this.btn_Fornecedor = new System.Windows.Forms.Button();
            this.btn_Marca = new System.Windows.Forms.Button();
            this.btn_Venda = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_Cliente
            // 
            this.btn_Cliente.BackColor = System.Drawing.Color.Crimson;
            this.btn_Cliente.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_Cliente.ForeColor = System.Drawing.SystemColors.Window;
            this.btn_Cliente.Location = new System.Drawing.Point(48, 188);
            this.btn_Cliente.Name = "btn_Cliente";
            this.btn_Cliente.Size = new System.Drawing.Size(210, 127);
            this.btn_Cliente.TabIndex = 0;
            this.btn_Cliente.Text = "Cliente";
            this.btn_Cliente.UseVisualStyleBackColor = false;
            this.btn_Cliente.Click += new System.EventHandler(this.btn_Cliente_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(164, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(214, 79);
            this.label1.TabIndex = 1;
            this.label1.Text = "MENU";
            // 
            // btn_Produto
            // 
            this.btn_Produto.BackColor = System.Drawing.Color.Crimson;
            this.btn_Produto.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_Produto.ForeColor = System.Drawing.Color.White;
            this.btn_Produto.Location = new System.Drawing.Point(48, 355);
            this.btn_Produto.Name = "btn_Produto";
            this.btn_Produto.Size = new System.Drawing.Size(210, 127);
            this.btn_Produto.TabIndex = 2;
            this.btn_Produto.Text = "Produto";
            this.btn_Produto.UseVisualStyleBackColor = false;
            this.btn_Produto.Click += new System.EventHandler(this.btn_Produto_Click);
            // 
            // btn_Fornecedor
            // 
            this.btn_Fornecedor.BackColor = System.Drawing.Color.Crimson;
            this.btn_Fornecedor.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_Fornecedor.ForeColor = System.Drawing.Color.White;
            this.btn_Fornecedor.Location = new System.Drawing.Point(310, 189);
            this.btn_Fornecedor.Name = "btn_Fornecedor";
            this.btn_Fornecedor.Size = new System.Drawing.Size(210, 127);
            this.btn_Fornecedor.TabIndex = 3;
            this.btn_Fornecedor.Text = "Fornecedor";
            this.btn_Fornecedor.UseVisualStyleBackColor = false;
            this.btn_Fornecedor.Click += new System.EventHandler(this.btn_Fornecedor_Click);
            // 
            // btn_Marca
            // 
            this.btn_Marca.BackColor = System.Drawing.Color.Crimson;
            this.btn_Marca.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_Marca.ForeColor = System.Drawing.Color.White;
            this.btn_Marca.Location = new System.Drawing.Point(310, 355);
            this.btn_Marca.Name = "btn_Marca";
            this.btn_Marca.Size = new System.Drawing.Size(210, 124);
            this.btn_Marca.TabIndex = 4;
            this.btn_Marca.Text = "Marca";
            this.btn_Marca.UseVisualStyleBackColor = false;
            this.btn_Marca.Click += new System.EventHandler(this.btn_Marca_Click);
            // 
            // btn_Venda
            // 
            this.btn_Venda.BackColor = System.Drawing.Color.Crimson;
            this.btn_Venda.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_Venda.ForeColor = System.Drawing.Color.White;
            this.btn_Venda.Location = new System.Drawing.Point(182, 531);
            this.btn_Venda.Name = "btn_Venda";
            this.btn_Venda.Size = new System.Drawing.Size(211, 133);
            this.btn_Venda.TabIndex = 5;
            this.btn_Venda.Text = "Venda";
            this.btn_Venda.UseVisualStyleBackColor = false;
            this.btn_Venda.Click += new System.EventHandler(this.btn_Venda_Click);
            // 
            // FrmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(585, 716);
            this.Controls.Add(this.btn_Venda);
            this.Controls.Add(this.btn_Marca);
            this.Controls.Add(this.btn_Fornecedor);
            this.Controls.Add(this.btn_Produto);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Cliente);
            this.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.FrmMenu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btn_Cliente;
        private Label label1;
        private Button btn_Produto;
        private Button btn_Fornecedor;
        private Button btn_Marca;
        private Button btn_Venda;
    }
}