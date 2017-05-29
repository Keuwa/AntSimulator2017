using System;
namespace AntSimulator2017Abstract.Simulation
{
    public abstract class AbstractSimulationFactory
    {
        public abstract AbstractSimulation createSimulation(int mapHeight,int mapWidth);
	}
}
