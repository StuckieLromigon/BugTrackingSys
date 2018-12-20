using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericLesson
{
    class Person
    {
        public string Gender { get; set; }
        public string Address { get; set; }

        public override string ToString()
        {
            return String.Format("{0} + {1}", Gender, Address);
        }
    }
}
