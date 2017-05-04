using System;
using System.Collections.Generic;

namespace AntSimulator2017Abstract
{
	public abstract class AbstractObservable
	{
        protected readonly List<AbstractObserver> observerList = new List<AbstractObserver>();

		public void atach(AbstractObserver observer){
			observerList.Add(observer);
		}

        public void atach(List<AbstractObserver> observers){
            foreach(AbstractObserver obs in observers){
				observerList.Add(obs);
			}
		}

		public void detach(AbstractObserver observer){
			observerList.Remove(observer);
		}

        public abstract void notify();
	}
}
