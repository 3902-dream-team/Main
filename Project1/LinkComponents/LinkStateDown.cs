using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace Project1.LinkComponents
{
    class LinkStateDown : ILinkDirectionState
    {
        public ILink Link { get; set; }

        public LinkStateDown(ILink link)
        {
            Link = link; 
        }

        public void Update()
        {

        }
        public void MoveDown()
        {
            
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
            Link.LinkDirectionState = new LinkStateUp(Link);
        }
    }
}
