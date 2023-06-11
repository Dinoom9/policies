namespace app
{
    public class HealthPolicey : IPolicy
    {
        private Gender gender;
        private decimal deductible;
        public HealthPolicey(Gender gender, decimal deductible)
        {
            this.gender = gender;
            this.deductible = deductible;
        }

        public decimal calc()
        {
            Console.WriteLine("Rating HEALTH policy...");

            if (this.gender == Gender.MALE)
            {
                return this.deductible < 500 ? 1000m : 900m;
            }
            else
            {
                return this.deductible < 800 ? 1100m : 1000m;
            }

        }

        public bool validate()
        {
            return true;

        }

    }

    public enum Gender
    {
        MALE, FEMALE

    }
}