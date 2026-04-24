public class CrazyRide : ThemeParkRide
{
    private int crazyFactor;

    public CrazyRide(string name, float speed, int crazyFactor) : base(name, speed)
    {
        this.crazyFactor = crazyFactor;
    }

    public override string ExtraDetails()
    {
        return $"This ride has a crazy factor of {crazyFactor}. Hold on tight!";
    }
}