using System;
using AntSimulator2017Abstract.Character;

namespace AntSimulator2017Abstract.Environnement.Map
{
    public abstract class AbstractLink
    {
        public AbstractArea Area1 { get; set; }
        public AbstractArea Area2 { get; set; }
        public Boolean IsOpen { get; set; }

        public abstract void MoveTrough(Character.Character charac);
    }
}
