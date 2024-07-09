using MongoDB.Bson;
using MongoDB.Driver;
using MongoDBConnection;
using MongoDBConnection.Models;

class Program
{
    static void Main(string[] args)
    {
        var client = new MongoClient("mongodb://localhost:27017");
        var database = client.GetDatabase("CinemaNetwork");

        var theaterCollection = database.GetCollection<Theater>("theaters");

        bool exit = false;
        while (!exit)
        {
            Console.WriteLine("Select an option:");
            Console.WriteLine("1 - Create Theater");
            Console.WriteLine("2 - Read Theaters");
            Console.WriteLine("3 - Update Theater");
            Console.WriteLine("4 - Delete Theater");
            Console.WriteLine("5 - Exit");

            var choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    App.CreateTheater(theaterCollection);
                    break;
                case "2":
                    App.ReadTheaters(theaterCollection);
                    break;
                case "3":
                    App.UpdateTheater(theaterCollection);
                    break;
                case "4":
                    App.DeleteTheater(theaterCollection);
                    break;
                case "5":
                    exit = true;
                    break;
                default:
                    Console.WriteLine("Invalid choice.");
                    break;
            }
        }
    }
}