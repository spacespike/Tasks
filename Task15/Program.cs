// get the number of a weekday 
// retuns if it is a weekend or no

bool IsWeekend (int num){
    return (num == 6 || num == 7);
}


Console.WriteLine("Write the number:");
int number = Convert.ToInt32(Console.ReadLine());

bool result = IsWeekend(number);
Console.WriteLine(result ? "Yes" : "No");