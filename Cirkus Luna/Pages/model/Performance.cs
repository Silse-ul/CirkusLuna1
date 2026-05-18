namespace Eksamen.Model
{
    public class Performance
    {
        public DateTime Date { get; set; }
        public string City { get; set; }
        public string Title { get; set; }
        public string Host { get; set; }
        public string Address { get; set; }
        public string StartTime { get; set; }
        public int Id { get; set; }



        private static int PerformanceCounter = 1; 

        public Performance()
        {
            Id = PerformanceCounter++;
        }

        //Starter vi programmet med et par forestillinger?
        public Performance(DateTime Date, string City, string Title, string Host, string Address, string StartTime)
        {
            City = null;
            Title = null;
            Host = null;
            Address = null;
            StartTime = null;
            //Bedre at kaste exception, men null for nu
        }

        //Performance newPerformance = new Performance(DateTime, "Slagelse", "Ogglyboogly", "Bubber", "Standgade 24", "18:30");

    }
}
