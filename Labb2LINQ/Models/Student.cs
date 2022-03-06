using System;
using System.Collections.Generic;
using System.Text;

namespace Labb2LINQ
{
    public class Student
    {
        public int StudentID { get; set; }
        public string StudentNamn { get; set; }
        public Klass Klasser { get; set; }
        public ICollection<StudentÄmne> Ämnen { get; set; }
        public ICollection<StudentLärare> StudentGrupp { get; set; }

    }
}
