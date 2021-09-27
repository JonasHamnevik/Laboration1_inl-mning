using System;

namespace Laboration1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Write the string you want to use: ");
            string input = Console.ReadLine();

            //string input = "29535123p48723487597645723645"; ////Koden från uppgiften hårdkodad som exempelkod

            long sum = 0;

            for (int i = 0; i < input.Length; i++)
            {
                if (!char.IsDigit(input[i]))
                {
                    continue; //Om char inte är en siffra så fortsätter den till nästa i loopen
                }
                for (int j = i + 1; j < input.Length; j++)
                {
                    if (!char.IsDigit(input[j]))
                    {
                        break; //Om char inte är en siffra avbryter den loopen och går tillbaka till första loopen
                    }
                    if (input[i] == input[j])
                    {
                        string substring = input.Substring(i, j - i + 1); //Substring innehållandes strängen vi vill markera
                        string substringPre = input.Substring(0, input.IndexOf(substring)); //Strängen som är innan den markerade
                        string substringPost = input.Substring(substring.Length + substringPre.Length,
                            (input.Length) - (substring.Length + substringPre.Length)); //Strängen som är efter den markerade

                        Console.Write(substringPre);
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write(substring);
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine(substringPost);

                        long result = long.Parse(substring);
                        sum += result;
                        break;
                    }
                }
            }
            Console.WriteLine("Total sum:");
            Console.Write(sum);
        }
    }
}
