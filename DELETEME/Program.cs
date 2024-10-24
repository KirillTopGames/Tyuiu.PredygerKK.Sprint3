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
            do
            {
                b++;
                b = a + c;
                c = b - a;
                d = (a + c) - i;
                i++;
            } while (i < 4);
            Console.WriteLine(d);

        }
    }
}
