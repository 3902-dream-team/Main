using Microsoft.Xna.Framework.Input;
using Project1.Interfaces;
using System.Collections.Generic;

namespace Project1.Classes
{
    class KeyboardController : IController
    {
        private Dictionary<Keys, ICommand> controllerMappings;
        private Game1 myGame;

        public KeyboardController(Game1 game)
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
}