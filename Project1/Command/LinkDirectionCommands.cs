using System;
using System.Collections.Generic;
using System.Text;

namespace Project1.Command
{
    class LinkMoveUpCmd : ICommand
    {
        private Game1 game;
        public Game1 Game
        {
            get { return game; }
            set { game = value; }
        }

        public LinkMoveUpCmd(Game1 game)
        {
            this.game = game;
        }

        public void Execute()
        {
            game.Link.MoveUp();
        }
    }

    class LinkMoveDownCmd : ICommand
    {
        private Game1 game;
        public Game1 Game
        {
            get { return game; }
            set { game = value; }
        }
        public LinkMoveDownCmd(Game1 game)
        {
            this.game = game;
        }

        public void Execute()
        {
            game.Link.MoveDown();
        }
    }

    class LinkMoveRightCmd : ICommand
    {
        private Game1 game;
        public Game1 Game
        {
            get { return game; }
            set { game = value; }
        }
        public LinkMoveRightCmd(Game1 game)
        {
            this.game = game;
        }

        public void Execute()
        {
            game.Link.MoveRight();
        }
    }

    class LinkMoveLeftCmd : ICommand
    {
        private Game1 game; 
        public Game1 Game
        {
            get { return game; }
            set { game = value; }
        }

        public LinkMoveLeftCmd(Game1 game)
        {
            this.game = game;
        }

        public void Execute()
        {
            game.Link.MoveLeft();
        }
    }

    class LinkSwordAttackCmd : ICommand
    {
        private Game1 game;
        public Game1 Game
        {
            get { return game; }
            set { game = value; }
        }

        public LinkSwordAttackCmd(Game1 game)
        {
            this.game = game;
        }
        public void Execute()
        {
            // need to implement 
            // game.Link.AttackSword(); 
        }
    }
}
