namespace State;

public class ConsideredState : GrantState
{
    public override void NextState()
    {
        Console.WriteLine("ConsideredState: Transitioning to UnderReviewState");
        _context.TransitionTo(new UnderReviewState());
    }

    public override void PastState()
    {
        Console.WriteLine("ConsideredState: Transitioning to ConsideredState");
        _context.TransitionTo(new ConsideredState());
    }
}