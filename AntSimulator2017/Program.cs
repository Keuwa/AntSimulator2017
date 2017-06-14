using System;
using System.Collections.Generic;
using AntSimulator2017Abstract.Character;
using AntSimulator2017Concrete.Simulation;

namespace AntSimulator2017
{
	class MainClass
	{
		public static void Main(string[] args)
		{
            int x = 10, y = 10;
            //AntEnvironnement environ = (AntEnvironnement)new AntEnvironnementFactory().createEnvironnement(x,y);
            AntSimulation simulation = (AntSimulator2017Concrete.Simulation.AntSimulation)new AntSimulationFactory().createSimulation(x,y);
            String str;
            str = String.Format("Environnement stats : \n Size : {0}x{1} ",simulation.Environnement.Map.areas.GetLength(0),simulation.Environnement.Map.areas[0].GetLength(0));
			
            Console.WriteLine(str);

            while(true){
				foreach (Character charac in simulation.Environnement.HeadQuarters[0].ObserverList)
				{
					Console.WriteLine(String.Format("{0} ---- (x:{1} y:{2})", charac.name, charac.position.x, charac.position.y));
				}

				Console.Write(simulation.Environnement.Draw());
				simulation.Simulate();
                System.Threading.Thread.Sleep(1000);
				Console.Clear();
			}

			
			
            //return 0;

			/*AntHill antHill = new AntHill();
			AntWorld world = new AntWorld(antHill);

            foreach(AntHill hill in world.bases){
                hill.atach(hill.characterList);
                world.atach(hill.characterList);
            }


			AntSimulation simulation = new AntSimulation(world);
			
            simulation.simulate(13);

            Console.WriteLine(simulation.getStats());*/

		}
	}
}
