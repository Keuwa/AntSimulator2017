using System;
using AntSimulator2017Abstract.State;
using AntSimulator2017Abstract.Strategy;

namespace AntSimulator2017Abstract.Character
{
	public abstract class Character
	{
        public abstract double lifePoint { get; set; }
        public abstract int perception { get; set; }
        public abstract int hungry { get; set; }
        public abstract int movementSpeed { get; set; }
        public String name { get; set; }
        public Position position { get; set; }
        public abstract IStrategy strategy { get; set; }
        public abstract IState state { get; set; }

	}
}
