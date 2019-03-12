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
        #region List Factory

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

        internal static List<string> RetailStoreList()
        {

            //scrape this list https://en.wikipedia.org/wiki/List_of_department_stores_of_the_United_States
                //no longer scraping - do this by hand
            List<string> listOfGroceryStores = new List<string>();
            var contents = File.ReadLines("C:\\Users\\NEO\\source\\repos\\_Banker\\_Banker\\groceryStoreList.txt");
            foreach (var item in contents)
            {
                //Console.WriteLine($"***********{item}");                
                listOfGroceryStores.Add(item);
            }
            return listOfGroceryStores;
        }


        #endregion



    }
}
