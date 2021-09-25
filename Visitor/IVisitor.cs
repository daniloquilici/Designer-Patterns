namespace Visitor
{
    public interface IVisitor
    {
        void ImprimeSoma(Soma soma);
        void ImprimeSoma2(Soma soma);
        void ImprimeSubtracao(Subtracao subtracao);
        void ImprimeSubtracao2(Subtracao subtracao);
        void ImprimeNumero(Numero numero);
    }
}
