using System;
using AntSimulator2017Abstract.Character;

namespace AntSimulator2017Concrete.Character
{
    public class ExplorerFactory : AntSimulator2017Abstract.Character.AbstractCharacterFactory
    {
        public ExplorerFactory()
        {
        }

        public override AntSimulator2017Abstract.Character.Character createCharacter()
        {
            return new ExplorerAnt();
        }
    }
}
