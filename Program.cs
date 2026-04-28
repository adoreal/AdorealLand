using System;
using System.Collections.Generic;

namespace SOLIDApp
{
    class Program
    {
        static void Main(string[] args)
        {
            List<IThemeParkRide> themeParkRides = new List<IThemeParkRide>();
            themeParkRides.Add(new SpinningRide("Teacups", 7, 360, 3));
            themeParkRides.Add(new BrokenRide("Pirates of the Carribean"));
            themeParkRides.Add(new DarkRide("Haunted Mansion", 5, 7));

            List<Restaurant> restaurants = new List<Restaurant>();
            restaurants.Add(new RatatouilleRestaurant("Rat Restaurant", 5, 7, 1000));
            restaurants.Add(new SpaceRestaurant("Pizzasaurus Rex", 5, 3, 1000));
            restaurants.Add(new SpaceRestaurant("Planet Mars Burgers", 8, 7.5F, 1000));
            restaurants.Add(new UnderseaRestaurant("Salads Undersea", 3, 6, 1000));
            ThemePark adorealLand = new ThemePark(themeParkRides, restaurants);
            adorealLand.TicketCost = 90;
            adorealLand.AverageDailyAttendance = 50000;
            adorealLand.ThemeParkName = "Adoreal Land";

            themeParkRides.Add(new SpinningRide("Teacups", 7, 360, 3));
            themeParkRides.Add(new BrokenRide("Pirates of the Carribean"));
            themeParkRides.Add(new DarkRide("Haunted Mansion", 5, 7));
            themeParkRides.Add(new DarkRide("It's A Small World", 5, 7));
            themeParkRides.Add(new SpinningRide("Merry-Go-Round", 5, 360, 3));
            

            //adorealLand.ThemeParkRides.Add(new DarkRide("Pirates of the Carribean", 5, 4));
            adorealLand.PrintRides();

            adorealLand.PrintRestaurants();

            adorealLand.PrintProfit();
        }
    }
}
