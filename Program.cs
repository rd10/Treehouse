using System;

namespace Treehouse.CodeChallenges
{
    class Program
    {
        static void Main()
        {
          Console.Write("Enter the number of times to print \"Yay!\": ");
          int num = 0;

          try
          {
            num = Convert.ToInt32(Console.ReadLine());
          }
          catch(FormatException fe)
          {
            Console.Write("You must enter a whole number.");

          }

          int i = 0;

          while(i < num) //counter is less than typed number
          {
              i++; //add 1 to the counter each time you loop
              Console.Write("Yay!");
          }

        }
    }
}
