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
            adorealLand.ThemeParkRides.Add(new DarkRide("Pirates of the Caribean", 5, 4));
            adorealLand.ThemeParkRides.Add(new SpinningRide("Teacups", 7, 360, 9));
            adorealLand.ThemeParkRides.Add(new CoasterRide("Space Mountain", 12, 0));
            adorealLand.ThemeParkRides.Add(new SpinningRide("Dumbo", -100, 360, 5));
            adorealLand.PrintRides();

            adorealLand.RestaurantAName = "Pizzasaurus Rex";
            adorealLand.RestaurantAIncome = 5;
            adorealLand.RestaurantALoss = 3;
            adorealLand.RestaurantBName = "Planet Mars Burgers";
            adorealLand.RestaurantBIncome = 8;
            adorealLand.RestaurantBLoss = 7.5F;
            adorealLand.RestaurantCName = "Salads Undersea";
            adorealLand.RestaurantCIncome = 3;
            adorealLand.RestaurantCLoss = 6;
            adorealLand.PrintRestaurants();

            adorealLand.PrintProfit();
        }
    }
}
