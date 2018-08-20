namespace _9._8_Exercícios
{
    public class TotalizadorDeContas
    {
        public  double ValorTotal { get; private set; }

        public void Soma(Conta conta)
        {
            ValorTotal += conta.SaldoDaConta;
            
        }
    }
}