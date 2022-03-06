using System;
using System.Collections.Generic;
using System.Text;

namespace Labb2LINQ
{
    public class StudentLärare
    {
        public int StudentID { get; set; }
        public Student student { get; set; }

        public int LärarID { get; set; }
        public Lärare lärare { get; set; }

    }
}
