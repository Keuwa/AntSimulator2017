using System;
using AntSimulator2017Abstract.Character;
using AntSimulator2017Abstract.Strategy;
using AntSimulator2017Concrete.Environnement.Map;
using AntSimulator2017Concrete.item;

namespace AntSimulator2017Concrete.Strategy
{
    public abstract class BaseStrategy : AntSimulator2017Abstract.Strategy.IStrategy
    {
		public AntSimulator2017Abstract.Character.Character Charac { get; set; }

		public BaseStrategy(AntSimulator2017Abstract.Character.Character charac)
		{
			this.Charac = charac;
		}

        public void PutPheromones(String pheromonType){
            Area current = (Area)Simulation.AntSimulation.Instance.Environnement.Map.areas[this.Charac.position.x][this.Charac.position.y];
            foreach (PheromonesItem phero in current.Pheromones){
                if(phero.Type.Equals(pheromonType)){
                    phero.turnDuration = PheromonesItem.DURATION;
                }
            }
            current.Pheromones.Add((PheromonesItem)new PheromonesFactory().CreateItemWithType(pheromonType));
        }

        public abstract void UpdateCharacterStrategy(AntSimulator2017Abstract.Character.Character context, IStrategy strategyReplacement);
        public abstract void Execute();
    }
}
