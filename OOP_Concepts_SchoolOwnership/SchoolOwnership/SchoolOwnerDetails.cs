using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolOwnership
{
    public class SchoolOwnerDetails : ISchoolOwnerRules
    {
        public int NoOfTeachers { get; set; }
        public bool TrainingSchool { get; set; }
        public string NumberOfTeachers()
        {


            if (NoOfTeachers < 15)
            {
                return "Lack of adequate teachers";
            }
            else
            {
                return "Accurate number of teachers";
            }

        }
        public string IsTrainingProvided()

        {


            if (TrainingSchool)
            {
                return "Training level accepted";
            }
            else
            {
                return "Not up to training level required";
            }
        }
    }
    public class PersonalDetails
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public string OwnerDetails( string firstName, string lastName)
        {
            Console.WriteLine("Please enter your first name");
            firstName =Convert.ToString(Console.ReadLine());
            Console.WriteLine("Please enter your Last name");
            lastName = Convert.ToString(Console.ReadLine());
            string Name = firstName + lastName;
            Console.WriteLine("FullName:  " + Name);
            return Name;    
        }

        public string OwnerDetails()
        {

            if(Age < 35)
            {
                return "Not up to the age of owning a school";
            }

            else
            {
                return "Passed age requirement";
            }

        }





    }
   

}

    






















