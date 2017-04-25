using System;

namespace AntSimulator2017Abstract
{
	public abstract class Character:AbstractObserver
	{
        int lifePoint { get; set; }
        String name { get; set; }
        IFightingStrategy figthingStrategy { get; set; }
        IMovementStrategy movementStrategy { get; set; }
        Position pos { get; set; }
	}
}
