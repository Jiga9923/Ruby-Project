using System;
using System.Collections.Generic;

public class UniqueNumbers
{
    public static void Main(string[] args)
    {
       var numbers = new List<int>();
       
       while(true)
       {
           Console.WriteLine("Enter the number or quit to exit");
           var input = Console.ReadLine();
           
           if(input.ToLower() == "quit")
              break;
              
           numbers.Add(Convert.ToInt32(input));
       }
       
       var uniqueNumber = new List<int>();
       
       foreach(var num in numbers)
       {
           if(!uniqueNumber.Contains(num))
           uniqueNumber.Add(num);
       }
       
       foreach(var unum in uniqueNumber)
       {
           Console.WriteLine(unum);
       }
    }
}