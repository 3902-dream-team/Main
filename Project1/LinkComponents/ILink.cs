using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using Project1.SpriteFactory;


namespace Project1.LinkComponents
{
    public interface ILink
    {
        ILinkDirectionState LinkDirectionState { get; set; }
        ILinkItemState LinkItemState { get; set; }

        ISpriteFactory LinkSprite { get; set; }
        // ILinkItemState LinkItemState { get; set; }
        void MoveUp();
        void MoveDown();
        void MoveRight();
        void MoveLeft();
        void Attack();
        void TakeDamage();
        void UseNoItem();
        void UseMagicalRod();
        void UseMagicalSheild();
        void UseMagicalSword();
        void UseWhiteSword();
        void UseWoodenSword();
        void Draw();
        void Update();
    }
}
