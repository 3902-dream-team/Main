using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace Project1.LinkComponents
{
    class Link : ILink
    {
        public ILinkState LinkState { get; set; }
        public ILinkItemState LinkItemState { get; set; }
        private Vector2 position;
        private Game1 game;

        public Link(Game1 game)
        {
            LinkState = new LinkStateUp(this);
            this.game = game;
        }
        public void MoveDown()
        {
            if ((int)position.Y < game.GraphicsDevice.Viewport.Height)
            {
                position.Y++;
            }
            LinkState.MoveDown();
        }

        public void MoveLeft()
        {
            if ((int)position.X > 0)
            {
                position.X--;
            }
            LinkState.MoveLeft();
        }

        public void MoveRight()
        {
            if ((int)position.X < game.GraphicsDevice.Viewport.Width)
            {
                position.X++;
            }
            LinkState.MoveRight();
        }

        public void MoveUp()
        {
            if ((int)position.Y > 0)
            {
                position.Y--;
            }
            LinkState.MoveUp();
        }

        public void SwordAttack()
        {
            throw new NotImplementedException();
        }
        public void Draw()
        {
            LinkState.Draw(); 
        }

        public void Update()
        {
            LinkState.Draw();        
        }
    }
}
