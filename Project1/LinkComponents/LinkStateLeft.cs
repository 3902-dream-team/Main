using System;
using System.Collections.Generic;
using System.Text;

namespace Project1.LinkComponents
{
    class LinkStateLeft : ILinkState
    {
        public ILink Link { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public LinkStateLeft(ILink link)
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
