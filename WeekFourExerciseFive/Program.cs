
// Exercise 5
// Write a program named TemperaturesComparison that allows a user to:

// input five daily Fahrenheit temperatures that must range from -30 to 130
// if a temperature is out of range, requires the user to re-enter it.

// If no temperature is lower than any previous one, display a message 'Getting warmer'. If every temperature is lower than the previous, display
// a message 'Getting cooler'. If the temperatures are not entered in either ascending or descending order, display a message 'It’s a mixed bag'.
// Finally, display the temperatures in the order they were entered, and then display the average of the temperature.

class TemperaturesComparison
{
    static void Main(string[] args)
    {
        int inputTemp = 0;
        int[] temps = new int[5];
        int x;
        int MIN = -30;
        int MAX = 130;


        for (x = 0; x < temps.Length;++x)
        {
            Console.WriteLine("Enter temperature value {0} >> ", (x + 1));
            inputTemp = Convert.ToInt32(Console.ReadLine());

            if (inputTemp < MIN || inputTemp > MAX)
            {
                Console.WriteLine("The value is out of range...please enter another value btw - 30 & 130!");
                --x;
            }
        }
        // too long to complete...
    }
}