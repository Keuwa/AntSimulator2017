using System;
namespace AntSimulator2017Abstract.HQ
{
    public abstract class AbstractHeadQuarter : AbstractObservable, AbstractObserver
    {

        public Position Position { get; set; }

        public abstract void update(AbstractObservable src, object data);
    }
}
