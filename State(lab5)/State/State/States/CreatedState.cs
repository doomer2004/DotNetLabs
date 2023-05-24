namespace State;

public class CreatedState : GrantState
{
    public override void NextState()
    {
        Console.WriteLine("CreatedState: Transitioning to UnderReviewState");
        _context.TransitionTo(new UnderReviewState());
    }

    public override void PastState()
    {
        Console.WriteLine("CreatedState: Transitioning to ConsideredState");
        _context.TransitionTo(new ConsideredState());
    }
}
