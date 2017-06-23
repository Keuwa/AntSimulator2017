using System;
using System.Collections.Generic;
using AntSimulator2017Abstract.Simulation;
using AntSimulator2017Concrete.Environnement;
using AntSimulator2017Concrete.HQ;

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
                simulation.NumberOfDeathThisTurn = 0;
                simulation.NumberOfDeathTotal = 0;
                AbstractSimulation.Instance = simulation;

                foreach(AntHill hill in AntSimulation.Instance.Environnement.HeadQuarters){
                    Simulation.AntSimulation.Instance.Environnement.Map.areas[hill.Position.x][hill.Position.y].Space = 999;
				}

			}

			return AbstractSimulation.Instance;
        }
    }
}
