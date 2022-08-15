using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates_Assignment
{
    /// <summary>
    /// this is a code to show the progress when transferring files
    /// </summary>
    internal class Monitor
    { 
        public delegate void TransferLeft(int transferLeft);

        /// <summary>
        /// I had to put a delegate to see how much byte is left when a user is transferring a file
        /// </summary>
      
        public static void TransferFile(TransferLeft tl)
        {
            for (int i = 0; i < 20000; i++)
            {
                var markedTransfer = i.ToString();

                tl(i);
            }
        }
    }
}
