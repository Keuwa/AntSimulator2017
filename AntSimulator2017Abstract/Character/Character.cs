using System;

namespace AntSimulator2017Abstract
{
	public abstract class Character:AbstractObserver,IFightingStrategy,IMovementStrategy
	{
		private int lifePoint;
		private String name;

		public abstract void fight();
		public abstract void move();
	}
}
