using System;
using AntSimulator2017Abstract.Character;

namespace AntSimulator2017Concrete.Character
{
    public class WarriorAntFactory : AntSimulator2017Abstract.Character.AbstractCharacterFactory
    {
        public WarriorAntFactory()
        {
        }

        public override AntSimulator2017Abstract.Character.Character createCharacter()
        {
            return new WarriorAnt();
        }
    }
}
