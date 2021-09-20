using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Xna.Framework;
using Project1.SpriteFactory;

namespace Project1.LinkComponents
{
    class LinkStateLeft : ILinkDirectionState
    {
        public ILink Link { get; set; }
        public Game1 Game { get; set; }

        public LinkStateLeft(ILink link, Game1 game)
        {
            Link = link;
            Game = game;
            Update();
        }

        public void Update()
        {
            Link.Texture = LinkSpriteFactory.Instance.DirectionSpriteSheet(Link);
            Link.start = 6;
        }
        public void MoveDown()
        {
            Link.LinkDirectionState = new LinkStateDown(Link, Game);
        }

        public void MoveLeft()
        {
            
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
