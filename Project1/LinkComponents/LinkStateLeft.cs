using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Xna.Framework;



namespace Project1.LinkComponents
{
    class LinkStateLeft : ILinkDirectionState
    {
        public ILink Link { get; set; }

        public LinkStateLeft(ILink link)
        {
            Link = link;
        }

        public void Update()
        {

        }
        
        public void MoveDown()
        {
            Link.LinkDirectionState = new LinkStateDown(Link);
        }

        public void MoveLeft()
        {
            
        }

        public void MoveRight()
        {
            Link.LinkDirectionState = new LinkStateRight(Link); 
        }

        public void MoveUp()
        {
            Link.LinkDirectionState = new LinkStateUp(Link); 
        }
    }
}
