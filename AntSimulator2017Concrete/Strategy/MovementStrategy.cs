using System;
using AntSimulator2017Abstract.Character;
using AntSimulator2017Abstract.Strategy;

namespace AntSimulator2017Concrete.Strategy
{
    public class MovementStrategy : IStrategy
    {
        public AntSimulator2017Abstract.Character.Character Charac { get; set; }

        public MovementStrategy(AntSimulator2017Abstract.Character.Character charac){
            this.Charac = charac;
        }

        public void Execute()
        {
            var map = AntSimulator2017Abstract.Simulation.AbstractSimulation.Instance.Environnement.Map;
            var current = map.areas[Charac.position.x][Charac.position.y];
            var chara = Charac.position;

            int x = current.Links.Count;
            x = AntSimulator2017Abstract.Simulation.AbstractSimulation.Instance.Random.Next(x);
            current.Links[x].MoveTrough(Charac);


            //Charac.position = current.position;
        }

        public void UpdateCharacterStrategy(AntSimulator2017Abstract.Character.Character context, IStrategy strategyReplacement)
        {
            /*Charac = context;
		    context.strategy = strategyReplacement;*/
		}
    }
}
