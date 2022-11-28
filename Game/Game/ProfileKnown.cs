public class ProfileKnown : Profile
{
    private bool NameKnown;
    private bool AgeKnown;
    private bool LocationKnown;
    private bool ReasonKnown;
    public ProfileKnown(string name, string age, string location, string reason)
    {
        Name = name;
        Age = age;
        Location = location;
        Reason = reason;

        NameKnown = false;
        AgeKnown = true;
        LocationKnown = false;
        ReasonKnown = false;
    }
    public string GetName()
    {
        if (!NameKnown)
            return "Unknown";
        return Name;
    }
    public string GetAge()
    {
        if (!AgeKnown)
            return "Unknown";
        return Age;
    }
    public string GetLocation()
    {
        if (!LocationKnown)
            return "Unknown";
        return Location;
    }
    public string GetReason()
    {
        if (!ReasonKnown)
            return "Unknown";
        return Reason;
    }
    public bool GetNameKnown()
    {
        return NameKnown;
    }
    public bool GetAgeKnown()
    {
        return AgeKnown;
    }
    public bool GetLocationKnown()
    {
        return LocationKnown;
    }
    public bool GetReasonKnown()
    {
        return ReasonKnown;
    }
    public void SetNameKnown()
    {
        NameKnown = true;
    }
    public void SetAgeKnown()
    {
        AgeKnown = true;
    }
    public void SetLocationKnown()
    {
        LocationKnown = true;
    }
    public void SetReasonKnown()
    {
        ReasonKnown = true;
    }
}
