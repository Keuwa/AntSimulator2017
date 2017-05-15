using System;
namespace AntSimulator2017Abstract.HQ
{
    public abstract class AbstractHeadQuarter : AbstractObservable, AbstractObserver
    {

        Position position;

        public AbstractHeadQuarter()
        {
        }

        public abstract void update(object data);
    }
}
