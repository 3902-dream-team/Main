using System;
using System.Collections.Generic;
using System.Text;

namespace Project1.LinkComponents
{
    class LinkStateDown : ILinkState
    {
        public ILink Link { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

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
