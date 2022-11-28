public class GameCore
{
    public CallCreator? CallCreator = null;
    public Call? CurrentCall = null;

    public int CurrentTime = 480;
    public TimerCallback TimeCallback;
    public Timer TimeUpdateTimer;

    public string[]? Field = null;
    public GameCore()
    {
        Map GameMap = new(); // create city map
        if (GameMap != null)
        {
            if (Field == null) // extract field from city map
                Field = GameMap.GetField();
        }

        TimeCallback = new TimerCallback(TimeUpdate);
        TimeUpdateTimer = new Timer(TimeCallback, null, 0, 1000);

        CreateCall();
    }
    public void CreateCall()
    {
        if (CurrentCall == null)
        {
            if (CallCreator == null)
                CallCreator = new CallCreator();
            CurrentCall = CallCreator.InitiateCall();
        }
    }
    void TimeUpdate(object? o)
    {
        CurrentTime += 1;
    }
}