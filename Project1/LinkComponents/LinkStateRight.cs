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

        public void MoveDown()
        {
            throw new NotImplementedException();
        }

        public void MoveLeft()
        {
            throw new NotImplementedException();
        }

        public void MoveRight()
        {
            throw new NotImplementedException();
        }

        public void MoveUp()
        {
            throw new NotImplementedException();
        }
    }
}
