namespace LinqTutorial_16dec2022_2;

internal class Program
{
    static void Main(string[] args)
    {
        var numbers = new List<int> { 5, 3, 7, 1, 2, 4 };
        var numbersWith10 = numbers.Append(10);

        //Console.WriteLine("Numbers: " + string.Join(", ", numbers));
        //Console.WriteLine("Numbers with 10: " + string.Join(", ", numbersWith10));

        //var oddNumbers = numbers.Where(number => number % 2 == 1);
        var orderdOddNumbers = numbers.Where(number => number % 2 == 1).OrderBy(number => number);

        Console.WriteLine("orderd odd numbers: " + string.Join(", ", orderdOddNumbers));

    }
}