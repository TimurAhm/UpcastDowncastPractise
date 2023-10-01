using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UpcastDowncastPractise
{
    class Human
    {
        public string name { get; set; }
        private int _age;
        public int age
        {
            get
            {
                return _age;
            }
            set
            {
                _age = value;
            }
        }
        public string sex { get; set; }

        //protected
        public void SayHello()
        {
            Console.WriteLine($"Привет от человека {age.ToString()}");
        }

    }
}
