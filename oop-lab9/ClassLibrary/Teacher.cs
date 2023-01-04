using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Teacher : Person
    {
        protected string Position { get; set; }
        protected string Department { get; set; }
        protected string University { get; set; }
        public Teacher (string name, string surname, int day, int month, long year, string position, string department, string university) : base(name, surname, day, month, year)
        {
            Position = position;
            Department = department;
            University = university;
        }
        public Teacher(string name, string surname, string position, string university) : base(name, surname)
        {
            Position = position;
            Department = string.Empty;
            University = university;
        }
        public Teacher() : base()
        {
            Position = string.Empty;
            Department = string.Empty;
            University = string.Empty;
        }
        public Teacher(Teacher duplicate) : base(duplicate)
        {
            Position = duplicate.Position;
            Department = duplicate.Department; 
            University = duplicate.University;
        }
        public string GetPosition()
        {
            return Position;
        }
        public string GetDepartment()
        {
            return Department;
        }
        public string GetUniversity()
        {
            return University;
        }
        public void SetPosition(string position)
        {
            Position = position;
        }
        public void SetDepartment(string department)
        {
            Department = department;
        }
        public void SetUniversity(string university)
        {
            University = university;
        }
        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine($"Посада:{Position,10} | Кафедра:{Department,20} | ВНЗ:{University,30}");
        }
    }
}
