using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    public interface IReportOfStudentCourseworkBuilder
    {
        void BuildGroup(); //IReportOfStudentCourseworkBuilder BuildGroup();

        void BuildAbout(); // IReportOfStudentCourseworkBuilder BuildAbout();

        void BuildReport(); // IReportOfStudentCourseworkBuilder BuildReport();


        ReportOfStudentCoursework GetReportOfStudentCoursework();
    }
}
