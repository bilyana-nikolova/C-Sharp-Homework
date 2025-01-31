

double depositSum=double.Parse(Console.ReadLine());
int termOfDeposit=int.Parse(Console.ReadLine());
double annualInterestRate=double.Parse(Console.ReadLine());
double sum = depositSum + termOfDeposit * ((depositSum * annualInterestRate / 100) / 12);

Console.WriteLine(sum);