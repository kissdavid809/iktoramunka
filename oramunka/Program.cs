Console.WriteLine("Ajd meg egy szamot");
int egyik = int.Parse(Console.ReadLine());

Console.WriteLine("adj egy masikat");
int masik = int.Parse(Console.ReadLine());

if (egyik > masik)
{
    Console.WriteLine("Az első nagyobb");
}
else
{
    if (masik > egyik)
    {
        Console.WriteLine("A masodik nagyobb");
    }
}
