using System;
using System.Windows.Forms;

namespace _9._8_Exercícios
{
    public class Conta
    {
        public string NomeDaConta { get; private set; }
        public double SaldoDaConta { get; private set; }
        public double NumeroDaConta { get; private set; }
        public string CpfDaConta { get; private set; }

        public virtual bool Cadastrar(string nomeDaConta, double numeroDaConta, double saldoDaConta, string cpfDaConta)
        {
            this.NomeDaConta = nomeDaConta;
            this.SaldoDaConta = saldoDaConta;
            this.NumeroDaConta = numeroDaConta;
            
            if (!String.IsNullOrEmpty(this.CpfDaConta = cpfDaConta))
            {
                return true;
            }
            return false;
        }

        public virtual void Depositar(double valorOperacao)
        {
                       
                this.SaldoDaConta += valorOperacao;            
        }

        public virtual bool Sacar(double valorOperacao)
        {
            if (this.NumeroDaConta !=0 && this.SaldoDaConta >= valorOperacao)
            {
                this.SaldoDaConta -= valorOperacao;
                return true;
            }
            return false;
        }

       
    }
}