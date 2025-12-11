using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace StackQueueDemo
{
    internal class SortedListDemo
    {
        static void Main(string[] args)
        {
            SortedList<int,string> inventory = new SortedList<int, string>();
            inventory.Add(2001, "wheat-20kg");
            inventory.Add(2003, "rice-50kg");
            inventory.Add(2002, "sugar-30kg");
            inventory.Add(2004, "salt-10kg");

            Console.WriteLine("\n ***inventory details***");
            Console.WriteLine("first item code:" + inventory.Keys[0]);
            Console.WriteLine("last item code:" + inventory.Values[inventory.Count - 1]);
            foreach (var item in inventory)
            {
                Console.WriteLine("key:" + item.Key + "value:" + item.Value);
                
            }

            // Search by key

            Console.WriteLine("enter key to search:");
            int keyToSearch = Convert.ToInt32(Console.ReadLine());
            if (inventory.ContainsKey(keyToSearch))
            {
                Console.WriteLine("Item found: " + inventory[keyToSearch]);
            }
            else
            {
                Console.WriteLine("item not found");
            }

            // Search by value
            Console.WriteLine("enter value to search");
            string valueToSearch = Console.ReadLine();
            if (inventory.ContainsValue(valueToSearch))
            {
                Console.WriteLine("item found with key:" + inventory.IndexOfValue(valueToSearch));

            }
            else
            {
                Console.WriteLine("item not found");
            }

            // Update the value
            Console.WriteLine("Enter key to update value");
            int keyToUpdate = Convert.ToInt32(Console.ReadLine());  
            string newValue = Console.ReadLine();
            inventory[keyToUpdate] = newValue;
            Console.WriteLine("upadted value" + inventory[keyToUpdate]);

            //Remove by key
            Console.WriteLine("removing item code 2003");
            inventory.Remove(2003);
            Console.WriteLine("After removal of 2003");
            foreach (var item in inventory)
            {
                Console.WriteLine("key:" + item.Key +"value:"+ item.Value);
                
            }

            //Remove  by Index
            inventory.RemoveAt(0);
            Console.WriteLine("after removal of index 0");
            foreach (var item in inventory)
            {
                Console.WriteLine("key:" + item.Key + "value:" + item.Value);
            }


            // Get index of key
            Console.WriteLine("index of key 2002" + inventory.IndexOfKey(2002));

            inventory.Clear();
            Console.ReadLine();
        }
        
    }
}
