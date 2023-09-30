
Console.Write("Please enter a string:");
string str = Console.ReadLine();
string reverseStr=String.Empty;
for (int i = str.Length-1; i >= 0; i--)
{
    reverseStr += str[i];
}
Console.WriteLine("Reverse of string[{0}] : "+reverseStr,str);
