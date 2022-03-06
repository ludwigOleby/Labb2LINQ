using System;
using System.Collections.Generic;
using System.Text;

namespace Labb2LINQ
{
    public class LärareÄmne
    {
        public int LärarID { get; set; }
        public Lärare lärare { get; set; }

        public int ÄmneID { get; set; }
        public Ämne Ämnen { get; set; }
    }
}
