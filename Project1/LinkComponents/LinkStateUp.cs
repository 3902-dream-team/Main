using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Xna.Framework;

namespace Project1.LinkComponents
{
    class LinkStateUp : ILinkDirectionState
    {
        public ILink Link { get; set; }

        public LinkStateUp(ILink link)
        {
            Link = link;
        }

        public void Update()
        {

        }

        public void MoveDown()
        {
            Link.LinkDirectionState = new LinkStateDown(Link);
        }

        public void MoveLeft()
        {
            Link.LinkDirectionState = new LinkStateLeft(Link);
        }

        public void MoveRight()
        {
            Link.LinkDirectionState = new LinkStateRight(Link);
        }

        public void MoveUp()
        {
        }
    }
}
