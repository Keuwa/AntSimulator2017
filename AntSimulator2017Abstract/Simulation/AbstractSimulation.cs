using System;
using AntSimulator2017Abstract.Environement;

namespace AntSimulator2017Abstract.Simulation
{
	public abstract class AbstractSimulation
	{
        /// <summary>
        /// 
        ///  Class used for the management of the whole simulation
        ///  This class will managing time, event, save, and load of the simulation
        ///  
        /// </summary>
        protected AbstractEnvironement Env { get; set; }
        protected int NumberOfTurn { get; set; }
        protected string Name { get; set; }

        public void simulate(int turns){
            NumberOfTurn += turns;
            for (int i = 0;i < turns;i++){
                Env.simulate();
            }
        }
	}
}
