using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.PredygerKK.Sprint3.Task3.V14.Lib
{
    public class DataService : ISprint3Task3V14
    {
        public string ReplaceCharInString(string value, char replaceable, char replacement)
        {
            foreach (char symbol in value)
            {
                if(symbol == replaceable)
                {
                    value = value.Replace(symbol, replacement);
                }
            }
            return value;
        }
    }
}
