using System;
using System.Collections.Generic;

namespace Challenge1
{
    class Program
    {
        static void Main(string[] args)
        {
                Random rand = new Random();
                 string askToRollDice = "";

                List<int> numList = new List<int>();
            
            while(askToRollDice != "N") 
            {
                Console.Write("Roll Dice? Enter Y or N: ");
                askToRollDice = Console.ReadLine();

                if ( askToRollDice == "Y" )
                {
                    int diceNumber = rand.Next(1,6);
                    Console.WriteLine("You rolled: " + diceNumber);
                    Console.WriteLine("");
                    numList.Add(diceNumber);
                }
            }
            Console.WriteLine("NoW its time to examine the results!");
             var result = String.Join(", ", numList.ToArray());
                    Console.WriteLine("[" + result + "]");
            Console.Write("How many dice rolls would you like to examine? ");
            string examineInput = Console.ReadLine();
            int examineCount =int.Parse(examineInput);
          

            int count = 0;
            int total = 0;
            if ( examineCount > numList.Count )
            {
                /*linked to user input, Do not allow more rows to be examined than exist*/
                examineCount = numList.Count;
            }
            for ( int i = 0 ; i < examineCount ; ++i )
            {
                total += numList[i];
                ++count;
            }

              Console.WriteLine("Your Guess Log");                    ;

                   


            Console.WriteLine("Average: " + (total/count));
            Console.WriteLine("Total: " + total); 

        }
    }
}
