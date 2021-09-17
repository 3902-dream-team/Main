using System;
using System.Collections.Generic;
using System.Text;

namespace Project1.LinkComponents
{
    public interface ILink
    {
        private static ILinkState LinkState;
        private static ILinkItemState LinkItemState;
        void MoveUp();
        void MoveDown();
        void MoveRight();
        void MoveLeft();
    }
}
