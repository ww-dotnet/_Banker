using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic.FileIO;



//***************************************************MAIN THEORY********************************************************************
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




namespace _Banker
{
    class Program
    {
        static void Main(string[] args)
        {
            foreach (string item in ParseMachine("c:\\testenv\\export.csv"))
            {
                Console.WriteLine(item);
                    
            }
            

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

        public static List<string> ParseMachine(string path)
        {
            List<string> gasStationList = ListFactory.GasStationList();
            List<string> departmentStoreList = ListFactory.DepartmentStoreList();
            List<string> groceryStoreList = ListFactory.GroceryStoreList();

            using (TextFieldParser parser = new TextFieldParser(path))
            {
                List<string> lineBuilder = new List<string>();
                List<string> lineStorer = new List<string>();
                int columnCounter = 0;

                parser.TextFieldType = FieldType.Delimited;
                parser.SetDelimiters(",");
                while (!parser.EndOfData)
                {
                    //Process row
                    string[] fields = parser.ReadFields();
                    foreach (string field in fields)
                    {
                        columnCounter++;
                        if (columnCounter != 7)
                        {
                            if (!string.IsNullOrEmpty(field))
                            {
                                lineBuilder.Add(field);
                            }
                            else if (!string.IsNullOrWhiteSpace(field))
                            {
                                lineBuilder.Add(field);
                            }
                            else
                            {
                                continue;
                            }
                        }
                        else
                        {
                            string lineConcat = String.Join(" ", lineBuilder);
                            lineStorer.Add(lineConcat);
                            foreach (string item in lineStorer)
                            {
                                //Console.WriteLine(item);
                            }
                            lineBuilder.Clear();
                            columnCounter = 0;
                        }
                    }
                }
                return lineStorer;
            }

        }



    }
}
 