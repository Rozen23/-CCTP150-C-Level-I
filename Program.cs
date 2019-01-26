using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    class Program
    {
        static void Main(string[] args)
        {
            bool attendingSchool = true;
            bool workingFullTime =false;
            bool attendingSchoolandWorking=attendingSchool && workingFullTime;

            string name ="Khevna";
            string city= "Edmonon";

            int yearsCollege=2;
            int yearsUniversity=1;
            int totalPostSecondaryYears = yearsCollege + yearsUniversity;
            bool moreThan4YearsPostSecondary = totalPostSecondaryYears>4;

            bool hardworking = true;
            bool smart = true;

            Console.WriteLine("Name "+name +" from "+ city);
            Console.WriteLine("Attending school and working: " + attendingSchoolandWorking);
            Console.WriteLine("More Than 4 Years of PostSecondary: " + moreThan4YearsPostSecondary);
            Console.WriteLine("Hard Working or Smart: " + (hardworking || smart));

        }
    }
}
