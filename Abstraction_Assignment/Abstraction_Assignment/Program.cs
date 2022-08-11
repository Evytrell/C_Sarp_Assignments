namespace Abstraction_Assignment
{

    //using interface to show abstraction

     public interface ISchoolRules
    {

        public void Punctual();

        public void Neat();


        static void Main(string[] args)
        {
             
            
        }
        class Teachers : ISchoolRules
        {
            void ISchoolRules.Neat()
            {
                Console.WriteLine("I always ensure my clothes are clean and well ironed");
            }

            void ISchoolRules.Punctual()
            {
               Console.WriteLine("I leave my house early so I can get to school on time"); 
            }
        }

        class Students : ISchoolRules
        {
            void ISchoolRules.Neat()
            {
                Console.WriteLine("My uniform is always clean and ironed");
            }

            void ISchoolRules.Punctual()
            {
                Console.WriteLine(" I always like being punctual");
            }
        }
     }
    
}