public class CallCreator
{
    public Call InitiateCall(int CallID = -1)
    {
        Call? NewCall = null;
        if (CallID == -1)
        {
            Random rng = new();
            NewCall = new(rng.Next(0,15));
        }
        else
            NewCall = new(CallID);
        Console.Beep();
        return NewCall;
    }
}