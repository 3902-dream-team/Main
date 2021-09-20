using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Xna.Framework;

namespace Project1.LinkComponents
{
    class LinkStateUp : ILinkDirectionState
    {
        public ILink Link { get; set; }
        public Game1 Game { get; set; }

        public LinkStateUp(ILink link, Game1 game)
        {
            Link = link;
            Game = game; 
        }

        public void Update()
        {

        }

        public void MoveDown()
        {
            Link.LinkDirectionState = new LinkStateDown(Link, Game);
        }

        public void MoveLeft()
        {
            Link.LinkDirectionState = new LinkStateLeft(Link, Game);
        }

        public void MoveRight()
        {
            Link.LinkDirectionState = new LinkStateRight(Link, Game);
        }

        public void MoveUp()
        {
        }
    }
}
