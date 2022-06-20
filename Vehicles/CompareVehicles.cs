using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicles
{
    public class CompareVehicles : IComparer<Vehicle>
    {
        public int Compare(Vehicle? x, Vehicle? y)
        {
            
            
            return x.Energy.CompareTo(y.Energy);
            
            
        }
    }
}
