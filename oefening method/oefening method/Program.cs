namespace oefening_method
{
    internal class Program
    {

        /*static void Main(string[] args)
        {
            Sum();
        }

        private static void Sum()
        {
            Console.WriteLine("Please give the first number you would like to multiply");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Please give the second number you would like to multiply");
            double y = Convert.ToDouble(Console.ReadLine());
            double result = (x + y);
            Console.WriteLine("The Sum of the two numbers is " + result);

        }*/
        static void Main(string[] args)
        {
            Console.WriteLine("Please give in the sentence you would like the longest word from");
            LangsteWoord();
           
        }

        private static void LangsteWoord()
        {
            string line = Console.ReadLine() ?? "";
            string[] words = line.Split(new[] { " " }, StringSplitOptions.None);
            string word = "";
            int ctr = 0;
            foreach (String s in words)
            {
                if (s.Length > ctr)
                {
                    word = s;
                    ctr = s.Length;
                }
            }

            Console.WriteLine($"You wrote the followign sentence " + line + " and the longest word of that sentence is " + word);

        }

        /*private static void Counting()
        {
            bool inputnull = true;
            int count;
            string name = "";

            while (inputnull)
            {
                Console.WriteLine("Please Give the sentence you would like to see the spaces count of");
                name = Console.ReadLine() ?? "";

                if (string.IsNullOrEmpty(name))
                {
                    Console.WriteLine("Your input is invalid, dingmush");
                }
                else
                {
                    inputnull = false;  
                }
            }
            count = name.Split(' ').Length;
            Console.WriteLine("The count is " + count);
        }*/

    }
}