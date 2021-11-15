using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XmlStudentCirclesParser
{
    class Circle
    {
        public string Name { get; set; } = null;
        public string Faculty { get; set; } = null;
        public string Schedule { get; set; } = null;
        public string Monitor { get; set; } = null;
        public string Subject { get; set; } = null;

        public Circle() { }

        public Circle(string name, string faculty, string schedule, string monitor, string subject)
        {
            Name = name;
            Faculty = faculty;
            Schedule = schedule;
            Monitor = monitor;
            Subject = subject;
        }

    }
}
