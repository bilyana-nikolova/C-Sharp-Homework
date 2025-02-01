//pen = 5.8
//markers = 7.20
//cleancer = 1.20 

int numOfPencil = int.Parse(Console.ReadLine());
int numOfMarkers = int.Parse(Console.ReadLine());
int CleancerLiters = int.Parse(Console.ReadLine());
int percentDiscount = int.Parse(Console.ReadLine());

double penPrice = 5.8;
double markersPrice = 7.2;
double cleancerPrice = 1.2;

double totalPricePen =  penPrice * numOfPencil;
double totalPriceMarkers =  markersPrice * numOfMarkers; 
double totalCleancerPrice = cleancerPrice * CleancerLiters;

double Total = totalPriceMarkers + totalCleancerPrice + totalPricePen;
double totalWithDiscount = Total - (percentDiscount/100.0) * Total;
// 100 - 10% / 100 * 100
// 100 - 0.01 * 100
// 100 - 10 
// 90 
Console.WriteLine(totalWithDiscount);