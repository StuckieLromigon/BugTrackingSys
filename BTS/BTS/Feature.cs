using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTS
{
    class Feature : Task
    {
        public new const double Priority = 2;

        public Feature(int number, int complexity, string description) : base(number, complexity, description)
        {

        }
    }
}
