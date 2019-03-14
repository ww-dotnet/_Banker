using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _Banker
{
    class ComparisonMachine
    {
        private static string costField;

        public string CostField
        {
            get { return costField; }
        }
        public static void ComparisonEngine(List<string> csvLineData)
        {
            List<string> gasStationList = ListFactory.GasStationList();
            List<string> departmentStoreList = ListFactory.DepartmentStoreList();
            List<string> groceryStoreList = ListFactory.GroceryStoreList();
            List<string> shippingStoreList = ListFactory.ShippingStoreList();

            List<string> splitGasList = new List<string>();
            List<string> splitDeptList = new List<string>();
            List<string> splitGroceryList = new List<string>();
            List<string> splitCsvLineData = new List<string>();

            
            foreach (string item in gasStationList)
            {
                string[] splitter = item.Split(' ');
                splitGasList.AddRange(splitter);
            }
            foreach (string line in csvLineData)
            {
                Console.WriteLine(line);
                foreach (string shippingStore in shippingStoreList)
                {
                    if (line.Contains(shippingStore))
                    {
                        ListFactory.shippingStoreCost.Add(line);
                        continue;
                    }
                }

                foreach (string gasStationNamePiece in splitGasList)
                {
                    if (line.Contains(gasStationNamePiece))
                    {
                        ListFactory.gasStationCost.Add(line);

                        //this algorithm is working, but it is adding USPS stuff to the 
                        //gas station list - it shouldn't do that
                        //may need to parse further

                    }
                }
            }
            //needs to be foreach item in csvlinedata, compare to a split list of grocerystores
        }
    }
}
