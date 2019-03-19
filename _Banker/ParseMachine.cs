using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _Banker
{


    //TODO
    //break this machine down so that it creates a dictionary of costs where each key is the name of the store and each value is the cost for that instance
    //then from that dictionary, we can create a report



    /// <summary>
    /// Responsible for parsing csv bulk data into line data. 
    /// Rely on this to create line data from csv files.
    /// </summary>
    class ParseMachine
    {
        /// <summary>
        /// The parsing engine.
        /// </summary>
        /// <param name="path">The string value for the path to the csv file on disk.</param>
        /// <returns>A list of csv line data.</returns>
        public static List<string> ParseEngine(string path)
        {
            List<string> gasStationList = ListFactory.GasStationList();
            List<string> departmentStoreList = ListFactory.DepartmentStoreList();
            List<string> groceryStoreList = ListFactory.GroceryStoreList();
            List<string> shippingStoreList = ListFactory.ShippingStoreList();

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
                            if (!string.IsNullOrEmpty(field) && !string.IsNullOrWhiteSpace(field))
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
                            ComparisonMachine.ComparisonEngine(lineConcat);

                            lineBuilder.Clear();
                            columnCounter = 0;
                        }
                    }
                }

                //learn regex via java video and apply it to gas station list, etc, as you parse so that it sorts all the data out into predictable columns
                return lineStorer;
            }
        }
    }
}
