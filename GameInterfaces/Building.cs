using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GameInterfaces
{
    public class Building : IHasValue
    {
        private string  tipo;
        private float   área;
        public float    Value {get;} 

        public Building (string tipo, float área )
        {
            this.tipo =tipo;
            this.área = área;
        }
        
        public void ToString()
        {
            Console.WriteLine($"O edifício é do tipo {tipo,-20}");
            Console.WriteLine($"O valor lor é {Value,8:f2}");
            Console.WriteLine($"A área é {área,8:f2}");
        }

        
    }
}