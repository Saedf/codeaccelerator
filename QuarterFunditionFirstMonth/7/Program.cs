
Console.WriteLine("Enter a date:(YYYY-MM-DD)");

Console.WriteLine();
Console.Write("Please Select an option:");

string input = Console.ReadLine();
DateTime dtUser=Convert.ToDateTime(input).Date;
DateTime dtToday=DateTime.Today.Date;
int year = dtUser.Year - dtToday.Year;
int month = dtUser.Month - dtToday.Month;
int day = dtUser.Day - dtToday.Day;
int diffOfDay = 0;
diffOfDay = (year * 365) + (month * 30) + day;
if (diffOfDay>1)
{
    Console.WriteLine("************************");
    Console.WriteLine();
    Console.WriteLine("{0} days remaining until this date", diffOfDay);
}
else
{
    Console.WriteLine("************************");
    Console.WriteLine();
    Console.WriteLine("{0} days have passed since this date",Math.Abs(diffOfDay));
}

