using MusicStore;

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
cds.Add(new CD() { Title = "Booker's Dream",  Artist = "Justin" });
cds.Add(new CD() { Title = "Straight Outta The Highlands", Artist = "Brad" });
cds.Add(new CD() { Title = "Barely Awake", Artist = "Michael" });

Console.WriteLine("Welcome to CL music store");

Console.WriteLine("1. List Inventory");
Console.WriteLine("2. Add to Inventory");
Console.WriteLine("3. Update existing product");
Console.WriteLine("4. Remove from Inventory");
Console.WriteLine("5. Sell from Inventory");
Console.WriteLine("6. Exit");

var key = Console.ReadKey().KeyChar;
Console.WriteLine("The key you pressed was " + key);

if (key == '1')
{
    Console.WriteLine("Inventory Contains:");
    Console.WriteLine(cds.Count);
    foreach (var cd in cds)
    {
        Console.WriteLine(cd.ToString());
    }
}
else if (key == '2')
{
    var newCd = new CD();

    Console.WriteLine("Creating new CD.");
    Console.WriteLine("Title: ");
    var title = Console.ReadLine();

    newCd.Title = title;

    Console.WriteLine("Artist: ");
    newCd.Artist = Console.ReadLine();

    Console.WriteLine("Genre: ");
    newCd.Genre = Console.ReadLine();

    Console.WriteLine("Price: ");
    var price = Console.ReadLine();
    try
    {
        newCd.Price = decimal.Parse(price);
    }
    catch (Exception)
    {
        Console.WriteLine("Failed to include price - was not a valid decimal.");
    }

    Console.WriteLine("Year of release: ");
    var year = Console.ReadLine();
    try
    {
        newCd.YearOfRelease = int.Parse(year);
    }
    catch (Exception)
    {
        Console.WriteLine("Failed to include year - was not a valid integer.");
    }

    Console.WriteLine(newCd.ToString());
}
else if (key == '3')
{
    Console.WriteLine("Choose CD to update: ");

    for (int i = 0; i < cds.Count; i++)
    {
        var currentCD = cds[i].ToString();
        Console.WriteLine($"{i + 1}. {currentCD}");
    }

    var selectedCDIndex = Console.ReadLine();

    int index;

    bool success = int.TryParse(selectedCDIndex, out index);

    if (success)
    {
        var selectedCD = cds[index - 1];

    }

}
