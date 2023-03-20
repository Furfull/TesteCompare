
using KellermanSoftware.CompareNetObjects;
using TesteCompare.Models;

namespace TesteCompare
{
    public class Program
    {
        static void Main()
        {
            CompareLogic comparelogic = new();
            comparelogic.Config.MaxDifferences = Int32.MaxValue;

            Customer Levi = new();
            Levi.Id = 2;
            Levi.Name = "Levi Gabriel";
            Levi.Address = "Rio de Janeiro";
            Customer Gabriel = new();
            Gabriel.Id = 2;
            Gabriel.Name = "Levi Gabriel Souza";
            Gabriel.Address = "Campinas";

            List<Difference> diffs = comparelogic.Compare(Levi, Gabriel).Differences;

            comparelogic.Config.MaxDifferences = Int32.MaxValue;

            foreach (Difference diff in diffs)
            {
                Console.WriteLine(diff.PropertyName);
                Console.WriteLine(diff.Object1);
                Console.WriteLine(diff.Object2);
            }
        }
    }
}