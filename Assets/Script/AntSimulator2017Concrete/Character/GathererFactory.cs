using System;
using AntSimulator2017Abstract;
using AntSimulator2017Abstract.Character;
using AntSimulator2017Concrete.mission;
using AntSimulator2017Concrete.Strategy;

namespace AntSimulator2017Concrete.Character
{
    public class GathererFactory : AbstractCharacterFactory
    {
        public GathererFactory()
        {
        }

        public override AntSimulator2017Abstract.Character.Character createCharacter(string name,Position pos)
        {
            AntGatherer ant = new AntGatherer();
			ant.hunger = 40;
			ant.lifePoint = 15;
			ant.movementSpeed = 1;
            ant.LoadCapacity = 17;
			ant.name = name;
			ant.perception = 1;
            ant.position = pos;
			ant.mission = new BringFood(ant);
			return ant;        
        }
    }
}
