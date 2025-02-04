double plastic = 1.5;
double paint = 14.5;
double thinner = 5;


double AmountOfPlastic = double.Parse(Console.ReadLine());
double amountOfPaint = double.Parse(Console.ReadLine());
double AmounOfthinner = double.Parse(Console.ReadLine());
double Hours = double.Parse(Console.ReadLine());
double plasticPrice = (AmountOfPlastic + 2) * plastic;
double paintPrice = (amountOfPaint + (0.10 * amountOfPaint)) * paint;
double thinnerPrice = AmounOfthinner * thinner;
double forMaterials = plasticPrice + paintPrice + thinnerPrice + 0.40;
double Worker = ( forMaterials * 0.30 ) * Hours;

double totalAmount = forMaterials + Worker;
Console.WriteLine(totalAmount);



