using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _Banker
{
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

                parser.TextFieldType = FieldType.Delimited;
                parser.SetDelimiters(",");
                while (!parser.EndOfData)
                {
                    //Process row
                    string[] fields = parser.ReadFields();
                    foreach (string field in fields)
                    {
                        Console.WriteLine(field);
                        Console.ReadLine();
                    }

                    string line = String.Join(" ", fields);
                    Console.WriteLine(line);
                    Console.ReadLine();
                    string correctedLine = Regex.Replace(line, " {2,}", " ");

                    Console.WriteLine(correctedLine);
                    Console.ReadLine();
                }
                return lineStorer;
            }
        }
    }
}

//go back to old code below and create string only using fields 1,2,3,4





//foreach (string field in fields)
//{
//    //Console.WriteLine("*************" + field);

//    columnCounter++;
//    if (columnCounter != 7)
//    {
//        if (!string.IsNullOrEmpty(field) && !string.IsNullOrWhiteSpace(field))
//        {
//            lineBuilder.Add(field);
//        }
//        else
//        {
//            continue;
//        }
//    }
//    else
//    {
//        string lineConcat = String.Join(" ", lineBuilder);
//        Console.WriteLine("***************" + lineConcat);
//        //ComparisonMachine.ComparisonEngine(lineConcat);

//        lineBuilder.Clear();
//        columnCounter = 0;
//    }
//}