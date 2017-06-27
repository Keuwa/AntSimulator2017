using System;
using System.Collections.Generic;
using AntSimulator2017Abstract.Environnement.Map;
using AntSimulator2017Concrete.item;

namespace AntSimulator2017Concrete.Environnement.Map
{
    public class Map:AbstractMap
    {
        public void Simulate(){
            for (int i = 0; i < areas.Length;i++){
                for (int j = 0; j < areas[i].Length;j++){
                    for (int k = (areas[i][j] as Area).Pheromones.Count-1; k >= 0 ;k--){
                        if ((areas[i][j] as Area).Pheromones[k].turnDuration == 0)
						{
							(areas[i][j] as Area).Pheromones.RemoveAt(k);
						}
                        else{
                            (areas[i][j] as Area).Pheromones[k].turnDuration--;
                        }
                    }					
                }
            }
        }
    }
}
