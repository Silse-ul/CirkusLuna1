namespace Cirkus_Luna.Pages.model;

    public class Performance
    {
        public string Date { get; set; }
        public string City { get; set; }
        public string Address { get; set; }
        public string StartTime { get; set; }
        public Artist Artist { get; set; }
        public int Id { get; set; }
        public List<Artist> Artists { get; set; }

        private static int PerformanceCounter = 1; 
        
        public Performance(string date, string city, string address, string startTime)
        {
            City = city;
            Address = address;
            StartTime = startTime;
            Date = date;
            Artists = new List<Artist>();
        }

        public Performance(string date, string city, string address, string startTime, Artist artist) : this(date, city,
            address, startTime)
        {
            Artist = artist;
            Id = PerformanceCounter++;
        }

    }