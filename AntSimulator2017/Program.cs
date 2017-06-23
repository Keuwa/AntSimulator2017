using System;
using System.Collections.Generic;
using AntSimulator2017Abstract;
using AntSimulator2017Abstract.Character;
using AntSimulator2017Concrete.Character;
using AntSimulator2017Concrete.HQ;
using AntSimulator2017Concrete.item;
using AntSimulator2017Concrete.Simulation;

namespace AntSimulator2017
{
	class MainClass
	{
		public static void Main(string[] args)
		{
            int x = 15, y = 15;
            AntSimulation simulation = (AntSimulator2017Concrete.Simulation.AntSimulation)new AntSimulationFactory().createSimulation(x,y);

            String str;
            //str = String.Format("Environnement stats : \n Size : {0}x{1} ",simulation.Environnement.Map.areas.GetLength(0),simulation.Environnement.Map.areas[0].GetLength(0));
            //Console.WriteLine(str);


			List<Ant> ants = new List<Ant>();


            while(true){
				str = String.Format("Number of death this turn : {0} \nNumber of death Total : {1}", simulation.NumberOfDeathThisTurn, simulation.NumberOfDeathTotal);
				Console.WriteLine(str);
                str = String.Format("Anthill number of ants :{0}\nFood supply : {1} ", simulation.Environnement.HeadQuarters[0].ObserverList.Count, (simulation.Environnement.HeadQuarters[0] as AntHill).FoodReserve);
				Console.WriteLine(str);
				foreach (Character charac in simulation.Environnement.HeadQuarters[0].ObserverList)
				{
                    //Console.WriteLine(String.Format("{0} ---- (x:{1} y:{2}) Hunger:{3} Strategy:{4}", charac.name, charac.position.x, charac.position.y,charac.hunger,charac.strategy.GetType()));
				}
                Queen queen = (AntSimulation.Instance.Environnement.HeadQuarters[0] as AntHill).queen;
                Console.WriteLine(String.Format(" Queen hunger : {0} LP : {1}",queen.hunger,queen.lifePoint));

                foreach (EggItem item in (simulation.Environnement.HeadQuarters[0] as AntHill).EggReserve)
				{
                    Console.WriteLine(String.Format("Egg ---- CountDown : {0}", item.EclosionTime));
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
