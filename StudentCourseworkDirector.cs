using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    public class StudentCourseworkDirector
    {
        private readonly IStudentCourseworkBuilder _builder;

        public StudentCourseworkDirector(IStudentCourseworkBuilder builder)
        {
            _builder = builder;
        }

        public void Build()
        {
            _builder.BuildGroup();
            _builder.BuildAbout();
            _builder.BuildReport();

            /* _builder
                      .BuildGroup();
                      .BuildAbout();
            */
        }
    }
}

