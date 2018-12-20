
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericLesson
{
    class Program
    {
        static void Main(string[] args)
        {
            //Person person = new Person() { Gender = "M", Address = "Venus" };
            //Student student = new Student() { Age = 30, Name = "Stuckie" };
            //Test<Person> testP = new Test<Person>(person);
            //Test<Student> testS = new Test<Student>(student);

            //Console.WriteLine(testP.GetValue());
            //Console.WriteLine(testS.GetValue());

            FixedStack<int> fixedStack = new FixedStack<int>(5);
            Console.WriteLine(fixedStack.IsEmpty());
            fixedStack.Push(10);
            fixedStack.Push(20);
            fixedStack.Push(40);    
            Console.WriteLine(fixedStack.Count);
            //Console.WriteLine(fixedStack.Pop());
            //Console.WriteLine(fixedStack.Peek());
            //Console.WriteLine(fixedStack.Pop());
            //Console.WriteLine(fixedStack.Peek());
            //Console.WriteLine(fixedStack.Pop());
            //Console.WriteLine(fixedStack.Pop());
        }
    }
}
