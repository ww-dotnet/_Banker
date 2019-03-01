using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic.FileIO;

namespace _Banker
{
    class Program
    {
        

        static void Main(string[] args)
        {
            
            using (TextFieldParser parser = new TextFieldParser(@"c:\testEnv\export.csv"))
            {
                parser.TextFieldType = FieldType.Delimited;
                parser.SetDelimiters(",");
                parser.SetFieldWidths(7);
                while (!parser.EndOfData)
                {
                    //Process row
                    string[] fields = parser.ReadFields();
                    int fieldCount = 0;

                    #region ListContainer

                    List<string> stringToHoldFields = new List<string>();
                    List<string> groceryCosts = new List<string>();
                    List<string> groceryStoreList = new List<string>();

                    #endregion -->

                    #region GroceryStoreContainer

                    groceryStoreList.Add("LION"); //Food Lion
                    groceryStoreList.Add("KROGER");
                    groceryStoreList.Add("WALMART");
                    groceryStoreList.Add("ALDI");
                    groceryStoreList.Add("");
                    groceryStoreList.Add("");
                    groceryStoreList.Add("");
                    groceryStoreList.Add("");
                    groceryStoreList.Add("");
                    groceryStoreList.Add("");
                    groceryStoreList.Add("");
                    groceryStoreList.Add("");
                    groceryStoreList.Add("");
                    groceryStoreList.Add("");
                    groceryStoreList.Add("");
                    groceryStoreList.Add("");

                    #endregion -->


                    foreach (string field in fields)
                    {
                        fieldCount++;
                        if (fieldCount <= 7)
                        {
                            stringToHoldFields.Add(field);
                            string fieldString = string.Join(" ", stringToHoldFields);
                            
                            if (stringToHoldFields.Count == 7)
                            {
                                if (stringToHoldFields.Contains("KROGER"))
                                {
                                    groceryCosts.Add(fieldString);                                    
                                }
                                string groceryString = string.Join(" ", groceryCosts);
                                Console.WriteLine(groceryString);
                                Console.WriteLine(fieldString);
                                stringToHoldFields.Clear();
                            }


                            //Console.Write(field.Trim() + "   ");                            
                            fieldCount = 0;
                        }
                    }
                    Console.WriteLine();                    
                }
            }
            Console.ReadLine();

            //not quite working yet --- nothing is added to groceryCosts, it seems
            //the idea is to parse everything out into different lists so that we can manipulate the lists and present data from them
            //this may be better achieved with a dictionary rather than a bunch of lists..
            //TODO
                //find out if dictionaries would be a better solution for this
                //try to parse grocery purchases into a list of grocery costs and print grocery costs back out to the screen
                    //if successful, build multiple lists or dictionaries that cover all possible expenditures and then have those lists/dictionaries build and present a report
                

        }

        public static List<string> GasStationList()
        {
            List<string> listOfGasStations = new List<string>();
            listOfGasStations.Add("GAS N GO");
            listOfGasStations.Add("4-5 STAR MARKETS");
            listOfGasStations.Add("WEIGELS");
            listOfGasStations.Add("");

            return listOfGasStations;
        }



    }
}
