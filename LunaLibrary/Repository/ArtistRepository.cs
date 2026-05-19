using Cirkus_Luna.Pages.model;

namespace Cirkus_Luna.Pages;

public class ArtistRepository : IArtistRepository
{
    
    private List<Artist> _artistsList;

    public ArtistRepository()
    {
        //tom liste 
        _artistsList = new List<Artist>();
        // vi tilføjer lokaler her 
        Artist h = new Artist("Jimmy" , 
            "Jimmy er en farverig og energisk klovn, der arbejder i et stort gammeldags cirkus fyldt med lys, musik og latter. Han er kendt for sit store røde hår, sin runde røde næse og sine alt for store sko, der altid får publikum til at grine, når han snubler rundt i manegen. Jimmy elsker at lave sjov med både børn og voksne, og han har en særlig evne til at få selv de mest generte mennesker til at smile. Han går klædt i et farverigt kostume med blå, gule og røde striber, og hans ansigt er malet med store hvide kinder og et kæmpe smil. Når forestillingen starter, kommer Jimmy ofte trillende ind på en lille cykel eller ud af en alt for lille bil sammen med andre klovne. Han jonglerer med bolde, laver fjollede tricks og ender næsten altid i sjove problemer, som får hele teltet til at bryde ud i latter.", "Ballade i Luna ", "det kommer ");
        _artistsList.Add(h);
        Artist t = new Artist("Luna", "Luna er en elegant og legesyg søløve, der optræder i et stort cirkus fyldt med musik, lys og begejstrede tilskuere. Hun er kendt for sin skinnende mørke pels, sine hurtige bevægelser og sine imponerende tricks, som altid får publikum til at klappe højt. Luna elsker opmærksomheden i manegen og virker næsten som om, hun smiler, når hun hører børnene grine og heppe på hende. Under forestillingerne balancerer Luna bolde på snuden, hopper gennem ringe og laver sjove klaplyde med lufferne. Hun er utrolig dygtig til at følge sin træners signaler og viser stor intelligens, når hun udfører sine numre. Et af hendes mest populære tricks er, når hun elegant glider hen over scenen og laver et højt spring op på en lille platform, hvor hun stolt bukker for publikum bagefter.", "DEN FRYGTESLØSE SØLØVE" , "det kommer");
        _artistsList.Add(t);
        Artist f = new Artist( "Valentino Vex", "En frygtløs ildsluger og balancekunstner kendt for at gå på line over brændende ringe uden sikkerhedsnet. Valentino er berømt for sine dramatiske entréer og sit intense blik, som får publikum til at holde vejret gennem hele showet.", "Flammer Over afgrunden", "Kommer");
        _artistsList.Add(f);
        Artist d = new Artist( "Zara Zoltan", "En illusionist og knivkaster med ry for aldrig at ramme ved siden af. Zara optræder i mørke omgivelser med lynhurtige tricks, forsvindingsnumre og knivkast så tæt på publikum, at man kan mærke suset.", "Skyggernes Dans", "Kommer");
        _artistsList.Add(d);
        Artist g = new Artist(" Bella Belladonna",
            "En mystisk luftakrobat der svæver gennem teltets mørke i silkebånd højt over publikum. Bella kombinerer elegance og fare i et hypnotiserende show fyldt med lys, røg og næsten umulige bevægelser",
            "Månens Hemmeligheder", "Kommer");
        _artistsList.Add(g);
        Artist r = new Artist("Celeste Noire",
            "Celeste Noire er en hypnotiserende illusionist, der blander dans, magi og psykologi i et show, som føles mere som en drøm end en forestilling. Med mørke fløjlskostumer, levende lys og teatralske skygger manipulerer hun publikums sanser, indtil ingen længere kan skelne mellem virkelighed og illusion. Hendes mest berømte nummer er “spejlkabinettet”, hvor frivillige fra publikum angiveligt ser deres største frygt blive levende foran dem. Rygtet siger, at nogle gæster nægter at gå ind til hendes forestillinger alene.",
            "Det Erotiske Mørke", "KOMMER");
        _artistsList.Add(r);
        Artist b = new Artist("Bruno “The Beast” Moretti",
            "Bruno Moretti er en enorm styrkeartist med et temperament lige så voldsomt som hans optræden. Foran et brølende publikum løfter han massive jernkæder, river metalstænger over med hænderne og trækker flere tons tunge køretøjer gennem arenaen alene. Men hans show handler ikke kun om rå styrke — Bruno opbygger spænding som en gladiator i en arena og udfordrer ofte publikum til at teste deres egen styrke mod hans. Ingen har endnu vundet.",
            "Titanernes Kamp", "KOMMER"); 
        _artistsList.Add(b);
        Artist c = new Artist("Elena Voltira",
            "Elena Voltira er kendt som “kvinden uden tyngdekraft”. Højt oppe under cirkusteltets tag udfører hun ekstreme spring, saltoer og luftakrobatik uden tøven. Hendes forestilling kombinerer elegance med konstant fare, mens hun svinger sig mellem trapezer kun få centimeter fra at miste grebet. Publikum holder vejret gennem hele showet, især under hendes legendariske finale, hvor hun falder frit gennem luften, før hun gribes i sidste sekund.",
            "Himmelstorm", "KOMMER");
        _artistsList.Add(c);
        Artist m = new Artist("Thunderhoof",
            "Thunderhoof er cirkussets mest berømte hingst, kendt for sin enorme fart og dramatiske optrædener. Med flammende dekorationer omkring arenaen stormer han gennem manegen, springer over forhindringer og udfører præcise tricks sammen med sine ryttere. Publikum elsker især hans afslutning, hvor han galoperer frit rundt i arenaen mens lyset blinker og musikken bygger op til et kæmpe klimaks.",
            "Den Sidste Galop", "KOMMER");
        _artistsList.Add(m);
        Artist o = new Artist("The Royal Ruff Pack (Hundegruppe)",
            "The Royal Ruff Pack består af en energisk gruppe specialtrænede hunde, der er kendt for deres imponerende teamwork og komiske personligheder. Under showet springer de gennem ringe, balancerer på bolde, kører små vogne rundt i arenaen og udfører perfekt timede tricks i høj fart. Publikum elsker især de kaotiske øjeblikke, hvor hundene tilsyneladende “glemmer” rutinen og skaber sjove situationer med deres trænere — før alt pludselig falder perfekt på plads igen. Showet kombinerer humor, fart og imponerende præcision, og det ender altid med stående applaus fra både børn og voksne.",
            "Poter i Perfektion", "Kommer");
        _artistsList.Add(o);
        Artist p = new Artist("The Inferno Riders (Motorcykelstuntgruppe)",
            "The Inferno Riders er en gruppe ekstreme stuntkørere, der er berømte for deres livsfarlige optræden inde i den gigantiske stålkugle kendt som “Dødskuglen”. Én efter én drøner motorcyklerne ind i kuglen, indtil flere kørere suser rundt samtidig i alle retninger med kun få centimeters afstand mellem hinanden. Motorerne brøler gennem teltet, mens gnister flyver fra stålet og publikum holder vejret under de vanvittige krydsninger i fuld fart. Showet bliver endnu vildere, når lyset slukkes, og kørerne fortsætter i mørket kun oplyst af flammende hjul og blinkende neonlys.",
            "Dødskuglens Raseri", "Kommer");
        _artistsList.Add(p);
        Artist w = new Artist("The Great Mordecai (Tryllekunstner & illusionist)",
            "The Great Mordecai er en legendarisk illusionist kendt for sine uforklarlige tricks og dramatiske sceneoptrædener. Med mørk kappe, levende lys og et teatralsk orkester får han mennesker til at forsvinde, svæve frit gennem luften og dukke op igen midt blandt publikum få sekunder senere. Hans mest berømte nummer er “Den Forsvundne Kiste”, hvor han låses inde foran hele arenaen — kun for at dukke op et helt andet sted i teltet i et glimt af røg og lys. Publikum forlader ofte showet uden at kunne forklare, hvordan noget af det kunne lade sig gøre.",
            "Mester over Illusionerne", "Kommer");
        _artistsList.Add(w);


    }

    public List<Artist> GetAll()
    {
        return _artistsList;
        
    }


    public Artist GetById(int id)
    {
        foreach (Artist item in _artistsList )
        {
            if (item.Id == id)
            {
                return item;
            }
        }
        return null;
    }
}