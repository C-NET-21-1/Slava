using System;

namespace Student_Class
{
    class UI
    {
        public static ConsoleKey ChooseMenu()
        {
            Console.WriteLine("Would you like to enter a new student's data by hand or use a random one?");
            Console.WriteLine("Press 1 or 2");

            ConsoleKey key = Console.ReadKey().Key;
            Console.WriteLine();

            return key;
        }

        public static void PrintStudent(Student person)
        {
            Console.Write($"\nStudent: {person.GetName()} {person.GetLastName()} \nId: {person.GetStudNumber()}" +
                    $"\nStudent since: {person.GetEnterDate().ToShortDateString()}");
        }

        public static string GetName(string text = "Enter student's name: ")
        {
            Console.Write(text);

            string name = ValidationName(Console.ReadLine());

            return name;
        }

        public static string ValidationName(string name)
        {
            for (int i = 0; i < name.Length; i++)
            {
                if (char.IsLetter(name[i]))
                {
                    continue;
                }
                else
                {
                    Console.WriteLine("Invalid Name!");
                    break;
                }
            }

            return name;
        }

        public static string GetLastName(string text = "Last Name: ")
        {
            Console.Write(text);

            string lastName = ValidationLastName(Console.ReadLine());

            return lastName;
        }

        public static string ValidationLastName(string lastName)
        {
            for (int i = 0; i < lastName.Length; i++)
            {
                if (char.IsLetter(lastName[i]))
                {
                    continue;
                }
                else
                {
                    Console.WriteLine("Invalid Last Name!");
                    break;
                }
            }

            return lastName;
        }

        public static uint GetStudNumber(string text = "Id: ")
        {
            Console.Write(text);
            string studNumber = Console.ReadLine();
            uint result = 0;

            if (ValidationStudNumber(studNumber))
            {
                result = uint.Parse(studNumber);
            }
            else
            {
                Console.WriteLine("Invalid Number!");
            }

            return result;
        }

        public static bool ValidationStudNumber(string input)
        {
            uint number = 0;

            return uint.TryParse(input, out number);
        }

        public static DateTime GetEnterDate(string text = "Date of entering: ")
        {
            Console.Write(text);
            DateTime.TryParse(Console.ReadLine(), out DateTime result);

            return result;
        }

        public static void PrintYear(Student person)
        {
            Console.Write("Year: {0}\n", BL.GetYear(person));
        }

        public static void PrintShortName(Student person)
        {
            Console.Write("Short name: {0}\n", BL.GetShortName(person));
        }

        public static string AlterDataOfStudent()
        {
            Console.WriteLine("\n\nWhat kind of student's data do you want to alter?");
            Console.WriteLine("Commands: name, lastname, id, date, year, shortname, exit.");
            string yourAlter = Console.ReadLine().ToLower();

            return yourAlter;
        }

        public static void PrintWarning()
        {
            Console.WriteLine("Try again!");
        }
    }
}
