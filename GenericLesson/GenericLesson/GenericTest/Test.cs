using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericLesson
{
    class Test<T>
    {
        private T _t;
        public Test(T t)
        {
            _t = t;
        }

        public string GetValue()
        {
            return _t.ToString();
        }
    }
}
