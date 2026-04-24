public class BoringRestaurant : Restaurant
{
    private int milesFromKansas;
    public BoringRestaurant(string name, float income, float loss, int milesFromKansas) : base(name, income, loss)
    {
        this.milesFromKansas = milesFromKansas;
    }

    public override string ExtraDetails()
    {
        return this.Name + " pretends it is " + this.milesFromKansas + " miles from Kansas.\n";
    }
}