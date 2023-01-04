using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary;

namespace oop_lab9
{
    internal class Program
    {
        static void Menu()
        {
            Console.WriteLine("1 - Ввести інформацію про людей");
            Console.WriteLine("2 - Вивести інформацію про людей");
            Console.WriteLine("0 - Вихід");
        }
        static int IntCorrect()
        {
            int n;
            bool isCorrect = false;
            do
            {
                isCorrect = int.TryParse(Console.ReadLine(), out n);
                if (isCorrect == false)
                {
                    Console.WriteLine("Помилка введення значення! Будь ласка, повторіть введення ще раз!");
                }
            } while (!isCorrect);
            return n;
        }
        static double DoubleCorrect()
        {
            double n;
            bool isCorrect = false;
            do
            {
                isCorrect = double.TryParse(Console.ReadLine(), out n);
                if (isCorrect == false)
                {
                    Console.WriteLine("Помилка введення значення! Будь ласка, повторіть введення ще раз!");
                }
            } while (!isCorrect);
            return n;
        }
        static long LongCorrect()
        {
            long n;
            bool isCorrect = false;
            do
            {
                isCorrect = long.TryParse(Console.ReadLine(), out n);
                if (isCorrect == false)
                {
                    Console.WriteLine("Помилка введення значення! Будь ласка, повторіть введення ще раз!");
                }
            } while (!isCorrect);
            return n;
        }
        static void CategoryMenu()
        {
            Console.WriteLine("\tОберіть категорію для людини:");
            Console.WriteLine("1 - Абітурієнт");
            Console.WriteLine("2 - Студент");
            Console.WriteLine("3 - Викладач");
            Console.WriteLine("4 - Користувач бібліотеки");
        }
        static Entrant[] ReadEntrants()
        {
            Console.WriteLine("Введіть кількість абітурієнтів: ");
            int entrantsNumber = IntCorrect();
            Entrant[] entrants = new Entrant[entrantsNumber];
            for (int i = 0; i < entrantsNumber; i++)
            {
                Console.WriteLine($"\nАбітурієнт N{i + 1}");
                Console.Write("Ім'я: ");
                string name = Console.ReadLine();
                Console.Write("Прізвище: ");
                string surname = Console.ReadLine();
                Console.WriteLine("Дата народження");
                Console.Write("День: ");
                int day = IntCorrect();
                Console.Write("Місяць: ");
                int month = IntCorrect();
                Console.Write("Рік: ");
                long year = LongCorrect();
                Console.Write("Бали за ЗНО: ");
                int znoPoints = IntCorrect();
                Console.Write("Бали атестата: ");
                double certificatePoints = DoubleCorrect();
                Console.Write("Назва закладу: ");
                string schoolName = Console.ReadLine();
                entrants[i] = new Entrant(name, surname, day, month, year, znoPoints, certificatePoints, schoolName);
            }
            return entrants;
        }
        static Student[] ReadStudents()
        {
            Console.WriteLine("Введіть кількість студентів: ");
            int studentsNumber = IntCorrect();
            Student[] students = new Student[studentsNumber];
            for (int i = 0; i < studentsNumber; i++)
            {
                Console.WriteLine($"\nСтудент N{i + 1}");
                Console.Write("Ім'я: ");
                string name = Console.ReadLine();
                Console.Write("Прізвище: ");
                string surname = Console.ReadLine();
                Console.WriteLine("Дата народження");
                Console.Write("День: ");
                int day = IntCorrect();
                Console.Write("Місяць: ");
                int month = IntCorrect();
                Console.Write("Рік: ");
                long year = LongCorrect();
                Console.Write("Курс: ");
                int course = IntCorrect();
                Console.Write("Група: ");
                string group = Console.ReadLine();
                Console.Write("Факультет: ");
                string faculty = Console.ReadLine();
                Console.Write("ВНЗ: ");
                string university = Console.ReadLine();
                students[i] = new Student(name, surname, day, month, year, course, group, faculty, university);
            }
            return students;
        }
        static Teacher[] ReadTeachers()
        {
            Console.WriteLine("Введіть кількість викладачів: ");
            int teachersNumber = IntCorrect();
            Teacher[] teachers = new Teacher[teachersNumber];
            for (int i = 0; i < teachersNumber; i++)
            {
                Console.WriteLine($"\nВикладач N{i + 1}");
                Console.Write("Ім'я: ");
                string name = Console.ReadLine();
                Console.Write("Прізвище: ");
                string surname = Console.ReadLine();
                Console.WriteLine("Дата народження");
                Console.Write("День: ");
                int day = IntCorrect();
                Console.Write("Місяць: ");
                int month = IntCorrect();
                Console.Write("Рік: ");
                long year = LongCorrect();
                Console.Write("Посада: ");
                string position = Console.ReadLine();
                Console.Write("Кафедра: ");
                string department = Console.ReadLine();
                Console.Write("ВНЗ: ");
                string university = Console.ReadLine();
                teachers[i] = new Teacher(name, surname, day, month, year, position, department, university);
            }
            return teachers;
        }
        static Reader[] ReadReaders()
        {
            Console.WriteLine("Введіть кількість користувачів бібліотеки: ");
            int readersNumber = IntCorrect();
            Reader[] readers = new Reader[readersNumber];
            for (int i = 0; i < readersNumber; i++)
            {
                Console.WriteLine($"\nКористувач N{i + 1}");
                Console.Write("Ім'я: ");
                string name = Console.ReadLine();
                Console.Write("Прізвище: ");
                string surname = Console.ReadLine();
                Console.WriteLine("Дата народження");
                Console.Write("День: ");
                int day = IntCorrect();
                Console.Write("Місяць: ");
                int month = IntCorrect();
                Console.Write("Рік: ");
                long year = LongCorrect();
                Console.Write("Номер читацького квитка: ");
                int ticketNumber = IntCorrect();
                Console.WriteLine("Дата видачі");
                Console.Write("День: ");
                int iDay = IntCorrect();
                Console.Write("Місяць: ");
                int iMonth = IntCorrect();
                Console.Write("Рік: ");
                long iYear = LongCorrect();
                Console.Write("Щомісячний внесок: ");
                double monthlyFee = DoubleCorrect();
                readers[i] = new Reader(name, surname, day, month, year, ticketNumber, iDay, iMonth, iYear, monthlyFee);
            }
            return readers;
        }
        static void Main(string[] args)
            {
            Console.OutputEncoding = Encoding.UTF8;
            System.Globalization.CultureInfo customCulture = (System.Globalization.CultureInfo)System.Threading.Thread.CurrentThread.CurrentCulture.Clone();
            customCulture.NumberFormat.NumberDecimalSeparator = ".";
            System.Threading.Thread.CurrentThread.CurrentCulture = customCulture;
            Console.Title = "Лабораторна робота N9";
            Entrant[] entrants = new Entrant[0];
            Student[] students = new Student[0];
            Teacher[] teachers = new Teacher[0];
            Reader[] readers = new Reader[0];
            int ch;
            do
            {
                Console.WriteLine("\nНатисніть будь-яку кнопку, щоб продовжити");
                Console.ReadKey();
                Console.Clear();
                Menu();
                ch = IntCorrect();
                switch (ch)
                {
                    case 1:
                        Console.Clear();
                        int c;
                        bool isWritten = false;
                        CategoryMenu();
                        do
                        {
                            c = IntCorrect();
                            switch (c)
                            {
                                case 1:
                                    Console.Clear();
                                    entrants = ReadEntrants();
                                    isWritten = true;
                                    break;
                                case 2:
                                    Console.Clear();
                                    students = ReadStudents();
                                    isWritten = true;
                                    break;
                                case 3:
                                    Console.Clear();
                                    teachers = ReadTeachers();
                                    isWritten = true;
                                    break;
                                case 4:
                                    Console.Clear();
                                    readers = ReadReaders();
                                    isWritten = true;
                                    break;
                                default:
                                    Console.WriteLine("Помилка введення значення! Будь ласка, повторіть введення ще раз!");
                                    break;
                            }
                        } while (!isWritten);
                       break;
                    case 2:
                        Console.Clear();
                        if (entrants == null || students == null || teachers == null || readers == null)
                        {
                            Console.WriteLine("Помилка! Не знайдено інформації про студентів!");
                        }
                        for (int i = 0; i < entrants.Length; i++)
                        {
                            Console.WriteLine($"\tАбітурієнт N{i + 1}");
                            entrants[0].ShowInfo();
                        }
                        Console.WriteLine();
                        for (int i = 0; i < students.Length; i++)
                        {
                            Console.WriteLine($"\tСтудент N{i + 1}");
                            students[0].ShowInfo();
                        }
                        Console.WriteLine();
                        for (int i = 0; i < teachers.Length; i++)
                        {
                            Console.WriteLine($"\tВикладач N{i + 1}");
                            teachers[0].ShowInfo();
                        }
                        Console.WriteLine();
                        for (int i = 0; i < readers.Length; i++)
                        {
                            Console.WriteLine($"\tКористувач бібліотеки N{i + 1}");
                            readers[0].ShowInfo();
                        }
                        break;
                    default:
                        Console.WriteLine("Помилка введення значення! Будь ласка, повторіть введення ще раз!");
                        break;

                }
            } while (ch != 0);
        } 
    }
}
