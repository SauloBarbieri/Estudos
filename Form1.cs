using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _9._8_Exercícios
{
    public partial class Form1 : Form
    {
        Conta contaCorrente01 = new Conta();
        ContaPoupanca contaPoupanca01 = new ContaPoupanca();
        TotalizadorDeContas totalizador = new TotalizadorDeContas();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //contaVictor.NomeDaConta = textoTitular.Text;
            //contaVictor.SaldoDaConta = Convert.ToDouble(textoSaldo.Text);
            //contaVictor.NumeroDaConta = Convert.ToDouble(textoNumero.Text);

            textoTitular.Text = ("Digite o nome do Titular");
            textoSaldo.Text = ("Digite o saldo da Conta");
            textoNumero.Text = ("Digite o Número da Conta");
            cpfDaConta.Text = ("Digite o CPF");
            valorDigitado.Text = ("Digite o Valor da Operação");

            cpTextoTitular.Text = ("Digite o nome do Titular");
            cpTextoSaldo.Text = ("Digite o saldo da Conta");
            cpTextoNumero.Text = ("Digite o Número da Conta");
            cpTextoCPF.Text = ("Digite o CPF");
            cpValorDigitado.Text = ("Digite o Valor da Operação");
        }

        private void botaoCadastrar_Click(object sender, EventArgs e)
        {
            string mensagem = contaCorrente01.Cadastrar(
                Convert.ToString(textoTitular.Text),
                Convert.ToDouble(textoNumero.Text),
                Convert.ToDouble(textoSaldo.Text),
                Convert.ToString(cpfDaConta.Text)) 
                ? "Cadastro Realizado Com Sucesso" : "Necessário Cadastrar CPF";
            MessageBox.Show(mensagem);
        }

        private void botaoExibir_Click(object sender, EventArgs e)
        {

            MessageBox.Show("Nome da Conta: " +contaCorrente01.NomeDaConta);
            MessageBox.Show("Número da Conta: " + contaCorrente01.NumeroDaConta);
            MessageBox.Show("Saldo da Conta: R$ "+ contaCorrente01.SaldoDaConta);
            MessageBox.Show("CPF da Conta: "+contaCorrente01.CpfDaConta);
        }

        private void botaoDepositar_Click(object sender, EventArgs e)
        {

            //string mensage = contaCorrente01.Depositar(Convert.ToDouble(valorDigitado.Text)) 
            //    ? "Depósito Realizado Com Sucesso!" : "Nenhuma conta foi Cadastrada!";
            //MessageBox.Show(mensage);

            if (contaCorrente01.NumeroDaConta != 0)
            {
                contaCorrente01.Depositar(Convert.ToDouble(valorDigitado.Text));
                MessageBox.Show("Depósito Realizado Com Sucesso!");
            }
            else
            {
                MessageBox.Show("Nenhuma conta foi Cadastrada!");
            }
            

        }

        private void botaoCpDepositar_Click(object sender, EventArgs e)
        {

            //string mensage = contaPoupanca01.Depositar(Convert.ToDouble(valorDigitado.Text))
            //    ? "Depósito Realizado Com Sucesso!" : "Nenhuma conta foi Cadastrada!";
            //MessageBox.Show(mensage);

            if (contaPoupanca01.NumeroDaConta != 0)
            {
                contaPoupanca01.Depositar(Convert.ToDouble(cpValorDigitado.Text));
                MessageBox.Show("Depósito Realizado Com Sucesso!");
            }
            else
            {
                MessageBox.Show("Nenhuma conta foi Cadastrada!");
            }

        }

        private void botaoSacar_Click(object sender, EventArgs e)
        {
            string ccmensagem = contaCorrente01.Sacar(Convert.ToDouble(valorDigitado.Text)) 
                ? "Saque Realizado Com Sucesso!" : "Essa Transação não é possível";
            MessageBox.Show(ccmensagem);

        }

        private void botaoCpSacar_Click(object sender, EventArgs e)
        {
            string cpmensagem = contaPoupanca01.Sacar(Convert.ToDouble(cpValorDigitado.Text))
                ? "Saque Realizado Com Sucesso!" : "Essa Transação não é possível";
            MessageBox.Show(cpmensagem);
        }


        private void botaoCpCadastrar_Click(object sender, EventArgs e)
        {
            string mensagem = contaPoupanca01.Cadastrar(
                Convert.ToString(cpTextoTitular.Text),
                Convert.ToDouble(cpTextoNumero.Text),
                Convert.ToDouble(cpTextoSaldo.Text),
                Convert.ToString(cpTextoCPF.Text))
                ? "Cadastro Realizado Com Sucesso" : "Necessário Cadastrar CPF";
            MessageBox.Show(mensagem);
        }

        private void botaoCpExibir_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Nome da Conta Poupança: " + contaPoupanca01.NomeDaConta);
            MessageBox.Show("Número da Conta Poupança: " + contaPoupanca01.NumeroDaConta);
            MessageBox.Show("Saldo da Conta Poupança: R$ " + contaPoupanca01.SaldoDaConta);
            MessageBox.Show("CPF da Conta Poupança: " + contaPoupanca01.CpfDaConta);
        }

        private void botaoTotalizador_Click(object sender, EventArgs e)
        {
            totalizador.Soma(contaCorrente01);
            totalizador.Soma(contaPoupanca01);

            MessageBox.Show("Saldo Total das Contas: R$ " + totalizador.ValorTotal);
        }
    }
}
