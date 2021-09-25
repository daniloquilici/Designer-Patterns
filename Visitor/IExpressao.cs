namespace Visitor
{
    public interface IExpressao
    {
        int Avalia();

        void Aceita(IVisitor visitor);
        void Aceita2(IVisitor visitor);
    }
}
