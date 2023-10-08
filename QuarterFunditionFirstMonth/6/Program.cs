var fileExists = File.Exists(pathFile);
int countWordWith4Character = 0;
string delim = " ,.";

string[]? fields;
var dict = new Dictionary<string, int>();

if (fileExists)
{

    var text = File.ReadAllText(pathFile);
    fields = text.ToLower().Split(delim.ToCharArray());

    for (var i = 0; i < fields.Length; i++)
    {

        for (int j = i + 1; j < fields.Length; j++)
        {
            if (fields[j] == fields[i] && fields[j].Length >= 4)
            {

                countWordWith4Character++;


                if (countWordWith4Character > 1)
                {
                    dict.Remove(fields[j]);
                    dict.Add(fields[j], countWordWith4Character);
                }
                else
                {
                    dict.Add(fields[j], countWordWith4Character);
                }

            }


        }


    }

    foreach (var item in dict)
    {

        Console.WriteLine("Word:{0}, {1}", item.Key, item.Value);

    }


}

