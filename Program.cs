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
            adorealLand.ThemeParkRideAName = "Haunted Mansion";
            adorealLand.ThemeParkRideASpeed = 5;
            adorealLand.ThemeParkRideBName = "Teacups";
            adorealLand.ThemeParkRideBSpeed = 7;
            adorealLand.ThemeParkRideCName = "Pirates of the Caribean";
            adorealLand.ThemeParkRideCSpeed = 5;
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
