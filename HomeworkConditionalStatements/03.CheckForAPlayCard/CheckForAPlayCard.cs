using System;
/*Problem 3. Check for a Play Card

Classical play cards use the following signs to designate the card face: `2, 3, 4, 5, 6, 7, 8, 9, 10, J, Q, K and A.
 Write a program that enters a string and
 prints “yes” if it is a valid card sign or “no” otherwise. Examples:*/

namespace CheckForAPlayCard
{
    class CheckForAPlayCard
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter card:");
            string a = Convert.ToString(Console.ReadLine());
            if (a == "2" | a == "3" | a == "4" | a == "5" | a == "6" | a == "7" |a == "8" | a == "9" | a == "10" |a == "J" | a == "Q" | a == "K" | a == "A")
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}
