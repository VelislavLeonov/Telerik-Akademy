using System;
/*Problem 11. Bank Account Data

A bank account has a holder name (first name, middle name and last name), available amount of money (balance), bank name, IBAN, 3 credit card numbers associated with the account.
Declare the variables needed to keep the information for a single bank account using the appropriate data types and descriptive names.*/

namespace BankAccountData
{
    class BankAccountData
    {
        static void Main(string[] args)
        {
            string firstName = "Ivan";
            string middleName = "Ivanov";
            string lastName = "Ivanov";
            object holderName = firstName + " " + middleName + " " + lastName;
            decimal avAmountOfMoney = 1523.14m;
            string bankName = "Alpha Bank";
            string iban = "BG48CRBA2030006633";
            ulong ccNumber1 = 4436221000522u;
            ulong ccNumber2 = 5444000000122u;
            ulong ccNumber3 = 4439223000144u;
            Console.WriteLine("Account holder:{0}\nAccount balance:{1}\nBank name:{2}\nIBAN:{3}\nCredit card 01:{4}\nCredit card 02:{5}\nCredit card 03:{6}", holderName, avAmountOfMoney, bankName, iban, ccNumber1, ccNumber2, ccNumber3);
        }
    }
}
