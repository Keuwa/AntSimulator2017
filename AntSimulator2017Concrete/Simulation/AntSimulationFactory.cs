using System;
using AntSimulator2017Abstract.Simulation;
using AntSimulator2017Concrete.Environnement;

namespace AntSimulator2017Concrete.Simulation
{
    public class AntSimulationFactory:AbstractSimulationFactory
    {
        public override AbstractSimulation createSimulation(int mapHeight,int mapWidth)
        {
            if(AbstractSimulation.Instance == null){
				AntSimulation simulation = new AntSimulation();
				simulation.Environnement = new AntEnvironnementFactory().createEnvironnement(mapHeight, mapWidth);
                simulation.Random = new Random();
                simulation.NumberOfTurn = 0;
                AbstractSimulation.Instance = simulation;
            }
            return AbstractSimulation.Instance;
        }
    }
}
