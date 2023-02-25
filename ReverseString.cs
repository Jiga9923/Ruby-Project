using System;
public class HelloWorld
{
    public static void Main(string[] args)
    {
       Console.WriteLine("Enter the name please");
       var name = Console.ReadLine();
       
       char[] reverseList = name.ToCharArray();
       
       string reverseName = String.Empty;
       
       foreach (var c in reverseList)
       {
           Console.WriteLine(c);
       }
       
       Console.WriteLine(reverseList.Length + "\n");
       Console.WriteLine();
     
       for (int i = reverseList.Length-1; i > -1; i--)
       {
            reverseName += reverseList[i];
       }
       
       Console.WriteLine(reverseName + "\n");
       
       foreach(var letter in reverseName)
       {
           Console.WriteLine(letter);
       }
       
       
    }
}