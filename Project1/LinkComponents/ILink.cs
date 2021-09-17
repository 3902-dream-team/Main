using System;
using System.Collections.Generic;
using System.Text;

namespace Project1.LinkComponents
{
    public interface ILink
    {
        ILinkState LinkState { get; set; }
        ILinkItemState LinkItemState { get; set; }
        void MoveUp();
        void MoveDown();
        void MoveRight();
        void MoveLeft();
    }
}
