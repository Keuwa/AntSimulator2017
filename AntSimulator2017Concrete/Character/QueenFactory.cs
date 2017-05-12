using System;
using AntSimulator2017Abstract.Character;
namespace AntSimulator2017Concrete.Character
{
    public class QueenFactory : AbstractCharacterFactory
    {
        public QueenFactory()
        {
        }

        public override AntSimulator2017Abstract.Character.Character createCharacter()
        {
            return new Queen();
        }
    }
}
