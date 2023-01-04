using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Person
    {
        protected string Name { get; set; }
        protected string Surname { get; set; }
        protected int Day { get; set; }
        protected int Month { get; set; }
        protected long Year { get; set; }
        public Person(string name, string surname, int day, int month, long year)
        {
            Name = name;
            Surname = surname;
            Day = day;
            Month = month;
            Year = year;
        }
        public Person(string name, string surname)
        {
            Name = name;
            Surname = surname;
            Day = 0;
            Month = 0;
            Year = 0;
        }
        public Person()
        {
            Name = string.Empty;
            Surname = string.Empty;
            Day = 0;
            Month = 0;
            Year = 0;
        }
        public Person(Person duplicate)
        {
            Name = duplicate.Name;
            Surname = duplicate.Surname;
            Day = duplicate.Day;
            Month = duplicate.Month;
            Year = duplicate.Year;
        }
        public string GetName()
        {
            return Name;
        }
        public string GetSurname()
        {
            return Surname;
        }
        public int GetDay()
        {
            return Day;
        }
        public int GetMonth()
        {
            return Month;
        }
        public long GetYear()
        {
            return Year;
        }
        public void SetName(string name)
        {
            Name = name;
        }
        public void SetSurname(string surname)
        {
            Surname = surname;
        }
        public void SetDay(int day)
        {
            Day = day;
        }
        public void SetMonth(int month)
        {
            Month = month;
        }
        public void SetYear(long year)
        {
            Year = year;
        }
        public virtual void ShowInfo()
        {
            Console.Write($"Ім'я:{Name,12} | Прізвище:{Surname,12} | ");
            if (Day == 0 || Month == 0 || Year == 0)
            {
                Console.Write($"Дата народження:\t| ");
            }
            else
            {
                Console.Write($"Дата народження:\t{Day}.{Month}.{Year}р.\t| ");
            }
        }
    }
}
