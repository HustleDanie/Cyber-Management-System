using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<string> userList = new List<string>();
        List<string> passwordList = new List<string>();
        int option = 0;

        Console.WriteLine("Welcome to the Cyber Management System!");

        do
        {
            Console.WriteLine("\nPlease select an option:");
            Console.WriteLine("1. Add user");
            Console.WriteLine("2. Remove user");
            Console.WriteLine("3. View all users");
            Console.WriteLine("4. Exit");

            int.TryParse(Console.ReadLine(), out option);

            switch (option)
            {
                case 1:
                    Console.WriteLine("\nEnter new user's name:");
                    string username = Console.ReadLine();
                    Console.WriteLine("\nEnter new user's password:");
                    string password = Console.ReadLine();
                    userList.Add(username);
                    passwordList.Add(password);
                    Console.WriteLine("\nUser added successfully.");
                    break;

                case 2:
                    Console.WriteLine("\nEnter user's name to remove:");
                    string removeUser = Console.ReadLine();
                    int index = userList.IndexOf(removeUser);

                    if (index >= 0)
                    {
                        userList.RemoveAt(index);
                        passwordList.RemoveAt(index);
                        Console.WriteLine("\nUser removed successfully.");
                    }
                    else
                    {
                        Console.WriteLine("\nUser not found.");
                    }
                    break;

                case 3:
                    Console.WriteLine("\nAll users:");
                    for (int i = 0; i < userList.Count; i++)
                    {
                        Console.WriteLine(userList[i]);
                    }
                    break;

                case 4:
                    Console.WriteLine("\nExiting program...");
                    break;

                default:
                    Console.WriteLine("\nInvalid option selected. Please try again.");
                    break;
            }

        } while (option != 4);

        Console.ReadKey();
    }
}
