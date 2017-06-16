using System;
using System.Collections.Generic;
using AntSimulator2017Abstract.Character;
using AntSimulator2017Abstract.Item;
using AntSimulator2017Concrete.Environnement.Map;
using AntSimulator2017Concrete.item;

namespace AntSimulator2017Concrete.Character
{
    public abstract class Ant : AntSimulator2017Abstract.Character.Character
    {
        public Ant()
        {
        }

        internal void Analyse()
        {
            //TODO: Define action using mission
            Area map = (Area)Simulation.AntSimulation.Instance.Environnement.Map.areas[position.x][position.y];
            if(map.Fruits.Count!=0){
                //TODO: gérer multifruit
                Eat((FruitItem)map.Fruits[0]);
            }
        }

        private void Eat(FruitItem fruit)
        {
            hunger += fruit.FeedingValue;
            fruit.Portion--;
        }

        internal void EndTurn()
        {
            if(hunger != 0){
                hunger--;
            }else{
                lifePoint--;
            }
        }


    }
}