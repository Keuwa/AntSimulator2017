using System;

namespace AntSimulator2017Abstract.Character
{
	public abstract class Character
	{
        protected double lifePoint { get; set; }
        protected int perception { get; set; }
        protected int hungry { get; set; }
        protected int movementSpeed { get; set; }
        protected String name { get; set; }
        protected Position position { get; set; }
	}
}
