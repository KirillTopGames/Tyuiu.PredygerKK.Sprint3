namespace DELETEME
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 4;
            int b = 2;
            int c = 1;
            int d = 9;
            int i = 1;
            while(i < 5)
            {
                a--;
                b -= a;
                c = b - a;
                d = (c + a) - i;
                i++;
            }
            Console.WriteLine(d);
        }
    }
}
