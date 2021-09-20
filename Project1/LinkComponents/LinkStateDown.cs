using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace Project1.LinkComponents
{
    class LinkStateDown : ILinkDirectionState
    {
        public ILink Link { get; set; }
        public Game1 Game { get; set; }

        public LinkStateDown(ILink link, Game1 game)
        {
            Link = link;
            Game = game; 
        }

        public void Update()
        {

        }
        public void MoveDown()
        {
            
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
            Link.LinkDirectionState = new LinkStateUp(Link, Game);
        }
    }
}
