using System;
using AntSimulator2017Abstract.Character;
namespace AntSimulator2017Concrete.Character
{
    public class GathererFactory : AbstractCharacterFactory
    {
        public GathererFactory()
        {
        }

        public override AntSimulator2017Abstract.Character.Character createCharacter()
        {
            return new AntGatherer();
        }
    }
}
