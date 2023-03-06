using System;

public class TimeChecker
{
	public TimeChecker()
	{
		Console.WriteLine("Write a date in 00:00 format");
		string inputTime = Console.ReadLine();

		string[] separatedTime = inputTime.Split(':');

		int hours = int.Parse(separatedTime[0]);
		int minutes = int.Parse(separatedTime[1]);

		bool isHoursCorrect = hours >= 0 && hours <= 23;
		bool isMinutesCorrect = minutes >= 0 && minutes <= 59;

		if (isHoursCorrect && isMinutesCorrect)
		{
			Console.WriteLine("Ok");
		}
		else {
			Console.WriteLine("invalid time");
		}
	}
}


