namespace Cirkus_Luna.Pages.model;

public enum TicketType {kids = 130 , adult = 200 , VIP = 300 }

    public class Ticket
        {
            public string Name { get; set; }
            public  int Price  { get; set; }
            public TicketType Type { get; set; }
            public string Id { get; set; }
            
            public int performanceId { get; set; }
            
            public string CustomerName{ get; set; }
            public int TicketType { get; set; } 
            
            
            public void CalculatePrice()
            {
                Price = (int)Type; 
            }

            


            public Ticket(string name, TicketType type, string id)
            {
                Name = name;
                Price = (int)Type;
                Type = type;
                Id = id;
                
            }


        }
    
    
    
