public class DeathRestaurant : Restaurant
{
    private int zombiesCount;

    public DeathRestaurant(string name, float income, float loss, int zombiesCount) : base(name, income, loss)
    {
        this.zombiesCount = zombiesCount;
    }

    public override string ExtraDetails()
    {
        return this.Name + " have " + zombiesCount + "waiting for you";
    }
}