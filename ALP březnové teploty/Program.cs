// zde zadáme hodnoty teplot
int[] poleTeplot = new int[31];
Console.WriteLine("Zadejte hodnoty: ");
for (int i = 0; i < 31; i++)
{
    poleTeplot[i] = int.Parse(Console.ReadLine());
}
// máme zadané hodnoty teplot a zadáme co chceme vypsat
Console.WriteLine("Jakou teplotu mám vypsat?");
Console.WriteLine("minimum, maximum, průměr");
string hodnota = Console.ReadLine();
// zde máme zadáno co chceme vypsat a program začne vypisovat
if (hodnota == "minimum")
{
    int min = poleTeplot[0];
    foreach (int i in poleTeplot)
    {
        min = Math.Min(min, poleTeplot[i + 1]);
    }
    Console.WriteLine(min);
    // tady program vypíše minimální hodnotu
}
else if (hodnota == "maximum")
{
    int max = poleTeplot[0];
    foreach (int i in poleTeplot)
    {
        max = Math.Max(max, poleTeplot[i + 1]);
    }
    Console.WriteLine(max);
    // tady maximální hodnotu
}
else
{
    int cisla = poleTeplot[0];
    for (int num = 1; num < 31; num++)
    {
        cisla = cisla + poleTeplot[num];
    }
    double prumer = cisla / 31;
    Console.WriteLine(prumer);
    // a tady průměr
}