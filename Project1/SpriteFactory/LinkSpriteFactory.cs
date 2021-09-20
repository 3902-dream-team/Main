using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Project1.LinkComponents;
using System;
using System.Collections.Generic;
using System.Text;

namespace Project1.SpriteFactory
{
    class LinkSpriteFactory : ISpriteFactory
    {
        private static LinkSpriteFactory instance = new LinkSpriteFactory();

        public static LinkSpriteFactory Instance
        {
            get
            {
                return instance;
            }
        }
        private LinkSpriteFactory(){}

        private static Texture2D directions;

        public void LoadAllTextures(ContentManager content)
        {
            directions = content.Load<Texture2D>("Sprites/LinkSprites/BasicMovement");
        }

        public Texture2D GetDirectionSpriteSheet(ILink Link)
        {
            Link.Columns = 6;
            Link.Rows = 1;
            Link.TotalFrames = 6;
            return directions;
        }
    }
}
