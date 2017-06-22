using System;
using AntSimulator2017Abstract.Character;
using AntSimulator2017Abstract;
using AntSimulator2017Concrete.Strategy;
using AntSimulator2017Concrete.mission;

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
			ant.hunger = 40;
			ant.lifePoint = 50;
            ant.LoadCapacity = 2;
			ant.movementSpeed = 0;
			ant.name = name;
			ant.perception = 1;
			ant.position = pos;
			ant.mission = new BringFood(ant);
			return ant;       
        }
    }
}
