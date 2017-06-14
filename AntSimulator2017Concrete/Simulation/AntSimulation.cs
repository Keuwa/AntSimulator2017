using System;
using AntSimulator2017Abstract.Simulation;
using System.Collections.Generic;


namespace AntSimulator2017Concrete.Simulation
{
    
    public class AntSimulation : AbstractSimulation
    {
        public void Simulate()
        {
            NumberOfTurn++;
            foreach(AntSimulator2017Concrete.Character.Ant chara in Environnement.HeadQuarters[0].ObserverList){
                chara.strategy.Execute();
            }
        }
    }
}
