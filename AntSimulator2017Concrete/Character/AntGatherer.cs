using System;
using AntSimulator2017Abstract.State;
using AntSimulator2017Abstract.Strategy;

namespace AntSimulator2017Concrete.Character
{
    public class AntGatherer : Ant
    {
        protected int load { get => load; set => load = value; }
		protected override double lifePoint { get => lifePoint; set => lifePoint = value; }
		protected override int perception { get => perception; set => perception = value; }
		protected override int hungry { get => hungry; set => hungry = value; }
		protected override int movementSpeed { get => movementSpeed; set => movementSpeed = value; }
		protected override IStrategy strategy { get => strategy; set => strategy = value; }
		protected override IState state { get => state; set => state = value; }

        public AntGatherer()
        {
        }
    }
}
