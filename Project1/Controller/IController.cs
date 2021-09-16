using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Text;
using Project1.Command;

namespace Project1.Controller
{
    public interface IController
    {
        void RegisterCommand(ICommand command, Keys key = Keys.None);
        void Update();
    }
}
