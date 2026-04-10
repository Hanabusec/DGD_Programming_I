// See https://aka.ms/new-console-template for more information
using System.Globalization;

Console.WriteLine("Hello, World!");

var numbers = new[] {8,12,-5,5,-9,6 };
int negativeNumbersCounter;


var onlyPositive = GetOnlyPositive(numbers,out negativeNumbersCounter);

//var onlyNegative = GetOnlyPositive(numbers);

foreach(var positiveNumber in onlyPositive)
{
    Console.WriteLine(positiveNumber);
}

Console.WriteLine("Negative number count is: " + negativeNumbersCounter);

//foreach (var onlyNegativeNumber in onlyNegative)
//{
//    Console.WriteLine(onlyNegativeNumber);
//}

Console.ReadKey();
List<int> GetOnlyPositive(int[] numbers, out int NegatifSayılarAdedi)
{
    NegatifSayılarAdedi = 0;
    var result = new List<int>();

    //var negativeNumbers = new List<int>();

    foreach (int number in numbers)
    {
        if(number > 0)
        {
            result.Add(number);
        }
        else
        {
            NegatifSayılarAdedi++;
            //negativeNumbers.Add(number);    
        }
    } 
    return result;
    //return negativeNumbers;
}
