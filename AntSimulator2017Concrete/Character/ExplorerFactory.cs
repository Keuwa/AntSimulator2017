using System;
using AntSimulator2017Abstract.Character;
using AntSimulator2017Abstract;
using AntSimulator2017Concrete.Strategy;
using AntSimulator2017Concrete.mission;

namespace AntSimulator2017Concrete.Character
{
    public class ExplorerFactory : AbstractCharacterFactory
    {
 
        public override AntSimulator2017Abstract.Character.Character createCharacter(string name, Position pos)
        {
            ExplorerAnt ant = new ExplorerAnt();
            ant.hunger = 40;
            ant.lifePoint = 10;
            ant.LoadCapacity = 10;
            ant.movementSpeed = 2;
            ant.name = name;
            ant.perception = 1;
			ant.position = pos;
            ant.mission = new BringFood(ant);
            //ant.strategy = new ExplorationStrategy(ant);
               
			return ant;
        }
    }
}
