namespace _9._8_Exercícios
{
    public class ContaPoupanca : Conta
    {
        public override bool Cadastrar(string nomeDaConta, double numeroDaConta, double saldoDaConta, string cpfDaConta)
        {
            base.Cadastrar(nomeDaConta, numeroDaConta, saldoDaConta, cpfDaConta);
            return true;
        }

        public override void Depositar(double valorOperacao)
        {

            base.Depositar(valorOperacao);

         }

        
        public override bool Sacar(double valorOperacao)
        {
            base.Sacar(valorOperacao + 0.10);
            return true;
        }

       
    }
}