using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GropuProject.Views
{
    public class Person
    {
        public int Id { get; set; }
        public string StName { get; set; }
        //public string OwnerName { get; set; }
        public int ContNo { get; set; }
        public string Address { get; internal set; }
        public int Age { get; internal set; }
        public int BirthDay { get; internal set; }
    }
}
