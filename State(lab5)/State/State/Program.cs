using State;

class Program
{
    static void Main(string[] args)
    {
        string q = null;
        int a;
        Context grant = new Context(new CreatedState());
        grant.Request1();
        grant.Request1();
        grant.Request1();
    }
}