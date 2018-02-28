using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueueStacker
{
    interface IStack
    {
        bool IsEmpty { get; }
        int Count { get; }
        void Push(string spell);
        String Pop();
        String Peek();

    }
}
