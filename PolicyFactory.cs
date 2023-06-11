using TestRating;

namespace app
{
    public class PolicyFactory
    {
        public IPolicy Create(Policy policy) 
        {
            if (policy == null) throw new Exception("policy is null");
            switch (policy.Type)
            {  // check PolicyType

                case PolicyType.Health:
                    {

                        Gender gender;
                        if (policy.Gender == "female")
                        {
                            gender = Gender.FEMALE;
                        }
                        else if (policy.Gender == "male")
                        {
                            gender = Gender.MALE;
                        }
                        else
                        {
                            throw new Exception("is not female or male");

                        }
                        return new HealthPolicey(gender, policy.Deductible);
                    }

                case PolicyType.Travel:
                    {
                        return new Travel(policy.Days, policy.Country);
                    }

                case PolicyType.Life:
                    {
                        return new LifePolicy(policy.DateOfBirth, policy.Amount, policy.IsSmoker);
                    }

                default: throw new Exception("Unknown policy type");
            }

        }
    }
}