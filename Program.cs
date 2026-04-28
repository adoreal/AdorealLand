using System;

namespace SOLIDApp
{
    class Program
    {
        static void Main(string[] args)
        {
            ThemePark adorealLand = new ThemePark();
            adorealLand.TicketCost = 90;
            adorealLand.AverageDailyAttendance = 50000;
            adorealLand.ThemeParkName = "Adoreal Land";

            adorealLand.ThemeParkRides.Add(new DarkRide("Haunted Mansion", 5, 7));
            adorealLand.ThemeParkRides.Add(new SpinningRide("Teacups", 7, 360, 3));
            adorealLand.ThemeParkRides.Add(new DarkRide("Pirates of the Carribean", 5, 4));
            adorealLand.ThemeParkRides.Add(new AnimalRide("Jungle Cruise", 5, 10));
            adorealLand.PrintRides();

            adorealLand.Restaurants.Add(new SpaceRestaurant("Pizzasaurus Rex", 5, 3, 1000));
            adorealLand.Restaurants.Add(new SpaceRestaurant("Planet Mars Burgers", 8, 7.5F, 1000));
            adorealLand.Restaurants.Add(new RatatouilleRestaurant("Ratatouille", 3, 6, 1000));
            adorealLand.Restaurants.Add(new CatRestaurant("Kitty log", 8, 3, 6));
            adorealLand.PrintRestaurants();

            adorealLand.PrintProfit();
        }
    }
}
