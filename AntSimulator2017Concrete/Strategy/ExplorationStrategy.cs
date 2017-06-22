using System;
using System.Collections.Generic;
using AntSimulator2017Abstract.Character;
using AntSimulator2017Abstract.Environnement.Map;
using AntSimulator2017Abstract.Strategy;
using AntSimulator2017Concrete.Environnement.Map;
using AntSimulator2017Concrete.item;

namespace AntSimulator2017Concrete.Strategy
{
    public class ExplorationStrategy : BaseStrategy
    {
        public ExplorationStrategy(AntSimulator2017Abstract.Character.Character charac) : base(charac)
        {
        }

        public override void Execute()
        {
			List<AbstractLink> links = new List<AbstractLink>();

			var map = AntSimulator2017Abstract.Simulation.AbstractSimulation.Instance.Environnement.Map;
			var current = map.areas[Charac.position.x][Charac.position.y];
			var chara = Charac.position;

			foreach (var link in current.Links)
			{
				if (link.IsOpen && link.IsAreaAccessible(current.Position))
				{
                    Area area = (AntSimulator2017Concrete.Environnement.Map.Area)link.GetArrivalArea(current);
                    if(area.Pheromones.Count ==0){
                        links.Add(link);
                    }
				}
			}

			int x = links.Count;
			if (x != 0)
			{
				x = AntSimulator2017Abstract.Simulation.AbstractSimulation.Instance.Random.Next(x);
				links[x].MoveTrough(Charac);
			}
            else{
                x = current.Links.Count;
				x = AntSimulator2017Abstract.Simulation.AbstractSimulation.Instance.Random.Next(x);
				current.Links[x].MoveTrough(Charac);
            }
			PutPheromones(PheromonesItem.NEUTRAL);
		}

        public override void UpdateCharacterStrategy(AntSimulator2017Abstract.Character.Character context, IStrategy strategyReplacement)
        {
            context.strategy = strategyReplacement;
        }
    }
}
