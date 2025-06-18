// See https://aka.ms/new-console-template for more information
using RatingSystem;

Console.WriteLine("Hello, World!");
IAgentRatingService service = new AgentRatingService();

service.GiveRating("Alice", 5);
service.GiveRating("Bob", 3);
service.GiveRating("Alice", 4);
service.GiveRating("Bob", 4);
service.GiveRating("Charlie", 5);

var ratings = service.GetRatings();
foreach (var agent in ratings)
{
    Console.WriteLine(agent);
}