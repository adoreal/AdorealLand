public class GauchoRestaurant(string name, float income, float loss, string specialtyOfTheDay) : Restaurant(name, income, loss)
{
    private string _specialtyOfTheDay = specialtyOfTheDay;

    public override string ExtraDetails()
    {
        return $"This restaurant serves delicious meat and is inspired by the gauchos of South America.\nToday's specialty: {_specialtyOfTheDay}\n";
    }
}