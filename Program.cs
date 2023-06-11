using System;
using app;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
namespace TestRating
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insurance Rating System Starting...");

            var engine = new RatingEngine();

            // load policy - open file policy.json
            string policyJson = File.ReadAllText("policy.json");
            var policy = JsonConvert.DeserializeObject<Policy>(policyJson, new StringEnumConverter());

            //creat PolicyFactory Object
            PolicyFactory policyFactory = new PolicyFactory();

            //Activate the create function
            
            decimal rating = engine.Rate(policyFactory.Create(policy));

            //check the rating
            if (rating > 0)
            {
                Console.WriteLine($"Rating: {rating}");
            }
            else
            {
                Console.WriteLine("No rating produced.");
            }
        }
    }
}
