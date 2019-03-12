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




namespace _Banker
{
    class Program
    {

        static void Main(string[] args)
        {
            List<string> gasStationList = ListFactory.GasStationList();
            List<string> departmentStoreList = ListFactory.DepartmentStoreList();
            List<string> groceryStoreList = ListFactory.GroceryStoreList();







            //query website
            //WebScraper webScraper = new WebScraper();
            //webScraper.Open_Browser();
            //--

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



                    foreach (string field in fields)
                    {
                        fieldCount++;
                        if (fieldCount <= 7)
                        {
                            stringToHoldFields.Add(field);
                            string fieldString = string.Join(" ", stringToHoldFields);

                            if (stringToHoldFields.Count == 7)
                            {
                                foreach (string store in groceryStoreList)
                                {
                                    if (stringToHoldFields.Contains(store))
                                    {
                                        groceryCosts.Add(fieldString);
                                    }
                                }
                                string groceryString = string.Join(" ", groceryCosts);
                                //Console.WriteLine(groceryString);
                                //Console.WriteLine(fieldString);
                                stringToHoldFields.Clear();
                            }


                            //Console.Write(field.Trim() + "   ");                            
                            fieldCount = 0;
                        }
                    }
                    //Console.WriteLine();                    
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
            //look to see if I can find a downloadable csv list of all gas stations, grocery stores, etc across the US


        }






        #endregion


    }
}
