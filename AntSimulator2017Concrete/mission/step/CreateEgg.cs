using System;
using System.Collections.Generic;
using AntSimulator2017Abstract.Character;
using AntSimulator2017Abstract.Mission;
using AntSimulator2017Concrete.Character;
using AntSimulator2017Concrete.HQ;
using AntSimulator2017Concrete.item;
using AntSimulator2017Concrete.Strategy;

namespace AntSimulator2017Concrete.mission.step
{
    public class CreateEgg : AbstractStep
    {


        private void CreateEggItem(AntHill hill)
		{
            hill.EggReserve.Add(new EggItem(10));
		}

        public override void DoStep(AntSimulator2017Abstract.Character.Character character)
        {
            AntHill hill = null;
            Queen queen = character as Queen;

            foreach (AntHill hq in Simulation.AntSimulation.Instance.Environnement.HeadQuarters){
				if (hq.queen == character)
				{
					hill = hq;
				}  
            }
                
            if(hill != null){
				queen.EatReserve(hill);
			}

            if(queen.hunger == queen.hungerMax){
                queen.LayEgg(hill);
            }
        }

        public override void updateStrategy(AntSimulator2017Abstract.Character.Character character)
        {
            character.strategy = new IdleStrategy(character);
        }


    }
}
