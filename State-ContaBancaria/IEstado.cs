namespace State_ContaBancaria
{
    public interface IEstado
    {
        void Depositar(Conta conta, double valor);
        void Sacar(Conta conta, double valor);
        void Positivar(Conta conta);
        void Negativar(Conta conta);
    }
}
