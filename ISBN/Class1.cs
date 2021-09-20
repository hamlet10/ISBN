using System;

namespace ISBN
{
    public class ISBN
    {
        public static void Input_Validator(string input)
        {
            if (!string.IsNullOrEmpty(input))
            {
                try
                {
                    foreach (var item in input)
                    {
                        if (!char.IsDigit(item)) throw new ArgumentException();
                    }
                }
                catch (FormatException)
                {

                    throw new FormatException();
                }
            }
            else
            {
                throw new ArgumentNullException();
            }

        }

        public static bool ISBNO10To13(string myInput)
        {
            int counter = 10;
            int[] myarray = new int[10];
            int totalSum = 0;
            for (int i = 0; i < myInput.Length; i++)
            {
                myarray[1] = Int32.Parse(myInput[i].ToString());
            }
            for (int i = 0; i < myarray.Length; i++)
            {
                totalSum += myarray[i] * counter;
                counter = --counter;
            }

            return (totalSum % 11 == 0) ? true : false;
        }

        public static bool ISBNO13To10(string myInput)
        {

            int[] myArray = new int[13];
            int totalSum = 0;
            for (int i = 0; i < myInput.Length; i++)
            {
                myArray[i] = int.Parse(myInput[i].ToString());
            }
            for (int i = 0; i < myArray.Length; i++)
            {
                int divisor = 0;
                divisor = (i % 2 == 0) ? 1 : 3;
                totalSum += myArray[i] * divisor;
            }
            return (totalSum % 10 == 0) ? true : false;
        }
    }
}
