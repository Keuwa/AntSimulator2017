using System;
using AntSimulator2017Abstract.Character;
using AntSimulator2017Abstract;
namespace AntSimulator2017Concrete.Character
{
    public class WarriorFactory : AbstractCharacterFactory
    {
        public WarriorFactory()
        {
        }

        public override AntSimulator2017Abstract.Character.Character createCharacter(string name,Position pos)
        {
            WarriorAnt ant = new WarriorAnt();
			ant.hungry = 10;
			ant.lifePoint = 50;
			ant.movementSpeed = 0;
			ant.name = name;
			ant.perception = 1;
			ant.position = pos;
			return ant;       
        }
    }
}
