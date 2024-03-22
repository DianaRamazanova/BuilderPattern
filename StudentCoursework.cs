using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    public class StudentCoursework
    {
        public string Group { get; set; }

        public string About { get; set; }

        public string Report { get; set; }
        public override string ToString() =>
            new StringBuilder()
            .Append(Group)
            .Append(About)
            .Append(Report)
            .ToString();
    }
}
