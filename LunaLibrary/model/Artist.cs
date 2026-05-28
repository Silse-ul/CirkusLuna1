namespace Cirkus_Luna.Pages.model;


public class Artist
{
        public int Id {get; set;}
        
        public string Name {get; set;}
        
        public string Description {get; set;}
        
        public string Act {get; set;}

        private static int ArtistId = 0;
        
        public string ImagePathArtist {get; set;}
        
        public List <Performance> Performances {get; set;}

        public Artist()
        {
                Performances = new List<Performance>();
        }

        public Artist(string name, string description, string act , string imagePathArtist)
        {
                Name = name;
                Description = description;
                Act = act;
                Id = ArtistId++;
                ImagePathArtist = imagePathArtist;
                Performances = new List<Performance>();
                
        }
}