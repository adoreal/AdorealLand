public class GauchoRestaurant(string name, float income, float loss) : Restaurant(name, income, loss)
{
    public override string ExtraDetails()
    {
        return "This restaurant serves delicious meat and is inspired by the gauchos of South America.\n";
    }
}