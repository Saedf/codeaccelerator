Console.Write("Please enter a number greater than 100: ");
int number =int.Parse( Console.ReadLine());


bool isPrime=false;
if (number >= 100)
{
  for (int i = 0; i <=number; i++)
    {
        int n = 1; int count = 0;
        while (n < i)
        {
            if (i % n == 0)
                count++;
            n++;
           
        }
       
        if (count < 2)
            Console.Write(i + " ");
    }
   
}
else
{
    Console.WriteLine("Number is not greater than 100....");
}
