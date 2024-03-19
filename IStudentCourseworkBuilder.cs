using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    public interface IStudentCourseworkBuilder
    {
        void BuildGroup(); //IStudentCourseworkBuilder BuildGroup();

        void BuildAbout(); // IStudentCourseworkBuilder BuildAbout();

        StudentCoursework GetStudentCoursework();
    }
}
