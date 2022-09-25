using System;
using System.Collections.Generic;
using System.Linq;

namespace phone_book {
    class Program {
        static void Main(string[] args) {
            BookRecords records = new BookRecords();
            bool loop = true;
            do {
                Console.Write("     1-Add");
                Console.Write("     2-Delete");
                Console.Write("     3-Update");
                Console.Write("     4-List Records");
                Console.Write("     5-Search");
                Console.Write("     6-Exit");
                Console.WriteLine(" ");

                string choice = Console.ReadLine();
            
                switch (choice) {
                    case "1":
                        Console.WriteLine("First Name: ");
                        string firstName = Console.ReadLine();
                        Console.WriteLine("Last Name: ");
                        string lastName = Console.ReadLine();
                        Console.WriteLine("Phone Number: ");
                        string phoneNumber = Console.ReadLine();
                        records.contactAdd(firstName, lastName, phoneNumber);
                        break;
                    case "2":
                        Console.WriteLine("Please enter a name to delete a contact:");
                        string deletedName = Console.ReadLine();
                        records.contactDelete(deletedName);
                        break;
                    case "3":
                        records.contactUpdate();
                        break;
                    case "4":
                        records.listContacts();
                        break;
                    case "5":
                        records.contactSearch();
                        break;
                    case "6":
                        loop = false;
                        break;
                    default:
                        break;
                }
            } while (loop == true);           
        }
    }
    class BookRecords {
        private static List<PhoneBookConstants> contacts = new List<PhoneBookConstants>();
        private static List<PhoneBookConstants> newContacts = new List<PhoneBookConstants>();

        public BookRecords() {
            contacts.Add(new PhoneBookConstants() { 
                firstName = "Ahmet", 
                lastName = "Senocak", 
                phoneNumber = "05541283445",
            });
        }

        public void listContacts() {
            Console.WriteLine("Contacts");
            Console.WriteLine("**********************************************");
            foreach(var item in contacts) {
                Console.WriteLine($"Name:  {item.firstName}");
                Console.WriteLine($"Surname:  {item.lastName}");
                Console.WriteLine($"Phone Number:  {item.phoneNumber}");
            }
            Console.WriteLine($"In directory {contacts.Count()} contacts exists.");
        }

        public void contactAdd(string firstName, string lastName, string phoneNumber) {
            firstName = StringExtensions.FirstCharToUpper(firstName);
            lastName = StringExtensions.FirstCharToUpper(firstName);
            contacts.Add(new PhoneBookConstants() {
                firstName = firstName, 
                lastName = lastName, 
                phoneNumber = phoneNumber,
            });
        }

        public void contactDelete(string name) {
            newContacts = contacts;
            foreach(var item in newContacts) {
                if (item.firstName.ToLower() == name.ToLower() || item.lastName.ToLower() == name.ToLower()) {
                    contacts.Remove(item);
                    Console.WriteLine($"{name} successfully deleted");
                    break;
                } else {
                    Console.WriteLine($"There is no name such a {name}");
                }
            }
            this.listContacts();
        }

        public void contactUpdate() {
            List<PhoneBookConstants> updatedContacts = new List<PhoneBookConstants>();
            Console.WriteLine("Enter a name to update contact:");
            string updatedName = Console.ReadLine();
            foreach (var item in contacts) {
                if (item.firstName.ToLower() == updatedName.ToLower() || item.lastName.ToLower() == updatedName.ToLower()) {
                    Console.WriteLine("First Name: " + item.firstName);
                    Console.WriteLine("Last Name: " + item.lastName);
                    Console.WriteLine("Phone Number: " + item.phoneNumber);
                    Console.WriteLine();
                    Console.WriteLine("Enter a new name");
                    string firstName = Console.ReadLine();
                    Console.WriteLine("Enter a new surname");
                    string lastName = Console.ReadLine();
                    Console.WriteLine("Enter a phone number");
                    string phoneNumber = Console.ReadLine();
                    updatedContacts.Add(new PhoneBookConstants() {
                        firstName = firstName,
                        lastName = lastName,
                        phoneNumber = phoneNumber,
                    });
                    Console.WriteLine("Contact successfully updated!");
                } else {
                    updatedContacts.Add(new PhoneBookConstants() {
                        firstName = item.firstName,
                        lastName = item.lastName,
                        phoneNumber = item.phoneNumber,
                    });
                }
            }
            Console.WriteLine("To end update process: (1)");
            Console.WriteLine("To try again: (2)");
            string selection = Console.ReadLine();
            switch (selection) {
                case "1" :
                    contacts.Clear();
                    contacts = updatedContacts;
                    break;
                case "2":
                    contactUpdate();
                    break;
                default: 
                    break;
            }
        }

        public void contactSearch() {
            Console.WriteLine("Enter a type that you wanted search with:");
            Console.WriteLine(" **********************************************");
            Console.WriteLine();
            Console.WriteLine("To search with name (1) :");
            Console.WriteLine("To search with phone number (2) :");
            string selection = Console.ReadLine();
            if (selection == "1") {
                Console.WriteLine("Enter a name: ");
                string searchName = Console.ReadLine();
                foreach (var item in contacts) {
                    if (item.firstName.ToLower() == searchName.ToLower() || item.lastName.ToLower() == searchName.ToLower()) {
                        Console.WriteLine("First Name: " + item.firstName);
                        Console.WriteLine("Last Name: " + item.lastName);
                        Console.WriteLine("Phone Number: " + item.phoneNumber);
                        Console.WriteLine();
                    }
                }
            } else if (selection == "2") {
                Console.WriteLine("Enter a number: ");
                string searchNumber = Console.ReadLine();
                foreach (var item in contacts) {
                    if (item.phoneNumber == searchNumber) {
                        Console.WriteLine("First Name: " + item.firstName);
                        Console.WriteLine("Last Name: " + item.lastName);
                        Console.WriteLine("Phone Number: " + item.phoneNumber);
                        Console.WriteLine();
                    }
                }
            }
        }
    }
}