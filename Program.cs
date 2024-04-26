using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CowsAndBulls
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Cows and Bulls Starter Framework Code

  Console.ReadLine();
  bool valid = false;
  int numGuesses = 1;
  int Cows = 0;
 int Bulls = 0;
 Random rand = new Random();
 int firstDigit = rand.Next(1, 10);
 Random rand2 = new Random();
 int secondDigit = rand2.Next(0, 10);
 while (firstDigit == secondDigit)
 {
     secondDigit = rand.Next(0, 10);
 }
 int thirdDigit = rand2.Next(0, 10);
 while (firstDigit == thirdDigit || thirdDigit == secondDigit)
 {
     thirdDigit = rand.Next(0, 10);
 }
 int fourthDigit = rand2.Next(0, 10);
 while (fourthDigit == thirdDigit || fourthDigit == secondDigit || fourthDigit == firstDigit)
 {
     fourthDigit = rand2.Next(0, 10);
 }

            
 Console.WriteLine("Enter a 4 digit number");
 string guess = Console.ReadLine();
 string guessFirstChar = guess.Substring(0, 1);
 string guessSecondChar = guess.Substring(1, 1);
 string guessThirdChar = guess.Substring(2, 1);
 string guessFourthChar = guess.Substring(3, 1);
 string firstChar = Convert.ToString(firstDigit);
 string secondChar = Convert.ToString(secondDigit);
 string thirdChar = Convert.ToString(thirdDigit);
 string fourthChar = Convert.ToString(fourthDigit);


 while (Bulls < 4)
 {
     while (valid == false)
     {
         while (guess.Length != 4 || guess.Substring(0,1) == "0")
         {
             Console.WriteLine("Enter a 4 digit number with unique digits and not beginning with 0.");
             guess = Console.ReadLine();
         }
         guessFirstChar = guess.Substring(0, 1);
         guessSecondChar = guess.Substring(1, 1);
         guessThirdChar = guess.Substring(2, 1);
         guessFourthChar = guess.Substring(3, 1);
         firstChar = Convert.ToString(firstDigit);
         secondChar = Convert.ToString(secondDigit);
         thirdChar = Convert.ToString(thirdDigit);
         fourthChar = Convert.ToString(fourthDigit);


         if (guessFirstChar == guessSecondChar || guessFirstChar == guessThirdChar || guessFirstChar == guessFourthChar)
         {
             Console.WriteLine("Invalid. Try again");
             guess = Console.ReadLine();
             guessFirstChar = guess.Substring(0, 1);
             guessSecondChar = guess.Substring(1, 1);
             guessThirdChar = guess.Substring(2, 1);
             guessFourthChar = guess.Substring(3, 1);
             firstChar = Convert.ToString(firstDigit);
             secondChar = Convert.ToString(secondDigit);
             thirdChar = Convert.ToString(thirdDigit);
             fourthChar = Convert.ToString(fourthDigit);
         }
         else if (guessFourthChar == guessSecondChar || guessSecondChar == guessThirdChar)
         {

             Console.WriteLine("Invalid. Try again");
             guess = Console.ReadLine();
             guessFirstChar = guess.Substring(0, 1);
             guessSecondChar = guess.Substring(1, 1);
             guessThirdChar = guess.Substring(2, 1);
             guessFourthChar = guess.Substring(3, 1);
             firstChar = Convert.ToString(firstDigit);
             secondChar = Convert.ToString(secondDigit);
             thirdChar = Convert.ToString(thirdDigit);
             fourthChar = Convert.ToString(fourthDigit);
         }
         else if (guessThirdChar == guessFourthChar)
         {

             Console.WriteLine("Invalid. Try again");
             guess = Console.ReadLine();
             guessFirstChar = guess.Substring(0, 1);
             guessSecondChar = guess.Substring(1, 1);
             guessThirdChar = guess.Substring(2, 1);
             guessFourthChar = guess.Substring(3, 1);
             firstChar = Convert.ToString(firstDigit);
             secondChar = Convert.ToString(secondDigit);
             thirdChar = Convert.ToString(thirdDigit);
             fourthChar = Convert.ToString(fourthDigit);
         }
         else { valid = true; }
     }
     int guess2 = Convert.ToInt32(guess);
     if (valid == true)
     {
         Bulls = 0;
         Cows = 0;

         if (guessFirstChar == firstChar)
         {
             Bulls++;
         }
         else if (guessFirstChar == secondChar)
         {
             Cows++;
         }
         else if (guessFirstChar == thirdChar)
         {
             Cows++;
         }
         else if (guessFirstChar == fourthChar)
         {
             Cows++;
         }

         if (guessSecondChar == secondChar)
         {
             Bulls++;
         }
         else if (guessSecondChar == firstChar)
         {
             Cows++;
         }
         else if (guessSecondChar == thirdChar)
         {
             Cows++;
         }
         else if (guessSecondChar == fourthChar)
         {
             Cows++;
         }
         if (guessThirdChar == thirdChar)
         {
            Bulls++;
         }
         else if (guessThirdChar == secondChar)
         {
             Cows++;
         }
         else if (guessThirdChar == firstChar)
         {
             Cows++;
         }
         else if (guessThirdChar == fourthChar)
         {
             Cows++;
         }
         if (guessFourthChar == fourthChar)
         {
             Bulls++;
         }
         else if (guessFourthChar == secondChar)
         {
             Cows++;
         }
         else if (guessFourthChar == thirdChar)
         {
             Cows++;
         }
         else if (guessFourthChar == firstChar)
         {
             Cows++;
         }
         if (Bulls == 4)
         {
             Console.WriteLine("Correct! You took " + numGuesses + " guesses");
         }
         else
         {
             Console.WriteLine("Bulls: " + Bulls);
             Console.WriteLine("Cows: " + Cows);
             numGuesses = numGuesses + 1;
             valid = false;
             Console.WriteLine("Enter a 4 digit number");
              guess = Console.ReadLine();
              guessFirstChar = guess.Substring(0, 1);
              guessSecondChar = guess.Substring(1, 1);
             guessFirstChar = guess.Substring(2, 1);
             guessFirstChar = guess.Substring(3, 1);
             guessFirstChar = Convert.ToString(firstDigit);
             guessFirstChar = Convert.ToString(secondDigit);
             guessFirstChar = Convert.ToString(thirdDigit);
             guessFirstChar = Convert.ToString(fourthDigit);
                    }            
                }           
            }          
        }
    }
}
