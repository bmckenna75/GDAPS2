using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace YourFirstMonogameGame
{
    class Player : GameObjects 
    {
        private int levelScore;
        public int LevelScore
        {
            get { return levelScore; }
        }
        private int totalScore;
        public int TotalScore
        {
            get { return totalScore; }
        }


        public Player(int X, int Y, int wid, int hei, Texture2D tex) : base(X, Y, wid, hei, tex)
        {
            levelScore = 0;
            totalScore = 0;
        }
    }
}
