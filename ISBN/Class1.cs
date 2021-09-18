using System;

namespace ISBN
{
    public class ISBN
    {
        public static bool ValidISBN10(string input)
        {
            return false;
        }


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
                catch (System.Exception)
                {

                    throw new ArgumentException();
                }

            }
            else
            {
                throw new ArgumentNullException();
            }

        }
    }
}
