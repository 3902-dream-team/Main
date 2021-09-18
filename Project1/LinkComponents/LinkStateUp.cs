using System;
using System.Collections.Generic;
using System.Text;

namespace Project1.LinkComponents
{
    class LinkStateUp : ILinkState
    {
        public ILink Link { get; set; }

        public LinkStateUp(ILink link)
        {
            Link = link;
        }

        public void Update()
        {

        }

        public void Draw()
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
            Link.LinkState = new LinkStateRight(Link);
        }

        public void MoveUp()
        {
            throw new NotImplementedException();
        }
    }
}
