using System;
using AntSimulator2017Abstract.Simulation;
using AntSimulator2017Concrete.Environnement;

namespace AntSimulator2017Concrete.Simulation
{
    public class AntSimulationFactory:AbstractSimulationFactory
    {



        public override AbstractSimulation createSimulation(int mapHeight,int mapWidth)
        {
            AntSimulation simulation = new AntSimulation();
            simulation.environnement = new AntEnvironnementFactory().createEnvironnement(mapHeight,mapWidth);
            return simulation;
        }
    }
}
