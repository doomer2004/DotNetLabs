namespace State;

public class Context
{
    private GrantState _currentState = null;

    public Context(GrantState grantState)
    {
        TransitionTo(grantState);
    }

    public void TransitionTo(GrantState grantState)
    {
        Console.WriteLine($"Context: Transition to {grantState.GetType().Name}.");
        _currentState = grantState;
    }

    public void Request1()
    {
        _currentState.NextState();
    }

    public void Request2()
    {
        _currentState.PastState();
    }
}