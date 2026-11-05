using MuzeumApp;
List<Mutargy> mutargyak = new List<Mutargy>();
int hiba = 0;
foreach (var sor in File.ReadAllLines(@"C:\Users\13d\source\repos\MuzeumApp\MuzeumApp\bin\Debug\net10.0\mutargyak.txt").Skip(1))
{
    if(sor.Count() != 4)
    {
        continue;
    }
    string[] adatok = sor.Split('|');
    string tipus = adatok[0];
    string azon = adatok[1];
    int becsult;
    int extra;

    if (string.IsNullOrWhiteSpace(azon))
    {
        hiba++;
        continue;
    }
    if(azon != "M" && azon != "F")
    {
        hiba++;
        continue;
    }

    if (int.TryParse(adatok[2], out becsult) || int.TryParse(adatok[3], out extra))
    {
        hiba++;
        continue;
    }

    if(azon == "M")
    {
        Mutargy targy = new Mutargy(azon, becsult);
        mutargyak.Add(targy);
    }
    else if (azon == "F")
    {
        Festmeny fest = new Festmeny(azon, becsult, extra);
        mutargyak.Add(fest);
    }

}
Console.WriteLine(hiba);
foreach (var item in mutargyak)
{
    Console.WriteLine(item);
}



