using System;
using System.Collections.Generic;
using System.Xml.Serialization;




namespace LibraryCatalogue
{
    class Program
    {
        
        static void Main(string[] args)
        {
            
            int choice;

            Console.WriteLine("Enter a file name");
            string fileName = Console.ReadLine();

            CardCatalogue myCardCatalogue = new CardCatalogue(fileName);
            do
            {
                choice = PromptUserForNumber(
                    string.Format("Would you like to 1.LIst all Books, 2.Add a book, or 3.Save and Exit ?"));
                              
                if (choice == 1)
                {

                    myCardCatalogue.ListBooks();
                }
                else if (choice == 2)
                {

                    myCardCatalogue.AddBook();
                }
                else if (choice == 3)
                {
                     myCardCatalogue.Save();
                }              
            } while (choice != 3);
        }
                  
        private static int PromptUserForNumber(string promptString = "Enter a number")
        {
            int num;
            string input = "";
            while (!int.TryParse(input, out num))
            {
                Console.WriteLine(promptString);
                input = Console.ReadLine();
            }
            return num;
        }

    }
}
