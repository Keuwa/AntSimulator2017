using AntSimulator2017Abstract.Simulation;
using System.Collections.Generic;
using AntSimulator2017Concrete.Character;
using AntSimulator2017Concrete.HQ;
using AntSimulator2017Concrete.Environnement.Map;
using AntSimulator2017Concrete.item;
using UnityEngine;

namespace AntSimulator2017Concrete.Simulation
{
    public class AntSimulation : AbstractSimulation
    {
		public int NumberOfDeathTotal { get; set; }
		public int NumberOfDeathThisTurn { get; set; }

        public void Simulate()
        {
            List<Ant> ants = new List<Ant>();

            NumberOfTurn++;
			NumberOfDeathThisTurn = 0;

            foreach(AntHill hq in Environnement.HeadQuarters){
                hq.Simulate();
            }

			foreach(Ant chara in Environnement.HeadQuarters[0].ObserverList){
                chara.Analyse();
                chara.strategy.Execute();
                chara.EndTurn();
                if(chara.IsDead()){
                    ants.Add(chara);
					Environnement.Map.areas[chara.position.x][chara.position.y].RemoveAnt();
					NumberOfDeathThisTurn++;
                    NumberOfDeathTotal++;
                }
            }

			foreach (Ant ant in ants){
				int pos = Environnement.HeadQuarters[0].ObserverList.IndexOf(ant);
				var antUi = GameManager.instance.Ants[pos];

				GameManager.instance.Ants.RemoveAt (pos);
				antUi.delete ();
                Environnement.HeadQuarters[0].detach(ant);
			}

            (Environnement.Map as Map).Simulate();

            foreach(AntHill anthill in Environnement.HeadQuarters){
				anthill.queen.Analyse();
				anthill.queen.strategy.Execute();
				anthill.queen.EndTurn();
                if(anthill.queen.IsDead()){
					throw new System.NotImplementedException();
				}
            }
        }
    }
}
