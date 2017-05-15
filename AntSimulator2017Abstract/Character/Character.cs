using System;
using AntSimulator2017Abstract.Mission;
using AntSimulator2017Abstract.State;
using AntSimulator2017Abstract.Strategy;

namespace AntSimulator2017Abstract.Character
{
    public abstract class Character : AbstractObservable,AbstractObserver
    {
        public abstract double lifePoint { get; set; }
        public abstract int perception { get; set; }
        public abstract int hungry { get; set; }
        public abstract int movementSpeed { get; set; }
        public string name { get; set; }
        public Position position { get; set; }
        public abstract IStrategy strategy { get; set; }
        public abstract IState state { get; set; }
        public abstract AbstractMission mission { get; set; }

        public abstract void update(object data);


    }
}
