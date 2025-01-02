using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITExpertsEraJuly2024
{
    public static class CollectionExample
    {
        public static void ArrayListOperation()
        {
            // Declaration
            ArrayList arrayList = new ArrayList();

            // Insert
            arrayList.Add(10);
            arrayList.Add("Mangoes");
            arrayList.Add(10.5);
            arrayList.Add(true);

            // Read the value
            int value1 = Convert.ToInt32(arrayList[0]);
            string value2 = Convert.ToString(arrayList[1]);
            decimal value3 = Convert.ToDecimal(arrayList[2]);
            bool value4 = Convert.ToBoolean(arrayList[3]);


            // insert the value
            arrayList.Insert(2, "Rashi");

            string value5 = Convert.ToString(arrayList[2]);

            //update
            arrayList[2] = "Shivani";
            arrayList[3] = 10;

            // delete

            arrayList.Remove("Mangoes");
            arrayList.RemoveAt(2);
            arrayList.Clear();

            // property

            int size = arrayList.Count;

            bool isexist = arrayList.Contains(10);

        }

        public static void HashTableOperation()
        {
            // Declare object
            Hashtable objHashTable = new Hashtable();

            // Insert 

            objHashTable.Add(10, "Rashi");
            objHashTable.Add("abc", 20);
            objHashTable.Add(30, true);
            objHashTable.Add(40, DateTime.Now);

            // Read values

            string value1 = Convert.ToString(objHashTable[10]);
            int value2 = Convert.ToInt32(objHashTable["abc"]);
            bool value3 = Convert.ToBoolean(objHashTable[30]);
            DateTime value4 = Convert.ToDateTime(objHashTable[40]);

            bool hasKey1 = objHashTable.Contains("abc");

            // update 

            objHashTable["abc"] = 50;

            //Delete

            objHashTable.Remove(30);

            objHashTable.Clear();

            int count = objHashTable.Count;

            bool hasKey = objHashTable.Contains("abc");
        }
    }
}
