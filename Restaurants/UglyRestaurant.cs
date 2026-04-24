public class UglyRestaurant : Restaurant
{
    private string ugliness;
    public UglyRestaurant(string name, float income, float loss, string ugliness) : base(name, income, loss)
    {
        this.ugliness = ugliness;
    }

    public override string ExtraDetails()
    {
        return this.Name + " is ugly as hell\n";
    }
}