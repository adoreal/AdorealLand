public class OfficeSpaceRide(string name, long speed, string specialFeature) : ThemeParkRide(name, speed)
{
    private string _specialFeature = specialFeature;

    public override string ExtraDetails()
    {        
        return $"Look for the precious Red Stappler! Special feature: {_specialFeature}\n";
    }
}