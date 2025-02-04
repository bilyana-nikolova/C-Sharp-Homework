int lenghtSm = int.Parse(Console.ReadLine());
int widthtSm = int.Parse(Console.ReadLine());
int hightSm = int.Parse(Console.ReadLine());
double percent = int.Parse(Console.ReadLine());

int aqariumVolume = lenghtSm * widthtSm * hightSm;
double aqariumLitersVolume = aqariumVolume / 1000;
double takenSpace = aqariumLitersVolume * percent / 100;

double neededLiters = aqariumLitersVolume - takenSpace;

Console.WriteLine(neededLiters);