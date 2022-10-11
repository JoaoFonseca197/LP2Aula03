using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BuildingCollections
{
    public class Building 
    {
        public string Tipo { get; set;}
        public float  Área { get; set;}
        public float    Value {get;} 

        public Building (string tipo, float área )
        {
            Tipo = tipo;
            Área = área;
        }
        /*
        public void ToString()
        {
            Console.WriteLine($"O edifício é do tipo {tipo,-20}");
            Console.WriteLine($"O valor lor é {Value,8:f2}");
            Console.WriteLine($"A área é {área,8:f2}");
        }
        */
        
    }
}