using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueueStacker
{
    class GameQueue : IQueue
    {
        //fields
        private List<string> login;
        public bool IsEmpty
        {
            get { if (login.Count == 0) { return true; } return false; }
        }
        public int Count { get { return login.Count; } }

        //constructor
        public GameQueue()
        {
            login = new List<string>();
        }

        //methods

        public void Enqueue(string player)
        {
            login.Add(player);
        }

        public string Dequeue()
        {
            if (login.Count > 0)
            {
                string tempLogin = login[0];
                login.RemoveAt(0);
                return tempLogin;
            }
            return "";
        }

        public string Peek()
        {
            if (login.Count > 0)
            {
                return login[0];
            }
            return "";
        }


    }
}
