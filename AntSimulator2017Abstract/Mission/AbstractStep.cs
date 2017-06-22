using System;
namespace AntSimulator2017Abstract.Mission
{
    public abstract class AbstractStep
    {
        //If true step is over, goToNextStep
        public abstract void DoStep(Character.Character character);
        public abstract void updateStrategy(Character.Character character);
        public bool StepIsOver { get; set; } = false;
    }
}
