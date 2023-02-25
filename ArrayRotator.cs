using System;
using System.Collections.Generic;
using System.Collections;

public class ArrayRotator
{
    public static void Main(string[] args)
    {

        var numbers = new List<int>();
        
        Console.WriteLine("Enter the list of numbers");
        var input = Console.ReadLine();
        
        foreach (var num in input.Split(','))
        {
            numbers.Add(Convert.ToInt32(num));
        }
        
        Console.WriteLine("Enter the number to iterate on left for that many times");
        int r = Convert.ToInt32(Console.ReadLine());
        
       // Console.WriteLine(arr.Count);
        
        int ctr = 0;
        int temp = 0;
        
        while(ctr < r)
        {
            temp = numbers[0];
            Console.WriteLine("The Value of temp is {0}" ,temp);
            for(int i = 1; i < numbers.Count; i++)
            {
                numbers[i-1] = numbers[i];
              //  Console.WriteLine(" The new i value is : {0}", arr[i]);
               /* Console.WriteLine("The new list");
                foreach(var num in arr)
                {
                    Console.WriteLine(num);
                }*/
            }
            numbers[numbers.Count-1] = temp;
            Console.WriteLine("The Value of last index is : {0}", numbers[numbers.Count-1]);
            ctr++;
        }
        
         Console.WriteLine("The Final list");
                foreach(var num in numbers)
                {
                    Console.WriteLine(num);
                }
        
       
    }
}