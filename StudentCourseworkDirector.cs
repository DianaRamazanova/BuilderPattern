using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    public class ReportOfStudentCourseworkDirector
    {
        private readonly IReportOfStudentCourseworkBuilder _builder;

        public ReportOfStudentCourseworkDirector(IReportOfStudentCourseworkBuilder builder)
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

