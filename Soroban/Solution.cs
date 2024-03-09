using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Numerics;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;

/**
 * Auto-generated code below aims at helping you parse
 * the standard input according to the problem statement.
 **/
class Solution
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter Number: ");
        string n = Console.ReadLine();

        BigInteger bigInteger;
        BigInteger ten = 10;
        List<BigInteger> digits = new List<BigInteger>();

        if(BigInteger.TryParse(n, out bigInteger) == true)
        {
            //bigInteger now contains the value
            while(bigInteger > 0)
            {
                //get the far rightmost digit
                BigInteger digit = BigInteger.Remainder(bigInteger, ten);
                //add to the list
                digits.Add(digit);
                bigInteger = BigInteger.Divide(bigInteger, ten);

            }
        }
        else
        {
            //bigInteger now contains 0
        }
        foreach(BigInteger big in digits)
        {
            Console.WriteLine(big);
        }
        //48590
        //mod the number and store them, then reverse the array
        Console.WriteLine(digits);
        // while((int)n > 0)
        // {
        //     int digit = (int) n%10;
        //     digits.Add(digit);
        //     //update number
        //     n/=10;
        // }
        // Console.WriteLine(digits.Reverse());
        // Write an answer using Console.WriteLine()
        // To debug: Console.Error.WriteLine("Debug messages...");
        
        Console.WriteLine("*****");
        Console.WriteLine("|||||");
        Console.WriteLine("=====");
        Console.WriteLine("***|*");
        Console.WriteLine("*|***");
        Console.WriteLine("****|");
        Console.WriteLine("|****");
        Console.WriteLine("**|**");
    }
}