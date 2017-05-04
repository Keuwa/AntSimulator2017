using System;
using AntSimulator2017Abstract.Environement;
using AntSimulator2017Abstract;

namespace AntSimulator2017Concrete.Environement
{
    public class AntWorld:AbstractEnvironement
    {
        public AntWorld(AntHill antHill)
        {
            this.bases = new System.Collections.Generic.List<Base>();
            this.bases.Add(antHill);
        }

        public override void notify()
        {
            int i = 0;
			foreach (AbstractObserver abstractObserver in observerList)
				{
	                if(i%2 == 0){
						abstractObserver.update("Environement notified");
					}
	                i++;
				}        
        }

        public override void simulate()
        {
            notify();
        }

        public override string getStats(){
            return bases[0].getStats();
        }


	}
}
