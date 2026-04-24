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

            adorealLand.ThemeParkRides.Add(new ThemeParkRide("Haunted Mansion", 5));
            adorealLand.ThemeParkRides.Add(new ThemeParkRide("Teacups", 7));
            adorealLand.ThemeParkRides.Add(new ThemeParkRide("Pirates of the Caribean", 5));
            adorealLand.PrintRides();

            adorealLand.Restaurants.Add(new Restaurant("Pizzasaurus Rex", 5, 3));
            adorealLand.Restaurants.Add(new Restaurant("Planet Mars Burgers", 8, 7.5F));
            adorealLand.Restaurants.Add(new Restaurant("Salads Undersea", 3, 6));
            adorealLand.PrintRestaurants();

            adorealLand.PrintProfit();
        }
    }
}
