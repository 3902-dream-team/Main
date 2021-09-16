using System;
using System.Collections.Generic;
using System.Text;

namespace Project1.Classes
{
    class KeyboardController : IController
    {
        private Dictionary<Keys, ICommand> controllerMappings;
        private Game1 myGame;

        public KeyboardController(Game game)
        {
            myGame = game;
            controllerMappings = new Dictionary<Keys, ICommand>();
        }

        void RegisterCommand(ICommand command, Keys key = Keys.None)
        {

        }
        void Update()
        {

        }
    }