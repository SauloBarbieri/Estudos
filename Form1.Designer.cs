namespace _9._8_Exercícios
{
    partial class Form1
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
            this.textoTitular = new System.Windows.Forms.TextBox();
            this.textoSaldo = new System.Windows.Forms.TextBox();
            this.textoNumero = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cpfDaConta = new System.Windows.Forms.TextBox();
            this.botaoExibir = new System.Windows.Forms.Button();
            this.botaoCadastrar = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.botaoSacar = new System.Windows.Forms.Button();
            this.botaoDepositar = new System.Windows.Forms.Button();
            this.valorDigitado = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cpTextoCPF = new System.Windows.Forms.TextBox();
            this.botaoCpExibir = new System.Windows.Forms.Button();
            this.botaoCpCadastrar = new System.Windows.Forms.Button();
            this.cpTextoNumero = new System.Windows.Forms.TextBox();
            this.cpTextoSaldo = new System.Windows.Forms.TextBox();
            this.cpTextoTitular = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.botaoCpSacar = new System.Windows.Forms.Button();
            this.botaoCpDepositar = new System.Windows.Forms.Button();
            this.cpValorDigitado = new System.Windows.Forms.TextBox();
            this.botaoTotalizador = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // textoTitular
            // 
            this.textoTitular.Location = new System.Drawing.Point(78, 19);
            this.textoTitular.Name = "textoTitular";
            this.textoTitular.Size = new System.Drawing.Size(169, 20);
            this.textoTitular.TabIndex = 3;
            // 
            // textoSaldo
            // 
            this.textoSaldo.Location = new System.Drawing.Point(77, 74);
            this.textoSaldo.Name = "textoSaldo";
            this.textoSaldo.Size = new System.Drawing.Size(169, 20);
            this.textoSaldo.TabIndex = 5;
            // 
            // textoNumero
            // 
            this.textoNumero.Location = new System.Drawing.Point(77, 48);
            this.textoNumero.Name = "textoNumero";
            this.textoNumero.Size = new System.Drawing.Size(170, 20);
            this.textoNumero.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cpfDaConta);
            this.groupBox1.Controls.Add(this.botaoExibir);
            this.groupBox1.Controls.Add(this.botaoCadastrar);
            this.groupBox1.Controls.Add(this.textoNumero);
            this.groupBox1.Controls.Add(this.textoSaldo);
            this.groupBox1.Controls.Add(this.textoTitular);
            this.groupBox1.Location = new System.Drawing.Point(26, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(310, 201);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cadastrar Conta Corrente";
            // 
            // cpfDaConta
            // 
            this.cpfDaConta.Location = new System.Drawing.Point(77, 100);
            this.cpfDaConta.Name = "cpfDaConta";
            this.cpfDaConta.Size = new System.Drawing.Size(169, 20);
            this.cpfDaConta.TabIndex = 6;
            // 
            // botaoExibir
            // 
            this.botaoExibir.Location = new System.Drawing.Point(181, 154);
            this.botaoExibir.Name = "botaoExibir";
            this.botaoExibir.Size = new System.Drawing.Size(75, 23);
            this.botaoExibir.TabIndex = 8;
            this.botaoExibir.Text = "Exibir";
            this.botaoExibir.UseVisualStyleBackColor = true;
            this.botaoExibir.Click += new System.EventHandler(this.botaoExibir_Click);
            // 
            // botaoCadastrar
            // 
            this.botaoCadastrar.Location = new System.Drawing.Point(64, 154);
            this.botaoCadastrar.Name = "botaoCadastrar";
            this.botaoCadastrar.Size = new System.Drawing.Size(75, 23);
            this.botaoCadastrar.TabIndex = 7;
            this.botaoCadastrar.Text = "Cadastrar";
            this.botaoCadastrar.UseVisualStyleBackColor = true;
            this.botaoCadastrar.Click += new System.EventHandler(this.botaoCadastrar_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.botaoSacar);
            this.groupBox2.Controls.Add(this.botaoDepositar);
            this.groupBox2.Controls.Add(this.valorDigitado);
            this.groupBox2.Location = new System.Drawing.Point(381, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(228, 200);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Operação Sacar e Depositar CC";
            // 
            // botaoSacar
            // 
            this.botaoSacar.Location = new System.Drawing.Point(126, 90);
            this.botaoSacar.Name = "botaoSacar";
            this.botaoSacar.Size = new System.Drawing.Size(75, 23);
            this.botaoSacar.TabIndex = 2;
            this.botaoSacar.Text = "Sacar";
            this.botaoSacar.UseVisualStyleBackColor = true;
            this.botaoSacar.Click += new System.EventHandler(this.botaoSacar_Click);
            // 
            // botaoDepositar
            // 
            this.botaoDepositar.Location = new System.Drawing.Point(12, 90);
            this.botaoDepositar.Name = "botaoDepositar";
            this.botaoDepositar.Size = new System.Drawing.Size(75, 23);
            this.botaoDepositar.TabIndex = 1;
            this.botaoDepositar.Text = "Depositar";
            this.botaoDepositar.UseVisualStyleBackColor = true;
            this.botaoDepositar.Click += new System.EventHandler(this.botaoDepositar_Click);
            // 
            // valorDigitado
            // 
            this.valorDigitado.Location = new System.Drawing.Point(40, 47);
            this.valorDigitado.Name = "valorDigitado";
            this.valorDigitado.Size = new System.Drawing.Size(136, 20);
            this.valorDigitado.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cpTextoCPF);
            this.groupBox3.Controls.Add(this.botaoCpExibir);
            this.groupBox3.Controls.Add(this.botaoCpCadastrar);
            this.groupBox3.Controls.Add(this.cpTextoNumero);
            this.groupBox3.Controls.Add(this.cpTextoSaldo);
            this.groupBox3.Controls.Add(this.cpTextoTitular);
            this.groupBox3.Location = new System.Drawing.Point(26, 264);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(310, 201);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Cadastrar Conta Poupanca";
            // 
            // cpTextoCPF
            // 
            this.cpTextoCPF.Location = new System.Drawing.Point(77, 100);
            this.cpTextoCPF.Name = "cpTextoCPF";
            this.cpTextoCPF.Size = new System.Drawing.Size(169, 20);
            this.cpTextoCPF.TabIndex = 6;
            // 
            // botaoCpExibir
            // 
            this.botaoCpExibir.Location = new System.Drawing.Point(181, 154);
            this.botaoCpExibir.Name = "botaoCpExibir";
            this.botaoCpExibir.Size = new System.Drawing.Size(75, 23);
            this.botaoCpExibir.TabIndex = 8;
            this.botaoCpExibir.Text = "Exibir";
            this.botaoCpExibir.UseVisualStyleBackColor = true;
            this.botaoCpExibir.Click += new System.EventHandler(this.botaoCpExibir_Click);
            // 
            // botaoCpCadastrar
            // 
            this.botaoCpCadastrar.Location = new System.Drawing.Point(64, 154);
            this.botaoCpCadastrar.Name = "botaoCpCadastrar";
            this.botaoCpCadastrar.Size = new System.Drawing.Size(75, 23);
            this.botaoCpCadastrar.TabIndex = 7;
            this.botaoCpCadastrar.Text = "Cadastrar";
            this.botaoCpCadastrar.UseVisualStyleBackColor = true;
            this.botaoCpCadastrar.Click += new System.EventHandler(this.botaoCpCadastrar_Click);
            // 
            // cpTextoNumero
            // 
            this.cpTextoNumero.Location = new System.Drawing.Point(77, 48);
            this.cpTextoNumero.Name = "cpTextoNumero";
            this.cpTextoNumero.Size = new System.Drawing.Size(170, 20);
            this.cpTextoNumero.TabIndex = 4;
            // 
            // cpTextoSaldo
            // 
            this.cpTextoSaldo.Location = new System.Drawing.Point(77, 74);
            this.cpTextoSaldo.Name = "cpTextoSaldo";
            this.cpTextoSaldo.Size = new System.Drawing.Size(169, 20);
            this.cpTextoSaldo.TabIndex = 5;
            // 
            // cpTextoTitular
            // 
            this.cpTextoTitular.Location = new System.Drawing.Point(78, 19);
            this.cpTextoTitular.Name = "cpTextoTitular";
            this.cpTextoTitular.Size = new System.Drawing.Size(169, 20);
            this.cpTextoTitular.TabIndex = 3;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.botaoCpSacar);
            this.groupBox4.Controls.Add(this.botaoCpDepositar);
            this.groupBox4.Controls.Add(this.cpValorDigitado);
            this.groupBox4.Location = new System.Drawing.Point(381, 265);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(228, 200);
            this.groupBox4.TabIndex = 8;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Operação Sacar e Depositar CP";
            // 
            // botaoCpSacar
            // 
            this.botaoCpSacar.Location = new System.Drawing.Point(126, 90);
            this.botaoCpSacar.Name = "botaoCpSacar";
            this.botaoCpSacar.Size = new System.Drawing.Size(75, 23);
            this.botaoCpSacar.TabIndex = 2;
            this.botaoCpSacar.Text = "Sacar";
            this.botaoCpSacar.UseVisualStyleBackColor = true;
            this.botaoCpSacar.Click += new System.EventHandler(this.botaoCpSacar_Click);
            // 
            // botaoCpDepositar
            // 
            this.botaoCpDepositar.Location = new System.Drawing.Point(12, 90);
            this.botaoCpDepositar.Name = "botaoCpDepositar";
            this.botaoCpDepositar.Size = new System.Drawing.Size(75, 23);
            this.botaoCpDepositar.TabIndex = 1;
            this.botaoCpDepositar.Text = "Depositar";
            this.botaoCpDepositar.UseVisualStyleBackColor = true;
            this.botaoCpDepositar.Click += new System.EventHandler(this.botaoCpDepositar_Click);
            // 
            // cpValorDigitado
            // 
            this.cpValorDigitado.Location = new System.Drawing.Point(40, 47);
            this.cpValorDigitado.Name = "cpValorDigitado";
            this.cpValorDigitado.Size = new System.Drawing.Size(136, 20);
            this.cpValorDigitado.TabIndex = 0;
            // 
            // botaoTotalizador
            // 
            this.botaoTotalizador.Location = new System.Drawing.Point(507, 503);
            this.botaoTotalizador.Name = "botaoTotalizador";
            this.botaoTotalizador.Size = new System.Drawing.Size(75, 23);
            this.botaoTotalizador.TabIndex = 10;
            this.botaoTotalizador.Text = "Total";
            this.botaoTotalizador.UseVisualStyleBackColor = true;
            this.botaoTotalizador.Click += new System.EventHandler(this.botaoTotalizador_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(748, 554);
            this.Controls.Add(this.botaoTotalizador);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox textoTitular;
        private System.Windows.Forms.TextBox textoSaldo;
        private System.Windows.Forms.TextBox textoNumero;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button botaoExibir;
        private System.Windows.Forms.Button botaoCadastrar;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox valorDigitado;
        private System.Windows.Forms.Button botaoSacar;
        private System.Windows.Forms.Button botaoDepositar;
        private System.Windows.Forms.TextBox cpfDaConta;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox cpTextoCPF;
        private System.Windows.Forms.Button botaoCpExibir;
        private System.Windows.Forms.Button botaoCpCadastrar;
        private System.Windows.Forms.TextBox cpTextoNumero;
        private System.Windows.Forms.TextBox cpTextoSaldo;
        private System.Windows.Forms.TextBox cpTextoTitular;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button botaoCpSacar;
        private System.Windows.Forms.Button botaoCpDepositar;
        private System.Windows.Forms.TextBox cpValorDigitado;
        private System.Windows.Forms.Button botaoTotalizador;
    }
}

