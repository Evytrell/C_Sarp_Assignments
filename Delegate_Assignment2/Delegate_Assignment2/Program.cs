namespace Delegate_Assignment2
{
    internal class Program
    {
        public delegate bool Pred(XClass x);
        
        static void Main(string[] args)
        {
            var likelyUsername = "Evelyn445";

            Pred classx = (XClass x) =>
            {
                if (x.UserName == likelyUsername)  // this line is to check if username is equal to likely username
                {
                    return true;
                }
                else
                {
                    return false;
                }
            };

        }
    }
    class XClass
    {
        public string LastName { get; set; }    
        public string FirstName { get; set; }   
        public string UserName { get; set; }    

    }
}