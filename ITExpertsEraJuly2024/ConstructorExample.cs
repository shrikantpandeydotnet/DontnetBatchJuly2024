using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITExpertsEraJuly2024
{
    public class ConstructorExample
    {
        public int noOfStudents;
        public string name;

        public static string gender;

        // default constructor
        public ConstructorExample()
        {
                noOfStudents = 10;
                name = "ItExpertsEra";
        }

        // parameterized constructor.
        public ConstructorExample(bool canInsertValue)
        {
            if (canInsertValue)
            {
                noOfStudents = 10;
                name = "ItExpertsEra";
            }
        }

        public ConstructorExample(int students, string newName)
        {
            noOfStudents = students;
            name = newName;
        }

        // copy constructor..

        public ConstructorExample(ConstructorExample obj1)
        {
            noOfStudents = obj1.noOfStudents;
            name = obj1.name;
        }

        // static constructor
        static ConstructorExample()
        {
            Console.WriteLine("I am static constructor");
        }
    }
}
