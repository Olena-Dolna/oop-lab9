using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Reader : Person
    {
        protected int TicketNumber { get; set; }
        protected int DayOfIssue { get; set; }
        protected int MonthOfIssue { get; set; }
        protected long YearOfIssue { get; set; }
        protected double MonthlyFee { get; set; }
        public Reader (string name, string surname, int day, int month, long year, int ticketNumber, int iDay, int iMonth, long iYear, double monthlyFee) : base(name, surname, day, month, year)
        {
            TicketNumber = ticketNumber;
            DayOfIssue = iDay;
            MonthOfIssue = iMonth;
            YearOfIssue = iYear;
            MonthlyFee = monthlyFee;
        }
        public Reader(string name, string surname, int ticketNumber, double monthlyFee) : base(name, surname)
        {
            TicketNumber = ticketNumber;
            DayOfIssue = 0;
            MonthOfIssue = 0;
            YearOfIssue = 0;
            MonthlyFee = monthlyFee;
        }
        public Reader() : base()
        {
            TicketNumber = 0;
            DayOfIssue = 0;
            MonthOfIssue = 0;
            YearOfIssue = 0;
            MonthlyFee = 0;
        }
        public Reader(Reader duplicate) : base(duplicate)
        {
            TicketNumber = duplicate.TicketNumber;
            DayOfIssue = duplicate.DayOfIssue;
            MonthOfIssue = duplicate.MonthOfIssue;
            YearOfIssue = duplicate.YearOfIssue;
            MonthlyFee = duplicate.MonthlyFee;
        }
        public int GetTicketNumber()
        {
            return TicketNumber;
        }
        public int GetDayOfIssue()
        {
            return DayOfIssue;
        }
        public int GetMonthOfIssue()
        {
            return MonthOfIssue;
        }
        public long GetYearOfIssue()
        {
            return YearOfIssue;
        }
        public double GetDayMonthlyFee()
        {
            return MonthlyFee;
        }
        public void SetTicketNumber(int ticketNumber)
        {
            TicketNumber = ticketNumber;
        }
        public void SetDayOfIssue(int iDay)
        {
            DayOfIssue = iDay;
        }
        public void SetMonthOfIssue(int iMonth)
        {
            MonthOfIssue = iMonth;
        }
        public void SetYearOfIssue(int iYear)
        {
            YearOfIssue = iYear;
        }
        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.Write($"Номер читацького квитка:{TicketNumber,6} | ");
            if (DayOfIssue == 0 || MonthOfIssue == 0 || YearOfIssue == 0)
            {
                Console.Write($"Дата видачі:\t");
            }
            else
            {
                Console.Write($"Дата видачі:\t{DayOfIssue}.{MonthOfIssue}.{YearOfIssue}р.\t| ");
            }
            Console.WriteLine("Щомісячний внесок:" + MonthlyFee.ToString("F2") + " грн. ");
        }
    }
}
