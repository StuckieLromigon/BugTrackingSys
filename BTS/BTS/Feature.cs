using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTS
{
    class Feature : Task
    {
        public override double Priority { get { return 2; } }

        public Feature(int number, int complexity, string description) : base(number, complexity, description)
        {

        }

        public override string ToString()
        {
            return base.ToString("Feature");
        }
    }
}
