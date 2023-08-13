//return 2nd digit in any number
// or retun message,that there is none

int ReturnSecondDigit(int num)
{
    if (num < 0) { num = num * -1; }   //checking for negative numbers
    if (num < 100) { return -1; }      //for numbers with less than 3 numbers 
    if (num > 999)                     //for numbers with more than 3 numbers
    {
        while (num > 999) { num = num / 10; }
    }
    int result = num % 10;
    return result;
}

Console.WriteLine("Write the number:");
int number = Convert.ToInt32(Console.ReadLine());

int answer = ReturnSecondDigit(number);
if (answer == -1) { Console.WriteLine("There is no third digit"); }
else Console.WriteLine($"The third digit is: {answer}");