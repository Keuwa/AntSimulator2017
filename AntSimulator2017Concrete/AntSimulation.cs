using System;
using AntSimulator2017Abstract.Simulation;
using AntSimulator2017Abstract.Environement;

namespace AntSimulator2017Concrete
{
    public class AntSimulation:AbstractSimulation
    {
        public AntSimulation(AbstractEnvironement env)
        {
            this.NumberOfTurn = 0;
            this.Env = env;
        }

        public string getStats()
        {
            
            return string.Format("Nombre de tour : {0} \n {1})",NumberOfTurn,Env.getStats());
        }
    }
}
