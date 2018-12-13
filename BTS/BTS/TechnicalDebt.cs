using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTS
{
    class TechnicalDebt : Task
    {
        public new const double Priority = 0.5;

        public TechnicalDebt(int number, int complexity, string description) : base(number, complexity, description)
        {

        }
    }
}
