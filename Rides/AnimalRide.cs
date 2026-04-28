public class AnimalRide : ThemeParkRide
{
    private int animalCount;

    public AnimalRide(string name, float speed, int animalCount = 0) : base(name, speed)
    {
        this.animalCount = animalCount;
    }

    public override string ExtraDetails()
    {
        return $"This ride has {animalCount} animals. Don't feed the animals!";
    }
}