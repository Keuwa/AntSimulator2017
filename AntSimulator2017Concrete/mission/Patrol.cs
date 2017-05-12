using System;
using AntSimulator2017Abstract.Mission;

namespace AntSimulator2017Concrete.mission
{
    public class Patrol : AbstractMission
    {
        public Patrol()
        {
        }

        public override string title => "Patrouiller dans une zone";
    }
}
