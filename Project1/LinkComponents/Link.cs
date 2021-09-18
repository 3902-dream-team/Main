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
        public Vector2 Position { get; set; }

        public Link()
        {
            LinkState = new LinkStateUp(this);
        }
        public void MoveDown()
        {
            LinkState.MoveDown();
        }

        public void MoveLeft()
        {
            LinkState.MoveLeft();
        }

        public void MoveRight()
        {
            LinkState.MoveRight();
        }

        public void MoveUp()
        {
            LinkState.MoveUp();
        }

        public void SwordAttack()
        {
            throw new NotImplementedException();
        }
        public void Draw()
        {
            throw new NotImplementedException();
        }
    }
}
