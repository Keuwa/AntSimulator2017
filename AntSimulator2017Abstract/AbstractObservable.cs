using System;
using System.Collections.Generic;

namespace AntSimulator2017Abstract
{
	public abstract class AbstractObservable
	{
		private readonly List<AbstractObserver> observerList = new List<AbstractObserver>();

		public void atach(AbstractObserver observer){
			observerList.Add(observer);
		}

		public void detach(AbstractObserver observer){
			observerList.Remove(observer);
		}

		public void Notify(){
			foreach(AbstractObserver abstractObserver in observerList){
				abstractObserver.update();
			}
		}
	}
}
