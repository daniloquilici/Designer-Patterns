namespace DesignPatterns.Investimento
{
    public class Conservador : IInvestidor
    {
        public double Investir(Conta conta)
        {
            return conta.Saldo * 0.008;
        }
    }
}
