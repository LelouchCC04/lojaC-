namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtValorU = new System.Windows.Forms.TextBox();
            this.txtSubtotal = new System.Windows.Forms.TextBox();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.txtQuantidade = new System.Windows.Forms.TextBox();
            this.cbProduto = new System.Windows.Forms.ComboBox();
            this.cbMarca = new System.Windows.Forms.ComboBox();
            this.rbDinheiro = new System.Windows.Forms.RadioButton();
            this.rbCred = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtCred6 = new System.Windows.Forms.TextBox();
            this.txtCred10 = new System.Windows.Forms.TextBox();
            this.txtVista = new System.Windows.Forms.TextBox();
            this.txtCred3 = new System.Windows.Forms.TextBox();
            this.rbCred10 = new System.Windows.Forms.RadioButton();
            this.rbCred6 = new System.Windows.Forms.RadioButton();
            this.rbCred3 = new System.Windows.Forms.RadioButton();
            this.rbVista = new System.Windows.Forms.RadioButton();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblstripData = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblstripHora = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblNota = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(173, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "PRODUTO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(334, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "QUANTIDADE";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(173, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "SUB-TOTAL";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(334, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "TOTAL";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(12, 66);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "VALOR UNITÁRIO";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(12, 12);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 15);
            this.label6.TabIndex = 5;
            this.label6.Text = "MARCA";
            // 
            // txtValorU
            // 
            this.txtValorU.Location = new System.Drawing.Point(12, 88);
            this.txtValorU.Name = "txtValorU";
            this.txtValorU.ReadOnly = true;
            this.txtValorU.Size = new System.Drawing.Size(155, 23);
            this.txtValorU.TabIndex = 7;
            // 
            // txtSubtotal
            // 
            this.txtSubtotal.Location = new System.Drawing.Point(173, 88);
            this.txtSubtotal.Name = "txtSubtotal";
            this.txtSubtotal.ReadOnly = true;
            this.txtSubtotal.Size = new System.Drawing.Size(155, 23);
            this.txtSubtotal.TabIndex = 9;
            // 
            // txtValor
            // 
            this.txtValor.Font = new System.Drawing.Font("Showcard Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtValor.Location = new System.Drawing.Point(334, 88);
            this.txtValor.Margin = new System.Windows.Forms.Padding(30, 3, 3, 3);
            this.txtValor.Name = "txtValor";
            this.txtValor.ReadOnly = true;
            this.txtValor.Size = new System.Drawing.Size(155, 26);
            this.txtValor.TabIndex = 11;
            this.txtValor.TextChanged += new System.EventHandler(this.txtValor_TextChanged);
            // 
            // txtQuantidade
            // 
            this.txtQuantidade.Location = new System.Drawing.Point(334, 30);
            this.txtQuantidade.Name = "txtQuantidade";
            this.txtQuantidade.Size = new System.Drawing.Size(155, 23);
            this.txtQuantidade.TabIndex = 10;
            this.txtQuantidade.TextChanged += new System.EventHandler(this.txtQuantidade_TextChanged);
            // 
            // cbProduto
            // 
            this.cbProduto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbProduto.FormattingEnabled = true;
            this.cbProduto.Location = new System.Drawing.Point(173, 30);
            this.cbProduto.Name = "cbProduto";
            this.cbProduto.Size = new System.Drawing.Size(155, 23);
            this.cbProduto.TabIndex = 12;
            this.cbProduto.SelectedIndexChanged += new System.EventHandler(this.cbProduto_SelectedIndexChanged);
            // 
            // cbMarca
            // 
            this.cbMarca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMarca.FormattingEnabled = true;
            this.cbMarca.Location = new System.Drawing.Point(12, 30);
            this.cbMarca.Name = "cbMarca";
            this.cbMarca.Size = new System.Drawing.Size(155, 23);
            this.cbMarca.TabIndex = 13;
            this.cbMarca.SelectedIndexChanged += new System.EventHandler(this.cbMarca_SelectedIndexChanged);
            // 
            // rbDinheiro
            // 
            this.rbDinheiro.AutoSize = true;
            this.rbDinheiro.Location = new System.Drawing.Point(6, 25);
            this.rbDinheiro.Name = "rbDinheiro";
            this.rbDinheiro.Size = new System.Drawing.Size(105, 19);
            this.rbDinheiro.TabIndex = 15;
            this.rbDinheiro.TabStop = true;
            this.rbDinheiro.Text = "Dinheiro  (-5%)";
            this.rbDinheiro.UseVisualStyleBackColor = true;
            this.rbDinheiro.CheckedChanged += new System.EventHandler(this.rbDinheiro_CheckedChanged);
            // 
            // rbCred
            // 
            this.rbCred.AutoSize = true;
            this.rbCred.Location = new System.Drawing.Point(6, 50);
            this.rbCred.Name = "rbCred";
            this.rbCred.Size = new System.Drawing.Size(64, 19);
            this.rbCred.TabIndex = 16;
            this.rbCred.TabStop = true;
            this.rbCred.Text = "Crédito";
            this.rbCred.UseVisualStyleBackColor = true;
            this.rbCred.CheckedChanged += new System.EventHandler(this.rbCred_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.rbCred);
            this.groupBox1.Controls.Add(this.rbDinheiro);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(12, 153);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(189, 102);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "TIPO PAGAMENTO";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.txtCred6);
            this.groupBox2.Controls.Add(this.txtCred10);
            this.groupBox2.Controls.Add(this.txtVista);
            this.groupBox2.Controls.Add(this.txtCred3);
            this.groupBox2.Controls.Add(this.rbCred10);
            this.groupBox2.Controls.Add(this.rbCred6);
            this.groupBox2.Controls.Add(this.rbCred3);
            this.groupBox2.Controls.Add(this.rbVista);
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(207, 153);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(354, 102);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "PARCELAS";
            // 
            // txtCred6
            // 
            this.txtCred6.Location = new System.Drawing.Point(232, 23);
            this.txtCred6.Name = "txtCred6";
            this.txtCred6.ReadOnly = true;
            this.txtCred6.Size = new System.Drawing.Size(84, 23);
            this.txtCred6.TabIndex = 23;
            // 
            // txtCred10
            // 
            this.txtCred10.Location = new System.Drawing.Point(232, 49);
            this.txtCred10.Name = "txtCred10";
            this.txtCred10.ReadOnly = true;
            this.txtCred10.Size = new System.Drawing.Size(84, 23);
            this.txtCred10.TabIndex = 22;
            // 
            // txtVista
            // 
            this.txtVista.Location = new System.Drawing.Point(76, 22);
            this.txtVista.Name = "txtVista";
            this.txtVista.ReadOnly = true;
            this.txtVista.Size = new System.Drawing.Size(84, 23);
            this.txtVista.TabIndex = 21;
            // 
            // txtCred3
            // 
            this.txtCred3.Location = new System.Drawing.Point(76, 48);
            this.txtCred3.Name = "txtCred3";
            this.txtCred3.ReadOnly = true;
            this.txtCred3.Size = new System.Drawing.Size(84, 23);
            this.txtCred3.TabIndex = 20;
            // 
            // rbCred10
            // 
            this.rbCred10.AutoSize = true;
            this.rbCred10.Location = new System.Drawing.Point(183, 50);
            this.rbCred10.Name = "rbCred10";
            this.rbCred10.Size = new System.Drawing.Size(43, 19);
            this.rbCred10.TabIndex = 18;
            this.rbCred10.TabStop = true;
            this.rbCred10.Text = "10x";
            this.rbCred10.UseVisualStyleBackColor = true;
            this.rbCred10.CheckedChanged += new System.EventHandler(this.rbCred10_CheckedChanged);
            // 
            // rbCred6
            // 
            this.rbCred6.AutoSize = true;
            this.rbCred6.Location = new System.Drawing.Point(183, 24);
            this.rbCred6.Name = "rbCred6";
            this.rbCred6.Size = new System.Drawing.Size(37, 19);
            this.rbCred6.TabIndex = 17;
            this.rbCred6.TabStop = true;
            this.rbCred6.Text = "6x";
            this.rbCred6.UseVisualStyleBackColor = true;
            this.rbCred6.CheckedChanged += new System.EventHandler(this.rbCred6_CheckedChanged);
            // 
            // rbCred3
            // 
            this.rbCred3.AutoSize = true;
            this.rbCred3.Location = new System.Drawing.Point(7, 49);
            this.rbCred3.Name = "rbCred3";
            this.rbCred3.Size = new System.Drawing.Size(37, 19);
            this.rbCred3.TabIndex = 16;
            this.rbCred3.TabStop = true;
            this.rbCred3.Text = "3x";
            this.rbCred3.UseVisualStyleBackColor = true;
            this.rbCred3.CheckedChanged += new System.EventHandler(this.rbCred3_CheckedChanged);
            // 
            // rbVista
            // 
            this.rbVista.AutoSize = true;
            this.rbVista.Location = new System.Drawing.Point(7, 23);
            this.rbVista.Name = "rbVista";
            this.rbVista.Size = new System.Drawing.Size(60, 19);
            this.rbVista.TabIndex = 15;
            this.rbVista.TabStop = true;
            this.rbVista.Text = "A vista";
            this.rbVista.UseVisualStyleBackColor = true;
            this.rbVista.CheckedChanged += new System.EventHandler(this.rbVista_CheckedChanged);
            // 
            // btnCalcular
            // 
            this.btnCalcular.BackColor = System.Drawing.Color.Lime;
            this.btnCalcular.Location = new System.Drawing.Point(571, 153);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(75, 42);
            this.btnCalcular.TabIndex = 19;
            this.btnCalcular.Text = "CALCULAR";
            this.btnCalcular.UseVisualStyleBackColor = false;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackColor = System.Drawing.Color.Red;
            this.btnLimpar.Location = new System.Drawing.Point(571, 218);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(75, 37);
            this.btnLimpar.TabIndex = 20;
            this.btnLimpar.Text = "LIMPAR";
            this.btnLimpar.UseVisualStyleBackColor = false;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Location = new System.Drawing.Point(508, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(138, 119);
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.lblstripData,
            this.toolStripStatusLabel2,
            this.lblstripHora});
            this.statusStrip1.Location = new System.Drawing.Point(0, 625);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(658, 22);
            this.statusStrip1.TabIndex = 22;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.BackColor = System.Drawing.SystemColors.Control;
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(47, 17);
            this.toolStripStatusLabel1.Text = "Hoje é: ";
            // 
            // lblstripData
            // 
            this.lblstripData.BackColor = System.Drawing.SystemColors.Control;
            this.lblstripData.Name = "lblstripData";
            this.lblstripData.Size = new System.Drawing.Size(118, 17);
            this.lblstripData.Text = "toolStripStatusLabel2";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.BackColor = System.Drawing.SystemColors.Control;
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(46, 17);
            this.toolStripStatusLabel2.Text = "| E são: ";
            // 
            // lblstripHora
            // 
            this.lblstripHora.BackColor = System.Drawing.SystemColors.Control;
            this.lblstripHora.Name = "lblstripHora";
            this.lblstripHora.Size = new System.Drawing.Size(118, 17);
            this.lblstripHora.Text = "toolStripStatusLabel3";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblNota
            // 
            this.lblNota.BackColor = System.Drawing.Color.Transparent;
            this.lblNota.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblNota.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNota.ForeColor = System.Drawing.Color.MediumSpringGreen;
            this.lblNota.Location = new System.Drawing.Point(12, 290);
            this.lblNota.Name = "lblNota";
            this.lblNota.Size = new System.Drawing.Size(617, 322);
            this.lblNota.TabIndex = 23;
            this.lblNota.Text = "label7";
            this.lblNota.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = global::WinFormsApp1.Properties.Resources.design_neon;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(658, 647);
            this.Controls.Add(this.lblNota);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cbMarca);
            this.Controls.Add(this.cbProduto);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.txtQuantidade);
            this.Controls.Add(this.txtSubtotal);
            this.Controls.Add(this.txtValorU);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
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
        private TextBox txtValorU;
        private TextBox txtSubtotal;
        private TextBox txtValor;
        private TextBox txtQuantidade;
        private ComboBox cbProduto;
        private ComboBox cbMarca;
        private RadioButton rbDinheiro;
        private RadioButton rbCred;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private TextBox txtCred6;
        private TextBox txtCred10;
        private TextBox txtVista;
        private TextBox txtCred3;
        private RadioButton rbCred10;
        private RadioButton rbCred6;
        private RadioButton rbCred3;
        private RadioButton rbVista;
        private Button btnCalcular;
        private Button btnLimpar;
        private PictureBox pictureBox1;
        private StatusStrip statusStrip1;
        private System.Windows.Forms.Timer timer1;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private ToolStripStatusLabel lblstripData;
        private ToolStripStatusLabel toolStripStatusLabel2;
        private ToolStripStatusLabel lblstripHora;
        private Label lblNota;
    }
}