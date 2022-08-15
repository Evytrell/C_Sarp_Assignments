namespace Delegates_Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
             Monitor.TransferFile(ProgressMeter);
        }

        public static void ProgressMeter(int transferredBytes)

        {
             Console.WriteLine($"the progress report {transferredBytes} remaining");
        }
    }
}