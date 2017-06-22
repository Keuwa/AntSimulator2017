using System;
using System.Collections.Generic;
using AntSimulator2017Abstract.Character;
using System.Linq;
namespace AntSimulator2017Abstract.Mission
{
    public abstract class AbstractMission
    {
        protected List<AbstractStep> steps { get; set; } 
        protected AbstractStep currentStep { get; set; } 

        public void updateStep(Character.Character context) {
            if (steps.IndexOf(currentStep) +1 < steps.Count) {
                currentStep = steps.ElementAt(steps.IndexOf(currentStep) + 1);
                currentStep.updateStrategy(context);
                //TODO DISPLAY NEW STEP
            } else {
                //TODO Mission finish Observer/Observable for new mission
                currentStep = steps[0];
				currentStep.updateStrategy(context);
			}
        }

        public void ExecuteStep(Character.Character character){
            currentStep.DoStep(character);
            if(currentStep.StepIsOver){
                currentStep.StepIsOver = false;
                updateStep(character);
            }
        }

    }
}
