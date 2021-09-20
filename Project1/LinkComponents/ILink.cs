using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using Project1.SpriteFactory;
using Microsoft.Xna.Framework.Graphics;

namespace Project1.LinkComponents
{
    public interface ILink
    {
        ILinkState LinkState { get; set; }
        ILinkItemState LinkItemState { get; set; }
        int Columns { get; set; }
        int Rows { get; set; }
        int TotalFrames { get; set; }
        Texture2D Texture { get; set; }
        int start { get; set; }

        void MoveUp();
        void MoveDown();
        void MoveRight();
        void MoveLeft();
        void Attack();
        void TakeDamage(); 
        void Draw(SpriteBatch spriteBatch);
        void Update();
    }
}
