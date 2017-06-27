using System;
using System.Collections.Generic;
using AntSimulator2017Abstract.Mission;
using AntSimulator2017Concrete.Character;
using AntSimulator2017Concrete.mission.step;

namespace AntSimulator2017Concrete.mission
{
    public class Lay : AbstractMission
    {
        public Lay(Ant ant)
        {
			steps = new List<AbstractStep>();
			steps.Add(new CreateEgg());
            currentStep = steps[0];
            currentStep.updateStrategy(ant);
        }
    }
}
