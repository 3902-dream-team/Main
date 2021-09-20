using Microsoft.Xna.Framework;
using Project1.SpriteFactory;
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
            Update();
        }

        public void Update()
        {
            Link.Texture = LinkSpriteFactory.Instance.DirectionSpriteSheet(Link);
            Link.start = 0;
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
