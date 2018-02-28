using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueueStacker
{
    class GameStack : IStack
    {
        //fields
        private List<string> spells;
        public bool IsEmpty
        {
            get { if (spells.Count == 0) { return true; } return false; }
        }
        public int Count { get { return spells.Count; } }


        //constructor
        public GameStack()
        {
            spells = new List<string>();
        }

        //methods

        public void Push(string spell)
        {
            spells.Add(spell);
        }


        /// <summary>
        /// Resolves the top item of the stack
        /// </summary>
        public string Pop()
        {
            if (spells.Count > 0)
            {
                string tempSpell = spells[spells.Count - 1];
                spells.RemoveAt(spells.Count - 1);
                return tempSpell;
            }
            return "";

        }

        public string Peek()
        {
            if (spells.Count > 0)
            {
                return spells[spells.Count - 1];
            }
            return "";
        }



    }
}
