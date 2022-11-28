public class GamePVP : GameCore
{
    ScreenPVP? CurrentScreen = null;
    public GamePVP()
    {
        CurrentScreen = new();
        VisualHandlerStart();
    }
    void VisualHandlerStart()
    {
        CurrentScreen.ScreenUpdate(Field, CurrentCall, CurrentTime);
    }

}
