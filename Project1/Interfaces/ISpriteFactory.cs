using Microsoft.Xna.Framework.Content;
using System;
using System.Collections.Generic;
using System.Text;

namespace Project1.Interfaces
{
    interface ISpriteFactory
    {
        private static readonly ISpriteFactory instance;
        ISpriteFactory Instance { get; }
        void LoadAllTextures(ContentManager content);
    }
}
