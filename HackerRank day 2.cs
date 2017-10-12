using System;
using System.Collections.Generic;
using System.IO;
class Solution
{
    static void Main(String[] args)
    {
        /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */

        //read in values line by line !!MAKE SURE YOU KEEP IN ORDER!!
        double meal = double.Parse(Console.ReadLine());
        //meal = 2.3
        int tipPer = int.Parse(Console.ReadLine());
        //tipPer = 4
        int taxPer = int.Parse(Console.ReadLine());
        //taxPer = 6


        double tip = meal * tipPer / 100;
        // 2.3 * 0.04 = 0.092
        double tax = meal * taxPer / 100;
        // 2.3 * 0.06 = 0.138
        double total = meal + tip + tax;
        //2.3 + 0.092 + 0.138 = 2.53
        Console.WriteLine("The total meal cost is {0} dollars.", Math.Round(total));
        //send total to stout after using Math.Round to round to integer
        // {0} uses the value straight after so Console.WriteLine("hello {0} is my {1}",this,world); 
        //would read hello this is my world as {0} would pull the first value and {1} the second being this a string and world
        //when it pulls total Math.Round(total) it gets the result of Math.Round(total) as an int idk why its an int though maybe 
        //its a string


        //example
        //2.3
        //4
        //6

    }
}