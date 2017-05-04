using System;
using AntSimulator2017Abstract.Strategy;

namespace AntSimulator2017Abstract.Environement
{
	public abstract class Character:AbstractObserver
	{
        protected int LifePoint { get; set; }
        protected String Name { get; set; }
        protected IFightingStrategy FigthingStrategy { get; set; }
        protected IMovementStrategy MovementStrategy { get; set; }
        protected Position Pos { get; set; }
	}
}
