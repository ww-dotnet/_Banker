using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _Banker
{
    /// <summary>
    /// Responible for comparing csv line data to sort costs into appropriate lists.
    /// Rely on this to sort csv bank data.
    /// </summary>
    class ComparisonMachine
    {

        internal static void ComparisonEngine(string csvFieldData)
        {
            List<string> gasStationList = ListFactory.GasStationList();
            List<string> departmentStoreList = ListFactory.DepartmentStoreList();
            List<string> groceryStoreList = ListFactory.GroceryStoreList();
            List<string> shippingStoreList = ListFactory.ShippingStoreList();
            
            foreach (string item in gasStationList)
            {
                Regex regex = new Regex($"^{item}$");
                Match match = regex.Match(csvFieldData);
                if (match.Success)
                {
                    Console.WriteLine("GAS SUCCESS");
                    ListFactory.gasStationCost.Add(csvFieldData);
                    break;
                }
            }

            foreach (string item in departmentStoreList)
            {
                Regex regex = new Regex($"^{item}$");
                Match match = regex.Match(csvFieldData);
                if (match.Success)
                {
                    Console.WriteLine("DEPT SUCCESS");
                    ListFactory.deptStoreCost.Add(csvFieldData);
                    break;
                }
            }

            foreach (string item in groceryStoreList)
            {
                Regex regex = new Regex($"^{item}$");
                Match match = regex.Match(csvFieldData);
                if (match.Success)
                {
                    Console.WriteLine("GROCERY SUCCESS");
                    ListFactory.groceryStoreCost.Add(csvFieldData);
                    break;
                }
            }

            foreach (string item in shippingStoreList)
            {
                Regex regex = new Regex($"^{item}$");
                Match match = regex.Match(csvFieldData);
                if (match.Success)
                {
                    Console.WriteLine("SHIPPING SUCCESS");
                    ListFactory.shippingStoreCost.Add(csvFieldData);
                    break;
                }
            }            
            ListFactory.undefinedCost.Add(csvFieldData);
            Console.WriteLine("UNDEFINED SUCCESS");
        }
    }
}