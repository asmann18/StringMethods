using System.Text;

namespace StringMethods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Daxil edin");
            string sentence = Console.ReadLine().ToLower().Trim();
            sentence=FormatString(sentence);
            Console.WriteLine(sentence);
        }
        static string FormatString(string text)
        {
            StringBuilder stringBuilder = new StringBuilder();
            for (int i = 0; i < text.Length; i++)
            {
                if(i==0)
                {
                    stringBuilder.Append(char.ToUpper(text[i]));
                }
                else if (char.IsWhiteSpace(text[i]))
                {
                    if (!char.IsWhiteSpace(text[i+1])) 
                    {
                        stringBuilder.Append(text[i]);
                        stringBuilder.Append(char.ToUpper(text[i+1]));
                        i++;
                    }
                }
                else
                {
                    stringBuilder.Append(text[i]);
                }
            }
            return stringBuilder.ToString();
        }
    }
}