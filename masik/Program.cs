Console.WriteLine("Mi volt az átlagod?");
double atlag = double.Parse(Console.ReadLine());

if (atlag < 2.00)
{
    Console.WriteLine("Az ösztöndíjad 0 Ft.");
}
else if (atlag < 3.00 && atlag > 1.99)
{
    Console.WriteLine("Az öszöndíjad 8000 Ft.");
}
else if (atlag > 2.99 && atlag < 4.00)
{
    Console.WriteLine("Az ösztöndíjad 25000 Ft.");
}
else if (atlag > 3.99 && atlag < 4.49)
{
    Console.WriteLine("Az ösztöndíjad 42000 Ft.");
}
else if (atlag > 4.48 && atlag < 5)
{
    Console.WriteLine("Az ösztöndíjad 59000 Ft.");
}