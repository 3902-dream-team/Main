using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Xna.Framework;

namespace Project1.LinkComponents
{
    class LinkStateRight : ILinkDirectionState
    {
        public ILink Link { get; set; }

        public LinkStateRight(ILink link)
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
        }

        public void MoveUp()
        {
            Link.LinkDirectionState = new LinkStateUp(Link); 
        }
    }
}
