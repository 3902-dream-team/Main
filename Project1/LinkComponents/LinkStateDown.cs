using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace Project1.LinkComponents
{
    class LinkStateDown : ILinkState
    {
        public ILink Link { get; set; }

        public void MoveDown()
        {
            
        }

        public void MoveLeft()
        {
            Link.LinkState = new LinkStateLeft(Link);
        }

        public void MoveRight()
        {
            Link.LinkState = new LinkStateRight(Link);
        }

        public void MoveUp()
        {
            Link.LinkState = new LinkStateUp(Link);
        }
    }
}
