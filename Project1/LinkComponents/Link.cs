using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using Project1.SpriteFactory;


namespace Project1.LinkComponents
{
    class Link : ILink
    {
        public ILinkDirectionState LinkDirectionState { get; set; }
        public ILinkItemState LinkItemState { get; set; }
        public ISpriteFactory LinkSprite { get; set; }
        private Vector2 position;
        private Game1 game;

        public Link(Game1 game)
        {
            LinkDirectionState = new LinkStateUp(this, game);
            LinkItemState = new LinkStateNoItem(this); 
            this.game = game;
        }
        public void MoveDown()
        {
            if ((int)position.Y < game.GraphicsDevice.Viewport.Height)
            {
                position.Y++;
            }
            LinkDirectionState.MoveDown();
        }

        public void MoveLeft()
        {
            if ((int)position.X > 0)
            {
                position.X--;
            }
            LinkDirectionState.MoveLeft();
        }

        public void MoveRight()
        {
            if ((int)position.X < game.GraphicsDevice.Viewport.Width)
            {
                position.X++;
            }
            LinkDirectionState.MoveRight();
        }

        public void MoveUp()
        {
            if ((int)position.Y > 0)
            {
                position.Y--;
            }
            LinkDirectionState.MoveUp();
        }

        public void Attack()
        {
            throw new NotImplementedException();
        }

        public void TakeDamage()
        {

        }

        public void UseNoItem()
        {
            LinkItemState.UseNoItem();
        }
        public void UseMagicalRod()
        {
            LinkItemState.UseMagicalRod(); 
        }
        public void UseMagicalSheild()
        {
            LinkItemState.UseMagicalSheild();
        }
        public void UseMagicalSword()
        {
            LinkItemState.UseMagicalSword();
        }
        public void UseWhiteSword()
        {
            LinkItemState.UseWhiteSword();
        }
        public void UseWoodenSword()
        {
            LinkItemState.UseWoodenSword();
        }

        public void Draw()
        {
            // LinkState.Draw();
        }

        public void Update()
        {
                  
        }
    }
}
