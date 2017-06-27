using System;
using AntSimulator2017Abstract.Character;
using AntSimulator2017Abstract.Mission;
using AntSimulator2017Concrete.Character;
using AntSimulator2017Concrete.HQ;
using AntSimulator2017Concrete.item;
using AntSimulator2017Concrete.Strategy;

namespace AntSimulator2017Concrete.mission.step
{
    public class BringBackItem : AbstractStep
    {
        public BringBackItem()
        {
        }

        public override void DoStep(AntSimulator2017Abstract.Character.Character character)
        {
            //TODO multi headquarter
            AntHill hill = (AntHill)Simulation.AntSimulation.Instance.Environnement.HeadQuarters[0];
            if (character.position.Equals(hill.Position)){
                (character as Ant).Unloading(character.Load as FruitItem,hill);
                character.mission.updateStep(character);
				StepIsOver = true;
			}
        }

        public override void updateStrategy(AntSimulator2017Abstract.Character.Character character)
        {
            character.strategy = new BringStrategy(character);
        }
    }
}
