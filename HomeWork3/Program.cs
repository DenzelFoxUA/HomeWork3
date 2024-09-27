using HomeWork3.Interfaces;

namespace HomeWork3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int valueToSearch1 = 100;
            int valueToSearch2 = 120;

            MyContainer numbers = new MyContainer();
            numbers.Add(1, 2, 3, 5, 13, 20.5, 101, -101.89,-1112, 120);



            numbers.SortByAscending().Show("Sorted by ascending");
            numbers.SortByDescending().Show("\nSorted by descending");

            Console.WriteLine($"\nMin value: " + numbers.Min);
            Console.WriteLine($"Max value: " + numbers.Max);
            Console.WriteLine($"Average = " + numbers.Average);

            ISort<MyContainer> parameterSort = numbers; 
            parameterSort.SortByParameter(true);
            numbers.Show($"Sorting by parameter \'true\'");

            parameterSort.SortByParameter(false);
            numbers.Show($"Sorting by parameter \'false\'");

            Console.WriteLine($"\nSearch for value {valueToSearch1} " 
                                + numbers.SearchByValue(valueToSearch1));

            Console.WriteLine($"\nSearch for value {valueToSearch2} " 
                                + numbers.SearchByValue(valueToSearch2));

            Console.WriteLine($"\nTry remove {valueToSearch1} from container: " +
                                    $"{numbers.Remove(valueToSearch1)}");

            Console.WriteLine($"\nTry remove {valueToSearch2} from container: " +
                                    $"{numbers.Remove(valueToSearch2)}");

            numbers.Show($"\nContainer after removing number");


        }
    }
}
