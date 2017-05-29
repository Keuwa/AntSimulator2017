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
			ant.hungry = 10;
			ant.lifePoint = 15;
			ant.movementSpeed = 1;
			ant.name = name;
			ant.perception = 1;
            ant.position = pos;
			return ant;        
        }
    }
}
