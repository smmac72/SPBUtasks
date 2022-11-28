public class GamePVE : GameCore
{
    ScreenPVE? CurrentScreen = null;
    public GamePVE()
    {
        CurrentScreen = new();
        VisualHandlerStart();
    }
    void VisualHandlerStart()
    {
        CurrentScreen.ScreenUpdate(Field, CurrentCall, CurrentTime);
    }
   
}
