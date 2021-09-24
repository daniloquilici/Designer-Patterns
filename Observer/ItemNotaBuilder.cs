namespace Observer
{
    public class ItemNotaBuilder
    {
        public string Nome { get; private set; }
        public double Valor { get; private set; }

        public ItemNotaBuilder AddNome(string nome) 
        {
            this.Nome = nome;
            return this;
        }

        public ItemNotaBuilder AddValor(double valor) 
        {
            this.Valor = valor;
            return this;
        }

        public ItemNota Builder() 
        {
            return new ItemNota(this.Nome, this.Valor);
        }
    }
}
