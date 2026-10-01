using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
   

    class TaskItem
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime DueDate { get; set; }
        public bool IsCompleted { get; set; }

        public TaskItem(string title, string description, DateTime dueDate)
        {
            Title = title;
            Description = description;
            DueDate = dueDate;
            IsCompleted = false;
        }
    }

    class Program
    {
        static List<TaskItem> tasks = new List<TaskItem>();

        static void Main()
        {
            while (true)
            {
                Console.Clear();

                Console.WriteLine("===== TodoManager =====");
                Console.WriteLine("1. Добави нова задача");
                Console.WriteLine("2. Покажи всички задачи");
                Console.WriteLine("3. Маркирай задача като изпълнена");
                Console.WriteLine("4. Изтрий задача");
                Console.WriteLine("5. Изход");
                Console.WriteLine("=======================");
                Console.Write("Избери опция: ");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        AddTask();
                        break;

                    case "2":
                        ShowTasks();
                        break;

                    case "3":
                        CompleteTask();
                        break;

                    case "4":
                        DeleteTask();
                        break;

                    case "5":
                        Console.WriteLine("Програмата приключи.");
                        return;

                    default:
                        Console.WriteLine("Невалидна опция!");
                        Pause();
                        break;
                }
            }
        }

        static void AddTask()
        {
            Console.Clear();
            Console.WriteLine("===== Добавяне на задача =====");

            Console.Write("Заглавие: ");
            string title = Console.ReadLine();

            Console.Write("Описание: ");
            string description = Console.ReadLine();

            DateTime dueDate;

            while (true)
            {
                Console.Write("Краен срок (дд.ММ.гггг): ");

                if (DateTime.TryParse(Console.ReadLine(), out dueDate))
                {
                    break;
                }

                Console.WriteLine("Невалидна дата! Опитай отново.");
            }

            TaskItem newTask = new TaskItem(title, description, dueDate);

            tasks.Add(newTask);

            Console.WriteLine("Задачата е добавена успешно!");
            Pause();
        }

        static void ShowTasks()
        {
            Console.Clear();
            Console.WriteLine("===== Всички задачи =====");

            if (tasks.Count == 0)
            {
                Console.WriteLine("Няма въведени задачи.");
                Pause();
                return;
            }

            for (int i = 0; i < tasks.Count; i++)
            {
                TaskItem task = tasks[i];

                string status = task.IsCompleted
                    ? "Изпълнена"
                    : "Неизпълнена";

                Console.WriteLine();
                Console.WriteLine($"Задача #{i + 1}");
                Console.WriteLine($"Заглавие: {task.Title}");
                Console.WriteLine($"Описание: {task.Description}");
                Console.WriteLine($"Краен срок: {task.DueDate:dd.MM.yyyy}");
                Console.WriteLine($"Статус: {status}");
                Console.WriteLine("-------------------------");
            }

            Pause();
        }

        static void CompleteTask()
        {
            Console.Clear();
            Console.WriteLine("===== Маркиране като изпълнена =====");

            if (tasks.Count == 0)
            {
                Console.WriteLine("Няма въведени задачи.");
                Pause();
                return;
            }

            ShowTaskNames();

            Console.Write("Въведи номер на задачата: ");

            if (int.TryParse(Console.ReadLine(), out int number))
            {
                if (number >= 1 && number <= tasks.Count)
                {
                    tasks[number - 1].IsCompleted = true;

                    Console.WriteLine("Задачата е маркирана като изпълнена.");
                }
                else
                {
                    Console.WriteLine("Невалиден номер на задача.");
                }
            }
            else
            {
                Console.WriteLine("Моля, въведи число.");
            }

            Pause();
        }

        static void DeleteTask()
        {
            Console.Clear();
            Console.WriteLine("===== Изтриване на задача =====");

            if (tasks.Count == 0)
            {
                Console.WriteLine("Няма въведени задачи.");
                Pause();
                return;
            }

            ShowTaskNames();

            Console.Write("Въведи номер на задачата за изтриване: ");

            if (int.TryParse(Console.ReadLine(), out int number))
            {
                if (number >= 1 && number <= tasks.Count)
                {
                    tasks.RemoveAt(number - 1);

                    Console.WriteLine("Задачата е изтрита успешно.");
                }
                else
                {
                    Console.WriteLine("Невалиден номер на задача.");
                }
            }
            else
            {
                Console.WriteLine("Моля, въведи число.");
            }

            Pause();
        }

        static void ShowTaskNames()
        {
            for (int i = 0; i < tasks.Count; i++)
            {
                string status = tasks[i].IsCompleted
                    ? "[X]"
                    : "[ ]";

                Console.WriteLine($"{i + 1}. {status} {tasks[i].Title}");
            }
        }

        static void Pause()
        {
            Console.WriteLine();
            Console.WriteLine("Натисни Enter за продължаване...");
            Console.ReadLine();
        }
    }

}
