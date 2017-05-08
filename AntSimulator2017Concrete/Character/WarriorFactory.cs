using System;
using AntSimulator2017Abstract.Character;
namespace AntSimulator2017Concrete.Character
{
    public class WarriorFactory : AbstractCharacterFactory
    {
        public WarriorFactory()
        {
        }

        public override AntSimulator2017Abstract.Character.Character createCharacter()
        {
            return new WarriorAnt();
        }
    }
}
