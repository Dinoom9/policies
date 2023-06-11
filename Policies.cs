namespace app
{
    public interface IPolicy
    {
        bool validate();
        decimal calc();

    }
}