Console.WriteLine("elso?");
double szam = double.Parse(Console.ReadLine());

Console.WriteLine("muvelet?");
char muvelet = char.Parse(Console.ReadLine());

Console.WriteLine("masodik?");
double szam2 = double.Parse(Console.ReadLine());

double eredmeny = double.Parse(Console.ReadLine());

if (muvelet == +)
{
    eredmeny = szam + szam2;
}
else if (muvelet == -)
{
    eredmeny = szam - szam2;
}
else if (muvelet == *)
{
    eredmeny = szam * szam2;
}
else if (muvelet == /)
{
    eredmeny = szam / szam2;
}

Console.WriteLine($"Eredmeny = {eredmeny}");
