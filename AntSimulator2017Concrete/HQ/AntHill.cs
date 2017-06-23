using System;
using System.Collections.Generic;
using AntSimulator2017Abstract;
using AntSimulator2017Abstract.HQ;
using AntSimulator2017Concrete.Character;
using AntSimulator2017Concrete.item;

namespace AntSimulator2017Concrete.HQ
{
    public class AntHill : AbstractHeadQuarter
    {

        public Queen queen { get; set; }
        public int FoodReserve { get; set; }
        public List<EggItem> EggReserve {get; set;}

        public AntHill()
        {
        }

        public void Simulate(){
            AgingEggs();
            EccloseEggs();
            queen.Analyse();
            queen.strategy.Execute();
        }

		private void AgingEggs()
		{
			foreach (EggItem egg in EggReserve)
			{
				egg.EclosionTime--;
			}
		}

        private void EccloseEggs()
        {
			foreach (EggItem egg in EggReserve)
			{
                if(egg.EclosionTime == 0){
                    int x = Simulation.AntSimulation.Instance.Random.Next(0, 2);
                    switch (x){
                        case 0:
                            this.ObserverList.Add(new GathererFactory().createCharacter("Ant Gatherer "+ObserverList.Count,new Position(Position)));
							break;
						case 1:
                            this.ObserverList.Add(new ExplorerFactory().createCharacter("Ant Explorer " + ObserverList.Count, new Position(Position)));
							break;
						case 2:
                            this.ObserverList.Add(new WarriorFactory().createCharacter("Ant Warrior " + ObserverList.Count, new Position(Position)));
							break;
                    }
                }
			}
            EggReserve.RemoveAll(egg => egg.EclosionTime <= 0);
        }

        public override void update(AbstractObservable src, object data)
        {
            throw new NotImplementedException();
        }

        public override void notify(object datas)
        {
            throw new NotImplementedException();
        }
    }
}
