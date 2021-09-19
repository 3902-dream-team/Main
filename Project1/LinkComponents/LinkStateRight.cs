using System;
using System.Collections.Generic;
using System.Text;

namespace Project1.LinkComponents
{
    class LinkStateRight : ILinkState
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
            Link.LinkState = new LinkStateDown(Link); 
        }

        public void MoveLeft()
        {
            Link.LinkState = new LinkStateLeft(Link); 
        }

        public void MoveRight()
        {
        }

        public void MoveUp()
        {
            Link.LinkState = new LinkStateUp(Link); 
        }
    }
}
