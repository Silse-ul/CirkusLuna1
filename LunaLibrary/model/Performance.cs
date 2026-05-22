namespace Cirkus_Luna.Pages.model;

    public class Performance
    {
        public string Date { get; set; }
        public string City { get; set; }
        public string Address { get; set; }
        public string StartTime { get; set; }
        public Artist Artist { get; set; }
        public int Id { get; set; }



        private static int PerformanceCounter = 1; 
        

        //Starter vi programmet med et par forestillinger?
        public Performance(string date, string city, string address, string startTime)
        {
            City = city;
            Address = address;
            StartTime = startTime;
            Date = date;
            //Bedre at kaste exception, men null for nu
        }

        public Performance(string date, string city, string address, string startTime, Artist artist) : this(date, city,
            address, startTime)
        {
            Artist = artist;
            Id = PerformanceCounter++;
        }

        //Performance newPerformance = new Performance(DateTime, "Slagelse", "Ogglyboogly", "Bubber", "Standgade 24", "18:30");

    }