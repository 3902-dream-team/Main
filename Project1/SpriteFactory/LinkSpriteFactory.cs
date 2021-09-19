using Microsoft.Xna.Framework.Content;
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
        private LinkSpriteFactory()
        {

        }

        public void LoadAllTextures(ContentManager content)
        {
            throw new NotImplementedException();
        }
    }
}
