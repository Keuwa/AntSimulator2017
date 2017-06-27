using System;
using System.Collections.Generic;
using AntSimulator2017Abstract.Character;
using AntSimulator2017Abstract.Environnement.Map;
using AntSimulator2017Abstract.Strategy;
using AntSimulator2017Concrete.HQ;
using AntSimulator2017Concrete.item;

namespace AntSimulator2017Concrete.Strategy
{
    public class BringStrategy : BaseStrategy
    {
        public BringStrategy(AntSimulator2017Abstract.Character.Character charac) : base(charac)
        {
        }

        public override void Execute()
        {
            List<AbstractLink> links = new List<AbstractLink>();

			var map = AntSimulator2017Abstract.Simulation.AbstractSimulation.Instance.Environnement.Map;
			var current = map.areas[Charac.position.x][Charac.position.y];
			var chara = Charac.position;
            AntHill headquarter = (AntHill)Simulation.AntSimulation.Instance.Environnement.HeadQuarters[0];

			foreach (var link in current.Links)
			{
                if (link.IsOpen && link.IsAreaAccessible(current.Position) && link.IsCloserTo(current,headquarter.Position))
				{
					links.Add(link);
				}
			}

			int x = links.Count;
			if (x != 0)
			{
				x = AntSimulator2017Abstract.Simulation.AbstractSimulation.Instance.Random.Next(x);
				links[x].MoveTrough(Charac);
			}

			///put pheromones
            PutPheromones(PheromonesItem.FOOD);        
        }

        public override void UpdateCharacterStrategy(AntSimulator2017Abstract.Character.Character context, IStrategy strategyReplacement)
        {
            context.strategy = strategyReplacement;
        }
    }
}
