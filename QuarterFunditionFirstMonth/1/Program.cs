Console.Write("Please enter a string:");
string str=Console.ReadLine();
Console.WriteLine("Number of Character:"+str.Length);
int countLetter=0,countDigit=0,countSpecialWords = 0;
foreach (var item in str)
{
    if (Char.IsLetter(item))
    {
        countLetter++;
    }

    if (char.IsDigit(item))
    {
        countDigit++;
    }
    if (!char.IsLetter(item)&& !char.IsDigit(item))
    {
        countSpecialWords++;
    }


}

Console.WriteLine("Number of Letters:" + countLetter);
Console.WriteLine("Number of Digits:" + countDigit);
Console.WriteLine("Number of SpecialWords:" + countSpecialWords);
