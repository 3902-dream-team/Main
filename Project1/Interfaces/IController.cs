using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Text;

namespace Project1.Interfaces
{
    interface IController
    {
        void RegisterCommand(ICommand command, Keys key = Keys.None);
        void Update();
    }
}
