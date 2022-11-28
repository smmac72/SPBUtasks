public class ChatBox
{
    const int MAXLEN = 10;
    List<String> messages;

    public ChatBox()
    {
        messages = new List<string>();
    }
    public void AddString(string str)
    {
        if (messages.Count > MAXLEN)
            messages.RemoveAt(0);
        if (str != null)
            messages.Add(str);
    }
    public List<string> GetChat()
    {
        return messages;
    }
}