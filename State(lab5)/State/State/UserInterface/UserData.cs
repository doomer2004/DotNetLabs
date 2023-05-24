namespace State.UserInterface;

public class UserData
{
    public readonly List<Context> Contexts = new List<Context>();
    public void GrantInitializer()
    {
        Context grantDanyilHizhutskyi = new Context(new CreatedState(), "Danyil Hizhutskyi");
        Context grantJaneSmith = new Context(new CreatedState(), "Jane Smith");
        Context grantJohnDoe = new Context(new CreatedState(), "John Doe");
        Context grantAliceJohnson = new Context(new CreatedState(), "Alice Johnson");
        Context grantBobWilliams = new Context(new CreatedState(), "Bob Williams");
        Context grantEmilyBrown = new Context(new CreatedState(), "Emily Brown");
        Contexts.AddRange(new List<Context>()
        {
            grantDanyilHizhutskyi,
            grantJaneSmith,
            grantJohnDoe,
            grantAliceJohnson,
            grantBobWilliams,
            grantEmilyBrown
        });
    }
}