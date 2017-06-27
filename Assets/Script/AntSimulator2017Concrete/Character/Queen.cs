using System;
using AntSimulator2017Abstract;
using AntSimulator2017Abstract.Mission;
using AntSimulator2017Abstract.State;
using AntSimulator2017Abstract.Strategy;
using AntSimulator2017Concrete.HQ;
using AntSimulator2017Concrete.item;

namespace AntSimulator2017Concrete.Character
{
    public class Queen : Ant
    {
        public Queen()
        {
        }

        public void EatReserve(AntHill hill)
        {
            if (hungerMax - hunger > 5){
                int foodEaten = (hill.FoodReserve <= 5) ? hill.FoodReserve : 5;

                hill.FoodReserve -= foodEaten;
                hunger += foodEaten;
            }else{
				int foodEaten = (hill.FoodReserve <= hungerMax - hunger) ? hill.FoodReserve : hungerMax - hunger;
				hill.FoodReserve -= foodEaten; 
                hunger += foodEaten;
            }
        }

        public void LayEgg(AntHill hill){
			hill.EggReserve.Add(new EggItem(10));
            this.hunger = hunger / 2;
		}

        public override void notify(Object datas)
        {
            throw new NotImplementedException();
        }

        public override void update(AbstractObservable src, object data)
        {
            throw new NotImplementedException();
        }
    }
}
