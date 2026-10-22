using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace doruk11g
{
    using System;

    public class Student
    {
        private int id;
        private string name;
        private int age;
        private int grade;
        private double averageScore;
        private decimal fee;
        private char classLetter;
        private DateTime birthDate;

        public int Id
        {
            get => id;
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException(nameof(value), "Идентификаторът трябва да бъде положително цяло число.");
                }
                id = value;
            }
        }

        public string Name
        {
            get => name;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Името не може да бъде празно или само интервали.", nameof(value));
                }
                name = value;
            }
        }

        public int Age
        {
            get => age;
            set
            {
                if (value < 6 || value > 20)
                {
                    throw new ArgumentOutOfRangeException(nameof(value), "Възрастта трябва да бъде между 6 и 20 години.");
                }
                age = value;
            }
        }

        public int Grade
        {
            get => grade;
            set
            {
                if (value < 1 || value > 12)
                {
                    throw new ArgumentOutOfRangeException(nameof(value), "Класът трябва да бъде между 1 и 12.");
                }
                grade = value;
            }
        }

        public double AverageScore
        {
            get => averageScore;
            set
            {
                if (value < 2.00 || value > 6.00)
                {
                    throw new ArgumentOutOfRangeException(nameof(value), "Средният успех трябва да бъде между 2.00 и 6.00.");
                }
                averageScore = value;
            }
        }

        public decimal Fee
        {
            get => fee;
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException(nameof(value), "Таксата не може да бъде отрицателна.");
                }
                fee = value;
            }
        }

        public bool HasScholarship { get; set; }

        public char ClassLetter
        {
            get => classLetter;
            set
            {
                if (!char.IsLetter(value))
                {
                    throw new ArgumentException("Паралелката трябва да е буква.", nameof(value));
                }
                classLetter = value;
            }
        }

        public DateTime BirthDate
        {
            get => birthDate;
            set
            {
                if (value > DateTime.Now)
                {
                    throw new ArgumentOutOfRangeException(nameof(value), "Датата на раждане не може да е бъдеща дата.");
                }
                birthDate = value;
            }
        }

        public Student(int id, string name)
        {
            Id = id;
            Name = name;
        }
    }
}
