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
        



    class ParseMachine
    {
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
                bool gasStationCost = false;
                bool groceryStoreCost = false;
                bool deptStoreCost = false;
                bool shippingStoreCost = false;
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
                                List<string> splitData = field.Split(' ').ToList();
                                foreach (string item in splitData) {
                                    Console.WriteLine("************************" + item);
                                }
                                if (gasStationList.Contains(field))
                                {
                                    gasStationCost = true;
                                } else if (groceryStoreList.Contains(field))
                                {
                                    groceryStoreCost = true;
                                } else if (departmentStoreList.Contains(field))
                                {
                                    deptStoreCost = true;
                                } else if (shippingStoreList.Contains(field))
                                {
                                    shippingStoreCost = true;
                                }
                                splitData.Clear();
                                lineBuilder.Add(field);
                                Console.WriteLine(field);
                            }                            
                            else
                            {
                                continue;
                            }
                        }
                        else
                        {
                            string lineConcat = String.Join(" ", lineBuilder);
                            if (gasStationCost)
                            {
                                ListFactory.gasStationCost.Add(lineConcat);
                            } else if (groceryStoreCost)
                            {
                                ListFactory.groceryStoreCost.Add(lineConcat);
                            } else if (deptStoreCost)
                            {
                                ListFactory.deptStoreCost.Add(lineConcat);
                            } else if (shippingStoreCost)
                            {
                                ListFactory.shippingStoreCost.Add(lineConcat);
                            } else
                            {
                                ListFactory.undefinedCost.Add(lineConcat);
                            }
                            gasStationCost = false;
                            groceryStoreCost = false;
                            deptStoreCost = false;
                            shippingStoreCost = false;
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
