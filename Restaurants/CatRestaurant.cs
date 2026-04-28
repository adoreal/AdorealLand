public class CatRestaurant : Restaurant
{
    private int cats;
    public CatRestaurant(string name, float income, float loss, int cats) : base(name, income, loss)
    {
        this.cats = cats;
    }

    public override string ExtraDetails()
    {
        return this.Name + " has " + this.cats + " waiter cats ready to serve you. Don't forget to tip them!\n";
    }
}