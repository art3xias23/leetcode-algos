namespace Algos
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method, AllowMultiple = false)]
    public class IdAttribute : Attribute
    {
        public int Id { get; set; }

        public IdAttribute(int id)
        {
            Id = id;
        }
    }
}
