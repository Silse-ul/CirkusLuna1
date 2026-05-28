namespace Cirkus_Luna.Pages.Model;

public enum TicketType {kids = 130 , adult = 200 , VIP = 300 }

    public class Ticket
        {
            public string Name { get; set; }
            public  int Price  { get; set; }
            public TicketType Type { get; set; }
            public string Id { get; set; }
            
            public int performanceId { get; set; }
            
            public string CustomerName{ get; set; }

            public Ticket()
            {
                
            }
            
            public Ticket(string name, TicketType type, string id)
            {
                Name = name;
                Type = type;
                Id = id;
                CalculatePrice();
                
            }
            public void CalculatePrice()
            {                           
                Price = (int)Type;      
            }                           


        }
                                   
    
    
