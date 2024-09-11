namespace Algos
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method, AllowMultiple = false)]
    public class StatsAttribute : Attribute
    {
        public string Date { get; set; }
        public string Time { get; set; }

        public StatsAttribute(string date, string time)
        {
            Date = date;
            Time = time;
        }
    }
}
