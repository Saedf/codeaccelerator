string pathFile = "D:\\text.txt";
var fileExists = File.Exists(pathFile);
int countWords = 0;
int countLineWith4Character = 0;
string delim = " ,.";

string[] fields = null;


if (fileExists)
{
   // var text = File.ReadAllText(pathFile);
    string[] lines = File.ReadAllLines(pathFile);
    for (var index = 0; index < lines.Length; index++)
    {
        var line = lines[index];
        
        Console.WriteLine(line);
       

        fields = line.Split(delim.ToCharArray());
        for (int i = 0; i < fields.Length; i++)
        {
            if (fields[i].Length>=4)
            {
                countLineWith4Character++;
            }
            countWords++;
        }
    }

    Console.WriteLine("*****************************");
    Console.WriteLine("Count Line:"+lines.Length);
    Console.WriteLine("Count all of words in File :"+countWords);
    Console.WriteLine("Count of words that are with more 4 Character :"+countLineWith4Character);

}
Console.ReadKey();

