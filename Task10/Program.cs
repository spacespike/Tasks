//get XXX number
//retun second number from that number


int ReturnSecondDigit(int num)
{
    if (num < 0) { num = num * -1; }
    int result = num / 10 % 10;
    return result;
}


Console.WriteLine("Write the number:");
int number = Convert.ToInt32(Console.ReadLine());

int answer = ReturnSecondDigit(number);
Console.WriteLine($"The number is: {answer}");