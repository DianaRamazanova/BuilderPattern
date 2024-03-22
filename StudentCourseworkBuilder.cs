using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    public class StudentCourseworkBuilder : IStudentCourseworkBuilder
    {
        private StudentCoursework _studentCoursework;

        private readonly IEnumerable<Student> _students;

        public StudentCourseworkBuilder(IEnumerable<Student> students)
        {
            _students = students;
            _studentCoursework = new();
        }

        public void BuildGroup() //  public IStudentCourseworkBuilder BuildGroup()
        {

            _studentCoursework.Group =
                $"Student's group: Mosip12/21b\n Course: 3\n Profil': System and Internet-programming\n Direction: Matobes\n Faculty:HSCM&S\n Subject:C#";

            _studentCoursework.Group +=
                "\n----------------------------------------------------------------------------------------------------\n";

            // return this;
        }

        public void BuildAbout() //public IStudentCourseworkBuilder BuildMark()  студент, тема и оценка
        {
            _studentCoursework.About =
                string.Join(Environment.NewLine,
                    _students.Select(e =>
                    $"Student: {e.Name}\t {e.Surname}\t\t | Topic: {e.Topic}\t\t\t  | Mark: {e.Mark}\n "));

            _studentCoursework.About +=
                "\n----------------------------------------------------------------------------------------------------\n";

            //  return this;
        }

        public void BuildReport()
        {
            _studentCoursework.Report =
               $"REPORT ON DATE: {DateTime.Now}\n";

            _studentCoursework.Report +=
               $"Prepod: Chapkin\n";

        }
        // средний балл за оценку

        public StudentCoursework GetStudentCoursework()
        {
            StudentCoursework studentCoursework = _studentCoursework;

            _studentCoursework = new();

            return studentCoursework;
        }
    }


}
