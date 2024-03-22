using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    public class ReportOfStudentCourseworkBuilder : IReportOfStudentCourseworkBuilder
    {
        private ReportOfStudentCoursework _reportOfStudentCoursework;

        private readonly IEnumerable<Student> _students;

        public ReportOfStudentCourseworkBuilder(IEnumerable<Student> students)
        {
            _students = students;
            _reportOfStudentCoursework = new();
        }

        public void BuildGroup() //  public IReportOfStudentCourseworkBuilder BuildGroup()
        {

            _reportOfStudentCoursework.Group =
                $"Student's group: Mosip12/21b\n Course: 3\n Profil': System and Internet-programming\n Direction: Matobes\n Faculty:HSCM&S\n Subject:C#";

            _reportOfStudentCoursework.Group +=
                "\n----------------------------------------------------------------------------------------------------\n";

            // return this;
        }

        public void BuildAbout() //public IReportOfStudentCourseworkBuilder BuildMark()  студент, тема и оценка
        {
            _reportOfStudentCoursework.About =
                string.Join(Environment.NewLine,
                    _students.Select(e =>
                    $"Student: {e.Name}\t {e.Surname}\t\t | Topic: {e.Topic}\t\t\t  | Mark: {e.Mark}\n "));

            _reportOfStudentCoursework.About +=
                "\n----------------------------------------------------------------------------------------------------\n";

            //  return this;
        }

        public void BuildReport()
        {
            _reportOfStudentCoursework.Report =
               $"REPORT ON DATE: {DateTime.Now}\n";

            _reportOfStudentCoursework.Report +=
               $"Prepod: Chapkin\n";

        }

        public ReportOfStudentCoursework GetReportOfStudentCoursework()
        {
            ReportOfStudentCoursework reportOfStudentCoursework = _reportOfStudentCoursework;

            _reportOfStudentCoursework = new();

            return reportOfStudentCoursework;
        }
    }


}
