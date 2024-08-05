using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstApproachEF.Model
{
    class Student
    {
        [Key]
        public int ID { get; set; }
        public string name { get; set; }
        public string department { get; set; }
        public string university { get; set; }
    }
}
