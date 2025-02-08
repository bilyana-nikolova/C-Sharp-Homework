int firstTime = int.Parse(Console.ReadLine());
int secondTime = int.Parse(Console.ReadLine());
int thirdTime = int.Parse(Console.ReadLine());

int TotalTime = firstTime + secondTime + thirdTime;

int min = TotalTime / 60;

int sec = TotalTime % 60;

if (sec <= 9)
{
    Console.WriteLine($"{min}:0{sec}");

}
else
{
    Console.WriteLine($"{min}:{sec}");
}