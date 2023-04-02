namespace assingment_5
{
    internal class Headtailpercentage
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter value number of flip :");
            int flip = Convert.ToInt32(Console.ReadLine());

            int head = 0, tail = 0, headcount = 0, tailcount = 0;
            double headpercentage, tailpercentage;
            for (int i = 0; i < flip; i++)
            {
                Random random = new Random();
                int coin = random.Next(2);
                if (coin == 0)
                {
                    Console.WriteLine("It's head");
                    head = 1;
                    headcount += 1;

                }
                else if (coin == 1)
                {
                    Console.WriteLine("It's tail");
                    tail = 1;
                    tailcount += 1;
                }

            }
            headpercentage = (headcount * 100) / flip;
            tailpercentage = (tailcount * 100) / flip;
            Console.WriteLine("number of head percentage" + " " + headpercentage + "%");
            Console.WriteLine("number of tail percentage" + " " + tailpercentage + "%");
        }
    }
}