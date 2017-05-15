﻿using System;
using System.Collections.Generic;

namespace AntSimulator2017Abstract
{
    public abstract class AbstractObservable
    {
        protected readonly List<AbstractObserver> observerList = new List<AbstractObserver>();

        public void attach(AbstractObserver observer)
        {
            observerList.Add(observer);
        }


        public void detach(AbstractObserver observer)
        {
            observerList.Remove(observer);
        }

        public abstract void notify(Object datas);
    }
}
