using System;
using System.Collections.Generic;
class Program
{
    static void Main(string[] args)
    {
       List<int> numbers=new List<int>();
       int userNumber=-2; 

       while(userNumber!=0)
        {
            Console.Write("Enter any number of your choice other than 0 that you want to input? ");
            string response=Console.ReadLine();
            userNumber=int.Parse(response);

            if(userNumber!=0)
            {
                numbers.Add(userNumber);
            }
        }

        int sum=0;
        foreach(int number in numbers)
        {
            sum+=number;
        }
            Console.WriteLine($"The sum of the numbers you have selected is {sum}");
        

        int countNumbers=numbers.Count;
        float average=(float)sum/countNumbers;
        Console.WriteLine($"The average of the numbers you have selected is {average}");

        int max=numbers[0];
        foreach(int number in numbers)
        {
            if(number>max)
            {
                max=number;
            }
        }
        Console.WriteLine($"The largest number you entered is {max}");
    }
}