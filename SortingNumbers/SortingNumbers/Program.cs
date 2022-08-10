namespace SortingNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {

                int[] newArray = new int[] { 34, 67, 9, 22, 43, 56, 9, 47 };
                int example;

                for (int i = 0; i < newArray.Length; i++)
                {
                    for (int arrange = i + 1; arrange < newArray.Length; arrange++)
                    {
                        if (newArray[i] < newArray[arrange])
                        {
                            example = newArray[i];
                            newArray[i] = newArray[arrange];
                            newArray[arrange] = example;
                        } 
                    }
                }
                foreach (int values in newArray)
                {
                    Console.WriteLine(values + " ");
                }
        }
    }
}