using System;
using System.Collections.Generic;
using System.Text;

namespace Project1.Command
{
    class MoveUpCmd : ICommand
    {
        public Game1 game { get; set; }

        public MoveUpCmd (Game1 game)
        {
            this.game = game;
        }

        public void Execute()
        {
            game.Link.MoveUp();
        }
    }

    class MoveDownCmd : ICommand
    {
        public Game1 game { get; set; }

        public MoveDownCmd(Game1 game)
        {
            this.game = game;
        }

        public void Execute()
        {
            game.Link.MoveDown();
        }
    }

    class MoveRightCmd : ICommand
    {
        public Game1 game { get; set; }

        public MoveRightCmd(Game1 game)
        {
            this.game = game;
        }

        public void Execute()
        {
            game.Link.MoveRight();
        }
    }

    class MoveLeftCmd : ICommand
    {
        public Game1 game { get; set; }

        public MoveLeftCmd(Game1 game)
        {
            this.game = game;
        }

        public void Execute()
        {
            game.Link.MoveLeft();
        }
    }
}
