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
            for (int i = 0; i < Map.areas.Length;i++){
                str += "|";
                for (int j = 0; j < Map.areas[i].Length;j++){
                    foreach(AntSimulator2017Abstract.Character.Character chara in temp ){
                        if(chara.position.x == i && chara.position.y == j){
                            str += " X ";
                            temp.Remove(chara);
                            printed = true;
                            break;
                        }
                    }
                    if(!printed){
                        str += " - ";
                    }
					printed = false;
				}
                str += "|\n";
            }
            return str;
        }
    }
}
