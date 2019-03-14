using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _Banker
{
    class ComparisonMachine
    {
        internal static bool GasStationComparisonEngine(string csvLineData)
        {
            List<string> gasStationList = ListFactory.GasStationList();
            bool isAGasStation = false;

            foreach (string item in gasStationList)
            {
                if (item.Contains(csvLineData))
                {
                    isAGasStation = true;                    
                } else
                {
                    isAGasStation = false;
                }
            }
            return isAGasStation;
        }

        internal static bool DeptartmentStoreComparisonEngine(string csvLineData)
        {
            List<string> departmentStoreList = ListFactory.DepartmentStoreList();
            bool isADeptStore = false;

            foreach (string item in departmentStoreList)
            {
                if (item.Contains(csvLineData))
                {
                    isADeptStore = true;
                }
                else
                {
                    isADeptStore = false;
                }
            }
            return isADeptStore;
        }

        internal static bool GroceryStoreComparisonEngine(string csvLineData)
        {
            List<string> groceryStoreList = ListFactory.GroceryStoreList();
            bool isAgroceryStore = false;

            foreach (string item in groceryStoreList)
            {
                if (item.Contains(csvLineData))
                {
                    isAgroceryStore = true;
                }
                else
                {
                    isAgroceryStore = false;
                }
            }
            return isAgroceryStore;
        }

        internal static bool ShippingStoreComparisonEngine(string csvLineData)
        {
            List<string> shippingStoreList = ListFactory.ShippingStoreList();
            bool isAshippingStore = false;

            foreach (string item in shippingStoreList)
            {
                if (item.Contains(csvLineData))
                {
                    isAshippingStore = true;
                }
                else
                {
                    isAshippingStore = false;
                }
            }
            return isAshippingStore;
        }
    }
}


        
    
            //needs to be foreach item in csvlinedata, compare to a split list of grocerystores
        
    


//            foreach (string item in gasStationList)
//            {
//                string[] splitter = item.Split(' ');
//splitGasList.AddRange(splitter);
//            }
//            foreach (string line in csvLineData)
//            {
//                Console.WriteLine(line);
//                foreach (string shippingStorePiece in shippingStoreList)
//                {
//                    if (line.Contains(shippingStorePiece))
//                    {
//                        ListFactory.shippingStoreCost.Add(line);
//                        continue;
//                    }
//                }

//                foreach (string gasStationNamePiece in splitGasList)
//                {
//                    if (gasStationNamePiece.Length >= 2)
//                    {
//                        if (line.Contains(gasStationNamePiece))
//                        {
//                            ListFactory.gasStationCost.Add(line);
//                        }
//                        //this algorithm is working, but it is adding USPS stuff to the 
//                        //gas station list - it shouldn't do that
//                        //may need to parse further
//                    }                        
//                }
//            }