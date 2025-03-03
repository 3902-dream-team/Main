﻿using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using Project1.SpriteFactory;


namespace Project1.LinkComponents
{
    class LinkStateNoItem : ILinkItemState
    {
        public ILink Link { get; set; }
        public Boolean IsAttaking { get; set; }
        public LinkStateNoItem(ILink link)
        {
            Link = link;
            IsAttaking = false;
        }

        public void Attack()
        {
        }

        public void TakeDamage()
        {
            Link.LinkItemState = new LinkStateDamage(Link);
        }

        public void UseNoItem()
        {

        }
        public void UseMagicalRod()
        {
            Link.LinkItemState = new LinkStateMagicalRod(Link);
        }
        public void UseMagicalSheild()
        {
            Link.LinkItemState = new LinkStateMagicalSheild(Link);

        }
        public void UseMagicalSword()
        {
            Link.LinkItemState = new LinkStateMagicalSword(Link);

        }
        public void UseWhiteSword()
        {
            Link.LinkItemState = new LinkStateWhiteSword(Link);
        }
        public void UseWoodenSword()
        {
            Link.LinkItemState = new LinkStateWoodenSword(Link);
        }
    }
}
