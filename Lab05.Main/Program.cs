using lab05;
using System.Diagnostics;
using System.Security.Cryptography.X509Certificates;

Console.Clear();
Console.WriteLine("This is fraction building program.");
Console.WriteLine("Please enter a numerator.");
string stringNumerator = Console.ReadLine();
int newNumerator = tryConvert(stringNumerator);
Console.WriteLine("Please enter a denominator");
string stringDenominator = Console.ReadLine();
int newDenominator = tryConvert(stringDenominator);

MixedNumber newRartional = new MixedNumber(newNumerator,newDenominator);
newRartional.displayMixedNumber();

int tryConvert(string num)
{
    bool isNumber = false;
    int newNumber = 0;

    while(isNumber == false)
    {
        try
        {
            newNumber = Convert.ToInt32(num);
            isNumber = true;
        }catch(FormatException)
        {
            Console.WriteLine("Sorry this is not a number try again");
            isNumber = false;
        }
    }

    return newNumber;
}