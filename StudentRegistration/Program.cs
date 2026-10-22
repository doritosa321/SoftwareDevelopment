namespace StudentRegistration
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Начало на програмата");
            try
            {
                Console.Write("Въведете число: ");
                int number = int.Parse(Console.ReadLine());

                Console.WriteLine($"Въведохте: {number}");
            }
            catch
            {
                Console.WriteLine("Грешка! Трябва да въведете число.");
            }
            finally
            {
                Console.WriteLine("Край на програмата");
            }
                


            Console.Write("Въведете възраст: ");
            if (int.TryParse(Console.ReadLine(), out int age))
            {
                Console.WriteLine($"Възраст: {age}");
            }
            else
            {
                Console.WriteLine("Невалидна възраст.");
            }
            Console.Write("Въведете клас: ");
            if (byte.TryParse(Console.ReadLine(), out byte studentClass))
            {
                Console.WriteLine($"Клас: {studentClass}");
            }
            else
            {
                Console.WriteLine("Невалиден клас. Моля, въведете число между 0 и 255.");
            }
            Console.Write("Въведете среден успех: ");
            if (double.TryParse(Console.ReadLine(), out double averageGrade))
            {
                Console.WriteLine($"Среден успех: {averageGrade}");
            }
            else
            {
                Console.WriteLine("Невалиден среден успех.");
            }
            Console.Write("Въведете парична стойност: ");
            if (decimal.TryParse(Console.ReadLine(), out decimal summoney))
            {
                Console.WriteLine($"Парична стойност:{summoney}");
            }
            else
            {
                Console.Write("Невалидна парична стойност");
            }
            Console.Write("Въведете паралелка:");
            if(char.TryParse(Console.ReadLine(), out char classtype))
            {
                Console.WriteLine($"Паралелка: {classtype}");
            }
            else
            {
                Console.WriteLine("Невалидна стойност");
            }
            Console.Write("Въведете рожден ден:");
            if (DateTime.TryParse(Console.ReadLine(), out DateTime birthDate))
            {
                Console.WriteLine($"Дата: {birthDate:d}");
            }
            else
            {
                Console.WriteLine("Невалидна дата.");
            }

        }
    }
}
    