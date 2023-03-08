namespace WinFormsApp1
{
    partial class FrmMarca
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
            this.btn_conteudoMarca = new System.Windows.Forms.Button();
            this.txtb_CodMarca = new System.Windows.Forms.TextBox();
            this.txtb_NomeMarca = new System.Windows.Forms.TextBox();
            this.txtb_DescMarca = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_Limpar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_conteudoMarca
            // 
            this.btn_conteudoMarca.ForeColor = System.Drawing.Color.White;
            this.btn_conteudoMarca.Image = global::WinFormsApp1.Properties.Resources._abstract;
            this.btn_conteudoMarca.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_conteudoMarca.Location = new System.Drawing.Point(388, 422);
            this.btn_conteudoMarca.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_conteudoMarca.Name = "btn_conteudoMarca";
            this.btn_conteudoMarca.Size = new System.Drawing.Size(97, 42);
            this.btn_conteudoMarca.TabIndex = 0;
            this.btn_conteudoMarca.Text = "Cadastrar";
            this.btn_conteudoMarca.UseVisualStyleBackColor = true;
            this.btn_conteudoMarca.Click += new System.EventHandler(this.btn_conteudoMarca_Click);
            // 
            // txtb_CodMarca
            // 
            this.txtb_CodMarca.Location = new System.Drawing.Point(168, 156);
            this.txtb_CodMarca.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtb_CodMarca.Name = "txtb_CodMarca";
            this.txtb_CodMarca.Size = new System.Drawing.Size(317, 27);
            this.txtb_CodMarca.TabIndex = 1;
            this.txtb_CodMarca.TextChanged += new System.EventHandler(this.txtb_CodMarca_TextChanged);
            // 
            // txtb_NomeMarca
            // 
            this.txtb_NomeMarca.Location = new System.Drawing.Point(168, 202);
            this.txtb_NomeMarca.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtb_NomeMarca.Name = "txtb_NomeMarca";
            this.txtb_NomeMarca.Size = new System.Drawing.Size(317, 27);
            this.txtb_NomeMarca.TabIndex = 2;
            this.txtb_NomeMarca.TextChanged += new System.EventHandler(this.txtb_NomeMarca_TextChanged);
            // 
            // txtb_DescMarca
            // 
            this.txtb_DescMarca.Location = new System.Drawing.Point(168, 247);
            this.txtb_DescMarca.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtb_DescMarca.Multiline = true;
            this.txtb_DescMarca.Name = "txtb_DescMarca";
            this.txtb_DescMarca.Size = new System.Drawing.Size(317, 64);
            this.txtb_DescMarca.TabIndex = 3;
            this.txtb_DescMarca.TextChanged += new System.EventHandler(this.txtb_DescMarca_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(73, 159);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Código:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(73, 209);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Nome:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(73, 247);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Descrição:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Showcard Gothic", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(132, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(253, 79);
            this.label4.TabIndex = 7;
            this.label4.Text = "MARCA";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(73, 384);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(270, 195);
            this.dataGridView1.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(73, 345);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "MARCA:";
            // 
            // btn_Limpar
            // 
            this.btn_Limpar.ForeColor = System.Drawing.Color.White;
            this.btn_Limpar.Image = global::WinFormsApp1.Properties.Resources._abstract;
            this.btn_Limpar.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_Limpar.Location = new System.Drawing.Point(388, 511);
            this.btn_Limpar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_Limpar.Name = "btn_Limpar";
            this.btn_Limpar.Size = new System.Drawing.Size(97, 42);
            this.btn_Limpar.TabIndex = 10;
            this.btn_Limpar.Text = "Limpar";
            this.btn_Limpar.UseVisualStyleBackColor = true;
            this.btn_Limpar.Click += new System.EventHandler(this.btn_Limpar_Click);
            // 
            // FrmMarca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.BackgroundImage = global::WinFormsApp1.Properties.Resources._abstract;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(535, 619);
            this.Controls.Add(this.btn_Limpar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtb_DescMarca);
            this.Controls.Add(this.txtb_NomeMarca);
            this.Controls.Add(this.txtb_CodMarca);
            this.Controls.Add(this.btn_conteudoMarca);
            this.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmMarca";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmMarca";
            this.Load += new System.EventHandler(this.FrmMarca_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btn_conteudoMarca;
        private TextBox txtb_CodMarca;
        private TextBox txtb_NomeMarca;
        private TextBox txtb_DescMarca;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private DataGridView dataGridView1;
        private Label label5;
        private Button btn_Limpar;
    }
}