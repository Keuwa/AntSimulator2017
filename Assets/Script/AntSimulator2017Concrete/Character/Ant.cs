using System;
using System.Collections.Generic;
using AntSimulator2017Abstract.Character;
using AntSimulator2017Abstract.HQ;
using AntSimulator2017Abstract.Item;
using AntSimulator2017Concrete.Environnement.Map;
using AntSimulator2017Concrete.HQ;
using AntSimulator2017Concrete.item;
using UnityEngine;

namespace AntSimulator2017Concrete.Character
{
    public abstract class Ant : AntSimulator2017Abstract.Character.Character
    {
        public Ant()
        {
        }

        internal void Analyse()
        {
            mission.ExecuteStep(this);

        }

        public void Eat(FruitItem fruit)
        {
            hunger += fruit.FeedingValue;
            fruit.Portion--;
        }

        public void Loading(FruitItem item)
		{
            //TODO gestion de la foodValue du fruit ( Enlever sweet et very sweet pour une variable)
            VerySweetFruitItem load = (VerySweetFruitItem)new VerySweetItemFactory().createItem();
            load.Portion = 0;
            while(item.Portion > 0 && this.LoadCapacity > load.Portion){
                load.Portion++;
                item.Portion--;
            }
            Load = load;
		}

        public void Unloading(FruitItem item, AntHill anthill)
		{
            anthill.FoodReserve += item.FeedingValue * item.Portion;
            Load = null; 
		}

        internal void EndTurn()
        {
            if(hunger != 0){
                hunger--;
            }else{
                lifePoint--;
            }
        }

		public override void update (AntSimulator2017Abstract.AbstractObservable src, object data)
		{
			Debug.Log ("update");
			switch (data as String) {
				case "armagedon":
					Debug.Log("arma");
					lifePoint = 0;
					break;
				case "acidrain":
					Debug.Log ("acid");
					lifePoint--;
					break;
				default:
					Debug.Log ("def");
					break;
				}
		}
    }
}