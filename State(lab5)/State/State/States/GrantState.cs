namespace State;

public abstract class GrantState
{
    protected Context _context;

    public void SetContext(Context context)
    {
        _context = context; ;
    }
    
    public abstract void NextState();

    public abstract void PastState();
}