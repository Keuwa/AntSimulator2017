using System;
using AntSimulator2017Abstract;
using AntSimulator2017Abstract.Character;
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
			ant.hunger = 10;
			ant.lifePoint = 15;
			ant.movementSpeed = 1;
			ant.name = name;
			ant.perception = 1;
            ant.position = pos;
			ant.strategy = new Strategy.MovementStrategy(ant);
			return ant;        
        }
    }
}
