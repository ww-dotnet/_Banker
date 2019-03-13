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
        //have pretty good lists - need to clean up




namespace _Banker
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> gasStationList = ListFactory.GasStationList();
            List<string> departmentStoreList = ListFactory.DepartmentStoreList();
            List<string> groceryStoreList = ListFactory.GroceryStoreList();
            


            using (TextFieldParser parser = new TextFieldParser(@"c:\testEnv\export.csv"))
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
                        lineBuilder.Add(field);
                        if (lineBuilder.Count == 7) {
                            lineStorer.AddRange(lineBuilder);
                            lineStorer.Add("  []  "); //sorting key
                        }

                        //this linestorer holds each line from the CSV with a sorting key []
                        //take the linestorer, and parse through it
                        
                        //hmm maybe a dictionary?

                            Console.WriteLine(field);
                            ComparisonMachine.ComparisonEngine(field.Trim());
                            //Console.Write(field.Trim() + "   "); //******THIS IS THE OUTPUT STRING AS THE PROGRAM PARSES THE CSV
                        }
                    }
                    Console.WriteLine();
                    Console.ReadLine();
                }            
            Console.ReadLine();
        }
    }
}
