using System;
using AntSimulator2017Abstract.Simulation;
using System.Collections.Generic;
using AntSimulator2017Concrete.Character;
using AntSimulator2017Abstract;

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

			//NumberOfDeathTotal += NumberOfDeathThisTurn;

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
                Environnement.HeadQuarters[0].detach(ant);
			}

            if(NumberOfTurn%15==0){
                Position pos = new Position(Environnement.HeadQuarters[0].Position.x,Environnement.HeadQuarters[0].Position.y);
                Environnement.HeadQuarters[0].ObserverList.Add(new ExplorerFactory().createCharacter("JEAN PAUL "+Environnement.ObserverList.Count, pos));   
            }
        }
    }
}
