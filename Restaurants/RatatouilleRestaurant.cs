public class RatatouilleRestaurant : Restaurant
{
    private int ratAmount;

    public RatatouilleRestaurant(string name, float income, float loss, int ratAmount) : base(name, income, loss)
    {
        this.ratAmount = ratAmount;
    }

    public override string ExtraDetails()
    {
        return this.Name + " has " + this.ratAmount + " rats in the kitchen.\n";
    }
}