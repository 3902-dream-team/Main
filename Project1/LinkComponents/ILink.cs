using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using Project1.SpriteFactory;


namespace Project1.LinkComponents
{
    public interface ILink
    {
        ILinkState LinkState { get; set; }
        ISpriteFactory LinkSprite { get; set; }
        // ILinkItemState LinkItemState { get; set; }
        void MoveUp();
        void MoveDown();
        void MoveRight();
        void MoveLeft();
        void Attack();
        void TakeDamage(); 
        void Draw();
        void Update();
    }
}
