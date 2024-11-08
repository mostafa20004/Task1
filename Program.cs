namespace frist
{
    internal class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("Number of small carpets:");            
            int value1 = int .Parse(Console.ReadLine());
            Console.WriteLine("Number of large carpets");
            int value2 = int .Parse(Console.ReadLine());
            Console.WriteLine($"Number of small room :$25");
            Console.WriteLine($"Number of large room :$35");
            double cost = (25 * value1 )+ (value2 * 35);
            double tax = cost * 0.06;
            Console.WriteLine($"Cost : {cost}");
            Console.WriteLine($"Tax : ${tax}");
            double totalEstimate = cost + tax;
            Console.WriteLine("===================================================");
            Console.WriteLine($"Total estimate:${totalEstimate}");
            Console.WriteLine("This estimate is valid for 30 days");


            

            Console.ReadLine();
            

        }
    }
}
