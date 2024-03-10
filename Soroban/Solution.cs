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

       
        Dictionary<int, string> dict = new Dictionary<int, string>();
        dict.Add(1,"*|=*|***");
        dict.Add(2,"*|=**|**");
        dict.Add(3,"*|=***|*");
        dict.Add(4,"*|=****|");
        dict.Add(5,"|*=|****");
        dict.Add(6,"|*=*|***");
        dict.Add(7,"|*=**|**");
        dict.Add(8,"|*=***|*");
        dict.Add(9,"|*=****|");

        string answer = "";
        for(int i = 0; i< 8; i++)
        {
            for(int j = 0; j<n.Length;j++)
            {
                int c = int.Parse(n[j].ToString());
                answer += dict[c][i].ToString();
            }
            if(i!=7)
            {
                answer += "\n";
            }
        }
        Console.WriteLine(answer);
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