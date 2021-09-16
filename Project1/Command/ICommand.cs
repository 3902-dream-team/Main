using System;
using System.Collections.Generic;
using System.Text;

namespace Project1.Interfaces
{
    public interface ICommand
    {
        Game1 game { get; set; }

        void Execute();
    }
}
