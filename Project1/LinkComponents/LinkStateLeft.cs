﻿using System;
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

        public void Draw()
        {

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
