public class RatatouilleRestaurant : Restaurant, IExtraDetailsRestaurant, IEventRestaurant
{
    private int RatAmount;

    public RatatouilleRestaurant(string name, float income, float loss, int ratAmount) : base(name, income, loss)
    {
        this.RatAmount = ratAmount;
    }

    public string ExtraDetails()
    {
        return this.Name + " has " + this.RatAmount + " rats in the kitchen.\n";
    }

    public string EventDetails()
    {
        return this.Name + " has a special event where the rats in the kitchen perform a musical number.\n";
    }
}