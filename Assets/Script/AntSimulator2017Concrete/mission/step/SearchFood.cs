using System;
using AntSimulator2017Abstract.Character;
using AntSimulator2017Abstract.Mission;
using AntSimulator2017Concrete.Character;
using AntSimulator2017Concrete.Environnement.Map;
using AntSimulator2017Concrete.item;
using AntSimulator2017Concrete.Simulation;
using AntSimulator2017Concrete.Strategy;

namespace AntSimulator2017Concrete.mission.step
{
    public class SearchFood : AbstractStep
    {
        public override void DoStep(AntSimulator2017Abstract.Character.Character character)
        {
            Area area = (Area)AntSimulation.Instance.Environnement.Map.areas[character.position.x][character.position.y];
            if(area.Fruits.Count!=0){
                
                (character as Ant).Loading(area.Fruits[0] as FruitItem);
                (character as Ant).Eat(area.Fruits[0] as FruitItem);
				StepIsOver = true;
            }

        }

        public override void updateStrategy(AntSimulator2017Abstract.Character.Character character)
        {
            character.strategy = new SearchFoodStrategy(character);
		}
    }
}
