namespace random1111
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter number");
            Random rnd = new Random();
            int random = rnd.Next(1, 100);
            while (true)
            {
                int number = Convert.ToInt32(Console.ReadLine());
                if (number > random)
                {
                    Console.WriteLine("less");
                }
                else if (number < random)
                {
                    Console.WriteLine("more");
                }
                else
                {
                    Console.WriteLine("right");
                    Console.WriteLine(random);                    
                    break;
                }
            }
        }
    }
}
