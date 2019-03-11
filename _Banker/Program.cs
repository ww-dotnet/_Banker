using System;
using System.Collections.Generic;
using System.IO;
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
            GasStationListParser();
            

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
                    List<string> groceryStoreList = new List<string>();

                    #endregion -->

                    #region GroceryStoreContainer

                    groceryStoreList.Add("LION"); //Food Lion
                    groceryStoreList.Add("KROGER");
                    groceryStoreList.Add("WALMART");
                    groceryStoreList.Add("WAL-MART");
                    groceryStoreList.Add("WM SUPERCENTER");
                    groceryStoreList.Add("ALDI");

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

        public static void GasStationListParser()
        {
            List<string> listOfGasStations = new List<string>();
            var contents = File.ReadLines("C:\\Users\\NEO\\source\\repos\\_Banker\\_Banker\\gasStationList.txt");
            foreach (var item in contents)
            {
                Console.WriteLine($"***********{item}");
                
                listOfGasStations.Add(item);
            }
        }

        //this is working - need to finalize with all the other lists, etc







        public static List<string> GroceryStoreList()
        {
            List<string> listOfGroceryStores = new List<string>(); //only stores you buy food for the house for - kroger, walmart, etc
            listOfGroceryStores.Add("");
            return listOfGroceryStores;
        }

        public static List<string> FastFoodList() //mcdonalds, burger king, pizza hut, starbucks, etc - any food ordered out that was not cooked in house
        {
            List<string> listOfGroceryStores = new List<string>();
            listOfGroceryStores.Add("");
            return listOfGroceryStores;
        }

        public static List<string> GeneralStoreList() //Walmart, Amazon, etc - could be groceries, but count it as general store as rule of thumb
        {
            List<string> listOfGroceryStores = new List<string>();
            listOfGroceryStores.Add("");
            return listOfGroceryStores;
        }

        public static List<string> FamilyCostsList() //karate, dance, school, outings, etc - things you do with the family
        {
            List<string> listOfGroceryStores = new List<string>();
            listOfGroceryStores.Add("");
            return listOfGroceryStores;
        }
    }


    //scrape wikipedia to get lists of store names
    /*
  http://softvernow.com/2018/09/28/how-to-web-scraping-using-c/

    */




}
