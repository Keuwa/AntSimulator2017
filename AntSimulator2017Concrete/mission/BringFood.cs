using System;
using AntSimulator2017Abstract.Mission;

namespace AntSimulator2017Concrete.mission
{
    public class BringFood : AbstractMission
    {
        public BringFood()
        {
        }

        public override string title => "Récolter des fruits";
    }
}
