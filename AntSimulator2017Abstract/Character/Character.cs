using System;
using AntSimulator2017Abstract.State;
using AntSimulator2017Abstract.Strategy;

namespace AntSimulator2017Abstract.Character
{
	public abstract class Character
	{
        protected abstract double lifePoint { get; set; }
        protected abstract int perception { get; set; }
        protected abstract int hungry { get; set; }
        protected abstract int movementSpeed { get; set; }
        protected String name { get; set; }
        protected Position position { get; set; }
        protected abstract IStrategy strategy { get; set; }
        protected abstract IState state { get; set; }

	}
}
