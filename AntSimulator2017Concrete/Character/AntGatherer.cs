using System;
using AntSimulator2017Abstract;
using AntSimulator2017Abstract.Mission;
using AntSimulator2017Abstract.State;
using AntSimulator2017Abstract.Strategy;

namespace AntSimulator2017Concrete.Character
{
    public class AntGatherer : Ant
    {
		
        public AntGatherer()
        {
        }
        // recevoir mission


        public override void notify(object datas)
        {
            throw new NotImplementedException();
        }

        public override void update(AbstractObservable src, object data)
        {
            throw new NotImplementedException();
        }
        // notifier fin de mission 

    }
}
