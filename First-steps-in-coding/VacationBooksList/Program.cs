int numOfPages = int.Parse(Console.ReadLine());
int readedPagesPerHour  = int.Parse(Console.ReadLine());    
int days = int.Parse(Console.ReadLine());

int pegesPerDay = numOfPages / days;
int hoursPerDay = pegesPerDay / readedPagesPerHour ;

Console.WriteLine(hoursPerDay); 