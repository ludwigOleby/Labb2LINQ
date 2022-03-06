using System;
using System.Collections.Generic;
using System.Text;

namespace Labb2LINQ
{
    public class Ämne
    {
        public int ÄmneID { get; set; }
        public string Namn { get; set; }
        public ICollection<StudentÄmne> Ämnen { get; set; }
        public ICollection<LärareÄmne> Lärare { get; set; }

       

    }
}
