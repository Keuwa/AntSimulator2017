using System;
using System.Collections.Generic;
using AntSimulator2017Abstract.Character;
using AntSimulator2017Concrete.Environnement;

namespace AntSimulator2017
{
	class MainClass
	{
		public static void Main(string[] args)
		{
            int x = 5, y = 4;
            AntEnvironnement environ = (AntEnvironnement)new AntEnvironnementFactory().createEnvironnement(x,y);
            String str;
            str = String.Format("Environnement stats : \n Size : {0}x{1} ",environ.Map.areas.GetLength(0),environ.Map.areas[0].GetLength(0));
			
            Console.WriteLine(str);

            foreach(Character charac in environ.HeadQuarters[0].){
                Console.WriteLine(charac.name);
            }

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
