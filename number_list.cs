using Systems;
using Systems.Collections.Generic;

public class commaSeperated_numbers
{
	public static void Main(string[] args)
	{
		Console.WriteLine("Enter the comma seperated numbers");
		var input = Console.ReadLine();

		string[] sub_string = input.Split(',');

		foreach(var s in sub_string)
		{
			Console.WriteLine(Conver.ToInt32(s);
		}
	}
}

