// Zde zadáme hodnoty teplot.
int[] poleTeplot = new int[31];
Console.WriteLine("Zadejte hodnoty: ");
for (int i = 0; i < 31; i++)
{
    poleTeplot[i] = int.Parse(Console.ReadLine());
}
// Máme zadané hodnoty teplot a zadáme co chceme vypsat.

Console.WriteLine("Jakou teplotu mám vypsat?");
Console.WriteLine("minimum, maximum, průměr");
string hodnota = Console.ReadLine();
// Zde máme zadáno co chceme vypsat a program začne vypisovat.

if (hodnota == "minimum")
{
    int min = poleTeplot[0];
    foreach (int cislo in poleTeplot)
    {
        min = Math.Min(min, cislo);
    }
    Console.WriteLine(min); // Tady program vypíše minimální hodnotu.
}

else if (hodnota == "maximum")
{
    int max = poleTeplot[0];
    foreach (int i in poleTeplot)
    {
        max = Math.Max(max, i);
    }
    Console.WriteLine(max); // Tady maximální hodnotu.
}

else
{
    double prumer = poleTeplot[0];
    foreach (int i in poleTeplot)
    {
        prumer = poleTeplot.Average();
    }
    Console.WriteLine("Průměr teplot je: " + prumer);
}