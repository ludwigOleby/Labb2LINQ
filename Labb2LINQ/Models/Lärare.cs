using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;


namespace Labb2LINQ
{
    public class Lärare
    {
        [Key]
        public int LärarID { get; set; }
        public string LärarNamn { get; set; }
        public ICollection<LärareÄmne> Ämnen { get; set; }
        public ICollection<StudentLärare> StudentGrupp { get; set; }

        
    }
}
