using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueueStacker
{
    interface IQueue
    {

            bool IsEmpty { get; }
            int Count { get; }
            void Enqueue(string player);
            String Dequeue();
            String Peek();

    }
}
