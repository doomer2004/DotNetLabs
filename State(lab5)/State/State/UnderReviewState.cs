namespace State;

public class UnderReviewState : GrantState
{
    public override void NextState()
    {
        Console.WriteLine("UnderReviewState: Transitioning to ConfirmedState");
        _context.TransitionTo(new ConfirmedState());
    }

    public override void PastState()
    {
        Console.WriteLine("UnderReviewState: Transitioning to ConsideredState");
        _context.TransitionTo(new ConsideredState());
    }
}