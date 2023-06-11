
using System;
using System.IO;
using app;

namespace TestRating
{
    /// <summary>
    /// The RatingEngine reads the policy application details from a file and produces a numeric 
    /// rating value based on the details.
    /// </summary>
    public class RatingEngine
    {
        //public decimal Rating { get; set; }
        public decimal Rate(IPolicy policy)
        {
            // log start rating
            Console.WriteLine("Starting rate.");
            Console.WriteLine("Loading policy.");

            if (!policy.validate()) throw new Exception("is not validate"); //Function implementation and validation
            return policy.calc(); // Function implementation and calc

        }
    }
}
