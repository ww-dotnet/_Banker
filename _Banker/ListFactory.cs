using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _Banker
{            
    class ListFactory
    {
        internal static List<string> gasStationCost = new List<string>();
        internal static List<string> groceryStoreCost = new List<string>();
        internal static List<string> deptStoreCost = new List<string>();
        internal static List<string> shippingStoreCost = new List<string>();
        internal static List<string> undefinedCost = new List<string>();


        internal static List<string> GasStationList()
        {
            List<string> listOfGasStations = new List<string>();
            var contents = File.ReadLines("C:\\Users\\NEO\\source\\repos\\_Banker\\_Banker\\gasStationList.txt");
            foreach (var item in contents)
            {
                //Console.WriteLine($"***********{item}");                
                listOfGasStations.Add(item);
            }
            return listOfGasStations;
        }

        internal static List<string> GroceryStoreList()
        {
            List<string> listOfGroceryStores = new List<string>();
            var contents = File.ReadLines("C:\\Users\\NEO\\source\\repos\\_Banker\\_Banker\\groceryStoreList.txt");
            foreach (var item in contents)
            {
                //Console.WriteLine($"***********{item}");                
                listOfGroceryStores.Add(item);
            }
            return listOfGroceryStores;
        }

        internal static List<string> DepartmentStoreList()
        {
            List<string> listOfDepartmentStores = new List<string>();
            var contents = File.ReadLines("C:\\Users\\NEO\\source\\repos\\_Banker\\_Banker\\departmentStoreList.txt");
            foreach (var item in contents)
            {
                //Console.WriteLine($"***********{item}");                
                listOfDepartmentStores.Add(item);
            }
            return listOfDepartmentStores;
        }

        internal static List<string> ShippingStoreList()
        {
            List<string> listOfDepartmentStores = new List<string>();
            listOfDepartmentStores.Add("USPS");
            listOfDepartmentStores.Add("UPS");
            listOfDepartmentStores.Add("FedEx");
            return listOfDepartmentStores;
        }
    }
}
