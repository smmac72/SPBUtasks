public class Call
{
    private ChatBox Chat;
    private CallArray callArray;

    private int CallID;
    private ProfileKnown Profile;
    private bool AbleToFindName = true;
    private int Units;
    private int CurrentlySentUnits;

    private int HouseX;
    private int HouseY;

    private string Report;

    public Call(int callID)
    {
        Chat = new();
        callArray = new();

        CallID = callID; 
        Profile = new(callArray.Names[CallID], callArray.Ages[CallID], callArray.Locations[CallID], callArray.Reasons[CallID]);
        AbleToFindName = callArray.AbleFindName[CallID];
        Units = callArray.RequiredUnits[CallID];
        CurrentlySentUnits = 0;

        HouseX = callArray.HouseX[CallID];
        HouseY = callArray.HouseY[CallID];

        Report = callArray.Resolve[CallID];

        Chat.AddString("[You] " + callArray.AnswerList[CallID, 0]);
        Chat.AddString(("[" + Profile.GetName() + "] ") + callArray.CallList[CallID, 0]);
    }

    public int GetCallID()
    {
        return CallID;
    }
    public ChatBox GetChat()
    {
        return Chat;
    }
    public string[,] GetCallArrayAnswer()
    {
        return callArray.AnswerList;
    }
    public string[,] GetCallArrayCall()
    {
        return callArray.CallList;
    }
    public ProfileKnown GetProfile()
    {
        return Profile;
    }
    public bool GetAbleToFindName()
    {
        return AbleToFindName;
    }
    public int GetUnits()
    {
        return Units;
    }
    public int GetSentUnits()
    {
        return CurrentlySentUnits;
    }
    public string GetReport()
    {
        return Report;
    }
    public void AddSentUnits(int value)
    {
        CurrentlySentUnits += value;
    }
}
