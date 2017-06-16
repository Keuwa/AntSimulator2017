using System;
using AntSimulator2017Abstract;
using AntSimulator2017Abstract.Character;
namespace AntSimulator2017Concrete.Character
{
    public class QueenFactory : AbstractCharacterFactory
    {
        public QueenFactory()
        {
        }

        public override AntSimulator2017Abstract.Character.Character createCharacter(string name,Position pos)
        {
            Queen ant = new Queen();
			
			ant.hunger = 10;
			ant.lifePoint = 50;
			ant.movementSpeed = 0;
			ant.name = name;
			ant.perception = 1;
			ant.position = pos;
			
            return ant;
            
        }
    }
}
