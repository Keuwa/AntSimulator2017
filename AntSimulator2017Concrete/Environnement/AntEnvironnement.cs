using System;
using AntSimulator2017Abstract;
using AntSimulator2017Abstract.Environnement;
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
                        if (Map.areas[x][y].Fruits.Count != 0){
                            str += "F ";
						}else{
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
