﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTS
{
    class Bug : Task
    {
        public new const double Priority = 1;
        public Feature linkedFeature { get; set; }

        public Bug(int number, int complexity, string description) : base(number, complexity, description)
        {

        }
    }
}
