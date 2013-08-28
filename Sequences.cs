using System.Collections.Generic;

namespace fibonacci
{
    public class Sequences
    {
        /// <summary>
        /// Creates Fibonacci sequence. Length depends on quantityOfNumbers.
        /// </summary>
        /// <param name="quantityOfNumbers">Length of sequence.</param>
        public static void fibonacciSequence(int quantityOfNumbers)
        {
            List<int> fNumbers = new List<int>();
            int firstNumber = 0;
            int secondNumber = 1;
            int fNumber;

            for (int i = 0; i < quantityOfNumbers; i++)
            {

                fNumber = firstNumber + secondNumber;
                firstNumber = secondNumber;
                secondNumber = fNumber;
                fNumbers.Add(fNumber);
            }


            foreach (int number in fNumbers)
                //write numbers to Label eg. Label.Text += +' '+number; or replace void with List<int> and return the list //

        }

    }
}