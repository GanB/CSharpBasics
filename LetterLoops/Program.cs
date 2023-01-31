using System.Text;

namespace LetterLoops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Letter Loops");
            Console.WriteLine("Please enter a string:");

            var sb = new StringBuilder();
            bool isStringValid = false;
            string input;

            do
            {
                input = Console.ReadLine();
                isStringValid = !string.IsNullOrEmpty(input);

                if (!isStringValid)
                {
                    Console.WriteLine("Please enter a valid string:");
                }
                else
                {
                    sb.Append(char.ToUpper(input[0]));

                    for (int i = 1; i < input.Length; i++)
                    {
                        sb.Append("-");
                        sb.Append(char.ToUpper(input[i]));
                        sb.Append(new String(char.ToLower(input[i]), i));

                    }
                    Console.WriteLine(sb);
                }
            } while (!isStringValid);
        }
    }
}