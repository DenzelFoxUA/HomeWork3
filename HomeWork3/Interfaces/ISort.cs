using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork3.Interfaces
{
    public interface ISort<T> where T : class
    {
        public abstract T SortByAscending();

        public abstract T SortByDescending();

        public virtual void SortByParameter(bool byAscending)
        {
            if (byAscending == true)
            {
                SortByAscending();
            }
            else
            {
                SortByDescending();
            }
        }
    }
}
