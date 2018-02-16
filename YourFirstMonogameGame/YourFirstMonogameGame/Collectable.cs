using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework.Graphics;

namespace YourFirstMonogameGame
{
    class Collectable : GameObjects
    {
        private bool active;
        public bool Active
        {
            get { return active; }
            set { active = value; }
        }

        public Collectable(int X, int Y, int wid, int hei, Texture2D tex) : base(X, Y, wid, hei, tex)
        {
            active = true;
        }

        public bool CheckCollision(GameObjects thing)
        {
            if (active)
            {
                if (this.ObjectPos.Intersects(thing.ObjectPos))
                {
                    active = false;
                    return true;
                }
            } 
            return false;
        }

        public override void Draw(SpriteBatch SB)
        {
            if (active)
            {
                base.Draw(SB);
            }
        }



    }
}
