using System;
using System.Collections.Generic;
using AntSimulator2017Abstract.Character;
using AntSimulator2017Abstract.Environnement.Map;
using AntSimulator2017Abstract.Strategy;
using AntSimulator2017Concrete.Environnement.Map;
using AntSimulator2017Concrete.item;

namespace AntSimulator2017Concrete.Strategy
{
    public class SearchFoodStrategy:BaseStrategy
    {
        public SearchFoodStrategy(AntSimulator2017Abstract.Character.Character charac) : base(charac)
        {
        }

        public override void Execute()
        {
            List<AbstractLink> links = new List<AbstractLink>(); // Exploration
			List<AbstractLink> linksWithFoodPheromones = new List<AbstractLink>(); //Follwing food


			var map = AntSimulator2017Abstract.Simulation.AbstractSimulation.Instance.Environnement.Map;
			var current = map.areas[Charac.position.x][Charac.position.y];

			foreach (var link in current.Links)
			{
				if (link.IsOpen && link.IsAreaAccessible(current.Position))
				{
					Area area = (AntSimulator2017Concrete.Environnement.Map.Area)link.GetArrivalArea(current);
					if (area.Pheromones.Count == 0)
					{
						links.Add(link);
					}
                    if(area.Fruits.Count>0){
                        link.MoveTrough(Charac);
                        return;
                    }
                    ///Check if foodpheromon
					bool isFoodPheromones = false;
					foreach (var phero in area.Pheromones)
					{
						if (phero.Type.Equals(PheromonesItem.FOOD))
						{
							isFoodPheromones = true;
							break;
						}
					}

                    //bool bo = link.IsCloserTo(current, Simulation.AntSimulation.Instance.Environnement.HeadQuarters[0].Position);
                    if (isFoodPheromones && link.IsCloserTo(current, Simulation.AntSimulation.Instance.Environnement.HeadQuarters[0].Position) == false)//TODO multi headquarter
					{
                        linksWithFoodPheromones.Add(link);
					}
				}
			}

            int x = linksWithFoodPheromones.Count;
            int y = links.Count;
			if (x != 0) //Si il y a des linkWith FOODPEHROMON et qu'on s'éloigne du HQ on y va
			{
				x = AntSimulator2017Abstract.Simulation.AbstractSimulation.Instance.Random.Next(x);
				linksWithFoodPheromones[x].MoveTrough(Charac);
			}
			else if (y != 0)
			{
				y = AntSimulator2017Abstract.Simulation.AbstractSimulation.Instance.Random.Next(y);
				links[y].MoveTrough(Charac);
            }
			else
			{
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
