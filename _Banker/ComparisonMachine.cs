using System;
using System.Collections.Generic;
using System.Globalization;
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




        }
    }
}



//FOR STORE NAMES
//split on the space
//for each item in the list after splitting on the space
//break down to char array

//FOR TRANSACTIONS
//split on the space
//for each item in the list after splitting on the space






        //    foreach (string item in gasStationList)
        //    {
        //        //bool matches = csvFieldData.IndexOf($"{item}", StringComparison.OrdinalIgnoreCase) >= 0;
        //        //CultureInfo culture = new CultureInfo("en-US");
        //        //bool matches = culture.CompareInfo.IndexOf(csvFieldData, item, CompareOptions.IgnoreCase) >= 0;

//        Regex regex = new Regex($"{item}");
//        Match match = regex.Match(csvFieldData);
//        if (match.Success)
//        {
//            Console.WriteLine("GAS SUCCESS");
//            ListFactory.gasStationCost.Add(csvFieldData);
//            break;
//        }
//    }

//    foreach (string item in departmentStoreList)
//    {
//        Regex regex = new Regex($"{item}");
//        Match match = regex.Match(csvFieldData);
//        //bool matches = csvFieldData.IndexOf($"{item}", StringComparison.OrdinalIgnoreCase) >= 0;

//        if (match.Success)
//        {
//            Console.WriteLine("DEPT SUCCESS");
//            ListFactory.deptStoreCost.Add(csvFieldData);
//            break;
//        }
//    }

//    foreach (string item in groceryStoreList)
//    {
//        //bool matches = csvFieldData.IndexOf($"{item}", StringComparison.OrdinalIgnoreCase) >= 0;

//        Regex regex = new Regex($"{item}");
//        Match match = regex.Match(csvFieldData);
//        if (match.Success)
//        {
//            Console.WriteLine("GROCERY SUCCESS");
//            ListFactory.groceryStoreCost.Add(csvFieldData);
//            break;
//        }
//    }

//    foreach (string item in shippingStoreList)
//    {
//        //bool matches = csvFieldData.IndexOf($"{item}", StringComparison.OrdinalIgnoreCase) >= 0;

//        Regex regex = new Regex($"{item}");
//        Match match = regex.Match(csvFieldData);
//        if (match.Success)
//        {
//            Console.WriteLine("SHIPPING SUCCESS");
//            ListFactory.shippingStoreCost.Add(csvFieldData);
//            break;
//        }
//    }
//    //ListFactory.undefinedCost.Add(csvFieldData);
//    //Console.WriteLine("UNDEFINED SUCCESS");
//}