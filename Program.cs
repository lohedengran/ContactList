using System;
using System.Collections.Generic;
using System.Linq;

namespace ContactList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> contacts = new List<Person>();

            AddContact(contacts);
            PrintList(contacts);
            RemoveContact(contacts);
            SortList(contacts);
        }


        private static void PrintList(List<Person> contacts)
        {
            foreach (Person item in contacts)
            {
                Console.WriteLine($"Name: {item.FirstName}. Phonenumber: {item.PhoneNumber}. E-mail: {item.EMail}");
            }
        }

        private static void AddContact(List<Person> contacts)
        {
            bool addContact = true;
            do
            {
                Console.WriteLine("Would you like to add a contact? Press Y");
                string answer = Console.ReadLine();
                answer = answer.ToLower();
                if (answer == "y")
                {
                    Console.WriteLine("Name of contact?");
                    string firstName = Console.ReadLine();
                    Console.WriteLine("Phonenumber to contact?");
                    string phoneNumber = Console.ReadLine();
                    Console.WriteLine("E-mail to contact?");
                    string eMail = Console.ReadLine();
                    Person contact = new Person(firstName, phoneNumber, eMail);
                    contacts.Add(contact);
                }
                else
                {
                    addContact = false;
                }
            } while (addContact);
        }
        private static void RemoveContact(List<Person> contacts)
        {
           
         
            bool removeContact = true;
            do
            {

                Console.WriteLine("Would you like to remove a contact? Press Y.");
                string answer = Console.ReadLine();
                answer = answer.ToLower();
                if (answer == "y")
                {
                    PrintList(contacts);
                    Console.Write("Enter name of contact to be removed: ");
                    string input = Console.ReadLine();
                    for (int i = 0; i < contacts.Count; i++)
                    {
                        if (contacts[i].FirstName == input)
                        {
                            contacts.Remove(contacts[i]);
                        } 
                    }
                    Console.WriteLine("Updated list of contacts: ");
                    PrintList(contacts);
                }
                else
                {
                    removeContact = false;
                }
            } while (removeContact);
        }

        private static void SortList(List<Person> contacts)
        {
            contacts.OrderBy(contacts => contacts.FirstName);
            Console.WriteLine("The list in alphabetical order: ");
            PrintList(contacts);
        }

    }
}
