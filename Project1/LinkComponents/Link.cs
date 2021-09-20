using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using Project1.SpriteFactory;
using Microsoft.Xna.Framework.Graphics;

namespace Project1.LinkComponents
{
    class Link : ILink
    {
        public ILinkState LinkState { get; set; }
        public ILinkItemState LinkItemState { get; set; }
        public Texture2D Texture;
        public int Columns { get; set; }
        public int TotalFrames { get; set; }
        public int Rows { get; set; }
        private int currentFrame;
        private Vector2 position;
        private Game1 game;

        public Link(Game1 game)
        {
            LinkState = new LinkStateUp(this, game);
            this.game = game;
            Texture = LinkSpriteFactory.Instance.GetDirectionSpriteSheet(this);
        }
        public void MoveDown()
        {
            if ((int)position.Y < game.GraphicsDevice.Viewport.Height)
                position.Y++;
            
            LinkState.MoveDown();
        }

        public void MoveLeft()
        {
            if ((int)position.X > 0)
                position.X--;
            
            LinkState.MoveLeft();
        }

        public void MoveRight()
        {
            if ((int)position.X < game.GraphicsDevice.Viewport.Width)
                position.X++;
            
            LinkState.MoveRight();
        }

        public void MoveUp()
        {
            if ((int)position.Y > 0)
                position.Y--;
            
            LinkState.MoveUp();
        }

        public void Attack()
        {
            throw new NotImplementedException();
        }

        public void TakeDamage()
        {

        }
        public void Draw(SpriteBatch spriteBatch)
        {
            int width = Texture.Width / Columns;
            int height = Texture.Height;
            int column = currentFrame % Columns;
            Rectangle sourceRectangle = new Rectangle(width*column, height, width, height);
            Rectangle destinationRectangle = new Rectangle((int)position.X, (int)position.Y, 50, 50);
            spriteBatch.Draw(Texture, destinationRectangle, sourceRectangle, Color.White);
        }

        public void Update()
        {
            currentFrame++;
            if (currentFrame == TotalFrames)
                currentFrame = 0;
        }
    }
}
