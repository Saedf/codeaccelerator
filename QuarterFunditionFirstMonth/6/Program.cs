string pathFile = "E:\\text.txt";
var fileExists = File.Exists(pathFile);
int countWords = 0;
int countWordWith4Character = 0;
string delim = " ,.";

string[] fields = null;
string words4char="";


if (fileExists)
{

     var text = File.ReadAllText(pathFile);
    fields = text.ToLower().Split(delim.ToCharArray());
    ////string[] lines = File.ReadAllLines(pathFile);
    for (var i = 0; i < fields.Length; i++)
    {
        //var line = lines[i];

        //Console.WriteLine(line);



        for (int j = i + 1; j < fields.Length; j++)
        {
            if (fields[j].Equals(fields[i]) && fields[j].Length>=4)
            {
                countWordWith4Character++;
                words4char = fields[j];
                
                //    Console.WriteLine("Count of words that are with more 4 Character :" + words4char);
               
            }

           
        }
       
        countWords++;
       
    }

    Console.WriteLine("*****************************");
    //Console.WriteLine("Count Line:" + lines.Length);
    if (countWordWith4Character > 1)
    {
        Console.WriteLine("Count of words that are with more 4 Character :{0}", words4char + " :" + countWordWith4Character);
    }
    Console.WriteLine("Count all of words in File :" + countWords);
   
          
    // Console.WriteLine("Count of words that are with more 4 Character :" + countLineWith4Character + " " + words4char);

}
Console.ReadKey();
//String string1 = "Big black bug bit a big black dog on his big black nose";
//int count;

////Converts the string into lowercase  
//string1 = string1.ToLower();

////Split the string into words using built-in function  
//String[] words = string1.Split(' ');

//Console.WriteLine("Duplicate words in a given string : ");
//for (int i = 0; i < words.Length; i++)
//{
//    count = 1;
//    for (int j = i + 1; j < words.Length; j++)
//    {
//        if (words[i].Equals(words[j]))
//        {
//            count++;
//            //Set words[j] to 0 to avoid printing visited word  
//            words[j] = "0";
//        }
//    }

//    //Displays the duplicate word if count is greater than 1  
//    if (count > 1 && words[i] != "0")
//        Console.WriteLine(words[i]);
//}