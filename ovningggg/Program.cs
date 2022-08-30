

string namn = "";
string vannamn = "";
string favspel = "";
string favdricka = "";

Console.WriteLine("Var God och skriv in ditt namn här: ");
namn = Console.ReadLine();



Console.WriteLine($"Hej {namn} och välkommen till Emils spel.");

Console.WriteLine(" ");

Console.WriteLine("Skriv in din kompis namn: ");
vannamn = Console.ReadLine();

Console.WriteLine(" ");

Console.WriteLine("Skriv in din kompis favorit spel: ");
favspel = Console.ReadLine();

Console.WriteLine(" ");

Console.WriteLine("Skriv in din kompis favorit dricka: ");
favdricka = Console.ReadLine();

Console.WriteLine(" ");
Console.WriteLine(" ");

Console.WriteLine($"hallå!...pssst..Din kompis {vannamn}s favorit dricka är väl {favdricka}?"); 
Console.WriteLine($"..Grabben väljer det av alla drickor i världen.. Hans favoritspel är också {favspel}! Det är så dåligt spel.");

Console.WriteLine(" ");
Console.WriteLine(" ");

Console.WriteLine("Tryck på ENTER för att avsluta.");

Console.ReadLine();