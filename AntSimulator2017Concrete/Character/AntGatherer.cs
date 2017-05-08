using System;
using AntSimulator2017Abstract.State;
using AntSimulator2017Abstract.Strategy;

namespace AntSimulator2017Concrete.Character
{
    public class AntGatherer : Ant
    {
        public int load { get => load; set => load = value; }
		public override double lifePoint { get => lifePoint; set => lifePoint = value; }
		public override int perception { get => perception; set => perception = value; }
		public override int hungry { get => hungry; set => hungry = value; }
		public override int movementSpeed { get => movementSpeed; set => movementSpeed = value; }
		public override IStrategy strategy { get => strategy; set => strategy = value; }
		public override IState state { get => state; set => state = value; }

        public AntGatherer()
        {
        }
    }
}
