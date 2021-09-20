using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using Project1.SpriteFactory;


namespace Project1.LinkComponents
{
    class LinkWhiteSword : ILink
    {
        public ILinkState LinkState { get; set; }
        // public ILinkItemState LinkItemState { get; set; }
        public ISpriteFactory LinkSprite { get; set; }
        private Vector2 position;
        private Game1 game;

        public LinkWhiteSword(Game1 game)
        {
            LinkState = new LinkStateUp(this, game);
            this.game = game;
        }
        public void MoveDown()
        {
            if ((int)position.Y < game.GraphicsDevice.Viewport.Height)
            {
                position.Y++;
            }
            LinkState.MoveDown();
        }

        public void MoveLeft()
        {
            if ((int)position.X > 0)
            {
                position.X--;
            }
            LinkState.MoveLeft();
        }

        public void MoveRight()
        {
            if ((int)position.X < game.GraphicsDevice.Viewport.Width)
            {
                position.X++;
            }
            LinkState.MoveRight();
        }

        public void MoveUp()
        {
            if ((int)position.Y > 0)
            {
                position.Y--;
            }
            LinkState.MoveUp();
        }

        public void Attack()
        {
            throw new NotImplementedException();
        }

        public void TakeDamage()
        {

        }
        public void UseNoItem()
        {
            game.Link = new Link(game);

        }
        public void UseMagicalRod()
        {
            game.Link = new LinkMagicalRod(game);

        }
        public void UseMagicalSheild()
        {
            game.Link = new LinkMagicalSheild(game);

        }
        public void UseMagicalSword()
        {
            game.Link = new LinkMagicalSword(game);

        }
        public void UseWhiteSword()
        {

        }
        public void UseWoodenSword()
        {
            game.Link = new LinkWoodenSword(game);

        }

        public void Draw()
        {
            LinkState.Draw();
        }

        public void Update()
        {
                  
        }
    }
}
