// public class VGRides : Ride
// {
    
//     public VGRides()
//     {
//         Name = "Video Games Rides";
//         Description = "Experience the thrill of Video Games with our exciting rides!";
//         ImageUrl = "https://example.com/vg.jpg";
//         Rides = new List<RideDetail>
//         {
//             new RideDetail
//             {
//                 Name = "Virtual Reality Coaster",
//                 Description = "Feel the rush of a roller coaster in virtual reality!",
//                 ImageUrl = "https://example.com/vrcoaster.jpg"
//             },
//             new RideDetail
//             {
//                 Name = "Arcade Adventure",
//                 Description = "Embark on an arcade adventure with classic games and challenges!",
//                 ImageUrl = "https://example.com/arcade.jpg"
//             }
//         };
//     }
//     public override void DisplayInfo()
//     {
//         Console.WriteLine($"Ride Name: {Name}");
//         Console.WriteLine($"Description: {Description}");
//         Console.WriteLine($"Image URL: {ImageUrl}");
//         Console.WriteLine("Available Rides:");
//         foreach (var ride in Rides)
//         {
//             Console.WriteLine($"- {ride.Name}: {ride.Description} (Image: {ride.ImageUrl})");
//         }
//     }

// }