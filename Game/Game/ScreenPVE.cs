public class ScreenPVE : ScreenCore
{
    CallCreator InternalCallCreator = new CallCreator();
    bool InternalCallChange = false;
    override public void ScreenUpdate(string[] Field, Call CurrentCall, int CurrentTime)
    {
        // kostyl потому что я вспомнил про трединг через 12 часов работы. ладно смирился уже
        if (CurrentCall != null)
        {
            if (InternalCallChange)
            {
                Console.WriteLine("[Report] You will never know what happened there. You just dropped a 9/11 call dude");
                Console.WriteLine("[Report] Press any key to take on the next call. You won't leave like that");
                InternalCallChange = false;
                Console.ReadKey();
                CurrentCall = InternalCallCreator.InitiateCall();
            }
            if (CurrentCall.GetUnits() == CurrentCall.GetSentUnits())
            {
                Console.WriteLine("[Report] " + CurrentCall.GetReport());
                Console.WriteLine("[Report] Press any key to take on the next call");
                Console.ReadKey();
                CurrentCall = InternalCallCreator.InitiateCall();
            }
            Console.Clear();
            PrintUI(Field, CurrentCall, CurrentTime);
            PrintChat(CurrentCall);
        }
        base.ScreenUpdate(Field, CurrentCall, CurrentTime);
        ScreenUpdate(Field, CurrentCall, CurrentTime);
    }
    void PrintChat(Call CurrentCall)
    {
        ChatBox CurrentChat = CurrentCall.GetChat();
        // prints lower ui
        if (CurrentChat != null)
        {
            // print hints
            Console.WriteLine("Hint: NAME - Get Name | LOC - Get Location via dialogue | SIT - Get Situation");
            Console.WriteLine("POLICE - Send Police Unit | EMS - Send Medic Unit | FIRE - Send Fire Unit");
            Console.WriteLine("END - End this phonecall. It's ok to feel uncomfortable. These are real training situations");

            // read next instruction
            ProcessInput(CurrentCall, CurrentChat);
        }
    }
    bool IsAcceptableAnswer(string answer)
    {
        if (answer == null)
            return false;
        string[] AcceptableAnswers = {
            "NAME", "LOC", "SIT",
            "POLICE", "EMS", "FIRE", "END" };
        foreach (string ans in AcceptableAnswers)
            if (ans.Equals(answer))
                return true;
        return false;
    }
    void ProcessInput(Call CurrentCall, ChatBox CurrentChat)
    {
        int ConsoleLeft, ConsoleTop;
        string InputCommand = "";
        Console.Write("Input your action: ");
        ConsoleLeft = Console.GetCursorPosition().Left;
        ConsoleTop = Console.GetCursorPosition().Top;
        Console.Write("\n");
        List<string> Messages = CurrentChat.GetChat();
        foreach (string message in Messages)
            Console.WriteLine(message);
        Console.SetCursorPosition(ConsoleLeft, ConsoleTop);

        InputCommand = Console.ReadLine();
        if (IsAcceptableAnswer(InputCommand))
        {

            int CurrentCallID = CurrentCall.GetCallID();
            int ReqUnits = CurrentCall.GetUnits();
            ProfileKnown Profile = CurrentCall.GetProfile();
            switch (InputCommand)
            {
                case "NAME":
                    if (Profile.GetNameKnown())
                        CurrentChat.AddString("[You] I already know the name");
                    else
                    {
                        CurrentChat.AddString("[You] " + CurrentCall.GetCallArrayAnswer()[CurrentCallID, 1]);
                        CurrentChat.AddString(("[" + Profile.GetName() + "] ") + CurrentCall.GetCallArrayCall()[CurrentCallID, 1]);
                        if (CurrentCall.GetAbleToFindName())
                            Profile.SetNameKnown();
                    }
                    break;
                case "LOC":
                    if (Profile.GetLocationKnown())
                        CurrentChat.AddString("[You] I already know the location");
                    else
                    {
                        CurrentChat.AddString("[You] " + CurrentCall.GetCallArrayAnswer()[CurrentCallID, 2]);
                        CurrentChat.AddString(("[" + Profile.GetName() + "] ") + CurrentCall.GetCallArrayCall()[CurrentCallID, 2]);
                        Profile.SetLocationKnown();
                    }
                    break;
                case "SIT":
                    if (Profile.GetReasonKnown())
                        CurrentChat.AddString("[You] I already know the situation");
                    else
                    {
                        CurrentChat.AddString("[You] " + CurrentCall.GetCallArrayAnswer()[CurrentCallID, 3]);
                        CurrentChat.AddString(("[" + Profile.GetName() + "] ") + CurrentCall.GetCallArrayCall()[CurrentCallID, 3]);
                        Profile.SetReasonKnown();
                    }
                    break;
                case "POLICE":
                    if (Profile.GetLocationKnown() == false)
                        CurrentChat.AddString("[You] I don't know the location yet...");
                    else
                    {
                        if (ReqUnits / 100 == 1)
                        {
                            if (CurrentCall.GetSentUnits() / 100 != 1)
                            {
                                CurrentChat.AddString("[You] " + CurrentCall.GetCallArrayAnswer()[CurrentCallID, 4]);
                                CurrentChat.AddString(("[" + Profile.GetName() + "] ") + CurrentCall.GetCallArrayCall()[CurrentCallID, 4]);
                                CurrentCall.AddSentUnits(100);
                            }
                            else
                                CurrentChat.AddString("[You] Police is already on its way");
                        }
                        else
                            CurrentChat.AddString("[You] I don't need police here");
                    }
                    break;
                case "EMS":
                    if (Profile.GetLocationKnown() == false)
                        CurrentChat.AddString("[You] I don't know the location yet...");
                    else
                    {
                        if (ReqUnits / 10 % 10 == 1)
                        {
                            if (CurrentCall.GetSentUnits() / 10 % 10 != 1)
                            {
                                CurrentChat.AddString("[You] " + CurrentCall.GetCallArrayAnswer()[CurrentCallID, 5]);
                                CurrentChat.AddString(("[" + Profile.GetName() + "] ") + CurrentCall.GetCallArrayCall()[CurrentCallID, 5]);
                                CurrentCall.AddSentUnits(10);
                            }
                            else
                                CurrentChat.AddString("[You] Medic team is already on its way");
                        }
                        else
                            CurrentChat.AddString("[You] I don't need medics here");
                    }
                    break;
                case "FIRE":
                    if (Profile.GetLocationKnown() == false)
                        CurrentChat.AddString("[You] I don't know the location yet...");
                    else
                    {
                        if (ReqUnits % 10 == 1)
                        {
                            if (CurrentCall.GetSentUnits() / 100 != 1)
                            {
                                CurrentChat.AddString("[You] " + CurrentCall.GetCallArrayAnswer()[CurrentCallID, 6]);
                                CurrentChat.AddString(("[" + Profile.GetName() + "] ") + CurrentCall.GetCallArrayCall()[CurrentCallID, 6]);
                                CurrentCall.AddSentUnits(1);
                            }
                            else
                                CurrentChat.AddString("[You] Fire brigade is already on its way");
                        }
                        else
                            CurrentChat.AddString("[You] I don't need fire crew here");
                    }
                    break;
                case "END":
                    InternalCallChange = true;
                    break;

            }
        }
    }
}
