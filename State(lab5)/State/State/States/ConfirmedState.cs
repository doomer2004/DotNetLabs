namespace State;

public class ConfirmedState : GrantState
{
    public override void NextState()
    {
        Console.WriteLine("ConfirmedState: Transitioning to RecalledState");
        _context.TransitionTo(new RecalledState());
    }

    public override void PastState()
    {
        Console.WriteLine("ConfirmedState: Transitioning to ConsideredState");
        _context.TransitionTo(new ConsideredState());
    }
}