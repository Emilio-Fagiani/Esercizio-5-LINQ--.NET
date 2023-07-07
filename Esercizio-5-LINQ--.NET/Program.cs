class Program
{
    static void Main()
    {

        List<double> numbers =  new List<double> {2.5,7.5,6.2,82.6,42,46.2,12.5 };

        double sum = numbers.Sum();
        double avg = numbers.Average();
        int count = numbers.Count();

        Console.WriteLine("Sum : " + sum);
        Console.WriteLine("Avg : " + avg);
        Console.WriteLine("Count items : " + count);

    }
}