public class FalloutRestaurant : Restaurant
{
    private int numberOfBunker;
    public FalloutRestaurant(string name, float income, float loss, int numberOfBunker) : base(name, income, loss)
    {
        this.numberOfBunker = numberOfBunker;
    }

    public override string ExtraDetails()
    {
        return this.Name + " pretends it is the bunker number" + this.numberOfBunker + " of the vault-tec corporation.";
    }
}