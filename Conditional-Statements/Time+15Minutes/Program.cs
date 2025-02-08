int hours = int.Parse(Console.ReadLine());    
int min = int.Parse(Console.ReadLine());

int newTime =  min + 15; 

if (newTime > 59)
{
    hours = hours + 1;
    newTime = newTime - 60;
    if (hours >= 24) 
    {
        hours = 0;
    }
}
Console.WriteLine($"{hours}:{newTime:D2}");