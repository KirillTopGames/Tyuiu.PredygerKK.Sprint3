namespace DELETEME
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str = "sxxrrg x vfrx";
            foreach (char c in str)
            {
                if (c == 'x')
                {
                    str = str.Replace(c, '2');
                }
            }
            Console.WriteLine(str);
        }
    }
}
