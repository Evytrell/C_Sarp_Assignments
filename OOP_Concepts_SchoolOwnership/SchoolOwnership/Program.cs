namespace SchoolOwnership
{
    internal class Program
    {
        static void Main(string[] args)
        {
            NewSchoolRegistration newSchoolRegistration = new NewSchoolRegistration();                            
            SchoolOwnerDetails schoolOwnerDetails = new SchoolOwnerDetails();
            Returns returns = new Returns();
            PersonalDetails personalDetails = new PersonalDetails();


             Console.WriteLine("Please enter your years of experience");
             newSchoolRegistration.YearsOfExperience = Convert.ToInt32(Console.ReadLine());
             Console.WriteLine(newSchoolRegistration.CheckExperience());       

             Console.WriteLine("please enter the amount you have to manage the schhol");
             newSchoolRegistration.Account = Convert.ToDouble(Console.ReadLine());
             Console.WriteLine(newSchoolRegistration.CheckFinances());

             Console.WriteLine("Please enter the number of teachers");
             schoolOwnerDetails.NoOfTeachers = Convert.ToInt32(Console.ReadLine());
             Console.WriteLine(schoolOwnerDetails.NumberOfTeachers());

             Console.WriteLine("Did you go to a teacher's training school(true/false)");
             schoolOwnerDetails.TrainingSchool = Convert.ToBoolean(Console.ReadLine());
             Console.WriteLine(schoolOwnerDetails.IsTrainingProvided());

             Console.WriteLine("Please enter your first name");
             Console.ReadLine();
             Console.WriteLine("Please enter your Last name");
             Console.ReadLine();
            
            Console.WriteLine("Please enter your age");
            personalDetails.Age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(personalDetails.OwnerDetails());

            returns.MonthlyReturn();

        }
    }
}