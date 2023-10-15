

DateTime dtToday = DateTime.Now;
int hour = dtToday.Hour;
int min = dtToday.Minute;
int seconds = dtToday.Second;
int diffSedconds = 0;
diffSedconds = (hour * 60 * 60) + (min * 60) + seconds;
Console.WriteLine("************************");
Console.WriteLine();
Console.WriteLine("{0} seconds have passed From the beginning of today", diffSedconds);


