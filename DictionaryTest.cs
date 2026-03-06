using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning
{
    public class DictionaryTest
    {
        public Dictionary<int,string> dictionaryTest = new Dictionary<int,string>();
        public DictionaryTest() 
        {
            string[] names= new string[] { "Alan","Blan","Clan"};

            dictionaryTest.Add(4, "Alan");
            dictionaryTest.Remove(4);

            for(int i = 0; i < names.Length; i++)
            {
                dictionaryTest[i] = names[i];
            }
            

            foreach(KeyValuePair<int,string> item in dictionaryTest)
            {
                Console.WriteLine("Key: " + item.Key + " Value: " + item.Value);
            }
        }
        
    }
}
