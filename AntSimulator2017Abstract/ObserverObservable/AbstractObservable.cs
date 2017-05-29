﻿using System;
using System.Collections.Generic;

namespace AntSimulator2017Abstract
{
    public abstract class AbstractObservable
    {
        public List<AbstractObserver> ObserverList { get; set; } = new List<AbstractObserver>();

        public void attach(AbstractObserver observer)
        {
            ObserverList.Add(observer);
        }


        public void detach(AbstractObserver observer)
        {
            ObserverList.Remove(observer);
        }

        public abstract void notify(Object datas);
    }
}
