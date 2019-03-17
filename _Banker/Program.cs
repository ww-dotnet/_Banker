using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic.FileIO;



//***************************************************MAIN THEORY & TODO*************************************************************
//-need to create methods like this to store lists of grocery stores, big name brands (amazon, etc) and populate on start.
//-then parse csv against these lists and create groups of spending
//-then create calculations based on spendings from certain categories
//-then feed that information into an infographic that displays the results of data mining to the user
//***************************************************MAIN THEORY********************************************************************


    //work must be hard for success to occur - hand write all the store lists instead of relying on the scraper's auto generation
    //the list queries are going to be the success of the software
        
    //TODO
        //create cost containers
        //compare each word in each list to each other
        //sort selected items into their appropriate cost container

    //probably need to do the comparison at the parse, judging if each word that is being built into the string that ultimately ends up being the cost contains part of a gas station name, etc

    //go through lists and clean them up by hand to increase success of parse machine

namespace _Banker
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> gasStationList = ListFactory.GasStationList();
            List<string> departmentStoreList = ListFactory.DepartmentStoreList();
            List<string> groceryStoreList = ListFactory.GroceryStoreList();

            List<string> parsedCsv = ParseMachine.ParseEngine("c:\\testenv\\export.csv");
            Console.WriteLine(ListFactory.shippingStoreCost.Count);
            Console.ReadLine();

            //the following method call will compare each line in lineStorer with each line in each store list and return true or false for that line
            //once I get that true or false, I can begin to sort costs by whether they match X list or not
            //ComparisonMachine.ComparisonEngine(field.Trim());

            //now I have a list of strings that contains each line from the spreadsheet
            //that list is lineStorer
            //from here, I can separate each line into individual words by splitting on the whitespace
            //then I can split each line in the store list by each word using the same whitespace split
            //then I can compare each word in each list to each other and if any of the words match
            //sort the selected object into the correct cost container
            //Console.ReadLine();
        }





    }
}
 