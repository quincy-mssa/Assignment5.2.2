using static System.Net.Mime.MediaTypeNames;

namespace Assignment5._2._2
{
    internal class Program
    {
        //Write a program in C# Sharp to print the first n natural number using recursion.
        //Test Data :
        //How many numbers to print : 10
        //Expected Output :
        //1 2 3 4 5 6 7 8 9 10
        static void Main(string[] args)

        {
            string input = Console.ReadLine();
            int number = Convert.ToInt32(input);
            NaturalNumbers(number);

        }

        static void NaturalNumbers(int num) 
        
        {
            if (num > 0)
            {

                NaturalNumbers(num - 1);

                Console.WriteLine(num);
            }

        }
    }
}
