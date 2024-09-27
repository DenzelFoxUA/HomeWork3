using HomeWork3.Interfaces;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Reflection.Metadata;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork3
{
    public class MyContainer: IEnumerable, IOutput, IMath, ISort<MyContainer>
    {
        private List<double> _myContainer;

        public MyContainer()
        {
            _myContainer = new List<double>();
        }

        public List<double> Copy => _myContainer.Select(x => x).ToList();

        public void Add(params double[] newValues)
        {
            foreach (var @parameter in newValues)
            {
                _myContainer.Add(@parameter);
            }
        }

        public bool Remove(double value) => _myContainer.Remove(value);

        public IEnumerator GetEnumerator()
        {
            for (int i = 0; i < _myContainer.Count; i++)
            {
                yield return _myContainer[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();

        //TASK 2
        public double Max => _myContainer.Max();

        public double Min => _myContainer.Min();

        public double Average => _myContainer.Average();

        public bool SearchByValue(double value) => _myContainer.Contains(value);
        //
        

        //TASK 1
        public void Show()
        {
            foreach (var item in _myContainer)
            {
                Console.Write($"{item} ");
            }
            Console.ReadLine();
        }

        public void Show(string textInfo)
        {
            Console.WriteLine($"Info: {textInfo}");
            Show();
        }
        //

        //TASK 3
        public MyContainer SortByAscending()
        {
            _myContainer = _myContainer.OrderBy(x => x).ToList();
            return this;
        }

        public MyContainer SortByDescending()
        {
            _myContainer = _myContainer.OrderByDescending(x => x).ToList();
            return this;
        }

        //SortByParameter(bool param) - реалізований віртуально в інтерфейсі
        //
    }
}
