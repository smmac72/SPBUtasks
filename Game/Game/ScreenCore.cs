public class ScreenCore
{
    virtual public void ScreenUpdate(string[] Field, Call CurrentCall, int CurrentTime)
    {
        // updates screen
        Console.Clear();
        PrintUI(Field, CurrentCall, CurrentTime);
    }
    public void PrintUI(string[] Field, Call CurrentCall, int CurrentTime)
    {
        ProfileKnown? CurrentCallerProfile = null;
        if (CurrentCall != null)
            CurrentCallerProfile = CurrentCall.GetProfile();

        // prints upper ui (map and person profile)
        for (int i = 0; i < 16; i++)
        {
            if (i == 0)
            {
                Console.WriteLine(Field[i]);
                //Console.Write(" Current time: {0}:{1}\n", CurrentTime / 60, ((CurrentTime % 60 < 10) ? '0' + (CurrentTime % 60).ToString() : CurrentTime % 60));
            }
            else if (i < 6 && CurrentCallerProfile != null) // stuff on the right side
            {
                Console.Write(Field[i]);
                switch (i)
                {
                    case 1:
                        Console.Write(" Caller profile\n");
                        break;
                    case 2:
                        Console.Write(" Name: {0}\n", CurrentCallerProfile.GetName());
                        break;
                    case 3:
                        Console.Write(" Age: {0}\n", CurrentCallerProfile.GetAge());
                        break;
                    case 4:
                        Console.Write(" Location: {0}\n", CurrentCallerProfile.GetLocation());
                        break;
                    case 5:
                        Console.Write(" Reason: {0}\n", CurrentCallerProfile.GetReason());
                        break;
                }
            }
            else
                Console.WriteLine(Field[i]);
        }
    }
}
