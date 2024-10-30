namespace DELETEME
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int count1 = 0;
            int x;
            for (x = 2; x <= 5; x++)
            {
                for (int d = 1; d <= x; d++)
                {
                    if(x % d == 0) 
                    {
                        count1++;
                    }
                }
            }
            Console.WriteLine(count1);
        }
    }
}
