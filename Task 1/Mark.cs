using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    class Mark
    {
        public string SubjectName { get; set; }
        public int Value { get; set; }

        public Mark(string subjectName, int value)
        {
            this.SubjectName = subjectName;
            this.Value = value;
        }
    }
}
