using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning
{
    public class ParamsTest
    {
        public ParamsTest()
        {
            NameClass(24,"Alan","Ten");
        }
        private void NameClass(int age, params string[] names)
        {
            Console.WriteLine(age+","+names.Length);
        }
    }

}
