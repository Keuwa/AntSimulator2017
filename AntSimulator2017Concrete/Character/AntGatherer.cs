﻿using System;
using AntSimulator2017Abstract;
using AntSimulator2017Abstract.Mission;
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
        public override AbstractMission mission { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public AntGatherer()
        {
        }
        // recevoir mission


        public override void notify(object datas)
        {
            throw new NotImplementedException();
        }

        public override void update(AbstractObservable src, object data)
        {
            throw new NotImplementedException();
        }
        // notifier fin de mission 

    }
}
