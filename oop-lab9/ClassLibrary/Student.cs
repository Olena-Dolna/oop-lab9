using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Student : Person
    {
        protected int Course { get; set; }
        protected string Group { get; set; }
        protected string Faculty { get; set; }
        protected string University { get; set; }
        public Student(string name, string surname, int day, int month, long year, int course, string group, string faculty, string university) : base(name, surname, day, month, year)
        {
            Course = course;
            Group = group;
            Faculty = faculty;
            University = university;
        }
        public Student(string name, string surname, int course, string group, string university) : base(name, surname)
        {
            Course = course;
            Group = group;
            Faculty = string.Empty;
            University = university;
        }
        public Student() : base()
        {
            Course = 0;
            Group = string.Empty;
            Faculty = string.Empty;
            University = string.Empty;
        }
        public Student(Student duplicate) : base(duplicate)
        {
            Course = duplicate.Course;
            Group = duplicate.Group;
            Faculty = duplicate.Faculty;
            University = duplicate.University;
        }
        public int GetCourse()
        {
            return Course;
        }
        public string GetGroup()
        {
            return Group;
        }
        public string GetFaculty()
        {
            return Faculty;
        }
        public string GetUniversity()
        {
            return University;
        }
        public void SetCourse(int course)
        {
            Course = course;
        }
        public void SetGroup(string group)
        {
            Group = group;
        }
        public void SetFaculty(string faculty)
        {
            Faculty = faculty;
        }
        public void SetUniversity(string university)
        {
            University = university;
        }
        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine($"Курс:{Course,4} | Група:{Group,6} | Факультет:{Faculty,6} | ВНЗ:{University,30}");
        }
    }
}
