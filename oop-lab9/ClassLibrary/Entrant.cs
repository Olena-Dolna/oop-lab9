using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Entrant : Person
    {
        protected int ZNOPoints { get; set; }
        protected double CertificatePoints { get; set; }
        protected string SchoolName { get; set; }
        public Entrant(string name, string surname, int day, int month, long year, int znoPoints, double certificatePoints, string schoolName) : base (name, surname, day, month, year)
        {
            ZNOPoints = znoPoints;
            CertificatePoints = certificatePoints;
            SchoolName = schoolName;
        }
        public Entrant (string name, string surname, int znoPoints, double certificatePoints) : base (name, surname)
        {
            ZNOPoints = znoPoints;
            CertificatePoints= certificatePoints;
            SchoolName = string.Empty;
        }
        public Entrant() : base()
        {
            ZNOPoints = 0;
            CertificatePoints = 0;
            SchoolName= string.Empty;
        }
        public Entrant (Entrant duplicate) : base (duplicate)
        {
            ZNOPoints = duplicate.ZNOPoints;
            CertificatePoints = duplicate.CertificatePoints;
            SchoolName = duplicate.SchoolName;
        }
        public int GetZNOPoints()
        {
            return ZNOPoints;
        }
        public double GetCertificatePoints()
        {
            return CertificatePoints;
        }
        public string GetSchoolName()
        {
            return SchoolName;
        }
        public void SetZNOPoints(int znoPoints)
        {
            ZNOPoints = znoPoints;
        }
        public void SetCertificatePoints(double certificatePoints)
        {
            CertificatePoints = certificatePoints;
        }
        public void SetSchoolName(string schoolName)
        {
            SchoolName = schoolName;
        }
        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine($"Бали за ЗНО:{ZNOPoints,6} | Бали атестата:{CertificatePoints,6} | Назва закладу:{SchoolName,20}");
        }
    }
}
