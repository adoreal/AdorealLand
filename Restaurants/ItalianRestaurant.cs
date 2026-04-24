public class ItalianRestaurant : Restaurant
  {
      private string specialty;

      public ItalianRestaurant() : base("Italian Restaurant", 0, 0)
      {
          this.specialty = "Pizza";
      }
      public ItalianRestaurant(string name, float income, float loss, string specialty)
          : base(name, income, loss)
      {
          this.specialty = specialty;
      }

      public override string ExtraDetails()
      {
          return "Specialty: " + specialty;
      }
  }