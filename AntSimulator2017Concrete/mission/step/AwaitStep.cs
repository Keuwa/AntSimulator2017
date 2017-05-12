using System;
using AntSimulator2017Abstract.Mission;

namespace AntSimulator2017Concrete.mission.step
{
    public class AwaitStep : AbstractStep
    {
        public AwaitStep()
        {
        }

        public override string name => "Attente d'un évenement ennemie";
    }
}
