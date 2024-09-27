using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork3.Interfaces
{
    public interface IMath
    {
        public double Max { get; }
        public double Min { get; }

        public double Average { get; }

        public abstract bool SearchByValue(double value);
    }
}
