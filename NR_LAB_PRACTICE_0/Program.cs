using System.Linq.Expressions;

/* 
    Nara Park CPRG 211 F 
    Lab 0: Basics of C# 
    Jan - 13 - 2024
 
 */
namespace Lab_0
{
    class Program
    {
        // Task 1: Creating Variables
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a low number: ");
            int lowNum = GetLowNumber();
            int highNum = GetHighNumber(lowNum);
            int difference = highNum - lowNum;
            Console.WriteLine($"The diffrence value is {difference}.");

            //Task 3: Using Arrays and File I/O
            int[] numArray = CreateArray(lowNum, highNum);
            SaveArrayFile(numArray, "C:/Users/narapark7561/Desktop/SECOND SEMESTER/CPRG211/oop2 Labs/NR_LAB_PRACTICE_0/numbers.txt");




        }

        // Task 2 : Looping and Input Validation
        public static int GetLowNumber()
        {
            int newLow;
            while (true)
            {
                string userInput = Console.ReadLine();
                bool t = int.TryParse(userInput, out newLow);
                if (t && newLow > 0)
                {
                    return newLow;
                }
                else
                {
                    Console.WriteLine("It's not lower number, please enter again");
                }

            }
        }

        public static int GetHighNumber(int lowNum)
        {
            int newHigh = 0;
            Console.WriteLine("Please enter a high number: ");
            while (true)
            {
                string userInput = Console.ReadLine();
                bool t = int.TryParse(userInput, out newHigh);
                if (t && newHigh > lowNum)
                {
                    return newHigh;
                }
                else
                {
                    Console.WriteLine($"Invalid input, please re-enter a number greater than {lowNum}");
                }
            }

        }

        // Task 3: Using Arrays and File I/O

        public static int[] CreateArray(int lowNum, int highNum)
        {
            int[] array = new int[highNum - lowNum + 1];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = lowNum + i;
            }
            return array;
        }

        public static void SaveArrayFile(int[] array, string fileName)
        {
            using (StreamWriter sw = new StreamWriter(fileName))
            {
                for (int i = array.Length - 1; i >= 0; i--)
                {
                    sw.WriteLine(array[i]);
                }
            }
        }
    }
}
