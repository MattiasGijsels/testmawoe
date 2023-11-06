namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please give the number you want to display the sum of");
            int num = Convert.ToInt32(Console.ReadLine());
            int num0,sum = 0;
            for (num0=1;num0<=num;num0++)
            {
                sum += num0;
            }
            Console.WriteLine($"The sum of natural numbers up to term {num} = {sum}");
        }  
    }
}