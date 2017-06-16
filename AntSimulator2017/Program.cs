using System;
using System.Collections.Generic;
using AntSimulator2017Abstract;
using AntSimulator2017Abstract.Character;
using AntSimulator2017Concrete.Character;
using AntSimulator2017Concrete.Simulation;

namespace AntSimulator2017
{
	class MainClass
	{
		public static void Main(string[] args)
		{
            int x = 6, y = 6;
            AntSimulation simulation = (AntSimulator2017Concrete.Simulation.AntSimulation)new AntSimulationFactory().createSimulation(x,y);

            String str;
            str = String.Format("Environnement stats : \n Size : {0}x{1} ",simulation.Environnement.Map.areas.GetLength(0),simulation.Environnement.Map.areas[0].GetLength(0));
            Console.WriteLine(str);


			List<Ant> ants = new List<Ant>();


            while(true){
				str = String.Format("Number of death this turn : {0} \n Number of death Total : {1}", simulation.NumberOfDeathThisTurn, simulation.NumberOfDeathTotal);
				Console.WriteLine(str);
				foreach (Character charac in simulation.Environnement.HeadQuarters[0].ObserverList)
				{
                    Console.WriteLine(String.Format("{0} ---- (x:{1} y:{2}) Hunger:{3}", charac.name, charac.position.x, charac.position.y,charac.hunger));
				}
                List<Position> listOfPosition = new List<Position>();
				foreach (Ant ant in simulation.Environnement.HeadQuarters[0].ObserverList)
				{
                    listOfPosition.Add(ant.position);
				}

				Console.Write(simulation.Environnement.Draw());
                simulation.Simulate();

                System.Threading.Thread.Sleep(500);
				Console.Clear();
			}
		}
	}
}
