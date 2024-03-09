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
        
        //Reverse the order to get starting value
        digits.Reverse();
        Dictionary<int, string> dict = new Dictionary<int, string>();
        dict.Add(1,"*|=*|***");
        dict.Add(2,"*|=**|**");
        dict.Add(3,"*|=***|*");
        dict.Add(4,"*|=****|");
        dict.Add(6,"|*=*|***");
        dict.Add(7,"|*=**|**");
        dict.Add(8,"|*=***|*");
        dict.Add(9,"|*=****|");

        for(int i=0; i<8; i++)
        {
            foreach(BigInteger digi in digits){
                dict.TryGetValue((int)digi, out string printNum);
                foreach(int key in dict.Keys)
                {
                    if(digi == key)
                    {
                    Console.WriteLine(printNum[i]);

                    }
                }
            } 
        }      



      
        // Write an answer using Console.WriteLine()
        // To debug: Console.Error.WriteLine("Debug messages...");
        
        // Console.WriteLine("*****");
        // Console.WriteLine("|||||");
        // Console.WriteLine("=====");
        // Console.WriteLine("***|*");
        // Console.WriteLine("*|***");
        // Console.WriteLine("****|");
        // Console.WriteLine("|****");
        // Console.WriteLine("**|**");
    }
}