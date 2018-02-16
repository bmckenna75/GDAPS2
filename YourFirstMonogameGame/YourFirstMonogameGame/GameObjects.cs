using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace YourFirstMonogameGame
{
    class GameObjects
    {
        private Rectangle objectPos;
        public Rectangle ObjectPos
        {
            get { return objectPos; }
            set { objectPos = value; }
        }
        public int ObjectPosX
        {
            get { return objectPos.X; }
            set { objectPos.X = value; }
        }
        public int ObjectPosY
        {
            get { return objectPos.Y; }
            set { objectPos.Y = value; }
        }
        private Texture2D objectTex;

        public GameObjects(int X, int Y, int wid, int hei, Texture2D tex)
        {
            objectPos.X = X;
            objectPos.Y = Y;
            objectPos.Width = wid;
            objectPos.Height = hei;
            objectTex = tex;
        }

        public virtual void Draw(SpriteBatch SB)
        {
            SB.Draw(objectTex, objectPos, Color.White);
        }

    }
}
