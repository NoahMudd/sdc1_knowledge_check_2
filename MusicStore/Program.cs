// See https://aka.ms/new-console-template for more information
/*
 * Music Store

- Track Sales
- Track Marketing Campaigns

- Keep Inventory
  - CRUD operations
  - Sell Inventory
  - Buy Inventory
  - Remove from inventory
  - Add from inventory
  	- Receive shipments
  - Items
	  - Instruments
	  - CDs
	  - Vinyl
	  - Tapes
*/
List<CD> cds = new List<CD>();
cds.Add(new CD() { Artist = "Justin" });
cds.Add(new CD() { Artist = "Brad" });
cds.Add(new CD() { Artist = "Michael" });

Console.WriteLine("Welcome to CL music store");

Console.WriteLine("1. List Inventory");
Console.WriteLine("2. Add to Inventory");
Console.WriteLine("3. Remove from Inventory");
Console.WriteLine("4. Sell from Inventory");
Console.WriteLine("5. Exit");

var key = Console.ReadKey().KeyChar;
Console.WriteLine("The key you pressed was " + key);

if (key == '1')
{
    Console.WriteLine("Inventory Contains:");
    Console.WriteLine(cds.Count);
    foreach (var i in cds)
    {
        Console.WriteLine(i.Artist);
    }
    //Console.WriteLine(myCD.Artist);
    //Console.WriteLine(myCD2.Artist);
    //Console.WriteLine(myCD3.Artist);
}

public class CD
{
	public string Title;

    public string Artist;

    public string Genre;

    public decimal Price;

    public int YearOfRelease;
}