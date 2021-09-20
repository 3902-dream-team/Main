using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace Project1.LinkComponents
{
    class LinkStateDown : ILinkState
    {
        public ILink Link { get; set; }
        public Game1 Game { get; set; }

        public LinkStateDown(ILink link, Game1 game)
        {
            Link = link;
            Game = game; 
        }
        public void MoveDown()
        {
            
        }

        public void MoveLeft()
        {
            Link.LinkState = new LinkStateLeft(Link, Game);
        }

        public void MoveRight()
        {
            Link.LinkState = new LinkStateRight(Link, Game);
        }

        public void MoveUp()
        {
            Link.LinkState = new LinkStateUp(Link, Game);
        }
    }
}
