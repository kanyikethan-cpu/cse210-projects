using System;

class Program
{
    static void Main(string[] args)

    {
        Journal journal=new Journal();
        string choice="";
        string[] prompts =
        {
            "Who was the most interesting person I interacted with today?",
            "What was the best part of my day?",
            "What was the strongest emotion I felt today?",
            "What did I learn today?",
            "If I had one thing I could do over today, what would it be?"
        };

        Random random = new Random();
        while(choice!="5")
        {
            Console.WriteLine("Please select one of the following options:");
            Console.WriteLine("1. Write a new entry");
            Console.WriteLine("2. Display the journal");
            Console.WriteLine("3. Save the journal to the file");
            Console.WriteLine("4. Load the journal from the file");
            Console.WriteLine("5. Quit");
            Console.WriteLine("What would you want to do?");
            choice=Console.ReadLine();

            if(choice=="1")
            {
                Entry entry=new Entry();
                entry._date=DateTime.Now.ToString("MM/dd/yyyy");
                int index=random.Next(prompts.Length);
                entry._prompt=prompts[index];
                Console.WriteLine(entry._prompt);
                Console.Write("Your response:");
                entry._response=Console.ReadLine();
                journal._entries.Add(entry);
                
            }

            else if (choice=="2")
            {
                journal.DisplayAll();
            }
            
            else if(choice=="3")
            {
                Console.Write("Enter the name of the file you want to save it as: ");
                string filename=Console.ReadLine();
                journal.SaveToFile(filename);
                Console.WriteLine("Journal saved successfully");
            }

            else if(choice=="4")
            {
                Console.Write("What file do you want to load? ");
                string loadname=Console.ReadLine();
                journal.LoadFromFile(loadname);
                Console.WriteLine("Journal loaded successully.");
            }

            else if(choice=="5")
            {
                Console.WriteLine("Thank you for your time");

            }

            else
            {
                Console.WriteLine("Invalid Choice");
            }
        }  
    }
}