using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BuildingCollections
{
    public interface IHasValue : IEquatable<IHasValue>
    {
        public float Value {get;}

    }

}