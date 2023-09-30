Console.Write("Please enter a string:");
string str = Console.ReadLine();

int lowercase = 0, uppercase = 0;
for (var index = 0; index < str.Length; index++)
{
    var item = str[index];
    if (item>='a' && item<='z')
    {
        lowercase++;
    }

    if (item >= 'A' && item <= 'Z')
    {
        uppercase++;
    }

  
}

Console.WriteLine("Number of Character:" + str.Length);
Console.WriteLine("Number of LowerCase:" + lowercase);
Console.WriteLine("Number of Uppercase:" + uppercase);
