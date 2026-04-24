public class PizzaRestaurant : Restaurant
{
    private int numberOfPizzas;
    public PizzaRestaurant(string name, float income, float loss, int numberOfPizzas) : base(name, income, loss)
    {
        this.numberOfPizzas = numberOfPizzas;
    }

    public override string ExtraDetails()
    {
        return this.Name + ".\n" + " Total Pizzas for This Order " + this.numberOfPizzas + ".\n";
    }
}