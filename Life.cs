namespace app
{

    public class LifePolicy : IPolicy
    {
        private DateTime dateOfBirth;
        private decimal amount;
        private bool isSmoker;
        public LifePolicy(DateTime dateOfBirth, decimal amount, bool isSmoker)
        {
            this.dateOfBirth = dateOfBirth;
            this.amount = amount;
            this.isSmoker = isSmoker;
        }

        public decimal calc()
        {

            Console.WriteLine("Rating LIFE policy...");
            decimal age = DateTime.Today.Year - this.dateOfBirth.Year;

            if (this.dateOfBirth.Month == DateTime.Today.Month &&
                DateTime.Today.Day < this.dateOfBirth.Day ||
                DateTime.Today.Month < this.dateOfBirth.Month)
            {
                age--;
            }
            decimal baseRate = this.amount * age / 200;

            if (this.isSmoker)
            {
                return baseRate * 2;

            }
            return baseRate;
        }

        public bool validate()
        {

            if (this.dateOfBirth == DateTime.MinValue)
            {
                Console.WriteLine("Life policy must include Date of Birth.");
                return false;
            }
            if (this.dateOfBirth < DateTime.Today.AddYears(-100))
            {
                Console.WriteLine("Max eligible age for coverage is 100 years.");
                return false;
            }
            if (this.amount == 0)
            {
                Console.WriteLine("Life policy must include an Amount.");
                return false;
            }
            return true;
        }

    }
}