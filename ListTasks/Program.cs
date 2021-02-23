using System;
using System.Collections.Generic;

namespace ListTasks
{
    class Program
    {
        static void Main(string[] args)
        {
            // Add a generic list named shoppingList that accepts String values to the class
            List<string> shoppingList = new List<string>();

            // Add shopping products to the shoppingList including "juice", "bread", "butter" and "cheese".
            shoppingList.Add("garlic");
            shoppingList.Add("juice");
            shoppingList.Add("bread");
            shoppingList.Add("butter");
            shoppingList.Add("cheese");
            shoppingList.Add("cashews");


            // Using the PrintList() method print items of the shoppingList out to the console.
            PrintList(shoppingList);


            // Research and add ingredients of the quiche to the shoppingList.
            shoppingList.Add("eggs");
            shoppingList.Add("pastry");
            shoppingList.Add("spinich");
            shoppingList.Add("tomatoes");
            shoppingList.Add("onion");

            // Add a space
            Console.WriteLine();

            //Using the PrintList() method print items of the updated shoppingList out to the console.
            PrintList(shoppingList);
            
            // As you have decided to cook quiche, you do not need to buy bread and juice. 
            // Remove those elements from the List.

            shoppingList.Remove("bread");
            shoppingList.Remove("juice");

            // Add a space
            Console.WriteLine();

            // Using the PrintList() method print items of the updated shoppingList out to the console.
            PrintList(shoppingList); 

            Console.ReadLine();

        }

        public static void PrintList(List<string> listItems)
        {
            foreach (string item in listItems)
            {
                Console.WriteLine(item);
            }
        }
    }
}
