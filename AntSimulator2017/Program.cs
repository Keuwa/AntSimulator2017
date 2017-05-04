using System;
using System.Collections.Generic;
using AntSimulator2017Concrete.Environement;
using AntSimulator2017Concrete;
using AntSimulator2017Abstract.Environement;

namespace AntSimulator2017
{
	class MainClass
	{
		public static void Main(string[] args)
		{
            
			AntHill antHill = new AntHill();
			AntWorld world = new AntWorld(antHill);

            foreach(AntHill hill in world.bases){
                hill.atach(hill.characterList);
                world.atach(hill.characterList);
            }


			AntSimulation simulation = new AntSimulation(world);
			
            simulation.simulate(13);

            Console.WriteLine(simulation.getStats());


		}
	}
}
