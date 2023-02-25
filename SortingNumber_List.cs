

using System;
using System.Collections.Generic;

public class HelloWorld
{
    public static void Main(string[] args)
    {
       Console.WriteLine("Enter 5 numbers");
       int num1 = Convert.ToInt32(Console.ReadLine());
      
       List<int> numberlist = new List<int>();
       numberlist.Add(num1);
       
       while(numberlist.Count < 5)
       {
           Console.WriteLine("Enter the next number");
           int num = Convert.ToInt32(Console.ReadLine());
           
           if(numberlist.Contains(num))
           {
               Console.WriteLine("Already Entered" + "\t");
           }
           else
           {
               numberlist.Add(num);
           }
       }
       
       numberlist.Sort();
       
       Console.WriteLine("The Sorted number are : " + "\n");
       
       foreach (var n in numberlist)
       {
           Console.WriteLine(n + "\n");
       }
     
      
    }
}