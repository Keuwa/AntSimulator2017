using System;
using AntSimulator2017Abstract.Mission;
using AntSimulator2017Abstract.State;
using AntSimulator2017Abstract.Strategy;

namespace AntSimulator2017Abstract.Character
{
    public abstract class Character : AbstractObservable,AbstractObserver
    {
        public double lifePoint { get; set; }
        public int perception { get; set; }
        public int hungry { get; set; }
        public int movementSpeed { get; set; }
        public string name { get; set; }
        public Position position { get; set; }
        public IStrategy strategy { get; set; }
        public IState state { get; set; }
        public AbstractMission mission { get; set; }

        public abstract void update(AbstractObservable src, object data);
    }
}
