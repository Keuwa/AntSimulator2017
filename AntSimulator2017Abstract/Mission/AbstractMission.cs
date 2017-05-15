using System;
using System.Collections.Generic;
using AntSimulator2017Abstract.Character;
using System.Linq;
namespace AntSimulator2017Abstract.Mission
{
    public abstract class AbstractMission
    {
        public abstract string title { get; }
        protected List<AbstractStep> steps { get; set; }
        protected AbstractStep currentStep { get; set; }

        public void updateStep(Character.Character context) {
            if (steps.IndexOf(currentStep) +1 < steps.Count) {
                currentStep = steps.ElementAt(steps.IndexOf(currentStep) + 1);
                // DISPLAY NEW STEP
            } else {
                //Mission finish Observer/Observable for new mission
            }
        }

        protected void addStep(AbstractStep stepToAdd) {
            steps.Add(stepToAdd);
        }
    }
}
