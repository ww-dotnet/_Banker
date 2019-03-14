using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _Banker
{
    class ParseMachine
    {
        public static List<string> ParseEngine(string path)
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
