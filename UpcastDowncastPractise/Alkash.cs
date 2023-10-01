using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UpcastDowncastPractise
{
    class Alkash : Human
    {
        private string staj {get;set;}

        public void HelloFromZapoy()
        {
            Console.WriteLine("Дарова внатуре, мелочи не будет? -" + name);
          //  SayHello();
        }
    }
}
