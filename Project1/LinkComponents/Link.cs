using System;
using System.Collections.Generic;
using System.Text;

namespace Project1.LinkComponents
{
    class Link : ILink
    {
        public ILinkState LinkState { get; set; }
        public ILinkItemState LinkItemState { get; set; }

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
