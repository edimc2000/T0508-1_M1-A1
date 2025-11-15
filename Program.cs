using System;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Module 1 Activity 1 Calculate the Average");

        // Create a console application in C# that calculates the average of three numbers entered by the user.
        // To calculate the average, summarize all the values and divide by the number of values.
        // For example, if the entered numbers are: 1,2,5
        // sum of values = 1 + 2 + 5 = 8
        // number of values = 3
        // ⇒average = 8 / 3 = 2.667

        int[] inputNums = new int[3];
        string values = "";

        for (int i = 1; i < 4; i++)
        {
            inputNums[i - 1] = captureInput(i, inputNums);
            values += inputNums[i - 1] + (i == 3 ? "" : " + ");
        }
        Console.WriteLine("Sum of values \t: " + values + " = " + inputNums.Sum());
        Console.WriteLine("Average is \t: " + inputNums.Average().ToString("F3"));
    }


    /// <summary>
    /// Prompts user for integer input with validation and retry logic.
    /// Continuously asks for input until a valid integer is provided.
    /// Displays error messages for invalid inputs and allows retry.
    /// </summary>
    public static int captureInput(int i, int[] inputNums)
    {
        int result = 0;
        bool validInput = false;

        while (!validInput)
        {
            try
            {
                Console.Write("Enter number " + i + "\t: ");
                result = Convert.ToInt32(Console.ReadLine());
                validInput = true;
            }
            catch (Exception err)
            {
                Console.WriteLine($" Error: {err.Message}");
                Console.WriteLine(" Please enter a valid integer. Try again.");
            }
        }
        return result;
    }
}
