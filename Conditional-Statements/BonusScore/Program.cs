int number = int.Parse(Console.ReadLine());

double bonus = 0.0;

if (number <= 100)
{
    bonus = 5;
}
else if (number > 100)
{
    bonus = 0.20 * number;
}
else if (number > 1000)
{
    bonus = 0.10 * number;
}


if (number % 2 == 0)
{