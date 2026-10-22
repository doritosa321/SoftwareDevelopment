using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace doruk11g
{
    internal class Program
    {
  
        private static int nextId = 1;

        static void Main()
        {
            Console.WriteLine("=== РЕГИСТРАЦИЯ НА УЧЕНИК ===");

            int id = nextId++;
            string name = ReadName();

            Student student = new Student(id, name);

            student.Age = ReadAge();
            student.Grade = ReadGrade();
            student.AverageScore = ReadAverageScore();
            student.Fee = ReadFee();
            student.HasScholarship = ReadHasScholarship();
            student.ClassLetter = ReadClassLetter();
            student.BirthDate = ReadBirthDate();

            Console.WriteLine("\n=== ДАННИ ЗА УЧЕНИК ===");
            Console.WriteLine($"Id: {student.Id}");
            Console.WriteLine($"Име: {student.Name}");
            Console.WriteLine($"Възраст: {student.Age}");
            Console.WriteLine($"Клас: {student.Grade}");
            Console.WriteLine($"Среден успех: {student.AverageScore:F2}");
            Console.WriteLine($"Такса: {student.Fee:F2} лв.");
            Console.WriteLine($"Стипендия: {(student.HasScholarship ? "Да" : "Не")}");
            Console.WriteLine($"Паралелка: {student.ClassLetter}");
            Console.WriteLine($"Дата на раждане: {student.BirthDate:dd.MM.yyyy}");
        }

        private static string ReadName()
        {
            while (true)
            {
                try
                {
                    Console.Write("Vavedete ime: ");
                    string input = Console.ReadLine();
                    if (string.IsNullOrWhiteSpace(input))
                    {
                        throw new ArgumentException("Imeto ne moje da buda prazno ili samo intervali.");
                    }
                    return input;
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Grehka: {ex.Message} Molya, opitaite otnovo.");
                }
            }
        }

        private static int ReadAge()
        {
            while (true)
            {
                try
                {
                    Console.Write("Vavedete vazrast (6-20): ");
                    if (!int.TryParse(Console.ReadLine(), out int value))
                    {
                        throw new FormatException("Nevaliden format za cyalo chislo.");
                    }
                    Student temp = new Student(1, "Test");
                    temp.Age = value;
                    return value;
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Grehka: {ex.Message} Molya, opitaite otnovo.");
                }
            }
        }

        private static int ReadGrade()
        {
            while (true)
            {
                try
                {
                    Console.Write("Vavedete klas (1-12): ");
                    if (!int.TryParse(Console.ReadLine(), out int value))
                    {
                        throw new FormatException("Nevaliden format za cyalo chislo.");
                    }
                    Student temp = new Student(1, "Test");
                    temp.Grade = value;
                    return value;
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Grehka: {ex.Message} Molya, opitaite otnovo.");
                }
            }
        }

        private static double ReadAverageScore()
        {
            while (true)
            {
                try
                {
                    Console.Write("Vavedete sreden uspeH (2.00-6.00): ");
                    string input = Console.ReadLine();
                    if (!double.TryParse(input, NumberStyles.Any, CultureInfo.InvariantCulture, out double value) &&
                        !double.TryParse(input, out value))
                    {
                        throw new FormatException("Nevaliden format za chislo.");
                    }
                    Student temp = new Student(1, "Test");
                    temp.AverageScore = value;
                    return value;
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Grehka: {ex.Message} Molya, opitaite otnovo.");
                }
            }
        }

        private static decimal ReadFee()
        {
            while (true)
            {
                try
                {
                    Console.Write("Vavedete taksa: ");
                    string input = Console.ReadLine();
                    if (!decimal.TryParse(input, NumberStyles.Any, CultureInfo.InvariantCulture, out decimal value) &&
                        !decimal.TryParse(input, out value))
                    {
                        throw new FormatException("Nevaliden format za chislo.");
                    }
                    Student temp = new Student(1, "Test");
                    temp.Fee = value;
                    return value;
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Grehka: {ex.Message} Molya, opitaite otnovo.");
                }
            }
        }

        private static bool ReadHasScholarship()
        {
            while (true)
            {
                try
                {
                    Console.Write(" Poluchava li stipendia (true/false): ");
                    string input = Console.ReadLine()?.Trim().ToLower();
                    if (input == "true" || input == "1" || input == "yes")
                        return true;
                    if (input == "false" || input == "0" || input == "no")
                        return false;

                    throw new FormatException("Molya, vavedete true ili false.");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Grehka: {ex.Message} Molya, opitaite otnovo.");
                }
            }
        }

        private static char ReadClassLetter()
        {
            while (true)
            {
                try
                {
                    Console.Write("Vavedete paralelka (bukva): ");
                    string input = Console.ReadLine();
                    if (string.IsNullOrEmpty(input) || input.Length != 1)
                    {
                        throw new FormatException("Molya, vavedete tochno edin simvol.");
                    }
                    char value = input[0];
                    Student temp = new Student(1, "Test");
                    temp.ClassLetter = value;
                    return value;
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Grehka: {ex.Message} Molya, opitaite otnovo.");
                }
            }
        }

        private static DateTime ReadBirthDate()
        {
            while (true)
            {
                try
                {
                    Console.Write("Vavedete data na rajdane (dd.MM.yyyy): ");
                    string input = Console.ReadLine();
                    if (!DateTime.TryParseExact(input, "dd.MM.yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime value) &&
                        !DateTime.TryParse(input, out value))
                    {
                        throw new FormatException("Nevaliden format na data. Izpolzvaite dd.MM.yyyy.");
                    }
                    Student temp = new Student(1, "Test");
                    temp.BirthDate = value;
                    return value;
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Grehka: {ex.Message} Molya, opitaite otnovo.");
                }
            }
        }
    }
}

