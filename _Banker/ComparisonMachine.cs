using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _Banker
{
    class ComparisonMachine
    {
        private static bool isFound;

        public bool IsFound
        {
            get { return isFound; }            
        }

        public static void ComparisonEngine(string csvLineData)
        {
        List<string> gasStationList = ListFactory.GasStationList();
        List<string> departmentStoreList = ListFactory.DepartmentStoreList();
        List<string> groceryStoreList = ListFactory.GroceryStoreList();
            //list factory needs more lists to store sorted costs

            Console.WriteLine(csvLineData);
            Console.ReadLine();

            //create a machine that takes each line of the csv and cleans it up, generating more string data based on the string it parses to make for clearer
            //comparison data here
            //then pass that data in to this machine which will split by whitespace each line thereby creating a list of words
            //compare each word in the new word list to each word in the other list


            //Console.WriteLine($"***********  { csvLineData } **************");
            if (groceryStoreList.Contains(csvLineData))
            {
                //Console.WriteLine("***************************TRUE******************");
                isFound = true;
            }
        }
    }
}
