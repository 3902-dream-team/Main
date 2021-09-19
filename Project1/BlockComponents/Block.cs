using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Project1.BlockComponents
{
    class Block : IBlock
    {
        private Vector2 position = new Vector2(0, 0);

        public Block(Vector2 position)
        {
            this.position = position;
        }

        public void Draw()
        {
            Texture2D texture;
            Rectangle sourceRectangle;
            Rectangle destinationRectangle = new Rectangle((int)position.X, (int)position.Y, 16, 16);


        }
    }
}
