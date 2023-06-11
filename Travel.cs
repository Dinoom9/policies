namespace app
{

    public class Travel : IPolicy
    {
        private int days;
        private string country;
        private decimal rating;

        public Travel(int days, string country)
        {
            this.days = days;
            this.country = country;

        }
        public decimal calc()
        {
            Console.WriteLine("Rating TRAVEL policy...");
            decimal Rating = this.days * 2.5m;
            if (this.country == "Italy")
            {
                Rating *= 3;
                return Rating;
            }
            throw new Exception("This Country is not italy");
            //  return -1;
        }

        public bool validate()
        {
            if (this.days <= 0)
            {
                // throw new Exception("Travel policy must specify Days.");
                Console.WriteLine("Travel policy must specify Days.");
                return false;
            }
            if (this.days > 180)
            {
                Console.WriteLine("Travel policy cannot be more then 180 Days.");
                return false;
            }
            if (String.IsNullOrEmpty(this.country))
            {
                Console.WriteLine("Travel policy must specify country.");
                return false;
            }
            return true;
        }
    }
}