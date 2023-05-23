namespace State;

public class RecalledState : GrantState
{
    
    public override void NextState()
    {
        Console.WriteLine("RecalledState: Transitioning to UnderReviewState");
        _context.TransitionTo(new UnderReviewState());
    }

    public override void PastState()
    {
        Console.WriteLine("Grant deleted");
    }
}