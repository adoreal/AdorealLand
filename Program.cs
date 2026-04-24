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
            adorealLand.ThemeParkRides.Add(new BrokenRide("Pirates of the Carribean"));
            //adorealLand.ThemeParkRides.Add(new DarkRide("Pirates of the Carribean", 5, 4));
            adorealLand.PrintRides();

            adorealLand.Restaurants.Add(new SpaceRestaurant("Pizzasaurus Rex", 5, 3, 1000));
            adorealLand.Restaurants.Add(new SpaceRestaurant("Planet Mars Burgers", 8, 7.5F, 1000));
            adorealLand.Restaurants.Add(new UnderseaRestaurant("Salads Undersea", 3, 6, 1000));
            adorealLand.PrintRestaurants();

            adorealLand.PrintProfit();
        }
    }
}
