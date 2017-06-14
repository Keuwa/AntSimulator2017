using System;
using AntSimulator2017Abstract.Character;
using AntSimulator2017Abstract;

namespace AntSimulator2017Concrete.Character
{
    public class ExplorerFactory : AntSimulator2017Abstract.Character.AbstractCharacterFactory
    {
        public ExplorerFactory()
        {
        }

        public override AntSimulator2017Abstract.Character.Character createCharacter(string name, Position pos)
        {
            ExplorerAnt ant = new ExplorerAnt();
            ant.hungry = 10;
            ant.lifePoint = 10;
            ant.movementSpeed = 2;
            ant.name = name;
            ant.perception = 1;
			ant.position = pos;
            ant.strategy = new Strategy.MovementStrategy(ant);
               
			return ant;
        }
    }
}
