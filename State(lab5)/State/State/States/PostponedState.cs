namespace State;

public class PostponedState : GrantState
{
    public override void NextState()
    {
        Console.WriteLine("PostponedState: Transitioning to UnderReviewState");
        _context.TransitionTo(new UnderReviewState());
    }

    public override void PastState()
    {
        Console.WriteLine("PostponedState: Transitioning to ConsideredState");
        _context.TransitionTo(new ConsideredState());
    }
}