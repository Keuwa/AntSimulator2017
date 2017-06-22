﻿using System;
using AntSimulator2017Abstract;
using AntSimulator2017Abstract.Environnement;
using AntSimulator2017Concrete.Environnement.Map;
using AntSimulator2017Concrete.item;

namespace AntSimulator2017Concrete.Environnement
{
    public class AntEnvironnement : AbstractEnvironnement
    {
        override public String Draw()
        {
            Position pos = new Position(0, 0);
            System.Collections.Generic.List<AbstractObserver> temp = new System.Collections.Generic.List<AbstractObserver>();

            foreach(var obs in HeadQuarters[0].ObserverList){
                temp.Add(obs);
            }
            Boolean printed = false;
            String str = "";
            for (int y = 0; y < Map.areas.Length;y++){
                str += "|";
                for (int x = 0; x < Map.areas[y].Length;x++){
                    foreach(AntSimulator2017Abstract.Character.Character chara in temp ){
                        if(chara.position.x == x && chara.position.y == y){
                            str += chara.lifePoint + " ";
							temp.Remove(chara);
                            printed = true;
                            break;
                        }
                    }
                    if(!printed){
                        var area = Map.areas[x][y] as Area;
                        if (area.Fruits.Count != 0){
                            str += "F ";
						}
						else if (Simulation.AntSimulation.Instance.Environnement.HeadQuarters[0].Position.x == x && Simulation.AntSimulation.Instance.Environnement.HeadQuarters[0].Position.y == y)
						{
							str += "X ";

						}
						else if (area.Pheromones.Count != 0){
                            bool isFoodPheromones = false;
                            foreach (var phero in area.Pheromones){
                                if(phero.Type.Equals(PheromonesItem.FOOD)){
                                    isFoodPheromones = true;
                                    break;
                                }
                            }
                            if (isFoodPheromones)
                            {
                                str += "@ ";
                            }
                            else
                            {
                                str += ". ";
                            }
						}
						else{
							str += Map.areas[x][y].usedSpace + " ";
						}
                    }
					printed = false;
				}
                str += "|\n";
            }
            return str;
        }
    }
}
