using System;
using AntSimulator2017Abstract.Mission;
using AntSimulator2017Concrete.mission.step;
using AntSimulator2017Concrete.Character;

namespace AntSimulator2017Concrete.mission
{
    public class BringFood : AbstractMission
    {
        public BringFood(Ant ant)
        {
            steps = new System.Collections.Generic.List<AbstractStep>();
            steps.Add(new SearchFood());
            steps.Add(new BringBackItem());
            currentStep = steps[0];
            currentStep.updateStrategy(ant);
        }
    }
}
