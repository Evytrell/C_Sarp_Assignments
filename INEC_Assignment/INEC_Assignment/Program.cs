using System.Collections;

namespace assignment_INEC

{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] votersName = {"John", "Ada", "Chika", "Ayo", "Ojo", "Ada", "Chika", "Ayo", "Adamu", "Bola" };

            Dictionary<string, int> userDic= new Dictionary<string, int>();
            foreach (var item in votersName)
            {
                if (userDic.ContainsKey(item))
                {
                    userDic[item]++;
                }
                else
                {
                    userDic[item] = 1;
                }

            }
            Console.WriteLine("Names of users and number of times registered");

            foreach (var item in userDic)
            {
                if (item.Value > 1)
                {
                    Console.WriteLine(item.Key + ": " + item.Value);
                }
            }
            
            // Using hashset to detect duplicate names 

            Console.WriteLine("\n\nUnique voters list");

            HashSet<string> unique = votersName.ToHashSet();
            foreach (string item in unique)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();


            






        }
    }
}